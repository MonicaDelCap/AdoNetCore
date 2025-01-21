using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdoNetCore.Repositories;

namespace AdoNetCore
{
    public partial class Form07DepartamentosEmpleados : Form
    {
        RepositoryDepartamentosEmpleados repo;
        public Form07DepartamentosEmpleados()
        {
            InitializeComponent();
            this.repo = new RepositoryDepartamentosEmpleados();
            this.LoadDepartamentos();
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            string ape = this.lstEmpleados.SelectedItem.ToString();
            await this.repo.DeleteEmpleadoAsync(ape);
            this.lstEmpleados.Items.Clear();

            string s = this.lstDepartamentos.SelectedItem.ToString();
            List<string> emp = await this.repo.LoadEmpleadosAsync(s);
            foreach (string em in emp)
            {
                this.lstEmpleados.Items.Add(em);
            }
        }

        private async void LoadDepartamentos()
        {
            this.lstDepartamentos.Items.Clear();
            List<string> dep = await this.repo.LoadDepartamentosAsync();
            foreach (string d in dep)
            {
                this.lstDepartamentos.Items.Add(d);
            }
        }

        private async void lstDepartamentos_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.lstEmpleados.Items.Clear();
            string s = this.lstDepartamentos.SelectedItem.ToString();
            List<string> emp = await this.repo.LoadEmpleadosAsync(s);
            foreach(string em in emp)
            {
                this.lstEmpleados.Items.Add(em);
            }
        }
    }
}
