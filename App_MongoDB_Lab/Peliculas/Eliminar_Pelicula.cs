using MongoDB.Driver;
using MongoDB.Driver.Builders;
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
    public partial class Eliminar_Pelicula : Form
    {
        public Eliminar_Pelicula()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            CRUD_Peliculas ventana = new CRUD_Peliculas();
            ventana.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            CRUD_Peliculas ventana = new CRUD_Peliculas();
            ventana.Show();
        }

        private void button3_Click(object sender, EventArgs e)
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

                    var coleccion = database.GetCollection<Pelicula>("Pelicula");
                    
                    var query = Query<Pelicula>.EQ(pelicula => pelicula.nombre, nombre);
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
                MessageBox.Show("Ingrese el nombre de la película.");
            }
        }
    }
}
