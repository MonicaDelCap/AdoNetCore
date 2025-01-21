using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdoNetCore.Models;
using Microsoft.Data.SqlClient;
namespace AdoNetCore.Repositories
{
    public class RepositoryHospitales
    {
        private SqlConnection cn;
        private SqlCommand com;
        private SqlDataReader reader;

        public RepositoryHospitales()
        {
            string connectionString = @"Data Source=LOCALHOST\SQLEXPRESS;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=sa;Trust Server Certificate=True";
            this.cn = new SqlConnection(connectionString);
            this.com = new SqlCommand();
            this.com.Connection = this.cn;
        }


        public async Task<List<Hospital>> GetHospitales()
        {
            string sql = "select * from HOSPITAL";
            List<Hospital> hospitales = new List<Hospital>();

            this.com.CommandType = System.Data.CommandType.Text;
            this.com.CommandText = sql;

            await this.cn.OpenAsync();
            this.reader = await this.com.ExecuteReaderAsync();

            while(await this.reader.ReadAsync())
            {
                Hospital hospital = new Hospital();
                hospital.hospitalCod = int.Parse(this.reader["HOSPITAL_COD"].ToString());
                hospital.nombre = this.reader["NOMBRE"].ToString();
                hospital.direccion = this.reader["DIRECCION"].ToString();
                hospital.telefono = this.reader["TELEFONO"].ToString();
                hospital.numCamas = int.Parse(this.reader["NUM_CAMA"].ToString());

                hospitales.Add(hospital);
            }

            await this.reader.CloseAsync();
            await this.cn.CloseAsync();

            return hospitales;
        }

        public async Task InsertarHospitalesAsync(int id, string nombre, string dir, string telf, int cam)
        {
            string sql = "insert into HOSPITAL values(@id,@nombre,@dir,@telf,@cam)";

            this.com.Parameters.AddWithValue("@id", id);
            this.com.Parameters.AddWithValue("@nombre", nombre);
            this.com.Parameters.AddWithValue("@dir", dir);
            this.com.Parameters.AddWithValue("@telf", telf);
            this.com.Parameters.AddWithValue("@cam", cam);


            this.com.CommandType = System.Data.CommandType.Text;
            this.com.CommandText = sql;

            await this.cn.OpenAsync();
            await this.com.ExecuteNonQueryAsync();

            await this.cn.CloseAsync();
            this.com.Parameters.Clear();
        }


        public async Task ModificarHospitales(int id, string nombre, string dir, string telf, int cam)
        {
            string sql = "update HOSPITAL " +
                "set NOMBRE=@nombre, DIRECCION=@dir, TELEFONO=@telf, NUM_CAMA=@cam " +
                "where HOSPITAL_COD=@id";

            this.com.Parameters.AddWithValue("@id", id);
            this.com.Parameters.AddWithValue("@nombre", nombre);
            this.com.Parameters.AddWithValue("@dir", dir);
            this.com.Parameters.AddWithValue("@telf", telf);
            this.com.Parameters.AddWithValue("@cam", cam);

            this.com.CommandType = System.Data.CommandType.Text;
            this.com.CommandText = sql;

            await this.cn.OpenAsync();
            await this.com.ExecuteNonQueryAsync();

            await this.cn.CloseAsync();
            this.com.Parameters.Clear();

        }

        public async Task DeleteHospitalAsync(int id)
        {
            string sql = "delete from HOSPITAL where HOSPITAL_COD=@id";

            this.com.Parameters.AddWithValue("@id", id);

            this.com.CommandType = System.Data.CommandType.Text;
            this.com.CommandText = sql;

            await this.cn.OpenAsync();
            await this.com.ExecuteNonQueryAsync();

            this.com.Parameters.Clear();
            await this.cn.CloseAsync();
        }
    }
}
