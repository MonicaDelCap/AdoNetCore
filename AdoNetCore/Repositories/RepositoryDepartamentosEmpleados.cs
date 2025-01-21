using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
namespace AdoNetCore.Repositories
{
    public class RepositoryDepartamentosEmpleados
    {
        private SqlConnection cn;
        private SqlCommand com;
        private SqlDataReader reader;


        public RepositoryDepartamentosEmpleados()
        {
            string connectionString = @"Data Source=LOCALHOST\SQLEXPRESS;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=sa;Trust Server Certificate=True";
            this.cn = new SqlConnection(connectionString);
            this.com = new SqlCommand();
        }

        public async Task<List<string>> LoadDepartamentosAsync()
        {
            string sql = " select DNOMBRE from DEPT";
            List<string> depart = new List<string>();
            this.com.Connection = this.cn;
            this.com.CommandType = System.Data.CommandType.Text;
            this.com.CommandText = sql;

            await this.cn.OpenAsync();
            this.reader = await this.com.ExecuteReaderAsync();
            while(await this.reader.ReadAsync())
            {
                depart.Add(this.reader["DNOMBRE"].ToString());
            }

            await this.reader.CloseAsync();
            await this.cn.CloseAsync();

            return depart;
        }


        public async Task<List<string>> LoadEmpleadosAsync(string dep)
        {
            string sql = "select EMP.APELLIDO from EMP inner join DEPT on DEPT.DEPT_NO=EMP.DEPT_NO where DEPT.DNOMBRE =@nombredepartamento";
            List<string> emp = new List<string>();

            this.com.Connection = this.cn;
            this.com.CommandType = System.Data.CommandType.Text;
            this.com.CommandText = sql;

            SqlParameter param = new SqlParameter("@nombredepartamento", dep);
            this.com.Parameters.Add(param);

            await this.cn.OpenAsync();
            this.reader = await this.com.ExecuteReaderAsync();

            while(await this.reader.ReadAsync())
            {
                emp.Add(this.reader["APELLIDO"].ToString());
            }

            await this.cn.CloseAsync();
            await this.reader.CloseAsync();
            this.com.Parameters.Clear();

            return emp;
        }


        public async Task DeleteEmpleadoAsync(string ap)
        {
            string sql = "delete from EMP where APELLIDO=@apellido";
            SqlParameter pamApellido = new SqlParameter("@apellido", ap);
            this.com.Parameters.Add(pamApellido);
            this.com.Connection = this.cn;
            this.com.CommandType = System.Data.CommandType.Text;
            this.com.CommandText = sql;

            await this.cn.OpenAsync();
            await this.com.ExecuteNonQueryAsync();

            await this.cn.CloseAsync();
            this.com.Parameters.Clear();

        }
    }
}
