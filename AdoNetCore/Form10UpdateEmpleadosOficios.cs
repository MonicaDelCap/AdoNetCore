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
    public partial class Form10UpdateEmpleadosOficios : Form
    {
        RepositoryUpdateEmpleados repo;
        public Form10UpdateEmpleadosOficios()
        {
            InitializeComponent();
            this.repo = new RepositoryUpdateEmpleados();
            this.LoadOficio();
        }

        private async Task LoadOficio()
        {
            List<string> oficio = await this.repo.GetOficiosAsync();
            this.lstOficios.Items.Clear();
            foreach (string ofi in oficio)
            {
                this.lstOficios.Items.Add(ofi);
            }
        }


        private async void btnIncrementar_Click(object sender, EventArgs e)
        {
            string oficio = this.lstOficios.SelectedItem.ToString();
            int incremento = int.Parse(this.txtIncremento.Text);
            int mod = await this.repo.UpdateSalarioEmpleadosOficio(oficio, incremento);

            string newOficio = this.txtOficio.Text;

            await this.repo.UpdateOficioEmpleadosAsync(newOficio, oficio);

            List<string> datos = await this.repo.ConseguirDatos(newOficio);

            this.lblMedia.Text = datos[0];
            this.lblMaximo.Text = datos[1];
            this.lblSuma.Text = datos[2];

            await this.LoadOficio();
            await this.LoadEmpleados(newOficio);
        }

        private void lstOficios_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(this.lstOficios.SelectedIndex != -1)
            {
                string oficio = this.lstOficios.SelectedItem.ToString();
                this.LoadEmpleados(oficio);
            }
        }

        private async Task LoadEmpleados(string oficio) 
        {
            List<string> empleados = await this.repo.GetEmpleadosOficioAsync(oficio);
            this.lstEmpleados.Items.Clear();
            foreach(string emp in empleados)
            {
                this.lstEmpleados.Items.Add(emp);
            }
        }

        
    }
}
