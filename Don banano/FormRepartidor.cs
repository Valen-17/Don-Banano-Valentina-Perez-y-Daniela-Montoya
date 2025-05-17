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
    public partial class FormRepartidor : Form
    {
        public FormRepartidor()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            int x = (this.ClientSize.Width - panel1_repartidor.Width) / 2;
            int y = (this.ClientSize.Height - panel1_repartidor.Height) / 2;
            panel1_repartidor.Location = new Point(x, y);
            panel1_repartidor.Visible = true;
            panel1_repartidor.BringToFront();
        }

        private void guna2Button11_Click(object sender, EventArgs e)
        {
            panel1_repartidor.Visible = false;
            panel1_repartidor.SendToBack();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            int x = (this.ClientSize.Width - panel2_completadas.Width) / 2;
            int y = (this.ClientSize.Height - panel2_completadas.Height) / 2;
            panel2_completadas.Location = new Point(x, y);
            panel2_completadas.Visible = true;
            panel2_completadas.BringToFront();
        }

        private void guna2Button10_Click(object sender, EventArgs e)
        {
            panel2_completadas.Visible = false;
            panel2_completadas.SendToBack();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            int x = (this.ClientSize.Width - panel3_actual.Width) / 2;
            int y = (this.ClientSize.Height - panel3_actual.Height) / 2;
            panel3_actual.Location = new Point(x, y);
            panel3_actual.Visible = true;
            panel3_actual.BringToFront();
        }

        private void btn_cerrarR_Click(object sender, EventArgs e)
        {
            panel3_actual.Visible = false;
            panel3_actual.SendToBack();
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();   
            this.Hide();
        }
    }
}
