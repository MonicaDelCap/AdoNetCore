using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
namespace AdoNetCore.Repositories
{
    public class RepositoryUpdateEmpleados
    {
        private SqlConnection cn;
        private SqlCommand com;
        private SqlDataReader reader;


        public RepositoryUpdateEmpleados()
        {
            string connectionString = @"Data Source=LOCALHOST\SQLEXPRESS;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=sa;Trust Server Certificate=True";
            this.cn = new SqlConnection(connectionString);
            this.com = new SqlCommand();
            this.com.Connection = this.cn;
        }

        public async Task<List<string>> GetOficiosAsync()
        {
            string sql = "select distinct OFICIO from EMP";
            this.com.CommandType = System.Data.CommandType.Text;
            this.com.CommandText = sql;

            await this.cn.OpenAsync();
            this.reader = await this.com.ExecuteReaderAsync();

            List<string> oficio = new List<string>();

            while(await this.reader.ReadAsync())
            {
                oficio.Add(this.reader["OFICIO"].ToString());
            }

            await this.reader.CloseAsync();
            await this.cn.CloseAsync();

            return oficio;
        }

        public async Task<List<string>> GetEmpleadosOficioAsync(string oficio)
        {
            string sql = "select * from EMP where OFICIO=@oficio ";
            this.com.Parameters.AddWithValue("@oficio", oficio);
            this.com.CommandType = System.Data.CommandType.Text;
            this.com.CommandText = sql;

            await this.cn.OpenAsync();
            this.reader = await this.com.ExecuteReaderAsync();
            List<string> empleados = new List<string>();


            while(await this.reader.ReadAsync())
            {
                empleados.Add(this.reader["APELLIDO"].ToString() + " - " + this.reader["SALARIO"].ToString());
            }

            await this.cn.CloseAsync();
            await this.reader.CloseAsync();

            this.com.Parameters.Clear();

            return empleados;
        }

        public async Task<int> UpdateSalarioEmpleadosOficio(string oficio, int incremento)
        {
            string sql = "update EMP set SALARIO=SALARIO+@incremento where OFICIO=@oficio";
            this.com.Parameters.AddWithValue("@incremento", incremento);
            this.com.Parameters.AddWithValue("@oficio", oficio);

            this.com.CommandType = System.Data.CommandType.Text;
            this.com.CommandText = sql;

            await this.cn.OpenAsync();
            int afectados =  await this.com.ExecuteNonQueryAsync();

            await this.cn.CloseAsync();
            this.com.Parameters.Clear();

            return afectados;
            
        }

        public async Task UpdateOficioEmpleadosAsync(string newOficio,string oldOficio)
        {
            string sql = "update EMP set OFICIO=@newOficio where OFICIO=@oldoficio";
            this.com.Parameters.AddWithValue("@newOficio", newOficio);
            this.com.Parameters.AddWithValue("@oldoficio", oldOficio);

            this.com.CommandType = System.Data.CommandType.Text;
            this.com.CommandText = sql;

            await this.cn.OpenAsync();
            await this.com.ExecuteNonQueryAsync();

            await this.cn.CloseAsync();
            this.com.Parameters.Clear();
        }

        public async Task<List<string>> ConseguirDatos(string oficio)
        {
            string sql = "select avg(SALARIO) as MEDIA , max(SALARIO) as MAXIMO, sum(SALARIO) as SUMA from EMP where OFICIO=@oficio";
            this.com.Parameters.AddWithValue("@oficio", oficio);

            List<string> datos = new List<string>();

            this.com.CommandType = System.Data.CommandType.Text;
            this.com.CommandText = sql;

            await this.cn.OpenAsync();
            this.reader = await this.com.ExecuteReaderAsync();
            
            while(await this.reader.ReadAsync())
            {
                datos.Add(this.reader["MEDIA"].ToString());
                datos.Add(this.reader["MAXIMO"].ToString());
                datos.Add(this.reader["SUMA"].ToString());
            }

            await this.cn.CloseAsync();
            await this.reader.CloseAsync();
            this.com.Parameters.Clear();

            return datos;
        }

    }
}
