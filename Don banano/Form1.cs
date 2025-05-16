using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Don_banano
{
    public partial class Form1 : Form
    {
        //Lista para almacenar los nombres
        private List<Usuarios> usuarios = new List<Usuarios>();

        //rol
        private string rolSeleccionado = "Cliente";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {
            // Centrar el panel en el formulario
            int x = (this.ClientSize.Width - panel_registrarse.Width) / 2;
            int y = (this.ClientSize.Height - panel_registrarse.Height) / 2;
            panel_registrarse.Location = new Point(x, y);
            panel_registrarse.Visible = true;
            panel_registrarse.BringToFront();
            panel_registrarse.Location = new Point(x,y); //Ubicar en la mitad de este panel
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

            // Verificar si el nombre de usuario ya existe

            if (usuarios.Exists(u => u.Usuario == usuario))
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

            usuarios.Add(new Usuarios(usuario, contraseña, rolSeleccionado));
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
        private void btn_vendedor_Click(object sender, EventArgs e)
        {
            rolSeleccionado = "Vendedor";
            MessageBox.Show("Rol correctamente seleccionado");
        }
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
        //Clase
        public class Usuarios
        {
            public string Usuario { get; set; }
            public string Contraseña { get; set; }
            public string Rol { get; set; }
            public Usuarios(string usuario, string contraseña, string rol)
            {
                Usuario = usuario;
                Contraseña = contraseña;
                Rol = rol;
            }
        }
    }
}
