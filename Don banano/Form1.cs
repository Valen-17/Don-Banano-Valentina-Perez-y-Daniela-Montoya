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
    public partial class Form1 : Form
    {

        //rol
        private string rolSeleccionado;

        public Form1()
        {
            InitializeComponent();
        }

        //Cargar datos de la listView del usuario Vendedor

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!UsuariosDB.ListaUsuarios.Exists(u => u.Usuario == "admin"))
            {
                UsuariosDB.ListaUsuarios.Add(new Usuarios("admin", "admin123", "Admin"));
            }
        }
        public List<Usuarios> ObtenerUsuarios()
        {
            return UsuariosDB.ListaUsuarios;
        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {
            // Centrar el panel en el formulario
            int x = (this.ClientSize.Width - panel_registrarse.Width) / 2;
            int y = (this.ClientSize.Height - panel_registrarse.Height) / 2;
            panel_registrarse.Location = new Point(x, y);
            panel_registrarse.Visible = true;
            panel_registrarse.BringToFront();
        }

        //Panel Registrarse
        private void btn_cerrarR_Click(object sender, EventArgs e)
        {
            panel_registrarse.Visible = false;
            panel_registrarse.SendToBack();
        }
        private void txt_password_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < txt_password.Text.Length; i++)
            {
                if (txt_password.Text[i] == ' ')
                {
                    MessageBox.Show("La contraseña no puede contener espacios.");
                    txt_password.Text = txt_password.Text.Remove(i, 1);
                    i--;
                }
            }
        }
        private void btn_register_Click(object sender, EventArgs e)
        {
            string usuario = txt_user.Text.Trim();
            string contraseña = txt_password.Text;
            string confirmar = txt_confirmar.Text;

            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(contraseña) || string.IsNullOrEmpty(confirmar))
            {
                MessageBox.Show("Por favor, completa todos los campos.");
                return;
            }
            if (string.IsNullOrEmpty(rolSeleccionado))
            {
                MessageBox.Show("Por favor, selecciona un rol antes de registrarte.");
                return;
            }

            // Verificar si el nombre de usuario ya existe

            if (UsuariosDB.ListaUsuarios.Exists(u => u.Usuario == usuario))
            {
                MessageBox.Show("Este nombre de usuario ya está en uso. Intenta con otro.");
                return;
            }

            //Contraseña
            if (contraseña != confirmar)
            {
                MessageBox.Show("Las contraseñas no coinciden, intentalo nuevamente.");
                return;
            }

            if (contraseña.Length < 8)
            {
                MessageBox.Show("La contraseña debe tener al menos 8 caracteres.");
                return;
            }

            UsuariosDB.ListaUsuarios.Add(new Usuarios(usuario, contraseña, rolSeleccionado));
            MessageBox.Show("Usuario registrado correctamente.");
            MessageBox.Show("Usuario: " + usuario + "\nContraseña: " + contraseña + "\nRol: " + rolSeleccionado);

            // Limpiar los campos
            txt_user.Clear();
            txt_password.Clear();
            txt_confirmar.Clear();
            panel_registrarse.Visible = false;
            panel_registrarse.SendToBack();

        }
        //Selección de los roles
        private void btn_cliente_Click(object sender, EventArgs e)
        {
            rolSeleccionado = "Cliente";
            MessageBox.Show("Rol correctamente seleccionado");
        }
        private void btn_repartidor_Click(object sender, EventArgs e)
        {
            rolSeleccionado = "Repartidor";
            MessageBox.Show("Rol correctamente seleccionado");
        }

        //Panel Iniciar Sesión
        private void btn_cerrarI_Click(object sender, EventArgs e)
        {
            panel_iniciar.Visible = false;
            panel_iniciar.SendToBack();
        }
        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            int x = (this.ClientSize.Width - panel_registrarse.Width) / 2;
            int y = (this.ClientSize.Height - panel_registrarse.Height) / 2;
            panel_iniciar.Location = new Point(x, y);
            panel_iniciar.Visible = true;
            panel_iniciar.BringToFront();
            panel_iniciar.Location = new Point(x, y);
        }
        private void btn_login_Click(object sender, EventArgs e)
        {
            string usuario = txt_usuario.Text.Trim();
            string contraseña = txt_contraseña.Text.Trim();

            if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(contraseña))
            {
                MessageBox.Show("Por favor, completa todos los campos.");
                return;
            }

            Usuarios usuarioEncontrado = UsuariosDB.ListaUsuarios.Find(u => u.Usuario == usuario && u.Contraseña == contraseña);
            FormRepartidor formRepartidor1 = new FormRepartidor();
            FormVendedor formVendedor1 = new FormVendedor(formRepartidor1);

            if (usuarioEncontrado != null)
            {
                switch (usuarioEncontrado.Rol)
                {
                    case "Cliente":
                        FormCliente formCliente = new FormCliente(formRepartidor1);
                        formCliente.Show();
                        this.Hide();
                        break;
                    case "Repartidor":
                        FormRepartidor formRepartidor = new FormRepartidor();
                        formRepartidor.Show();
                        this.Hide();
                        break;
                    case "Admin":
                        FormAdmin formAdmin = new FormAdmin();
                        formAdmin.Show();
                        this.Hide();
                        break;
                    case "vendedor": 
                        MessageBox.Show("Bienvenido vendedor: " + usuarioEncontrado.Usuario);
                        FormVendedor formVendedor = new FormVendedor(formRepartidor1);
                        formVendedor.Show();
                        this.Hide();
                        break;
                    default:
                        MessageBox.Show("Usuario no encontrado.");
                        break;
                }
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.");
            }
        }
    }
}
