﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
namespace AdoNetCore.Repositories
{
    public class RepositorySalas
    {
        private SqlConnection cn;
        private SqlCommand com;
        private SqlDataReader reader;

        public RepositorySalas()
        {
            string connectionString = @"Data Source=LOCALHOST\SQLEXPRESS;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=sa;Trust Server Certificate=True";
            this.cn = new SqlConnection(connectionString);
            this.com = new SqlCommand();
        }

        public async Task<List<string>> GetNombreSalasAsync()
        {
            string sql = "select distinct NOMBRE from SALA";
            this.com.Connection = this.cn;
            this.com.CommandType = System.Data.CommandType.Text;
            this.com.CommandText = sql;

            await this.cn.OpenAsync();
            this.reader = await this.com.ExecuteReaderAsync();

            List<string> salas = new List<string>();
            while (await this.reader.ReadAsync())
            {
                string nombre = this.reader["NOMBRE"].ToString();
                salas.Add(nombre);
            }

            await this.reader.CloseAsync();
            await this.cn.CloseAsync();

            return salas;
        }


        public async Task UpdateNombreSalasAsync(string oldName, string newName)
        {
            string sql = "update SALA set NOMBRE=@nuevonombre where NOMBRE=@antiguonombre";
            SqlParameter paramNewName = new SqlParameter("@nuevonombre", newName);
            SqlParameter paramOldName = new SqlParameter("@antiguonombre", oldName);
            this.com.Parameters.Add(paramNewName);
            this.com.Parameters.Add(paramOldName);

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
