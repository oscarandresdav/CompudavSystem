namespace CompudavSystem.historico
{
    partial class Historial
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
            this.listadoDataGridView = new System.Windows.Forms.DataGridView();
            this.encabezadoPanel = new System.Windows.Forms.Panel();
            this.rangoFechaLabel = new System.Windows.Forms.Label();
            this.rangoFechaComboBox = new System.Windows.Forms.ComboBox();
            this.fromDateLabel = new System.Windows.Forms.Label();
            this.fromDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.toDateLabel = new System.Windows.Forms.Label();
            this.toDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.busquedaLabel = new System.Windows.Forms.Label();
            this.busquedaTextBox = new System.Windows.Forms.TextBox();
            this.tituloPictureBox = new System.Windows.Forms.PictureBox();
            this.tituloLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.listadoDataGridView)).BeginInit();
            this.encabezadoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tituloPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // listadoDataGridView
            // 
            this.listadoDataGridView.AllowUserToAddRows = false;
            this.listadoDataGridView.AllowUserToDeleteRows = false;
            this.listadoDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.listadoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listadoDataGridView.Location = new System.Drawing.Point(10, 161);
            this.listadoDataGridView.Name = "listadoDataGridView";
            this.listadoDataGridView.ReadOnly = true;
            this.listadoDataGridView.RowHeadersVisible = false;
            this.listadoDataGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.listadoDataGridView.Size = new System.Drawing.Size(760, 467);
            this.listadoDataGridView.TabIndex = 3;
            this.listadoDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListadoDataGridView_CellClick);
            // 
            // encabezadoPanel
            // 
            this.encabezadoPanel.Controls.Add(this.rangoFechaLabel);
            this.encabezadoPanel.Controls.Add(this.rangoFechaComboBox);
            this.encabezadoPanel.Controls.Add(this.fromDateLabel);
            this.encabezadoPanel.Controls.Add(this.fromDateTimePicker);
            this.encabezadoPanel.Controls.Add(this.toDateLabel);
            this.encabezadoPanel.Controls.Add(this.toDateTimePicker);
            this.encabezadoPanel.Controls.Add(this.busquedaLabel);
            this.encabezadoPanel.Controls.Add(this.busquedaTextBox);
            this.encabezadoPanel.Controls.Add(this.tituloPictureBox);
            this.encabezadoPanel.Controls.Add(this.tituloLabel);
            this.encabezadoPanel.Location = new System.Drawing.Point(10, 10);
            this.encabezadoPanel.Name = "encabezadoPanel";
            this.encabezadoPanel.Size = new System.Drawing.Size(760, 145);
            this.encabezadoPanel.TabIndex = 2;
            // 
            // rangoFechaLabel
            // 
            this.rangoFechaLabel.AutoSize = true;
            this.rangoFechaLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(79)))), ((int)(((byte)(110)))));
            this.rangoFechaLabel.Location = new System.Drawing.Point(489, 54);
            this.rangoFechaLabel.Name = "rangoFechaLabel";
            this.rangoFechaLabel.Size = new System.Drawing.Size(40, 15);
            this.rangoFechaLabel.TabIndex = 20;
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
            this.rangoFechaComboBox.Location = new System.Drawing.Point(532, 50);
            this.rangoFechaComboBox.Name = "rangoFechaComboBox";
            this.rangoFechaComboBox.Size = new System.Drawing.Size(225, 23);
            this.rangoFechaComboBox.TabIndex = 19;
            this.rangoFechaComboBox.SelectedIndexChanged += new System.EventHandler(this.RangoFechaComboBox_SelectedIndexChanged);
            // 
            // fromDateLabel
            // 
            this.fromDateLabel.AutoSize = true;
            this.fromDateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(79)))), ((int)(((byte)(110)))));
            this.fromDateLabel.Location = new System.Drawing.Point(493, 110);
            this.fromDateLabel.Name = "fromDateLabel";
            this.fromDateLabel.Size = new System.Drawing.Size(36, 15);
            this.fromDateLabel.TabIndex = 18;
            this.fromDateLabel.Text = "Hasta";
            // 
            // fromDateTimePicker
            // 
            this.fromDateTimePicker.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(79)))), ((int)(((byte)(110)))));
            this.fromDateTimePicker.Location = new System.Drawing.Point(532, 107);
            this.fromDateTimePicker.Name = "fromDateTimePicker";
            this.fromDateTimePicker.Size = new System.Drawing.Size(225, 22);
            this.fromDateTimePicker.TabIndex = 17;
            this.fromDateTimePicker.ValueChanged += new System.EventHandler(this.FromDateTimePicker_ValueChanged);
            // 
            // toDateLabel
            // 
            this.toDateLabel.AutoSize = true;
            this.toDateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(79)))), ((int)(((byte)(110)))));
            this.toDateLabel.Location = new System.Drawing.Point(490, 82);
            this.toDateLabel.Name = "toDateLabel";
            this.toDateLabel.Size = new System.Drawing.Size(39, 15);
            this.toDateLabel.TabIndex = 16;
            this.toDateLabel.Text = "Desde";
            // 
            // toDateTimePicker
            // 
            this.toDateTimePicker.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(79)))), ((int)(((byte)(110)))));
            this.toDateTimePicker.Location = new System.Drawing.Point(532, 79);
            this.toDateTimePicker.Name = "toDateTimePicker";
            this.toDateTimePicker.Size = new System.Drawing.Size(225, 22);
            this.toDateTimePicker.TabIndex = 15;
            this.toDateTimePicker.ValueChanged += new System.EventHandler(this.ToDateTimePicker_ValueChanged);
            // 
            // busquedaLabel
            // 
            this.busquedaLabel.AutoSize = true;
            this.busquedaLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(79)))), ((int)(((byte)(110)))));
            this.busquedaLabel.Location = new System.Drawing.Point(3, 83);
            this.busquedaLabel.Name = "busquedaLabel";
            this.busquedaLabel.Size = new System.Drawing.Size(62, 15);
            this.busquedaLabel.TabIndex = 5;
            this.busquedaLabel.Text = "Busqueda:";
            // 
            // busquedaTextBox
            // 
            this.busquedaTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.busquedaTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.busquedaTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.busquedaTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.busquedaTextBox.Font = new System.Drawing.Font("Open Sans", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.busquedaTextBox.Location = new System.Drawing.Point(70, 83);
            this.busquedaTextBox.Name = "busquedaTextBox";
            this.busquedaTextBox.Size = new System.Drawing.Size(381, 15);
            this.busquedaTextBox.TabIndex = 0;
            this.busquedaTextBox.TextChanged += new System.EventHandler(this.BusquedaTextBox_TextChanged);
            // 
            // tituloPictureBox
            // 
            this.tituloPictureBox.Image = global::CompudavSystem.Properties.Resources.order_history_36px;
            this.tituloPictureBox.Location = new System.Drawing.Point(3, 2);
            this.tituloPictureBox.Name = "tituloPictureBox";
            this.tituloPictureBox.Size = new System.Drawing.Size(40, 40);
            this.tituloPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.tituloPictureBox.TabIndex = 1;
            this.tituloPictureBox.TabStop = false;
            // 
            // tituloLabel
            // 
            this.tituloLabel.AutoSize = true;
            this.tituloLabel.Font = new System.Drawing.Font("Roboto Medium", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(79)))), ((int)(((byte)(110)))));
            this.tituloLabel.Location = new System.Drawing.Point(50, 14);
            this.tituloLabel.Name = "tituloLabel";
            this.tituloLabel.Size = new System.Drawing.Size(72, 17);
            this.tituloLabel.TabIndex = 4;
            this.tituloLabel.Text = "Historial";
            // 
            // Historial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(780, 640);
            this.Controls.Add(this.encabezadoPanel);
            this.Controls.Add(this.listadoDataGridView);
            this.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Historial";
            this.Text = "Historial";
            this.Load += new System.EventHandler(this.Historial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listadoDataGridView)).EndInit();
            this.encabezadoPanel.ResumeLayout(false);
            this.encabezadoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tituloPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView listadoDataGridView;
        private System.Windows.Forms.Panel encabezadoPanel;
        private System.Windows.Forms.Label busquedaLabel;
        public System.Windows.Forms.TextBox busquedaTextBox;
        private System.Windows.Forms.PictureBox tituloPictureBox;
        private System.Windows.Forms.Label tituloLabel;
        private System.Windows.Forms.Label fromDateLabel;
        private System.Windows.Forms.DateTimePicker fromDateTimePicker;
        private System.Windows.Forms.Label toDateLabel;
        private System.Windows.Forms.DateTimePicker toDateTimePicker;
        private System.Windows.Forms.Label rangoFechaLabel;
        public System.Windows.Forms.ComboBox rangoFechaComboBox;
    }
}