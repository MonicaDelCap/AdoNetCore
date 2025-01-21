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
    public partial class Form06UpdateSalasClase : Form
    {
        RepositorySalas repository;
        public Form06UpdateSalasClase()
        {
            InitializeComponent();
            this.repository = new RepositorySalas();
            this.LoadSalas();
        }

        private async void LoadSalas()
        {
            List<string> salas = await this.repository.GetNombreSalasAsync();
            foreach(string nombre in salas)
            {
                this.lstSalas.Items.Add(nombre);
            }
        }

        private async void btnModificarSalas_Click(object sender, EventArgs e)
        {
            string oldName = this.lstSalas.SelectedItem.ToString();
            string newName = this.txtNuevaSala.Text;
            await this.repository.UpdateNombreSalasAsync(oldName, newName);
            this.lstSalas.Items.Clear();
            this.LoadSalas();
        }
    }
}
