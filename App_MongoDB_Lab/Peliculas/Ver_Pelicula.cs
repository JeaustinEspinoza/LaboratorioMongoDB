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
    public partial class Ver_Pelicula : Form
    {
        public Ver_Pelicula()
        {
            InitializeComponent();
            string conexion = "mongodb://localhost";
            var mc = new MongoClient(conexion);
            var server = mc.GetServer();
            var database = server.GetDatabase("MongoDB_Lab");

            var collection = database.GetCollection<Pelicula>("Pelicula");

            datos.DataSource = collection.FindAll().ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            CRUD_Peliculas ventana = new CRUD_Peliculas();
            ventana.Show();
        }
    }
}
