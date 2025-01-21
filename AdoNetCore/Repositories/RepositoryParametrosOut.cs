using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdoNetCore.Models;
using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Tokens;
namespace AdoNetCore.Repositories
{
    public class RepositoryParametrosOut
    {
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;

        public RepositoryParametrosOut()
        {
            string connectionString = @"Data Source=LOCALHOST\SQLEXPRESS;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=sa;Trust Server Certificate=True";
            this.cn = new SqlConnection(connectionString);
            this.com = new SqlCommand();
            this.com.Connection = this.cn;
        }

        public async Task<List<string>> LoadDepartamentos()
        {
            string sql = "SP_ALL_DEPARTAMENTOS";
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            this.reader = await this.com.ExecuteReaderAsync();
            List<string> departamentos = new List<string>();
            while (await this.reader.ReadAsync())
            {
                departamentos.Add(this.reader["DNOMBRE"].ToString());
            }

            await this.cn.CloseAsync();
            await this.reader.CloseAsync();
            return departamentos;
        }

        public async Task<EmpleadosDatos> MostrarDatos(string nombre)
        {
            string sql = "SP_EMPLEADOS_DEPT_OUT";
            //PARA LOS PARAM DE ENTRADA USAMOS ADDWITHVALUE
            //PARA LOS PARAM DE SALIDA PARAMETER
            this.com.Parameters.AddWithValue("@nombre", nombre);
           
            SqlParameter paramSuma = new SqlParameter();
            paramSuma.ParameterName = "@suma";
            paramSuma.Value = 0;
            paramSuma.Direction = ParameterDirection.Output;
            this.com.Parameters.Add(paramSuma);

            SqlParameter pamMedia = new SqlParameter();
            pamMedia.ParameterName = "@media";
            pamMedia.Value = 0;
            pamMedia.Direction = ParameterDirection.Output;
            this.com.Parameters.Add(pamMedia);

            SqlParameter pamPersonas = new SqlParameter();
            pamPersonas.ParameterName = "@personas";
            pamPersonas.Value = 0;
            pamPersonas.Direction = ParameterDirection.Output;
            this.com.Parameters.Add(pamPersonas);
            //DEVULVE CONSULTA DE SELECCION

            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = sql;

            await this.cn.OpenAsync();
            this.reader = await this.com.ExecuteReaderAsync();
            List<string> empleados = new List<string>();

            while (await this.reader.ReadAsync())
            {
                empleados.Add(this.reader["APELLIDO"].ToString());
            }
            await this.reader.CloseAsync();

            int suma = 0;
            int personas = 0;
            int media = 0;

            try
            {
                 suma = int.Parse(paramSuma.Value.ToString());
                 personas = int.Parse(pamPersonas.Value.ToString());
                 media = int.Parse(pamMedia.Value.ToString());
            }
            catch (System.FormatException){}
            

            await this.cn.CloseAsync();
            this.com.Parameters.Clear();

            EmpleadosDatos empleadosDatos = new EmpleadosDatos();
            empleadosDatos.empleados = empleados;
            empleadosDatos.suma = suma;
            empleadosDatos.media = media;
            empleadosDatos.personas = personas;

            return empleadosDatos;
        }

    }
}
