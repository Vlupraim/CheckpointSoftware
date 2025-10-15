using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckpointSoftware
{
    public partial class AdminForm : Form
    {
        public AdminForm(String Usuario)
        {
            InitializeComponent();
            txtUser.Text = Usuario;
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'masterDataSet.Producto' Puede moverla o quitarla según sea necesario.
            this.productoTableAdapter.Fill(this.masterDataSet.Producto);

        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            ProductosVen ventana = new ProductosVen();
            ventana.Show();
            this.Hide();

        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            UsuariosVen ventana = new UsuariosVen();
            ventana.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
