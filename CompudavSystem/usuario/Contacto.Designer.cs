﻿namespace CompudavSystem.usuario
{
    partial class Contacto
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
            this.agregarButton = new System.Windows.Forms.Button();
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
            this.encabezadoPanel.Controls.Add(this.agregarButton);
            this.encabezadoPanel.Controls.Add(this.busquedaLabel);
            this.encabezadoPanel.Controls.Add(this.busquedaTextBox);
            this.encabezadoPanel.Controls.Add(this.tituloPictureBox);
            this.encabezadoPanel.Controls.Add(this.tituloLabel);
            this.encabezadoPanel.Location = new System.Drawing.Point(10, 10);
            this.encabezadoPanel.Name = "encabezadoPanel";
            this.encabezadoPanel.Size = new System.Drawing.Size(760, 129);
            this.encabezadoPanel.TabIndex = 2;
            // 
            // agregarButton
            // 
            this.agregarButton.BackColor = System.Drawing.Color.White;
            this.agregarButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.agregarButton.FlatAppearance.BorderSize = 0;
            this.agregarButton.Font = new System.Drawing.Font("Open Sans ExtraBold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agregarButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(79)))), ((int)(((byte)(110)))));
            this.agregarButton.Location = new System.Drawing.Point(657, 3);
            this.agregarButton.Name = "agregarButton";
            this.agregarButton.Size = new System.Drawing.Size(100, 40);
            this.agregarButton.TabIndex = 1;
            this.agregarButton.Text = "Nuevo";
            this.agregarButton.UseVisualStyleBackColor = false;
            this.agregarButton.Click += new System.EventHandler(this.AgregarButton_Click);
            // 
            // busquedaLabel
            // 
            this.busquedaLabel.AutoSize = true;
            this.busquedaLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(79)))), ((int)(((byte)(110)))));
            this.busquedaLabel.Location = new System.Drawing.Point(50, 85);
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
            this.busquedaTextBox.Location = new System.Drawing.Point(118, 85);
            this.busquedaTextBox.Name = "busquedaTextBox";
            this.busquedaTextBox.Size = new System.Drawing.Size(600, 15);
            this.busquedaTextBox.TabIndex = 0;
            this.busquedaTextBox.TextChanged += new System.EventHandler(this.BusquedaTextBox_TextChanged);
            // 
            // tituloPictureBox
            // 
            this.tituloPictureBox.Image = global::CompudavSystem.Properties.Resources.user_group_36px;
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
            this.tituloLabel.Location = new System.Drawing.Point(50, 15);
            this.tituloLabel.Name = "tituloLabel";
            this.tituloLabel.Size = new System.Drawing.Size(82, 17);
            this.tituloLabel.TabIndex = 4;
            this.tituloLabel.Text = "Contactos";
            // 
            // listadoDataGridView
            // 
            this.listadoDataGridView.AllowUserToAddRows = false;
            this.listadoDataGridView.AllowUserToDeleteRows = false;
            this.listadoDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.listadoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listadoDataGridView.Location = new System.Drawing.Point(10, 145);
            this.listadoDataGridView.Name = "listadoDataGridView";
            this.listadoDataGridView.ReadOnly = true;
            this.listadoDataGridView.RowHeadersVisible = false;
            this.listadoDataGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.listadoDataGridView.Size = new System.Drawing.Size(760, 483);
            this.listadoDataGridView.TabIndex = 3;
            this.listadoDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listadoDataGridView_CellClick);
            // 
            // Contacto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(780, 640);
            this.Controls.Add(this.encabezadoPanel);
            this.Controls.Add(this.listadoDataGridView);
            this.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Contacto";
            this.Text = "contacto";
            this.Load += new System.EventHandler(this.Contacto_Load);
            this.encabezadoPanel.ResumeLayout(false);
            this.encabezadoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tituloPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listadoDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel encabezadoPanel;
        private System.Windows.Forms.Button agregarButton;
        private System.Windows.Forms.Label busquedaLabel;
        public System.Windows.Forms.TextBox busquedaTextBox;
        private System.Windows.Forms.PictureBox tituloPictureBox;
        private System.Windows.Forms.Label tituloLabel;
        private System.Windows.Forms.DataGridView listadoDataGridView;
    }
}