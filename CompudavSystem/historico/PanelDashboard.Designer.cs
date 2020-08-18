namespace CompudavSystem.historico
{
    partial class PanelDashboard
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
            this.rangoFechaLabel = new System.Windows.Forms.Label();
            this.rangoFechaComboBox = new System.Windows.Forms.ComboBox();
            this.fromDateLabel = new System.Windows.Forms.Label();
            this.fromDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.toDateLabel = new System.Windows.Forms.Label();
            this.toDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.totalVentasPanel = new System.Windows.Forms.Panel();
            this.totalFacturasTextBox = new System.Windows.Forms.TextBox();
            this.totalVentasTextBox = new System.Windows.Forms.TextBox();
            this.totalVentasLabel = new System.Windows.Forms.Label();
            this.encabezadoPanel = new System.Windows.Forms.Panel();
            this.fechaActualTextBox = new System.Windows.Forms.TextBox();
            this.tituloPictureBox = new System.Windows.Forms.PictureBox();
            this.tituloLabel = new System.Windows.Forms.Label();
            this.topProductosPanel = new System.Windows.Forms.Panel();
            this.listadoDataGridView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.stockPanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.busquedaLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.busquedaTextBox = new System.Windows.Forms.TextBox();
            this.stockDataGridView = new System.Windows.Forms.DataGridView();
            this.stockLabel = new System.Windows.Forms.Label();
            this.facturasImpresasTextBox = new System.Windows.Forms.TextBox();
            this.facturasGuardadasTextBox = new System.Windows.Forms.TextBox();
            this.totalVentasPanel.SuspendLayout();
            this.encabezadoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tituloPictureBox)).BeginInit();
            this.topProductosPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listadoDataGridView)).BeginInit();
            this.stockPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stockDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // rangoFechaLabel
            // 
            this.rangoFechaLabel.AutoSize = true;
            this.rangoFechaLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(79)))), ((int)(((byte)(110)))));
            this.rangoFechaLabel.Location = new System.Drawing.Point(20, 102);
            this.rangoFechaLabel.Name = "rangoFechaLabel";
            this.rangoFechaLabel.Size = new System.Drawing.Size(40, 15);
            this.rangoFechaLabel.TabIndex = 26;
            this.rangoFechaLabel.Text = "Rango";
            // 
            // rangoFechaComboBox
            // 
            this.rangoFechaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rangoFechaComboBox.FormattingEnabled = true;
            this.rangoFechaComboBox.Items.AddRange(new object[] {
            "Hoy",
            "Ayer",
            "Este mes",
            "Mes anterior",
            "Últimos 30 días",
            "Último trimestre",
            "Último semestre",
            "Este año",
            "Año anterior",
            "Seleccionar rango"});
            this.rangoFechaComboBox.Location = new System.Drawing.Point(63, 97);
            this.rangoFechaComboBox.Name = "rangoFechaComboBox";
            this.rangoFechaComboBox.Size = new System.Drawing.Size(180, 23);
            this.rangoFechaComboBox.TabIndex = 25;
            this.rangoFechaComboBox.SelectedIndexChanged += new System.EventHandler(this.RangoFechaComboBox_SelectedIndexChanged);
            // 
            // fromDateLabel
            // 
            this.fromDateLabel.AutoSize = true;
            this.fromDateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(79)))), ((int)(((byte)(110)))));
            this.fromDateLabel.Location = new System.Drawing.Point(507, 102);
            this.fromDateLabel.Name = "fromDateLabel";
            this.fromDateLabel.Size = new System.Drawing.Size(36, 15);
            this.fromDateLabel.TabIndex = 24;
            this.fromDateLabel.Text = "Hasta";
            // 
            // fromDateTimePicker
            // 
            this.fromDateTimePicker.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(79)))), ((int)(((byte)(110)))));
            this.fromDateTimePicker.Location = new System.Drawing.Point(546, 98);
            this.fromDateTimePicker.Name = "fromDateTimePicker";
            this.fromDateTimePicker.Size = new System.Drawing.Size(210, 22);
            this.fromDateTimePicker.TabIndex = 23;
            this.fromDateTimePicker.ValueChanged += new System.EventHandler(this.FromDateTimePicker_ValueChanged);
            // 
            // toDateLabel
            // 
            this.toDateLabel.AutoSize = true;
            this.toDateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(79)))), ((int)(((byte)(110)))));
            this.toDateLabel.Location = new System.Drawing.Point(249, 102);
            this.toDateLabel.Name = "toDateLabel";
            this.toDateLabel.Size = new System.Drawing.Size(39, 15);
            this.toDateLabel.TabIndex = 22;
            this.toDateLabel.Text = "Desde";
            // 
            // toDateTimePicker
            // 
            this.toDateTimePicker.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(79)))), ((int)(((byte)(110)))));
            this.toDateTimePicker.Location = new System.Drawing.Point(291, 98);
            this.toDateTimePicker.Name = "toDateTimePicker";
            this.toDateTimePicker.Size = new System.Drawing.Size(210, 22);
            this.toDateTimePicker.TabIndex = 21;
            this.toDateTimePicker.ValueChanged += new System.EventHandler(this.ToDateTimePicker_ValueChanged);
            // 
            // totalVentasPanel
            // 
            this.totalVentasPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(115)))), ((int)(((byte)(119)))));
            this.totalVentasPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.totalVentasPanel.Controls.Add(this.totalFacturasTextBox);
            this.totalVentasPanel.Controls.Add(this.totalVentasTextBox);
            this.totalVentasPanel.Controls.Add(this.totalVentasLabel);
            this.totalVentasPanel.Location = new System.Drawing.Point(13, 153);
            this.totalVentasPanel.Name = "totalVentasPanel";
            this.totalVentasPanel.Size = new System.Drawing.Size(250, 250);
            this.totalVentasPanel.TabIndex = 27;
            // 
            // totalFacturasTextBox
            // 
            this.totalFacturasTextBox.BackColor = System.Drawing.Color.White;
            this.totalFacturasTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.totalFacturasTextBox.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalFacturasTextBox.ForeColor = System.Drawing.Color.Black;
            this.totalFacturasTextBox.Location = new System.Drawing.Point(0, 228);
            this.totalFacturasTextBox.Name = "totalFacturasTextBox";
            this.totalFacturasTextBox.Size = new System.Drawing.Size(250, 22);
            this.totalFacturasTextBox.TabIndex = 30;
            this.totalFacturasTextBox.Text = "Total Facturas : 00";
            this.totalFacturasTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // totalVentasTextBox
            // 
            this.totalVentasTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(115)))), ((int)(((byte)(119)))));
            this.totalVentasTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.totalVentasTextBox.Font = new System.Drawing.Font("Open Sans SemiBold", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalVentasTextBox.ForeColor = System.Drawing.Color.White;
            this.totalVentasTextBox.Location = new System.Drawing.Point(15, 100);
            this.totalVentasTextBox.Name = "totalVentasTextBox";
            this.totalVentasTextBox.Size = new System.Drawing.Size(220, 55);
            this.totalVentasTextBox.TabIndex = 29;
            this.totalVentasTextBox.Text = "$0.00";
            this.totalVentasTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // totalVentasLabel
            // 
            this.totalVentasLabel.AutoSize = true;
            this.totalVentasLabel.BackColor = System.Drawing.Color.White;
            this.totalVentasLabel.Font = new System.Drawing.Font("Open Sans SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalVentasLabel.Location = new System.Drawing.Point(0, 0);
            this.totalVentasLabel.Name = "totalVentasLabel";
            this.totalVentasLabel.Padding = new System.Windows.Forms.Padding(20, 10, 104, 10);
            this.totalVentasLabel.Size = new System.Drawing.Size(250, 42);
            this.totalVentasLabel.TabIndex = 28;
            this.totalVentasLabel.Text = "Total en ventas";
            // 
            // encabezadoPanel
            // 
            this.encabezadoPanel.BackColor = System.Drawing.Color.White;
            this.encabezadoPanel.Controls.Add(this.fechaActualTextBox);
            this.encabezadoPanel.Controls.Add(this.tituloPictureBox);
            this.encabezadoPanel.Controls.Add(this.tituloLabel);
            this.encabezadoPanel.Controls.Add(this.rangoFechaLabel);
            this.encabezadoPanel.Controls.Add(this.rangoFechaComboBox);
            this.encabezadoPanel.Controls.Add(this.toDateTimePicker);
            this.encabezadoPanel.Controls.Add(this.fromDateLabel);
            this.encabezadoPanel.Controls.Add(this.toDateLabel);
            this.encabezadoPanel.Controls.Add(this.fromDateTimePicker);
            this.encabezadoPanel.Location = new System.Drawing.Point(0, 0);
            this.encabezadoPanel.Name = "encabezadoPanel";
            this.encabezadoPanel.Size = new System.Drawing.Size(780, 132);
            this.encabezadoPanel.TabIndex = 28;
            // 
            // fechaActualTextBox
            // 
            this.fechaActualTextBox.BackColor = System.Drawing.Color.White;
            this.fechaActualTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.fechaActualTextBox.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaActualTextBox.ForeColor = System.Drawing.Color.Black;
            this.fechaActualTextBox.Location = new System.Drawing.Point(30, 38);
            this.fechaActualTextBox.Name = "fechaActualTextBox";
            this.fechaActualTextBox.ReadOnly = true;
            this.fechaActualTextBox.Size = new System.Drawing.Size(30, 22);
            this.fechaActualTextBox.TabIndex = 31;
            this.fechaActualTextBox.Text = "00";
            this.fechaActualTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tituloPictureBox
            // 
            this.tituloPictureBox.Image = global::CompudavSystem.Properties.Resources.calendar_64px;
            this.tituloPictureBox.Location = new System.Drawing.Point(13, 12);
            this.tituloPictureBox.Name = "tituloPictureBox";
            this.tituloPictureBox.Size = new System.Drawing.Size(64, 64);
            this.tituloPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.tituloPictureBox.TabIndex = 1;
            this.tituloPictureBox.TabStop = false;
            // 
            // tituloLabel
            // 
            this.tituloLabel.AutoSize = true;
            this.tituloLabel.Font = new System.Drawing.Font("Roboto Medium", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(79)))), ((int)(((byte)(110)))));
            this.tituloLabel.Location = new System.Drawing.Point(83, 32);
            this.tituloLabel.Name = "tituloLabel";
            this.tituloLabel.Size = new System.Drawing.Size(47, 17);
            this.tituloLabel.TabIndex = 4;
            this.tituloLabel.Text = "Hola!";
            // 
            // topProductosPanel
            // 
            this.topProductosPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.topProductosPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.topProductosPanel.Controls.Add(this.listadoDataGridView);
            this.topProductosPanel.Controls.Add(this.label2);
            this.topProductosPanel.Location = new System.Drawing.Point(269, 153);
            this.topProductosPanel.Name = "topProductosPanel";
            this.topProductosPanel.Size = new System.Drawing.Size(499, 225);
            this.topProductosPanel.TabIndex = 29;
            // 
            // listadoDataGridView
            // 
            this.listadoDataGridView.AllowUserToAddRows = false;
            this.listadoDataGridView.AllowUserToDeleteRows = false;
            this.listadoDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.listadoDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listadoDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.listadoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listadoDataGridView.ColumnHeadersVisible = false;
            this.listadoDataGridView.Location = new System.Drawing.Point(0, 45);
            this.listadoDataGridView.Name = "listadoDataGridView";
            this.listadoDataGridView.ReadOnly = true;
            this.listadoDataGridView.RowHeadersVisible = false;
            this.listadoDataGridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listadoDataGridView.RowTemplate.Height = 35;
            this.listadoDataGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.listadoDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listadoDataGridView.Size = new System.Drawing.Size(499, 175);
            this.listadoDataGridView.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Open Sans SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(20, 10, 316, 10);
            this.label2.Size = new System.Drawing.Size(499, 42);
            this.label2.TabIndex = 28;
            this.label2.Text = "Items más vendidos";
            // 
            // stockPanel
            // 
            this.stockPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.stockPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.stockPanel.Controls.Add(this.label3);
            this.stockPanel.Controls.Add(this.label1);
            this.stockPanel.Controls.Add(this.panel3);
            this.stockPanel.Controls.Add(this.busquedaLabel);
            this.stockPanel.Controls.Add(this.panel1);
            this.stockPanel.Controls.Add(this.panel2);
            this.stockPanel.Controls.Add(this.busquedaTextBox);
            this.stockPanel.Controls.Add(this.stockDataGridView);
            this.stockPanel.Controls.Add(this.stockLabel);
            this.stockPanel.Location = new System.Drawing.Point(269, 384);
            this.stockPanel.Name = "stockPanel";
            this.stockPanel.Size = new System.Drawing.Size(499, 244);
            this.stockPanel.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(146, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 15);
            this.label3.TabIndex = 32;
            this.label3.Text = "Agotado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(89, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 32;
            this.label1.Text = "Alerta";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(201)))), ((int)(((byte)(203)))));
            this.panel3.Location = new System.Drawing.Point(132, 230);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 10);
            this.panel3.TabIndex = 33;
            // 
            // busquedaLabel
            // 
            this.busquedaLabel.AutoSize = true;
            this.busquedaLabel.ForeColor = System.Drawing.Color.White;
            this.busquedaLabel.Location = new System.Drawing.Point(24, 227);
            this.busquedaLabel.Name = "busquedaLabel";
            this.busquedaLabel.Size = new System.Drawing.Size(45, 15);
            this.busquedaLabel.TabIndex = 31;
            this.busquedaLabel.Text = "Normal";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(172)))), ((int)(((byte)(250)))), ((int)(((byte)(193)))));
            this.panel1.Location = new System.Drawing.Point(10, 230);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 10);
            this.panel1.TabIndex = 31;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(251)))), ((int)(((byte)(193)))));
            this.panel2.Location = new System.Drawing.Point(75, 230);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 10);
            this.panel2.TabIndex = 33;
            // 
            // busquedaTextBox
            // 
            this.busquedaTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.busquedaTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.busquedaTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.busquedaTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.busquedaTextBox.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.busquedaTextBox.Location = new System.Drawing.Point(272, 12);
            this.busquedaTextBox.Name = "busquedaTextBox";
            this.busquedaTextBox.Size = new System.Drawing.Size(219, 17);
            this.busquedaTextBox.TabIndex = 30;
            this.busquedaTextBox.TextChanged += new System.EventHandler(this.BusquedaTextBox_TextChanged);
            // 
            // stockDataGridView
            // 
            this.stockDataGridView.AllowUserToAddRows = false;
            this.stockDataGridView.AllowUserToDeleteRows = false;
            this.stockDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.stockDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.stockDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.stockDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stockDataGridView.ColumnHeadersVisible = false;
            this.stockDataGridView.Location = new System.Drawing.Point(0, 45);
            this.stockDataGridView.Name = "stockDataGridView";
            this.stockDataGridView.ReadOnly = true;
            this.stockDataGridView.RowHeadersVisible = false;
            this.stockDataGridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockDataGridView.RowTemplate.Height = 30;
            this.stockDataGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.stockDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.stockDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.stockDataGridView.Size = new System.Drawing.Size(499, 180);
            this.stockDataGridView.TabIndex = 29;
            this.stockDataGridView.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.StockDataGridView_RowPrePaint);
            // 
            // stockLabel
            // 
            this.stockLabel.AutoSize = true;
            this.stockLabel.BackColor = System.Drawing.Color.White;
            this.stockLabel.Font = new System.Drawing.Font("Open Sans SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockLabel.Location = new System.Drawing.Point(0, 0);
            this.stockLabel.Name = "stockLabel";
            this.stockLabel.Padding = new System.Windows.Forms.Padding(20, 10, 287, 10);
            this.stockLabel.Size = new System.Drawing.Size(499, 42);
            this.stockLabel.TabIndex = 28;
            this.stockLabel.Text = "Existencia de productos";
            // 
            // facturasImpresasTextBox
            // 
            this.facturasImpresasTextBox.BackColor = System.Drawing.Color.White;
            this.facturasImpresasTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.facturasImpresasTextBox.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.facturasImpresasTextBox.ForeColor = System.Drawing.Color.Black;
            this.facturasImpresasTextBox.Location = new System.Drawing.Point(13, 403);
            this.facturasImpresasTextBox.Name = "facturasImpresasTextBox";
            this.facturasImpresasTextBox.Size = new System.Drawing.Size(250, 21);
            this.facturasImpresasTextBox.TabIndex = 31;
            this.facturasImpresasTextBox.Text = "Facturas impresas : 00";
            this.facturasImpresasTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // facturasGuardadasTextBox
            // 
            this.facturasGuardadasTextBox.BackColor = System.Drawing.Color.White;
            this.facturasGuardadasTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.facturasGuardadasTextBox.Font = new System.Drawing.Font("Open Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.facturasGuardadasTextBox.ForeColor = System.Drawing.Color.Black;
            this.facturasGuardadasTextBox.Location = new System.Drawing.Point(13, 425);
            this.facturasGuardadasTextBox.Name = "facturasGuardadasTextBox";
            this.facturasGuardadasTextBox.Size = new System.Drawing.Size(250, 21);
            this.facturasGuardadasTextBox.TabIndex = 32;
            this.facturasGuardadasTextBox.Text = "Facturas guardadas : 00";
            this.facturasGuardadasTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PanelDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(780, 640);
            this.Controls.Add(this.facturasGuardadasTextBox);
            this.Controls.Add(this.facturasImpresasTextBox);
            this.Controls.Add(this.stockPanel);
            this.Controls.Add(this.topProductosPanel);
            this.Controls.Add(this.encabezadoPanel);
            this.Controls.Add(this.totalVentasPanel);
            this.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PanelDashboard";
            this.Text = "Panel";
            this.Load += new System.EventHandler(this.PanelDashboard_Load);
            this.totalVentasPanel.ResumeLayout(false);
            this.totalVentasPanel.PerformLayout();
            this.encabezadoPanel.ResumeLayout(false);
            this.encabezadoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tituloPictureBox)).EndInit();
            this.topProductosPanel.ResumeLayout(false);
            this.topProductosPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listadoDataGridView)).EndInit();
            this.stockPanel.ResumeLayout(false);
            this.stockPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stockDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label rangoFechaLabel;
        public System.Windows.Forms.ComboBox rangoFechaComboBox;
        private System.Windows.Forms.Label fromDateLabel;
        private System.Windows.Forms.DateTimePicker fromDateTimePicker;
        private System.Windows.Forms.Label toDateLabel;
        private System.Windows.Forms.DateTimePicker toDateTimePicker;
        private System.Windows.Forms.Panel totalVentasPanel;
        private System.Windows.Forms.TextBox totalFacturasTextBox;
        private System.Windows.Forms.TextBox totalVentasTextBox;
        private System.Windows.Forms.Label totalVentasLabel;
        private System.Windows.Forms.Panel encabezadoPanel;
        private System.Windows.Forms.PictureBox tituloPictureBox;
        private System.Windows.Forms.Label tituloLabel;
        private System.Windows.Forms.TextBox fechaActualTextBox;
        private System.Windows.Forms.Panel topProductosPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView listadoDataGridView;
        private System.Windows.Forms.Panel stockPanel;
        private System.Windows.Forms.DataGridView stockDataGridView;
        private System.Windows.Forms.Label stockLabel;
        public System.Windows.Forms.TextBox busquedaTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label busquedaLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox facturasImpresasTextBox;
        private System.Windows.Forms.TextBox facturasGuardadasTextBox;
    }
}