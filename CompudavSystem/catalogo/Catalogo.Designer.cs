namespace CompudavSystem.catalogo
{
    partial class Catalogo
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
            this.encabezadoPanel = new System.Windows.Forms.Panel();
            this.categoriaButton = new System.Windows.Forms.Button();
            this.fabricanteButton = new System.Windows.Forms.Button();
            this.busquedaLabel = new System.Windows.Forms.Label();
            this.busquedaTextBox = new System.Windows.Forms.TextBox();
            this.tituloPictureBox = new System.Windows.Forms.PictureBox();
            this.tituloLabel = new System.Windows.Forms.Label();
            this.listadoDataGridView = new System.Windows.Forms.DataGridView();
            this.encabezadoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tituloPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listadoDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // encabezadoPanel
            // 
            this.encabezadoPanel.Controls.Add(this.categoriaButton);
            this.encabezadoPanel.Controls.Add(this.fabricanteButton);
            this.encabezadoPanel.Controls.Add(this.busquedaLabel);
            this.encabezadoPanel.Controls.Add(this.busquedaTextBox);
            this.encabezadoPanel.Controls.Add(this.tituloPictureBox);
            this.encabezadoPanel.Controls.Add(this.tituloLabel);
            this.encabezadoPanel.Location = new System.Drawing.Point(10, 10);
            this.encabezadoPanel.Name = "encabezadoPanel";
            this.encabezadoPanel.Size = new System.Drawing.Size(760, 90);
            this.encabezadoPanel.TabIndex = 0;
            // 
            // categoriaButton
            // 
            this.categoriaButton.Image = global::CompudavSystem.Properties.Resources.doctors_bag_24px;
            this.categoriaButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.categoriaButton.Location = new System.Drawing.Point(660, 10);
            this.categoriaButton.Name = "categoriaButton";
            this.categoriaButton.Size = new System.Drawing.Size(95, 35);
            this.categoriaButton.TabIndex = 4;
            this.categoriaButton.Text = "Categoria";
            this.categoriaButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.categoriaButton.UseVisualStyleBackColor = true;
            // 
            // fabricanteButton
            // 
            this.fabricanteButton.Image = global::CompudavSystem.Properties.Resources.bayer_logo_24;
            this.fabricanteButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.fabricanteButton.Location = new System.Drawing.Point(660, 51);
            this.fabricanteButton.Name = "fabricanteButton";
            this.fabricanteButton.Size = new System.Drawing.Size(95, 35);
            this.fabricanteButton.TabIndex = 3;
            this.fabricanteButton.Text = "Fabricante";
            this.fabricanteButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.fabricanteButton.UseVisualStyleBackColor = true;
            this.fabricanteButton.Click += new System.EventHandler(this.FabricanteButton_Click);
            // 
            // busquedaLabel
            // 
            this.busquedaLabel.AutoSize = true;
            this.busquedaLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(79)))), ((int)(((byte)(110)))));
            this.busquedaLabel.Location = new System.Drawing.Point(51, 61);
            this.busquedaLabel.Name = "busquedaLabel";
            this.busquedaLabel.Size = new System.Drawing.Size(62, 15);
            this.busquedaLabel.TabIndex = 1;
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
            this.busquedaTextBox.Location = new System.Drawing.Point(119, 61);
            this.busquedaTextBox.Name = "busquedaTextBox";
            this.busquedaTextBox.Size = new System.Drawing.Size(400, 15);
            this.busquedaTextBox.TabIndex = 0;
            // 
            // tituloPictureBox
            // 
            this.tituloPictureBox.Image = global::CompudavSystem.Properties.Resources.pills_36px;
            this.tituloPictureBox.Location = new System.Drawing.Point(3, 3);
            this.tituloPictureBox.Name = "tituloPictureBox";
            this.tituloPictureBox.Size = new System.Drawing.Size(40, 40);
            this.tituloPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.tituloPictureBox.TabIndex = 1;
            this.tituloPictureBox.TabStop = false;
            // 
            // tituloLabel
            // 
            this.tituloLabel.AutoSize = true;
            this.tituloLabel.Font = new System.Drawing.Font("Open Sans SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(79)))), ((int)(((byte)(110)))));
            this.tituloLabel.Location = new System.Drawing.Point(50, 15);
            this.tituloLabel.Name = "tituloLabel";
            this.tituloLabel.Size = new System.Drawing.Size(70, 19);
            this.tituloLabel.TabIndex = 2;
            this.tituloLabel.Text = "Catálogo";
            // 
            // listadoDataGridView
            // 
            this.listadoDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.listadoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listadoDataGridView.Location = new System.Drawing.Point(10, 113);
            this.listadoDataGridView.Name = "listadoDataGridView";
            this.listadoDataGridView.Size = new System.Drawing.Size(760, 515);
            this.listadoDataGridView.TabIndex = 1;
            // 
            // Catalogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(780, 640);
            this.Controls.Add(this.listadoDataGridView);
            this.Controls.Add(this.encabezadoPanel);
            this.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Catalogo";
            this.Text = "catalogo";
            this.Load += new System.EventHandler(this.Catalogo_Load);
            this.encabezadoPanel.ResumeLayout(false);
            this.encabezadoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tituloPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listadoDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel encabezadoPanel;
        private System.Windows.Forms.DataGridView listadoDataGridView;
        private System.Windows.Forms.Label tituloLabel;
        private System.Windows.Forms.PictureBox tituloPictureBox;
        private System.Windows.Forms.TextBox busquedaTextBox;
        private System.Windows.Forms.Label busquedaLabel;
        private System.Windows.Forms.Button fabricanteButton;
        private System.Windows.Forms.Button categoriaButton;
    }
}