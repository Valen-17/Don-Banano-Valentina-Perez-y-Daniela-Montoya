namespace Don_banano
{
    partial class FormInventario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInventario));
            this.listView_inventario = new System.Windows.Forms.ListView();
            this.Producto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Stock = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Sucursal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Dirección = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btn_Editar = new Guna.UI2.WinForms.Guna2Button();
            this.btn_volver = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Shapes2 = new Guna.UI2.WinForms.Guna2Shapes();
            this.txt_producto = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_sucursal = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_direccion = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_stock = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_cancelar = new Guna.UI2.WinForms.Guna2Button();
            this.btn_guardar = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btn_agregar = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // listView_inventario
            // 
            this.listView_inventario.BackColor = System.Drawing.Color.LemonChiffon;
            this.listView_inventario.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Producto,
            this.Stock,
            this.Sucursal,
            this.Dirección});
            this.listView_inventario.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView_inventario.HideSelection = false;
            this.listView_inventario.Location = new System.Drawing.Point(56, 80);
            this.listView_inventario.Name = "listView_inventario";
            this.listView_inventario.Size = new System.Drawing.Size(534, 479);
            this.listView_inventario.TabIndex = 1;
            this.listView_inventario.UseCompatibleStateImageBehavior = false;
            this.listView_inventario.View = System.Windows.Forms.View.Details;
            // 
            // Producto
            // 
            this.Producto.Text = "Producto";
            this.Producto.Width = 150;
            // 
            // Stock
            // 
            this.Stock.Text = "Stock";
            this.Stock.Width = 80;
            // 
            // Sucursal
            // 
            this.Sucursal.Text = "Sucursal";
            this.Sucursal.Width = 150;
            // 
            // Dirección
            // 
            this.Dirección.Text = "Dirección";
            this.Dirección.Width = 150;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.AutoSize = false;
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(48)))), ((int)(((byte)(1)))));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(56, 3);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(248, 92);
            this.guna2HtmlLabel2.TabIndex = 27;
            this.guna2HtmlLabel2.Text = "Inventario";
            this.guna2HtmlLabel2.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("guna2Panel1.BackgroundImage")));
            this.guna2Panel1.Controls.Add(this.btn_agregar);
            this.guna2Panel1.Controls.Add(this.guna2Panel2);
            this.guna2Panel1.Controls.Add(this.guna2PictureBox1);
            this.guna2Panel1.Controls.Add(this.btn_volver);
            this.guna2Panel1.Controls.Add(this.btn_Editar);
            this.guna2Panel1.Controls.Add(this.listView_inventario);
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel2);
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(754, 632);
            this.guna2Panel1.TabIndex = 28;
            // 
            // btn_Editar
            // 
            this.btn_Editar.BackColor = System.Drawing.Color.Transparent;
            this.btn_Editar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(48)))), ((int)(((byte)(1)))));
            this.btn_Editar.BorderRadius = 15;
            this.btn_Editar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Editar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Editar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Editar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Editar.FillColor = System.Drawing.Color.OliveDrab;
            this.btn_Editar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btn_Editar.ForeColor = System.Drawing.Color.White;
            this.btn_Editar.Location = new System.Drawing.Point(607, 228);
            this.btn_Editar.Name = "btn_Editar";
            this.btn_Editar.Size = new System.Drawing.Size(134, 49);
            this.btn_Editar.TabIndex = 28;
            this.btn_Editar.Text = "Editar";
            this.btn_Editar.UseTransparentBackground = true;
            // 
            // btn_volver
            // 
            this.btn_volver.BackColor = System.Drawing.Color.Transparent;
            this.btn_volver.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(48)))), ((int)(((byte)(1)))));
            this.btn_volver.BorderRadius = 15;
            this.btn_volver.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_volver.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_volver.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_volver.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_volver.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btn_volver.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btn_volver.ForeColor = System.Drawing.Color.White;
            this.btn_volver.Location = new System.Drawing.Point(607, 294);
            this.btn_volver.Name = "btn_volver";
            this.btn_volver.Size = new System.Drawing.Size(134, 49);
            this.btn_volver.TabIndex = 29;
            this.btn_volver.Text = "Volver";
            this.btn_volver.UseTransparentBackground = true;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(596, 477);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(145, 139);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 30;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.UseTransparentBackground = true;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.LemonChiffon;
            this.guna2Panel2.Controls.Add(this.guna2HtmlLabel6);
            this.guna2Panel2.Controls.Add(this.guna2HtmlLabel5);
            this.guna2Panel2.Controls.Add(this.guna2HtmlLabel4);
            this.guna2Panel2.Controls.Add(this.guna2HtmlLabel3);
            this.guna2Panel2.Controls.Add(this.btn_guardar);
            this.guna2Panel2.Controls.Add(this.btn_cancelar);
            this.guna2Panel2.Controls.Add(this.txt_stock);
            this.guna2Panel2.Controls.Add(this.txt_direccion);
            this.guna2Panel2.Controls.Add(this.txt_sucursal);
            this.guna2Panel2.Controls.Add(this.txt_producto);
            this.guna2Panel2.Controls.Add(this.guna2PictureBox2);
            this.guna2Panel2.Controls.Add(this.guna2HtmlLabel1);
            this.guna2Panel2.Controls.Add(this.guna2Shapes2);
            this.guna2Panel2.Location = new System.Drawing.Point(730, 97);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(730, 610);
            this.guna2Panel2.TabIndex = 31;
            this.guna2Panel2.Visible = false;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.AutoSize = false;
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(49)))));
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(48)))), ((int)(((byte)(1)))));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(239, 30);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(344, 92);
            this.guna2HtmlLabel1.TabIndex = 27;
            this.guna2HtmlLabel1.Text = "Actualizar inventario";
            this.guna2HtmlLabel1.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox2.Image")));
            this.guna2PictureBox2.ImageRotate = 0F;
            this.guna2PictureBox2.Location = new System.Drawing.Point(97, 14);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.Size = new System.Drawing.Size(136, 119);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox2.TabIndex = 28;
            this.guna2PictureBox2.TabStop = false;
            this.guna2PictureBox2.UseTransparentBackground = true;
            // 
            // guna2Shapes2
            // 
            this.guna2Shapes2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(43)))), ((int)(((byte)(1)))));
            this.guna2Shapes2.BorderThickness = 3;
            this.guna2Shapes2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(49)))));
            this.guna2Shapes2.Location = new System.Drawing.Point(5, 5);
            this.guna2Shapes2.Name = "guna2Shapes2";
            this.guna2Shapes2.PolygonSkip = 1;
            this.guna2Shapes2.Rotate = 0F;
            this.guna2Shapes2.Shape = Guna.UI2.WinForms.Enums.ShapeType.Rectangle;
            this.guna2Shapes2.Size = new System.Drawing.Size(722, 141);
            this.guna2Shapes2.TabIndex = 29;
            this.guna2Shapes2.Text = "guna2Shapes2";
            this.guna2Shapes2.Zoom = 100;
            // 
            // txt_producto
            // 
            this.txt_producto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_producto.DefaultText = "";
            this.txt_producto.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_producto.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_producto.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_producto.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_producto.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_producto.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_producto.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_producto.Location = new System.Drawing.Point(58, 217);
            this.txt_producto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_producto.Name = "txt_producto";
            this.txt_producto.PlaceholderText = "";
            this.txt_producto.SelectedText = "";
            this.txt_producto.Size = new System.Drawing.Size(288, 48);
            this.txt_producto.TabIndex = 30;
            // 
            // txt_sucursal
            // 
            this.txt_sucursal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_sucursal.DefaultText = "";
            this.txt_sucursal.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_sucursal.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_sucursal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_sucursal.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_sucursal.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_sucursal.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_sucursal.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_sucursal.Location = new System.Drawing.Point(58, 317);
            this.txt_sucursal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_sucursal.Name = "txt_sucursal";
            this.txt_sucursal.PlaceholderText = "";
            this.txt_sucursal.SelectedText = "";
            this.txt_sucursal.Size = new System.Drawing.Size(288, 48);
            this.txt_sucursal.TabIndex = 31;
            // 
            // txt_direccion
            // 
            this.txt_direccion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_direccion.DefaultText = "";
            this.txt_direccion.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_direccion.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_direccion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_direccion.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_direccion.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_direccion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_direccion.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_direccion.Location = new System.Drawing.Point(58, 415);
            this.txt_direccion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.PlaceholderText = "";
            this.txt_direccion.SelectedText = "";
            this.txt_direccion.Size = new System.Drawing.Size(288, 48);
            this.txt_direccion.TabIndex = 32;
            // 
            // txt_stock
            // 
            this.txt_stock.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_stock.DefaultText = "";
            this.txt_stock.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_stock.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_stock.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_stock.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_stock.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_stock.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_stock.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_stock.Location = new System.Drawing.Point(389, 217);
            this.txt_stock.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_stock.Name = "txt_stock";
            this.txt_stock.PlaceholderText = "";
            this.txt_stock.SelectedText = "";
            this.txt_stock.Size = new System.Drawing.Size(288, 48);
            this.txt_stock.TabIndex = 33;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.Color.Transparent;
            this.btn_cancelar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(43)))), ((int)(((byte)(0)))));
            this.btn_cancelar.BorderRadius = 20;
            this.btn_cancelar.BorderThickness = 2;
            this.btn_cancelar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_cancelar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_cancelar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_cancelar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_cancelar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.btn_cancelar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_cancelar.Location = new System.Drawing.Point(399, 510);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(258, 53);
            this.btn_cancelar.TabIndex = 34;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseTransparentBackground = true;
            // 
            // btn_guardar
            // 
            this.btn_guardar.BackColor = System.Drawing.Color.Transparent;
            this.btn_guardar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(43)))), ((int)(((byte)(0)))));
            this.btn_guardar.BorderRadius = 20;
            this.btn_guardar.BorderThickness = 2;
            this.btn_guardar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_guardar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_guardar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_guardar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_guardar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(194)))), ((int)(((byte)(3)))));
            this.btn_guardar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btn_guardar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(43)))), ((int)(((byte)(0)))));
            this.btn_guardar.Location = new System.Drawing.Point(88, 510);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(258, 53);
            this.btn_guardar.TabIndex = 35;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseTransparentBackground = true;
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.AutoSize = false;
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(48)))), ((int)(((byte)(1)))));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(58, 182);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(278, 38);
            this.guna2HtmlLabel3.TabIndex = 36;
            this.guna2HtmlLabel3.Text = "Producto";
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.AutoSize = false;
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(48)))), ((int)(((byte)(1)))));
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(58, 281);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(278, 38);
            this.guna2HtmlLabel4.TabIndex = 37;
            this.guna2HtmlLabel4.Text = "Sucursal";
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.AutoSize = false;
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(48)))), ((int)(((byte)(1)))));
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(58, 381);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(278, 38);
            this.guna2HtmlLabel5.TabIndex = 38;
            this.guna2HtmlLabel5.Text = "Dirección";
            // 
            // guna2HtmlLabel6
            // 
            this.guna2HtmlLabel6.AutoSize = false;
            this.guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(48)))), ((int)(((byte)(1)))));
            this.guna2HtmlLabel6.Location = new System.Drawing.Point(389, 182);
            this.guna2HtmlLabel6.Name = "guna2HtmlLabel6";
            this.guna2HtmlLabel6.Size = new System.Drawing.Size(278, 38);
            this.guna2HtmlLabel6.TabIndex = 39;
            this.guna2HtmlLabel6.Text = "Stock";
            // 
            // btn_agregar
            // 
            this.btn_agregar.BackColor = System.Drawing.Color.Transparent;
            this.btn_agregar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(48)))), ((int)(((byte)(1)))));
            this.btn_agregar.BorderRadius = 15;
            this.btn_agregar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_agregar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_agregar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_agregar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_agregar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(77)))), ((int)(((byte)(100)))));
            this.btn_agregar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btn_agregar.ForeColor = System.Drawing.Color.White;
            this.btn_agregar.Location = new System.Drawing.Point(607, 163);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(134, 49);
            this.btn_agregar.TabIndex = 32;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseTransparentBackground = true;
            // 
            // FormInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 628);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "FormInventario";
            this.Text = "FormInventario";
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.guna2Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView_inventario;
        private System.Windows.Forms.ColumnHeader Producto;
        private System.Windows.Forms.ColumnHeader Stock;
        private System.Windows.Forms.ColumnHeader Sucursal;
        private System.Windows.Forms.ColumnHeader Dirección;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button btn_volver;
        private Guna.UI2.WinForms.Guna2Button btn_Editar;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Shapes guna2Shapes2;
        private Guna.UI2.WinForms.Guna2TextBox txt_stock;
        private Guna.UI2.WinForms.Guna2TextBox txt_direccion;
        private Guna.UI2.WinForms.Guna2TextBox txt_sucursal;
        private Guna.UI2.WinForms.Guna2TextBox txt_producto;
        private Guna.UI2.WinForms.Guna2Button btn_cancelar;
        private Guna.UI2.WinForms.Guna2Button btn_guardar;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel6;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2Button btn_agregar;
    }
}