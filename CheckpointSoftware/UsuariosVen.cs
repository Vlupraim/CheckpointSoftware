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
    public partial class UsuariosVen : Form
    {
        public UsuariosVen()
        {
            InitializeComponent();
        }

        private void UsuariosVen_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'datosUsuarios.Usuario' Puede moverla o quitarla según sea necesario.
            this.usuarioTableAdapter.Fill(this.datosUsuarios.Usuario);
            dataGridView1.DataSource = datosUsuarios.Usuario;
        }
    
        private void btnAgregarUser_Click(object sender, EventArgs e)
        {
            using (BDCheckpointEntities bd = new BDCheckpointEntities())
            {
                Usuario nuevoUsuario = new Usuario
                {
                    Nombre = txtUsuario.Text,
                    Email = txtEmail.Text,
                    PasswordHash = txtClave.Text,
                    Activo = cbxActivo.Checked
                };

                bd.Usuario.Add(nuevoUsuario);
                bd.SaveChanges();
                MessageBox.Show("Usuario agregado correctamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.usuarioTableAdapter.Fill(this.datosUsuarios.Usuario);
            }
        }

    }
}
