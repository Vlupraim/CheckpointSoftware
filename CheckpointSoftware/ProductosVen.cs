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
    public partial class ProductosVen : Form
    {
        public ProductosVen()
        {
            InitializeComponent();
        }

        private void ProductosVen_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'datosProductos.Producto' Puede moverla o quitarla según sea necesario.
            this.productoTableAdapter.Fill(this.datosProductos.Producto);
            dataGridView1.DataSource = datosProductos.Producto;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            using (BDCheckpointEntities bd = new BDCheckpointEntities())
            {

                Producto nuevoProducto = new Producto
                {
                    Id = 1,
                    Nombre = txtNombre.Text,
                    Unidad = txtUnidad.Text,
                    VidaUtilDias = int.Parse(txtVida.Text),
                    TempMax = decimal.Parse(txtTempMax.Text),
                    TempMin = decimal.Parse(txtTempMin.Text),
                    Sku = txtSku.Text,
                    StockMinimo = decimal.Parse(txtStockMin.Text),
                    Activo = chkActivo.Checked


                };
                bd.Producto.Add(nuevoProducto);
                bd.SaveChanges();
                MessageBox.Show("Producto agregado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.productoTableAdapter.Fill(this.datosProductos.Producto);
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            AdminForm adminForm = new AdminForm("");
            adminForm.Show();
            this.Hide();

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value);
                using (BDCheckpointEntities bd = new BDCheckpointEntities())
                {
                    var producto = bd.Producto.FirstOrDefault(p => p.Id == id);
                    if (producto != null)
                    {
                        bd.Producto.Remove(producto);
                        bd.SaveChanges();
                        MessageBox.Show("Producto eliminado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.productoTableAdapter.Fill(this.datosProductos.Producto);
                    }
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value);
                using (BDCheckpointEntities bd = new BDCheckpointEntities())
                {
                    var producto = bd.Producto.FirstOrDefault(p => p.Id == id);
                    if (producto != null)
                    {
                        producto.Nombre = txtNombre.Text;
                        producto.Unidad = txtUnidad.Text;
                        producto.VidaUtilDias = int.Parse(txtVida.Text);
                        producto.TempMax = decimal.Parse(txtTempMax.Text);
                        producto.TempMin = decimal.Parse(txtTempMin.Text);
                        producto.Sku = txtSku.Text;
                        producto.StockMinimo = decimal.Parse(txtStockMin.Text);
                        producto.Activo = chkActivo.Checked;

                        bd.SaveChanges();
                        MessageBox.Show("Producto editado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.productoTableAdapter.Fill(this.datosProductos.Producto);
                    }
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtUnidad.Clear();
            txtVida.Clear();
            txtTempMax.Clear();
            txtTempMin.Clear();
            txtSku.Clear();
            txtStockMin.Clear();
            chkActivo.Checked = false;
        }
    }
}
