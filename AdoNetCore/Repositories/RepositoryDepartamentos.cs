using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdoNetCore.Models;
using Microsoft.Data.SqlClient;
namespace AdoNetCore.Repositories
{
    public class RepositoryDepartamentos
    {
        private SqlConnection cn;
        private SqlCommand com;
        private SqlDataReader reader;


        public RepositoryDepartamentos()
        {
            string connectionString = @"Data Source=LOCALHOST\SQLEXPRESS;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=sa;Trust Server Certificate=True";
            this.cn = new SqlConnection(connectionString);
            this.com = new SqlCommand();
            this.com.Connection = this.cn;
        }

        public async Task<List<Departamento>> GetDepartamentosAsync()
        {
            string sql = "select * from DEPT";
            List<Departamento> departamentos = new List<Departamento>();

            this.com.CommandType = System.Data.CommandType.Text;
            this.com.CommandText = sql;

            await this.cn.OpenAsync();
            this.reader = await this.com.ExecuteReaderAsync();

            while(await this.reader.ReadAsync())
            {
                int id = int.Parse(this.reader["DEPT_NO"].ToString());
                string nombre = this.reader["DNOMBRE"].ToString();
                string loc = this.reader["LOC"].ToString();
                Departamento departamento = new Departamento();
                departamento.id = id;
                departamento.nombre = nombre;
                departamento.loc = loc;
                departamentos.Add(departamento);
            }

            await this.reader.CloseAsync();
            await this.cn.CloseAsync();

            return departamentos;

        }

        public async Task InsertDepartamento(int id , string nombre, string loc)
        {
            string sql = "insert into DEPT values(@id, @nombre, @loc)";

            SqlParameter paramid = new SqlParameter("@id", id);
            this.com.Parameters.Add(paramid);
            SqlParameter paramnombre = new SqlParameter("@nombre", nombre);
            this.com.Parameters.Add(paramnombre);
            SqlParameter paramloc = new SqlParameter("@loc", loc);
            this.com.Parameters.Add(paramloc);

            this.com.CommandType = System.Data.CommandType.Text;
            this.com.CommandText = sql;

            await this.cn.OpenAsync();
            await this.com.ExecuteNonQueryAsync();

            await this.cn.CloseAsync();
            this.com.Parameters.Clear();
        }

        public async Task ModificarDepartamentoAsync(int id, string nombre, string loc)
        {
            string sql = "update DEPT set DNOMBRE=@nombre, LOC=@loc where DEPT_NO=@id";

            //METODO EN EL COMAND PARA ALMACENAR PARAMETROS, SOLO SE USAN PARA PARAMETROS TIPADOS PRIMITIVOS
            SqlParameter paramid = new SqlParameter("@id", id);
            this.com.Parameters.AddWithValue("@id", id);
            this.com.Parameters.AddWithValue("@nombre", nombre);
            this.com.Parameters.AddWithValue("@loc", loc);

            this.com.CommandType = System.Data.CommandType.Text;
            this.com.CommandText = sql;

            await this.cn.OpenAsync();
            await this.com.ExecuteNonQueryAsync();

            this.com.Parameters.Clear();
            await this.cn.CloseAsync();
        }

        public async Task DeleteDepartamento(int id)
        {
            string sql = "delete from DEPT where DEPT_NO=@id";
            this.com.Parameters.AddWithValue("@id", id);

            this.com.CommandType = System.Data.CommandType.Text;
            this.com.CommandText = sql;

            await this.cn.OpenAsync();
            await this.com.ExecuteNonQueryAsync();

            await this.cn.CloseAsync();
            this.com.Parameters.Clear();
        }
    }
}
