using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Don_banano
{
    public partial class  FormRepartidor : Form
    {
        private List<Pedido> entregasPendientes = new List<Pedido>();
        private Queue<Pedido> colaEntregas = new Queue<Pedido>();

        public FormRepartidor()
        {
            InitializeComponent();
        }

        // ────── Paneles ──────────────────────────────────────────────

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Facturar.ProductosVendidos.Clear();
            panel2_completadas.Visible = true;
            panel2_completadas.BringToFront();
            int x = (this.ClientSize.Width - panel2_completadas.Width) / 2;
            int y = (this.ClientSize.Height - panel2_completadas.Height) / 2;
            panel2_completadas.Location = new Point(x, y);
        }

        private void guna2Button11_Click(object sender, EventArgs e)
        {
            panel1_repartidor.Visible = false;
            panel1_repartidor.SendToBack();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            Facturar.ProductosVendidos.Clear();
            panel1_repartidor.Visible = true;
            panel1_repartidor.BringToFront();
            int x = (this.ClientSize.Width - panel1_repartidor.Width) / 2;
            int y = (this.ClientSize.Height - panel1_repartidor.Height) / 2;
            panel1_repartidor.Location = new Point(x, y);
        }

        private void guna2Button10_Click(object sender, EventArgs e)
        {
            panel2_completadas.Visible = false;
            panel2_completadas.SendToBack();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Facturar.ProductosVendidos.Clear();
            panel3_actual.Visible = true;
            panel3_actual.BringToFront();
            int x = (this.ClientSize.Width - panel3_actual.Width) / 2;
            int y = (this.ClientSize.Height - panel3_actual.Height) / 2;
            panel3_actual.Location = new Point(x, y);
        }

        private void btn_cerrarR_Click(object sender, EventArgs e)
        {
            panel3_actual.Visible = false;
            panel3_actual.SendToBack();
        }

        // ────── Navegación ───────────────────────────────────────────

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        // ────── Mostrar y gestionar entregas ─────────────────────────

        private void MostrarSiguienteEntrega()
        {
            lvEntregaActual.Items.Clear();

            if (colaEntregas.Count > 0)
            {
                Pedido siguiente = colaEntregas.Peek();

                ListViewItem item = new ListViewItem(siguiente.Orden.ToString());
                item.SubItems.Add(siguiente.Cliente);
                item.SubItems.Add(siguiente.Direccion);
                item.SubItems.Add(siguiente.Productos);

                lvEntregaActual.Items.Add(item);
            }
            else
            {
                ListViewItem vacio = new ListViewItem("Sin pedidos pendientes");
                lvEntregaActual.Items.Add(vacio);
            }
        }

        private void btnSiguienteEntrega_Click(object sender, EventArgs e)
        {
            if (colaEntregas.Count > 0)
            {
                colaEntregas.Dequeue();
                MostrarSiguienteEntrega();
            }
        }

        private void btnPedidoEntregado_Click(object sender, EventArgs e)
        {
            if (colaEntregas.Count > 0)
            {
                Pedido entregaFinalizada = colaEntregas.Dequeue();

                ListViewItem fila = new ListViewItem(entregaFinalizada.Orden.ToString());
                fila.SubItems.Add(entregaFinalizada.Cliente);
                fila.SubItems.Add(entregaFinalizada.Direccion);
                fila.SubItems.Add(entregaFinalizada.Productos);

                listViewCompletadas.Items.Add(fila);

                MostrarSiguienteEntrega();
            }
        }

        // ────── Recibir pedidos desde FormCliente ────────────────────

        public void AgregarPedidoAPendientes(Pedido pedido)
        {
            entregasPendientes.Add(pedido);

            // Insertar en ListView de pendientes
            ListViewItem item = new ListViewItem(pedido.Orden.ToString());
            item.SubItems.Add(pedido.Cliente);
            item.SubItems.Add(pedido.Direccion);
            item.SubItems.Add(pedido.Productos);
            item.SubItems.Add(pedido.Sucursal);
            item.SubItems.Add(pedido.HoraCreacion.ToString("HH:mm:ss"));

            listViewPendientes.Items.Add(item);

            // Insertar en cola y ordenar por hora
            entregasPendientes = entregasPendientes.OrderBy(p => p.HoraCreacion).ToList();

            colaEntregas.Clear();
            foreach (var p in entregasPendientes)
            {
                colaEntregas.Enqueue(p);
            }

            MostrarSiguienteEntrega();
        }

        // ────── Acciones de eliminar ─────────────────────────────────

        private void EliminarEntrega_Click(object sender, EventArgs e)
        {
            if (listViewCompletadas.SelectedItems.Count > 0)
            {
                listViewCompletadas.Items.Remove(listViewCompletadas.SelectedItems[0]);
            }
            else
            {
                MessageBox.Show("Selecciona una entrega para eliminar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void EliminarEntrega2_Click(object sender, EventArgs e)
        {
            if (listViewPendientes.SelectedItems.Count > 0)
            {
                listViewPendientes.Items.Remove(listViewPendientes.SelectedItems[0]);
            }
            else
            {
                MessageBox.Show("Selecciona una entrega para eliminar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void CancelarEntrega_Click(object sender, EventArgs e)
        {
            if (lvEntregaActual.SelectedItems.Count > 0)
            {
                lvEntregaActual.Items.Remove(lvEntregaActual.SelectedItems[0]);
            }
            else
            {
                MessageBox.Show("Selecciona una entrega para eliminar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

