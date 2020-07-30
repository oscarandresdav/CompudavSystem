using CompudavSystem.bdd;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompudavSystem.documento
{
    public partial class Venta : Form
    {
        public DataGridView ContactoDataGridView { get; set; } = new DataGridView();
        public Venta()
        {
            InitializeComponent();
            CargaNombre();
            this.ContactoDataGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ContactoDataGridView_KeyDown);
            this.ContactoDataGridView.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ContactoDataGridView_KeyUp);
        }

        private void CargaNombre()
        {
            string businessName = nameTextBox.Text.Replace("'", "\\'").Trim();
            DataTable dataTable = ConsultasSql.Busqueda("contact", "business_name", businessName, "id, id_number, business_name, address, landline");
            ContactoDataGridView.DataSource = dataTable;
            ContactoDataGridView.Size = new Size(350,120);
            ContactoDataGridView.Location = new Point(nameTextBox.Location.X+10, nameTextBox.Location.Y+26);
            ContactoDataGridView.ColumnHeadersVisible = false;
            ContactoDataGridView.RowHeadersVisible = false;
            ContactoDataGridView.AllowUserToAddRows = false;
            ContactoDataGridView.AllowUserToDeleteRows = false;
            ContactoDataGridView.BackgroundColor = Color.White;
            ContactoDataGridView.AllowUserToResizeColumns = false;
            ContactoDataGridView.AllowUserToResizeRows = false;
            ContactoDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ContactoDataGridView.ReadOnly = true;
            Controls.Add(ContactoDataGridView);
            ContactoDataGridView.BringToFront();
            if (ContactoDataGridView.Rows.Count > 0)
            {
                ContactoDataGridView.Columns["id_number"].Width = 90;
                ContactoDataGridView.Columns["business_name"].Width = 256;
                ContactoDataGridView.Columns["id"].Visible = false;
                ContactoDataGridView.Columns["address"].Visible = false;
                ContactoDataGridView.Columns["landline"].Visible = false;
            }

            if (businessName.Length > 0 && dataTable.Rows.Count > 0)
            {
                ContactoDataGridView.Visible = true;
            }
            else
            {
                ContactoDataGridView.Visible = false;
            }

            
            
            

            
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            CargaNombre();
        }

        private void NameTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down) 
            {
                if (ContactoDataGridView.Rows.Count > 0)
                {
                    ContactoDataGridView.Focus();
                }
            }
        }

        private void ContactoDataGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                if (ContactoDataGridView.CurrentCell.RowIndex == 0)
                {
                    nameTextBox.Focus();
                }
            }
            if (e.KeyCode == Keys.Enter)
            {
                ContactoDataGridView.Visible = false;
                dateIssueDateTimePicker.Focus();
            }
        }

        private void ContactoDataGridView_KeyUp(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Up)
            //{
            //    if (ContactoDataGridView.CurrentCell.RowIndex == 0)
            //    {
            //        nameTextBox.Focus();
            //    }
            //}
        }

        private void ListadoDataGridView_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}
