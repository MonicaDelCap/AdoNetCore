using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
namespace AdoNetCore
{
    public partial class Form03EliminarEnfermos : Form
    {
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;
        public Form03EliminarEnfermos()
        {
            InitializeComponent();
            string connection = @"Data Source=LOCALHOST\SQLEXPRESS;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=sa;Trust Server Certificate=True";
            this.cn = new SqlConnection(connection);
            this.com = new SqlCommand();
            this.LoadEnfermos();
            
          
        }

        private void btnEliminarEnfermo_Click(object sender, EventArgs e)
        {
            //DEBEMOS INDICAR EL TIPO DE DATO COMO PARAMETRO
            //INSCRIPCION ES UN NUMERO HAY QUE CASTEARLO
            int inscripcion = int.Parse(this.txtInscripcion.Text);
            string sql = "delete from ENFERMO where INSCRIPCION=@inscripcion";
            
            //CREAMOS EL PARAMETRO PARA LA INSCRIPCION
            SqlParameter pamInscripcion = new SqlParameter("@inscripcion",inscripcion);
            
            ////POR ESTE NOMBRE LO BUSCA EN LA CONSULTA
            //pamInscripcion.ParameterName = "@inscripcion";
            ////VALUE DEBE SER DEL MISMO TIPO
            //pamInscripcion.Value = inscripcion;

            ////ESTO ES OPCIONAL
            //pamInscripcion.DbType = DbType.Int32;

            ////LA DIRECTION INDICA SI EL PARAMETRO ES DE ENTRADA O SALIDA (INPUT POR DEFECTO)
            //pamInscripcion.Direction = ParameterDirection.Input;
            //AÑADIMOS EL PARAMETRO A COMMAND
            
            this.com.Parameters.Add(pamInscripcion);


            this.com.Connection = this.cn;
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            int eliminados = this.com.ExecuteNonQuery();
            
            this.cn.Close();
            this.com.Parameters.Clear();

            MessageBox.Show("Se han eliminado " + eliminados);
            this.LoadEnfermos();
        }

        private void LoadEnfermos()
        {
            string sql = " select * from ENFERMO";
            this.com.Connection = this.cn;
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;

            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            this.lstEnfermos.Items.Clear();

            while (this.reader.Read())
            {
                string inscripcion = this.reader["INSCRIPCION"].ToString();
                string ape = this.reader["APELLIDO"].ToString();
                this.lstEnfermos.Items.Add(inscripcion + " - " + ape);
            }

            this.cn.Close();
            this.reader.Close();
        }
    }
}
