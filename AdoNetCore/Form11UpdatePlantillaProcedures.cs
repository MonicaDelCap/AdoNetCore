using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
#region STORED PROCEDURE
//alter procedure SP_ALL_HOSPITALES
//as 
//	select * from HOSPITAL
//go


//alter procedure SP_UPDATEPLANTILLAHOSPITAL
//(@nombre nvarchar(50), @incremento int)
//as
//	declare @hospitalcod int
//	select @hospitalcod = HOSPITAL_COD from HOSPITAL where NOMBRE=@nombre
//	update PLANTILLA set SALARIO = SALARIO + @incremento where HOSPITAL_COD = @hospitalcod
//	select * from PLANTILLA where HOSPITAL_COD= @hospitalcod
//go


//create procedure SP_SELECTPLANTILLA_NOMBREHOSPITAL
//(@nombrehospital nvarchar(50))
//as
//	declare @hospitalid int
//	select @hospitalid=HOSPITAL_COD from HOSPITAL where NOMBRE=@nombrehospital
//	select * from PLANTILLA where HOSPITAL_COD=@hospitalid;
//go
#endregion
namespace AdoNetCore
{
    public partial class Form11UpdatePlantillaProcedures : Form
    {
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;
        public Form11UpdatePlantillaProcedures()
        {
            InitializeComponent();
            string connectionString = @"Data Source=LOCALHOST\SQLEXPRESS;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=sa;Trust Server Certificate=True";
            this.cn = new SqlConnection(connectionString);
            this.com = new SqlCommand();
            this.com.Connection = this.cn;
            this.LoadHospitales();
        }


        public async void LoadHospitales()
        {
            string sql = "SP_ALL_HOSPITALES";
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = sql;

            await this.cn.OpenAsync();
            this.reader = await this.com.ExecuteReaderAsync();

            this.lstPlantilla.Items.Clear();
            while (await this.reader.ReadAsync())
            {
                string nombre = this.reader["NOMBRE"].ToString();
                this.cmbHospitales.Items.Add(nombre);
            }

            await this.reader.CloseAsync();
            await this.cn.CloseAsync();
        }

        private async void btnModificarSalario_Click(object sender, EventArgs e)
        {
            string nombre = this.cmbHospitales.SelectedItem.ToString();
            int incre = int.Parse(this.txtIncremento.Text);

            string sql = "SP_UPDATEPLANTILLAHOSPITAL";
            this.com.Parameters.AddWithValue("@nombre", nombre);
            this.com.Parameters.AddWithValue("@incremento", incre);

            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = sql;

            await this.cn.OpenAsync();

            this.reader = await this.com.ExecuteReaderAsync();
            this.lstPlantilla.Items.Clear();

            while (await this.reader.ReadAsync())
            {
                string ape = this.reader["APELLIDO"].ToString();
                int salario = int.Parse(this.reader["SALARIO"].ToString());
                this.lstPlantilla.Items.Add(ape + " - " + salario);
            }

            this.com.Parameters.Clear();
            await this.cn.CloseAsync();
            await this.reader.CloseAsync();
        }

        private async void cmbHospitales_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nombreHospital = this.cmbHospitales.SelectedItem.ToString();
            string sql = "SP_SELECTPLANTILLA_NOMBREHOSPITAL";

            this.com.Parameters.AddWithValue("@nombrehospital", nombreHospital);
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = sql;

            await this.cn.OpenAsync();
            this.reader = await this.com.ExecuteReaderAsync();

            this.lstPlantilla.Items.Clear();

            while(await this.reader.ReadAsync())
            {
                this.lstPlantilla.Items.Add(this.reader["APELLIDO"].ToString());
            }
            int filas = this.reader.RecordsAffected;
            this.lstPlantilla.Items.Add(filas);
            await this.reader.CloseAsync();
            await this.cn.CloseAsync();
            this.com.Parameters.Clear();
        }
    }
}
