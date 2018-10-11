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
    public partial class CRUD_Cmp_Productoras : Form
    {
        public CRUD_Cmp_Productoras()
        {
            InitializeComponent();
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Agregar_Compañia ventana = new Agregar_Compañia();
            ventana.Show();
        }

        private void btn_Ver_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ver_Compañia ventana = new Ver_Compañia();
            ventana.Show();
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Modificar_Compañia ventana = new Modificar_Compañia();
            ventana.Show();
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Eliminar_Compañia ventana = new Eliminar_Compañia();
            ventana.Show();
        }

        private void btn_Volver_Click(object sender, EventArgs e)
        {
            this.Hide();
            Principal ventana = new Principal();
            ventana.Show();
        }
    }
}
