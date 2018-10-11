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
    public partial class Agregar_Pelicula : Form
    {
        public Agregar_Pelicula()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            CRUD_Peliculas ventana = new CRUD_Peliculas();
            ventana.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var nombre = pelicula1.Text;
            string genero = genero1.Text;
            string director = director1.Text;
            string franquicia = franquicia1.Text;
            string pais = pais1.Text;
            int año = Convert.ToInt32(año1.Text);
            int duracion = Convert.ToInt32(duracion1.Text);
            string productora = productora1.Text;
            string[] actores = actores1.Text.Split(',');


            try
            {
                string conexion = "mongodb://localhost";
                var mc = new MongoClient(conexion);
                var server = mc.GetServer();
                var database = server.GetDatabase("MongoDB_Lab");
                server.Connect();
                var coleccion = database.GetCollection<Pelicula>("Pelicula");
                var pelicula = new Pelicula { nombre = nombre, genero = genero,
                    director = director, franquicia = franquicia, pais = pais, anho = año,
                    duracion = duracion, productora = productora, actores = actores };
                coleccion.Insert(pelicula);
                MessageBox.Show("Se registró la película.");
                this.Hide();
            }
            catch (Exception error)
            {
                MessageBox.Show("Sucedió un error: " + error);
            }
        }
    }
}
