
using App_MongoDB_Lab.Peliculas;
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
    public partial class CRUD_Peliculas : Form
    {
        public CRUD_Peliculas()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Eliminar_Pelicula ventana = new Eliminar_Pelicula();
            ventana.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Agregar_Pelicula ventana = new Agregar_Pelicula();
            ventana.Show();
        }

        private void volver_Click(object sender, EventArgs e)
        {
            this.Hide();
            Principal ventana = new Principal();
            ventana.Show();
        }

        private void modificar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Modificar_Pelicula ventana = new Modificar_Pelicula();
            ventana.Show();
        }

        private void ver_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ver_Pelicula ventana = new Ver_Pelicula();
            ventana.Show();
        }
    }
}
