using System;
using MongoDB.Driver;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Driver.Builders;

namespace App_MongoDB_Lab.Peliculas
{
    public partial class Eliminar_Compañia : Form
    {
        public Eliminar_Compañia()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            CRUD_Cmp_Productoras ventana = new CRUD_Cmp_Productoras();
            ventana.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string nombre = nombre1.Text;
            if (nombre != "")
            {
                try
                {
                    var conexion = "mongodb://localhost";
                    var mc = new MongoClient(conexion);
                    var server = mc.GetServer();
                    var database = server.GetDatabase("MongoDB_Lab");
                    server.Connect();

                    var coleccion = database.GetCollection<Productora>("Productora");

                    var query = Query<Productora>.EQ(pelicula => pelicula.nombre, nombre);
                    coleccion.Remove(query);
                    MessageBox.Show("Éxito");
                    this.Hide();
                }
                catch (Exception error)
                {
                    MessageBox.Show("Ocurrió un error: " + error);
                }
            }
            else
            {
                MessageBox.Show("Ingrese el nombre de la productora.");
            }
        }
    }
}
