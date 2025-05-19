using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            panel_agregar.Location = new Point(x, y);

        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            string nuevoUsuario = txt_usuario.Text.Trim();
            string nuevaContraseña = txt_contraseña.Text;

            if (string.IsNullOrEmpty(nuevoUsuario) || string.IsNullOrEmpty(nuevaContraseña))
            {
                MessageBox.Show("Completa todos los campos");
                return;
            }

            Form1 formPrincipal = Application.OpenForms["Form1"] as Form1;

            if (formPrincipal != null)
            {
                var lista = formPrincipal.ObtenerUsuarios();

                // Validar si ya existe
                if (lista.Exists(u => u.Usuario == nuevoUsuario))
                {
                    MessageBox.Show("Ese nombre de usuario ya existe");
                    return;
                }

                lista.Add(new Usuarios(nuevoUsuario, nuevaContraseña, "vendedor"));
                MessageBox.Show("Vendedor agregado correctamente");

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

        //Panel editar y eliminar
        private void btn_editar_Click(object sender, EventArgs e)
        {
            //Seleciionar un vendedor para que sea posible editarlo
            if (listViewVendedores.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecciona un vendedor para editar.");
                return;
            }

            ListViewItem item = listViewVendedores.SelectedItems[0];
            txt_usuarioE.Text = item.SubItems[0].Text;
            txt_contraseñaE.Text = item.SubItems[1].Text;

            panel_editar.Visible = true;
            panel_editar.BringToFront();
            int x = (this.ClientSize.Width - panel_editar.Width) / 2;
            int y = (this.ClientSize.Height - panel_editar.Height) / 2;
            panel_editar.Location = new System.Drawing.Point(x, y);
        }

        private void btn_cerrarE_Click(object sender, EventArgs e)
        {
            panel_editar.Visible = false;
            panel_editar.SendToBack();
        }

        private void btn_editarE_Click(object sender, EventArgs e)
        {
            string nuevoUsuario = txt_usuarioE.Text.Trim();
            string nuevaContraseña = txt_contraseñaE.Text.Trim();

            if (string.IsNullOrEmpty(nuevoUsuario) || string.IsNullOrEmpty(nuevaContraseña))
            {
                MessageBox.Show("Completa todos los campos");
                return;
            }

            var lista = UsuariosDB.ListaUsuarios;
            string usuarioOriginal = listViewVendedores.SelectedItems[0].SubItems[0].Text;

            // Buscar el usuario original
            Usuarios usuario = lista.Find(u => u.Usuario == usuarioOriginal && u.Rol.ToLower() == "vendedor");

            if (usuario != null)
            {
                usuario.Usuario = nuevoUsuario;
                usuario.Contraseña = nuevaContraseña;
                MessageBox.Show("Vendedor editado correctamente");
                CargarVendedores();
                panel_editar.Visible = false;
            }
            else
            {
                MessageBox.Show("No se encontró el vendedor");
            }
        }

        private void btn_EliminarE_Click(object sender, EventArgs e)
        {
            string usuarioAEliminar = listViewVendedores.SelectedItems[0].SubItems[0].Text;

            DialogResult confirm = MessageBox.Show( $"¿Estás seguro de que deseas eliminar al vendedor '{usuarioAEliminar}'?","Confirmar eliminación", MessageBoxButtons.YesNo);

            if (confirm == DialogResult.Yes)
            {
                var lista = UsuariosDB.ListaUsuarios;
                Usuarios usuario = lista.Find(u => u.Usuario == usuarioAEliminar && u.Rol.ToLower() == "vendedor");

                if (usuario != null)
                {
                    lista.Remove(usuario);
                    MessageBox.Show("Vendedor eliminado correctamente");
                    CargarVendedores();
                    panel_editar.Visible = false;
                }
                else
                {
                    MessageBox.Show("No se encontró el vendedor a eliminar");
                }
            }
        }
    }
}


