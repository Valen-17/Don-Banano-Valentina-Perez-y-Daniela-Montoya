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
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
        }

        private void btn_vendedores_Click(object sender, EventArgs e)
        {
            FormAgregarVendedor formAgregar = new FormAgregarVendedor();
            formAgregar.Show();
            this.Hide();
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            Form1 formPrincipal = new Form1();
            formPrincipal.Show();
            this.Hide();
        }
    }
}
