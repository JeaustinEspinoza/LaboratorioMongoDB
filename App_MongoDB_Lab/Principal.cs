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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            CRUD_Peliculas ventana = new CRUD_Peliculas();
            ventana.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Consultas ventana = new Consultas();
            ventana.Show();

        }

        private void btn_compania_Click(object sender, EventArgs e)
        {
            this.Hide();
            CRUD_Cmp_Productoras ventana = new CRUD_Cmp_Productoras();
            ventana.Show();
        }
    }
}
