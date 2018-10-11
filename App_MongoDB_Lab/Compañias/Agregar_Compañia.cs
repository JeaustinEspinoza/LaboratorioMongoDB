using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_MongoDB_Lab.Peliculas
{
    public partial class Agregar_Compañia : Form
    {
        public Agregar_Compañia()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            CRUD_Cmp_Productoras ventan = new CRUD_Cmp_Productoras();
            ventan.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var nombre = nombre1.Text;
            int año = Convert.ToInt32(año1.Text);
            string sitio = sitio1.Text;

            try
            {
                string conexion = "mongodb://localhost";
                var mc = new MongoClient(conexion);
                var server = mc.GetServer();
                var database = server.GetDatabase("MongoDB_Lab");
                server.Connect();
                var coleccion = database.GetCollection<Productora>("Productora");
                var productora = new Productora
                {
                    nombre = nombre,
                    anho = año,
                    sitioWeb = sitio,
                };
                coleccion.Insert(productora);
                MessageBox.Show("Se registró la compañía");
                this.Hide();
            }
            catch (Exception error)
            {
                MessageBox.Show("Sucedió un error: " + error);
            }
        }
    }
}
