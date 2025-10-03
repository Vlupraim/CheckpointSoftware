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
    }
}
