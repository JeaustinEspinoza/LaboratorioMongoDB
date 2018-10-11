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
    public partial class Modificar_Compañia : Form
    {
        public Modificar_Compañia()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string conexion = "mongodb://localhost";
            var mc = new MongoClient(conexion);
            var server = mc.GetServer();
            var database = server.GetDatabase("MongoDB_Lab");

            var collection = database.GetCollection<Productora>("Productora");

            var nombreProduOriginal = nombre1.Text;
            string sitio = sitio1.Text;
            int año = Convert.ToInt32(año1.Text);


            var query = Query<Productora>.EQ(productora => productora.nombre, nombreProduOriginal);

            var update = Update<Productora>.Set(productora => productora.anho, año);
            collection.Update(query, update);

            update = Update<Productora>.Set(productora => productora.sitioWeb, sitio);
            collection.Update(query, update);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            CRUD_Cmp_Productoras ventana = new CRUD_Cmp_Productoras();
            ventana.Show();
        }
    }
}
