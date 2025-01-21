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

namespace AdoNetCore
{
    public partial class Form08CrudDepartamentos : Form
    {

        private RepositoryDepartamentos repo;
        public Form08CrudDepartamentos()
        {
            InitializeComponent();
            this.repo = new RepositoryDepartamentos();
            this.LoadDepartamentos();
        }

        private async void LoadDepartamentos()
        {
            List<Departamento> departamentos = await this.repo.GetDepartamentosAsync();

            this.lstDepartamentos.Items.Clear();
            foreach (Departamento dep in departamentos)
            {
                this.lstDepartamentos.Items.Add(dep.id + " - " + dep.nombre + " - " + dep.loc);
            }

        }
        private async void btnInsertar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(this.txtId.Text);
            string n = this.txtNombre.Text;
            string l = this.txtLocalidad.Text;

            await this.repo.InsertDepartamento(id, n, l);
            this.LoadDepartamentos();
        }

        private async void btnModificar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(this.txtId.Text);
            string nombre = this.txtNombre.Text;
            string loc = this.txtLocalidad.Text;

            await this.repo.ModificarDepartamentoAsync(id, nombre, loc);
            this.LoadDepartamentos();
        }

        private void lstDepartamentos_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] atridep = this.lstDepartamentos.SelectedItem.ToString().Split("-");
            this.txtId.Text = atridep[0];
            this.txtNombre.Text = atridep[1];
            this.txtLocalidad.Text = atridep[2];
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(this.txtId.Text);
            await this.repo.DeleteDepartamento(id);
            this.LoadDepartamentos();

            this.txtId.Clear();
            this.txtNombre.Clear();
            this.txtLocalidad.Clear();
        }
    }
}
