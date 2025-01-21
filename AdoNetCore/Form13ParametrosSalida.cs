using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdoNetCore.Models;
using AdoNetCore.Repositories;
using Microsoft.Data.SqlClient;
#region PROCEDURE
//create procedure SP_EMPLEADOS_DEPT_OUT
//(@nombre nvarchar(50), @suma int OUT, @media int OUT, @personas int OUT)
//as
//	declare @id int
//	select @id = DEPT_NO from DEPT where DNOMBRE = @nombre
//	select * from EMP where DEPT_NO = @id
//	select @suma=SUM(SALARIO), @media = avg(SALARIO), @personas = COUNT(EMP_NO) from EMP
//	where DEPT_NO=@id
//go



#endregion
namespace AdoNetCore
{
    public partial class Form13ParametrosSalida : Form
    {
        RepositoryParametrosOut repo;
        List<string> departamentos;
        EmpleadosDatos empleadosDatos;
       
        public Form13ParametrosSalida()
        {
            InitializeComponent();
            this.repo = new RepositoryParametrosOut();
            this.departamentos = new List<string>();
            this.empleadosDatos = new EmpleadosDatos();
            this.LoadDepartamentos();
        }

        private async void LoadDepartamentos()
        {
            this.departamentos = await this.repo.LoadDepartamentos();
            this.lstEmpleados.Items.Clear();
            foreach(string depnombre in departamentos)
            {
                this.cmbDepartamentos.Items.Add(depnombre);
            }
        }

        private async void btnMostrarDatos_Click(object sender, EventArgs e)
        {
            this.empleadosDatos = await this.repo.MostrarDatos(this.cmbDepartamentos.SelectedItem.ToString());
            this.lstEmpleados.Items.Clear();
            foreach(string empleado in empleadosDatos.empleados)
            {
                this.lstEmpleados.Items.Add(empleado);
            }
            this.txtMedia.Text = empleadosDatos.media.ToString();
            this.txtPersonas.Text = empleadosDatos.personas.ToString();
            this.txtSuma.Text = empleadosDatos.suma.ToString();

        }
    }
}
