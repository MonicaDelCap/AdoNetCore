using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdoNetCore.Models;
using Microsoft.Data.SqlClient;
#region PROCEDURE
//create procedure SP_ALL_DEPARTAMENTOS
//as
//	select * from DEPT
//go


//create procedure SP_INSERT_DEPARTAMENTO
//(@numero int, @nombre nvarchar(50), @localidad nvarchar(50))
//as
//	insert into DEPT values(@numero, @nombre, @localidad)
//go

#endregion
namespace AdoNetCore
{
    public partial class Form12MensajeServidor : Form
    {
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;
        public Form12MensajeServidor()
        {
            InitializeComponent();
            string connectionString = @"Data Source=LOCALHOST\SQLEXPRESS;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=sa;Trust Server Certificate=True";
            this.cn = new SqlConnection(connectionString);
            this.com = new SqlCommand();
            this.com.Connection = this.cn;

            //RECUPERAR EL EVENTO DE MENSAJES 
            this.cn.InfoMessage += Cn_InfoMessage;
            this.LoadDepartamentosAsync();
        }

        private void Cn_InfoMessage(object sender, SqlInfoMessageEventArgs e)
        {
            this.lblMensaje.Text = e.Message;
        }

        private async Task LoadDepartamentosAsync()
        {
            string sql = "SP_ALL_DEPARTAMENTOS";
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = sql;

            await this.cn.OpenAsync();
            this.reader = await this.com.ExecuteReaderAsync();
            this.lstDepartamentos.Items.Clear();
            while (await this.reader.ReadAsync())
            {
                this.lstDepartamentos.Items.Add(this.reader["DNOMBRE"].ToString());
            }

            await this.cn.CloseAsync();
            await this.reader.CloseAsync();

        }

        

        private  void btnInsertar_Click(object sender, EventArgs e)
        {
            this.lblMensaje.Text = "";
            string sql = "SP_INSERT_DEPARTAMENTO";
            this.com.Parameters.AddWithValue("@numero", int.Parse(this.txtNumero.Text));
            this.com.Parameters.AddWithValue("@nombre", this.txtNombre.Text);
            this.com.Parameters.AddWithValue("@localidad", this.txtLocalidad.Text);

            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = sql;

              this.cn.Open();
            int afectados =  this.com.ExecuteNonQuery();

              this.cn.CloseAsync();
            this.com.Parameters.Clear();

            MessageBox.Show("Afectados: " + afectados);

             //this.LoadDepartamentosAsync();
        }
    }
}
