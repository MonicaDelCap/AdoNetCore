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
    public partial class Form01PrimerAdo : Form
    {
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;
        string connectionString;

        public Form01PrimerAdo()
        {
            this.connectionString = @"Data Source=LOCALHOST\SQLEXPRESS;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=sa;Trust Server Certificate=True";
            this.cn = new SqlConnection(this.connectionString);
            this.com = new SqlCommand();
            this.cn.StateChange += Cn_StateChange;
            InitializeComponent();
        }

        private void Cn_StateChange(object sender, StateChangeEventArgs e)
        {
            this.lblMensaje.Text = "La conexion esta pasando de " + e.OriginalState + " a " + e.CurrentState;
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            if (this.cn.State == ConnectionState.Closed)
            {
                this.cn.Open();
                this.lblMensaje.BackColor = Color.Green;
            }
        }

        private void btnDesconectar_Click(object sender, EventArgs e)
        {
            this.cn.Close();
            this.lblMensaje.BackColor = Color.Red;
        }

        private void btnLeerDatos_Click(object sender, EventArgs e)
        {
            //1.CONSULTA
            string sql = "select * from EMP";
            //2.CONFIGURAR COMAND
            //INDICAMOS CONEXION
            this.com.Connection = this.cn;
            //3.TIPO CONSULTA
            this.com.CommandType = CommandType.Text;
            //4.LA PROPIA CONSULTA
            this.com.CommandText = sql;

            //5.ABRIMOS LA CONEXION
            this.reader = this.com.ExecuteReader();

            //6.LEER LA PRIMERA COLUMNA
            for(int i = 0; i < this.reader.FieldCount; i++)
            {
                string columna = this.reader.GetName(i);
                string tipoDato = this.reader.GetDataTypeName(i);
                this.lstColumnas.Items.Add(columna);
                this.lstTipoDato.Items.Add(tipoDato);
            }


            //7.LEEMOS EL PRIMER REGISTRO PARA ELLOS USAMOS EL METODO READ()
            while (this.reader.Read())
            {
                string apellido = this.reader["APELLIDO"].ToString();
                this.lstApellidos.Items.Add(apellido);
            }

            //8.HAY QUE CERRAR TODO PARA REUTILIZARLO
            this.reader.Close();
        }
    }
}
