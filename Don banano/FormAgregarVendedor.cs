using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static Don_banano.Form1;
using Don_banano;


namespace Don_banano
{
    public partial class FormAgregarVendedor : Form
    {
        public FormAgregarVendedor()
        {
            InitializeComponent();
            CargarVendedores();
        }
 
        private void CargarVendedores()
        {
            listViewVendedores.Items.Clear();

            Form1 formPrincipal = Application.OpenForms["Form1"] as Form1;
            if (formPrincipal != null)
            {
                foreach (var user in formPrincipal.ObtenerUsuarios())
                {
                    if (user.Rol.ToLower() == "vendedor")
                    {
                        ListViewItem item = new ListViewItem(user.Usuario);
                        item.SubItems.Add(user.Contraseña);
                        item.SubItems.Add(user.Rol);
                        listViewVendedores.Items.Add(item);
                    }
                }
            }
        }

        //Panel agregar
        private void btn_cerrarA_Click(object sender, EventArgs e)
        {
            panel_agregar.Visible = false;
            panel_agregar.SendToBack();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            int x = (this.ClientSize.Width - panel_agregar.Width) / 2;
            int y = (this.ClientSize.Height - panel_agregar.Height) / 2;
            panel_agregar.Visible = true;
            panel_agregar.BringToFront();
            panel_agregar.Location = new System.Drawing.Point(x, y);

        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            string nuevoUsuario = txt_usuario.Text.Trim();
            string nuevaContraseña = txt_contraseña.Text;

            if (string.IsNullOrEmpty(nuevoUsuario) || string.IsNullOrEmpty(nuevaContraseña))
            {
                MessageBox.Show("Completa todos los campos.");
                return;
            }

            Form1 formPrincipal = Application.OpenForms["Form1"] as Form1;

            if (formPrincipal != null)
            {
                var lista = formPrincipal.ObtenerUsuarios();

                // Validar si ya existe
                if (lista.Exists(u => u.Usuario == nuevoUsuario))
                {
                    MessageBox.Show("Ese nombre de usuario ya existe.");
                    return;
                }

                lista.Add(new Usuarios(nuevoUsuario, nuevaContraseña, "vendedor"));
                MessageBox.Show("Vendedor agregado correctamente.");

                txt_usuario.Clear();
                txt_contraseña.Clear();

                CargarVendedores();
            }
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            FormAdmin formAdmin = new FormAdmin();
            formAdmin.Show();
            this.Hide();
        }
    }
}


