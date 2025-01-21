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
    public partial class Form05UpdateSalas : Form
    {
        SqlConnection conection;
        SqlCommand command;
        SqlDataReader reader;
        string salaNombre;
        public Form05UpdateSalas()
        {
            InitializeComponent();
            string connectionString = @"Data Source=LOCALHOST\SQLEXPRESS;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=sa;Trust Server Certificate=True";
            conection = new SqlConnection(connectionString);
            command = new SqlCommand();
            this.salaNombre = "";
            this.LoadSalas();
        }

        private async void btnModificarSalas_Click(object sender, EventArgs e)
        {
            string sql = "update SALA set NOMBRE=@nombrenuevo where NOMBRE=@nombreantiguo";
            string nuevonombre = this.txtNuevaSala.Text;

            SqlParameter parameterSet = new SqlParameter("@nombrenuevo", nuevonombre);
            SqlParameter parameterWhere = new SqlParameter("@nombreantiguo", salaNombre);

            this.command.Parameters.Add(parameterSet);
            this.command.Parameters.Add(parameterWhere);

            this.command.Connection = this.conection;
            this.command.CommandType = CommandType.Text;
            this.command.CommandText = sql;
            await this.conection.OpenAsync();
            await this.command.ExecuteNonQueryAsync();

            this.command.Parameters.Clear();
            await this.conection.CloseAsync();
            this.LoadSalas();
        }

        private async void LoadSalas()
        {
            string sql = "select DISTINCT(NOMBRE) from SALA";
            this.command.Connection = this.conection;
            this.command.CommandType = CommandType.Text;
            this.command.CommandText = sql;

            await this.conection.OpenAsync();
            this.reader = await this.command.ExecuteReaderAsync();
            this.lstSalas.Items.Clear();

            while ( await this.reader.ReadAsync())
            {
                string nombre = this.reader["NOMBRE"].ToString();
                this.lstSalas.Items.Add(nombre);
            }

            await this.reader.CloseAsync();
            await this.conection.CloseAsync();


        }


        private void lstSalas_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            this.txtNuevaSala.Text = (string)this.lstSalas.SelectedItem;
            this.salaNombre = this.txtNuevaSala.Text;
        }
    }
}
