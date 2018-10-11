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
    public partial class Modificar_Pelicula : Form
    {
        public Modificar_Pelicula()
        {
            InitializeComponent();
            string conexion = "mongodb://localhost";
            var mc = new MongoClient(conexion);
            var server = mc.GetServer();
            var database = server.GetDatabase("MongoDB_Lab");

            var collection = database.GetCollection<Pelicula>("Pelicula");

            datos.DataSource = collection.FindAll().ToList();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string conexion = "mongodb://localhost";
            var mc = new MongoClient(conexion);
            var server = mc.GetServer();
            var database = server.GetDatabase("MongoDB_Lab");

            var collection = database.GetCollection<Pelicula>("Pelicula");

            var nombrePeliOriginal = pelicula1.Text;
            string genero = genero1.Text;
            string director = director1.Text;
            string franquicia = franquicia1.Text;
            string pais = pais1.Text;
            int año = Convert.ToInt32(año1.Text);
            int duracion = Convert.ToInt32(duracion1.Text);
            string productora = productora1.Text;
            string[] actores = actores1.Text.Split(','); ;





            var query = Query<Pelicula>.EQ(pelicula=> pelicula.nombre, nombrePeliOriginal);
            
            var update =Update<Pelicula>.Set(pelicula=> pelicula.genero, genero);
            collection.Update(query, update);

            update = Update<Pelicula>.Set(pelicula => pelicula.director,director);
            collection.Update(query, update);

            update = Update<Pelicula>.Set(pelicula => pelicula.franquicia, franquicia);
            collection.Update(query, update);

            update = Update<Pelicula>.Set(pelicula => pelicula.pais, pais);
            collection.Update(query, update);

            update = Update<Pelicula>.Set(pelicula => pelicula.anho, año);
            collection.Update(query, update);

            update = Update<Pelicula>.Set(pelicula => pelicula.duracion, duracion);
            collection.Update(query, update);

            update = Update<Pelicula>.Set(pelicula => pelicula.productora, productora);
            collection.Update(query, update);

            update = Update<Pelicula>.Set(pelicula => pelicula.actores, actores);
            collection.Update(query, update);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Modificar_Pelicula_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            CRUD_Peliculas ventana = new CRUD_Peliculas();
            ventana.Show();
        }
    }
}
