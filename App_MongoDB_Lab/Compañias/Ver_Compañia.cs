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
    public partial class Ver_Compañia : Form
    {
        public Ver_Compañia()
        {
            InitializeComponent();
            string conexion = "mongodb://localhost";
            var mc =new MongoClient(conexion);
            var server = mc.GetServer();
            var database= server.GetDatabase("MongoDB_Lab");

            var collection = database.GetCollection<Productora>("Productora");

            datos.DataSource = collection.FindAll().ToList();
        }

        private void Ver_Compañia_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            CRUD_Cmp_Productoras ventana = new CRUD_Cmp_Productoras();
            ventana.Show();
        }
    }
}
