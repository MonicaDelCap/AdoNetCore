using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Extensions.Configuration;

namespace AdoNetCore
{
    public partial class Form14Settings : Form
    {
        public Form14Settings()
        {
            InitializeComponent();
        }

        private void btnLeerSettings_Click(object sender, EventArgs e)
        {
            ConfigurationBuilder builder = new ConfigurationBuilder();
            //NO ES NATIVO PARA ESTE ENTORNO, DEBEMOS INDICAR EL NOMBRE DEL FICHERO Y SU UBICACION
            builder.SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json",false,true);
            IConfigurationRoot configuration = builder.Build();
            string connection = configuration.GetConnectionString("SqlTajamar");
            this.lblCadenaConexion.Text = connection;

            string imagen1 = configuration.GetSection("Imagenes:imagen1").Value;
            string imagen2 = configuration.GetSection("Imagenes:imagen1").Value;
            string fondo = configuration.GetSection("Colores:fondo").Value;
            string letra = configuration.GetSection("Colores:letra").Value;

            this.pictureBox1.Load(imagen1);
            this.pictureBox2.Load(imagen1);

            this.btnLeerSettings.BackColor = Color.FromName(fondo);
        }
    }
}
