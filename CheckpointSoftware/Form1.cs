using System;
using System.CodeDom;
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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            String email = txtUsuario.Text;
            String pass = txtPass.Text;


            using (BDCheckpointEntities bd = new BDCheckpointEntities())
            {
                var query = from u in bd.Usuario
                            where u.Email == email && u.PasswordHash == pass && u.Activo == true
                            select new
                            {
                                idUsuario = u.Id,
                                nombre = u.Nombre

                            };

                if (query.Count() > 0)
                {
                    var resultado = query.FirstOrDefault();
                    MessageBox.Show("Bienvenido " + resultado.nombre + " id" + resultado.idUsuario);
                    AdminForm MenuAdmin = new AdminForm(resultado.nombre);
                    //MenuAdmin.IdUsuario = resultado.idUsuario;
                    MenuAdmin.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrecta", "Datos incorrectos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            

        }
    } 
}