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

namespace App_MongoDB_Lab
{
    public partial class Consultas : Form
    {
        public Consultas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (bytitulo.Text != "")
            {
                string conexion = "mongodb://localhost";
                var mc = new MongoClient(conexion);
                var server = mc.GetServer();
                var database = server.GetDatabase("MongoDB_Lab");
                server.Connect();

                MongoCollection<Pelicula> coleccion = database.GetCollection<Pelicula>("Pelicula");
                var resultado = Query<Pelicula>.EQ(u => u.nombre, bytitulo.Text);
                datos.DataSource = coleccion.Find(resultado).ToList();

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Principal ventana = new Principal();
            ventana.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string conexion = "mongodb://localhost";
            var mc = new MongoClient(conexion);
            var server = mc.GetServer();
            var database = server.GetDatabase("MongoDB_Lab");
            server.Connect();

            MongoCollection<Pelicula> coleccion = database.GetCollection<Pelicula>("Pelicula");
            var resultado = Query<Pelicula>.EQ(u => u.franquicia, byfranquicia.Text);
            datos.DataSource = coleccion.Find(resultado).ToList();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string conexion = "mongodb://localhost";
            var mc = new MongoClient(conexion);
            var server = mc.GetServer();
            var database = server.GetDatabase("MongoDB_Lab");
            server.Connect();

            MongoCollection<Pelicula> coleccion = database.GetCollection<Pelicula>("Pelicula");
            int valor = int.Parse(min.Text);
            int valor2 = int.Parse(max.Text);
            var resultado = Query<Pelicula>.Where(x => x.anho >= valor && x.anho <= valor2);
            datos.DataSource = coleccion.Find(resultado).ToList();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string conexion = "mongodb://localhost";
            var mc = new MongoClient(conexion);
            var server = mc.GetServer();
            var database = server.GetDatabase("MongoDB_Lab");
            server.Connect();

            MongoCollection<Pelicula> coleccion = database.GetCollection<Pelicula>("Pelicula");
            var resultado = Query<Pelicula>.EQ(u => u.productora, byproductora.Text);
            datos.DataSource = coleccion.Find(resultado).SetFields(Fields.Include("nombre", "genero", "anho")).ToList();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                string conexion = "mongodb://localhost";
                var mc = new MongoClient(conexion);
                var server = mc.GetServer();
                var database = server.GetDatabase("MongoDB_Lab");
                server.Connect();

                MongoCollection<Pelicula> coleccion = database.GetCollection<Pelicula>("Pelicula");

                var resultado = Query<Pelicula>.EQ(u => u.productora, estadisticas.Text);

                var contar = coleccion.Find(resultado).Count();
                var min = coleccion.Find(resultado).SetSortOrder(SortBy.Ascending("duracion")).SetLimit(1).FirstOrDefault();
                var max = coleccion.Find(resultado).SetSortOrder(SortBy.Descending("duracion")).SetLimit(1).FirstOrDefault();
                var filtro = coleccion.Find(resultado);
                double promedio = filtro.Average(x => x.duracion);



                lblCantidad.Text = contar + "";
                lblMin.Text = min.duracion + "";
                lblMax.Text = max.duracion + "";
                lblPromedio.Text = promedio + "";
            }
            catch (Exception error)
            {

            }
        }
    }
}
