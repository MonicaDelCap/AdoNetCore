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
    public partial class Form09CrudHospitales : Form
    {
        RepositoryHospitales repo;
        public Form09CrudHospitales()
        {
            InitializeComponent();
            this.repo = new RepositoryHospitales();
            this.LoadHospitales();
        }

        private async void LoadHospitales()
        {
            List<Hospital> hospitals = await this.repo.GetHospitales();
            this.lstHospitales.Items.Clear();
            foreach (Hospital hos in hospitals)
            {
                this.lstHospitales.Items.Add(
                    hos.hospitalCod + " - " +
                    hos.nombre + " - " +
                    hos.direccion + " - " +
                    hos.telefono + " - " +
                    hos.numCamas);
            }

        }
        private async void btnInsertar_Click(object sender, EventArgs e)
        {
            await this.repo.InsertarHospitalesAsync(int.Parse(this.txtId.Text), this.txtNombre.Text, this.txtDireccion.Text, this.txtTelefono.Text, int.Parse(this.txtCam.Text));
            this.LoadHospitales();
        }

        private async void btnModificar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(this.txtId.Text);
            string cam = (this.txtCam.Text);
            await this.repo.ModificarHospitales(
                int.Parse(this.txtId.Text),
                this.txtNombre.Text,
                this.txtDireccion.Text,
                this.txtTelefono.Text,
                int.Parse(this.txtCam.Text)
                );
            this.LoadHospitales();
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            await this.repo.DeleteHospitalAsync(int.Parse(this.txtId.Text));
            this.LoadHospitales();
        }
    }
}
