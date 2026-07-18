namespace Actividad4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            growtech = new Label();
            txtCodigo = new TextBox();
            label2 = new Label();
            lblNombreProducto = new Label();
            txtNombre = new TextBox();
            txtMarca = new TextBox();
            lblMarca = new Label();
            lblCategoria = new Label();
            cmbCategoria = new ComboBox();
            lblInformacion = new Label();
            label1 = new Label();
            lblPrecioCompra = new Label();
            lblPrecioVenta = new Label();
            lblStockMinimo = new Label();
            lblStockActual = new Label();
            txtPrecioCompra = new TextBox();
            txtPrecioVenta = new TextBox();
            txtStockMinimo = new TextBox();
            txtStockActual = new TextBox();
            label3 = new Label();
            lblModelo = new Label();
            lblColor = new Label();
            lblAnio = new Label();
            lblProveedor = new Label();
            lblTelefonoProveedor = new Label();
            txtModelo = new TextBox();
            txtColor = new TextBox();
            txtAnio = new TextBox();
            txtProveedor = new TextBox();
            txtTelfProveedor = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label7 = new Label();
            cmbPasillo = new ComboBox();
            cmbEstado = new ComboBox();
            SuspendLayout();
            // 
            // growtech
            // 
            growtech.AutoSize = true;
            growtech.Location = new Point(428, 26);
            growtech.Name = "growtech";
            growtech.Size = new Size(60, 15);
            growtech.TabIndex = 1;
            growtech.Text = "GrowTech";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(150, 109);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(132, 23);
            txtCodigo.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(86, 112);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 3;
            label2.Text = "Codigo:";
            label2.Click += label2_Click;
            // 
            // lblNombreProducto
            // 
            lblNombreProducto.AutoSize = true;
            lblNombreProducto.Location = new Point(29, 141);
            lblNombreProducto.Name = "lblNombreProducto";
            lblNombreProducto.Size = new Size(106, 15);
            lblNombreProducto.TabIndex = 4;
            lblNombreProducto.Text = "Nombre Producto:";
            lblNombreProducto.Click += label3_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(150, 138);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(132, 23);
            txtNombre.TabIndex = 5;
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(150, 167);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(132, 23);
            txtMarca.TabIndex = 6;
            // 
            // lblMarca
            // 
            lblMarca.AutoSize = true;
            lblMarca.Location = new Point(92, 170);
            lblMarca.Name = "lblMarca";
            lblMarca.Size = new Size(43, 15);
            lblMarca.TabIndex = 7;
            lblMarca.Text = "Marca:";
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Location = new Point(74, 199);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(61, 15);
            lblCategoria.TabIndex = 8;
            lblCategoria.Text = "Categoría:";
            // 
            // cmbCategoria
            // 
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Items.AddRange(new object[] { "Tv", "Celular", "Laptop", "Impresora", "Accesorios" });
            cmbCategoria.Location = new Point(150, 196);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(132, 23);
            cmbCategoria.TabIndex = 9;
            // 
            // lblInformacion
            // 
            lblInformacion.AutoSize = true;
            lblInformacion.Location = new Point(114, 73);
            lblInformacion.Name = "lblInformacion";
            lblInformacion.Size = new Size(108, 15);
            lblInformacion.TabIndex = 10;
            lblInformacion.Text = "Información Básica";
            lblInformacion.Click += label1_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(111, 266);
            label1.Name = "label1";
            label1.Size = new Size(86, 15);
            label1.TabIndex = 11;
            label1.Text = "Precios y Stock";
            // 
            // lblPrecioCompra
            // 
            lblPrecioCompra.AutoSize = true;
            lblPrecioCompra.Location = new Point(41, 305);
            lblPrecioCompra.Name = "lblPrecioCompra";
            lblPrecioCompra.Size = new Size(103, 15);
            lblPrecioCompra.TabIndex = 12;
            lblPrecioCompra.Text = "Precio de compra:";
            // 
            // lblPrecioVenta
            // 
            lblPrecioVenta.AutoSize = true;
            lblPrecioVenta.Location = new Point(53, 334);
            lblPrecioVenta.Name = "lblPrecioVenta";
            lblPrecioVenta.Size = new Size(91, 15);
            lblPrecioVenta.TabIndex = 13;
            lblPrecioVenta.Text = "Precio de venta:";
            // 
            // lblStockMinimo
            // 
            lblStockMinimo.AutoSize = true;
            lblStockMinimo.Location = new Point(60, 363);
            lblStockMinimo.Name = "lblStockMinimo";
            lblStockMinimo.Size = new Size(84, 15);
            lblStockMinimo.TabIndex = 14;
            lblStockMinimo.Text = "Stock mínimo:";
            // 
            // lblStockActual
            // 
            lblStockActual.AutoSize = true;
            lblStockActual.Location = new Point(69, 392);
            lblStockActual.Name = "lblStockActual";
            lblStockActual.Size = new Size(74, 15);
            lblStockActual.TabIndex = 15;
            lblStockActual.Text = "Stock actual:";
            // 
            // txtPrecioCompra
            // 
            txtPrecioCompra.Location = new Point(161, 297);
            txtPrecioCompra.Name = "txtPrecioCompra";
            txtPrecioCompra.Size = new Size(121, 23);
            txtPrecioCompra.TabIndex = 16;
            // 
            // txtPrecioVenta
            // 
            txtPrecioVenta.Location = new Point(161, 331);
            txtPrecioVenta.Name = "txtPrecioVenta";
            txtPrecioVenta.Size = new Size(121, 23);
            txtPrecioVenta.TabIndex = 17;
            // 
            // txtStockMinimo
            // 
            txtStockMinimo.Location = new Point(161, 360);
            txtStockMinimo.Name = "txtStockMinimo";
            txtStockMinimo.Size = new Size(121, 23);
            txtStockMinimo.TabIndex = 18;
            // 
            // txtStockActual
            // 
            txtStockActual.Location = new Point(161, 389);
            txtStockActual.Name = "txtStockActual";
            txtStockActual.Size = new Size(121, 23);
            txtStockActual.TabIndex = 19;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(475, 73);
            label3.Name = "label3";
            label3.Size = new Size(114, 15);
            label3.TabIndex = 20;
            label3.Text = "Detalles y Proveedor";
            // 
            // lblModelo
            // 
            lblModelo.AutoSize = true;
            lblModelo.Location = new Point(451, 112);
            lblModelo.Name = "lblModelo";
            lblModelo.Size = new Size(51, 15);
            lblModelo.TabIndex = 21;
            lblModelo.Text = "Modelo:";
            // 
            // lblColor
            // 
            lblColor.AutoSize = true;
            lblColor.Location = new Point(463, 141);
            lblColor.Name = "lblColor";
            lblColor.Size = new Size(39, 15);
            lblColor.TabIndex = 23;
            lblColor.Text = "Color:";
            // 
            // lblAnio
            // 
            lblAnio.AutoSize = true;
            lblAnio.Location = new Point(386, 170);
            lblAnio.Name = "lblAnio";
            lblAnio.Size = new Size(116, 15);
            lblAnio.TabIndex = 24;
            lblAnio.Text = "Año de lanzamiento:";
            // 
            // lblProveedor
            // 
            lblProveedor.AutoSize = true;
            lblProveedor.Location = new Point(391, 199);
            lblProveedor.Name = "lblProveedor";
            lblProveedor.Size = new Size(111, 15);
            lblProveedor.TabIndex = 25;
            lblProveedor.Text = "Nombre Proveedor:";
            // 
            // lblTelefonoProveedor
            // 
            lblTelefonoProveedor.AutoSize = true;
            lblTelefonoProveedor.Location = new Point(389, 227);
            lblTelefonoProveedor.Name = "lblTelefonoProveedor";
            lblTelefonoProveedor.RightToLeft = RightToLeft.No;
            lblTelefonoProveedor.Size = new Size(113, 15);
            lblTelefonoProveedor.TabIndex = 26;
            lblTelefonoProveedor.Text = "Telefono Proveedor:";
            // 
            // txtModelo
            // 
            txtModelo.Location = new Point(518, 109);
            txtModelo.Name = "txtModelo";
            txtModelo.Size = new Size(100, 23);
            txtModelo.TabIndex = 27;
            // 
            // txtColor
            // 
            txtColor.Location = new Point(518, 139);
            txtColor.Name = "txtColor";
            txtColor.Size = new Size(100, 23);
            txtColor.TabIndex = 28;
            // 
            // txtAnio
            // 
            txtAnio.Location = new Point(518, 167);
            txtAnio.Name = "txtAnio";
            txtAnio.Size = new Size(100, 23);
            txtAnio.TabIndex = 29;
            // 
            // txtProveedor
            // 
            txtProveedor.Location = new Point(518, 195);
            txtProveedor.Name = "txtProveedor";
            txtProveedor.Size = new Size(100, 23);
            txtProveedor.TabIndex = 30;
            // 
            // txtTelfProveedor
            // 
            txtTelfProveedor.Location = new Point(518, 224);
            txtTelfProveedor.Name = "txtTelfProveedor";
            txtTelfProveedor.Size = new Size(100, 23);
            txtTelfProveedor.TabIndex = 31;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(475, 266);
            label4.Name = "label4";
            label4.Size = new Size(107, 15);
            label4.TabIndex = 32;
            label4.Text = "Estado y Ubicacion";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(451, 305);
            label5.Name = "label5";
            label5.Size = new Size(44, 15);
            label5.TabIndex = 33;
            label5.Text = "Pasillo:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(450, 334);
            label7.Name = "label7";
            label7.Size = new Size(45, 15);
            label7.TabIndex = 35;
            label7.Text = "Estado:";
            // 
            // cmbPasillo
            // 
            cmbPasillo.FormattingEnabled = true;
            cmbPasillo.Items.AddRange(new object[] { "A1", "A2", "A3", "B1", "B2", "B3" });
            cmbPasillo.Location = new Point(518, 297);
            cmbPasillo.Name = "cmbPasillo";
            cmbPasillo.Size = new Size(121, 23);
            cmbPasillo.TabIndex = 36;
            // 
            // cmbEstado
            // 
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Items.AddRange(new object[] { "Nuevo", "Usado" });
            cmbEstado.Location = new Point(518, 331);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(121, 23);
            cmbEstado.TabIndex = 37;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(950, 484);
            Controls.Add(cmbEstado);
            Controls.Add(cmbPasillo);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtTelfProveedor);
            Controls.Add(txtProveedor);
            Controls.Add(txtAnio);
            Controls.Add(txtColor);
            Controls.Add(txtModelo);
            Controls.Add(lblTelefonoProveedor);
            Controls.Add(lblProveedor);
            Controls.Add(lblAnio);
            Controls.Add(lblColor);
            Controls.Add(lblModelo);
            Controls.Add(label3);
            Controls.Add(txtStockActual);
            Controls.Add(txtStockMinimo);
            Controls.Add(txtPrecioVenta);
            Controls.Add(txtPrecioCompra);
            Controls.Add(lblStockActual);
            Controls.Add(lblStockMinimo);
            Controls.Add(lblPrecioVenta);
            Controls.Add(lblPrecioCompra);
            Controls.Add(label1);
            Controls.Add(lblInformacion);
            Controls.Add(cmbCategoria);
            Controls.Add(lblCategoria);
            Controls.Add(lblMarca);
            Controls.Add(txtMarca);
            Controls.Add(txtNombre);
            Controls.Add(lblNombreProducto);
            Controls.Add(label2);
            Controls.Add(txtCodigo);
            Controls.Add(growtech);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label growtech;
        private TextBox txtCodigo;
        private Label label2;
        private Label lblNombreProducto;
        private TextBox txtNombre;
        private TextBox txtMarca;
        private Label lblMarca;
        private Label lblCategoria;
        private ComboBox cmbCategoria;
        private Label lblInformacion;
        private Label label1;
        private Label lblPrecioCompra;
        private Label lblPrecioVenta;
        private Label lblStockMinimo;
        private Label lblStockActual;
        private TextBox txtPrecioCompra;
        private TextBox txtPrecioVenta;
        private TextBox txtStockMinimo;
        private TextBox txtStockActual;
        private Label label3;
        private Label lblModelo;
        private Label lblColor;
        private Label lblAnio;
        private Label lblProveedor;
        private Label lblTelefonoProveedor;
        private TextBox txtModelo;
        private TextBox txtColor;
        private TextBox txtAnio;
        private TextBox txtProveedor;
        private TextBox txtTelfProveedor;
        private Label label4;
        private Label label5;
        private Label label7;
        private ComboBox cmbPasillo;
        private ComboBox cmbEstado;
    }
}
