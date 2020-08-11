using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using CompudavSystem.bdd;
using CompudavSystem.utilitario;

namespace CompudavSystem.usuario
{
    public partial class Contacto : Form, IContacto
    {
        private NuevoContacto NuevoItemForm { get; set; } = new NuevoContacto();
        private string TableBdd { get; set; } = "contact";
        public Contacto()
        {
            InitializeComponent();
            DatosIniciales();
        }

        public void DatosIniciales()
        {
            listadoDataGridView.DataSource = ConsultasSql.ConsultaGeneral(TableBdd, campoOrden: "business_name");
            listadoDataGridView.Sort(listadoDataGridView.Columns["business_name"], ListSortDirection.Ascending);
            listadoDataGridView.Columns["business_name"].HeaderText = "Nombre";
            listadoDataGridView.Columns["business_name"].Width = 320;

            listadoDataGridView.Columns["id_number"].HeaderText = "Identificación";
            listadoDataGridView.Columns["landline"].HeaderText = "Telefono";
            listadoDataGridView.Columns["landline"].Width = 90;
            listadoDataGridView.Columns["email"].HeaderText = "Correo";
            listadoDataGridView.Columns["email"].Width = 120;

            listadoDataGridView.Columns["id"].Visible = false;
            listadoDataGridView.Columns["tradename"].Visible = false;
            listadoDataGridView.Columns["address"].Visible = false;
            listadoDataGridView.Columns["mobile_phone"].Visible = false;
            listadoDataGridView.Columns["client"].Visible = false;
            listadoDataGridView.Columns["provider"].Visible = false;
            listadoDataGridView.Columns["special_taxpayer"].Visible = false;
            listadoDataGridView.Columns["additional_information"].Visible = false;
            listadoDataGridView.Columns["status"].Visible = false;
            listadoDataGridView.Columns["created_at"].Visible = false;
            listadoDataGridView.Columns["modified_at"].Visible = false;
            listadoDataGridView.Columns["revision"].Visible = false;
            listadoDataGridView.Columns["typeIdentificationId"].Visible = false;

        }

        public void FocoEnTextBoxDeBusqueda()
        {
            busquedaTextBox.Focus();
        }

        private void CrearBotonAccionesDatagridview(string headerText, string name, Bitmap pathImage)
        {
            DataGridViewImageColumn img = new DataGridViewImageColumn();
            Image image = pathImage;
            img.Image = image;
            listadoDataGridView.Columns.Add(img);
            img.HeaderText = headerText;
            img.Name = name;
            img.Width = 60;
        }
        private void AgregarButton_Click(object sender, EventArgs e)
        {
            DatosGuardarActualizar
                (
                    "", "Guardar", "", "", "", "", "", "", "", "0",
                    "0", "0", "", ""
                );
        }

        private void DatosGuardarActualizar(string id, string accionBoton, string idNumberCampo, string businessNameCampo,
            string tradenameCampo, string addressCampo, string landlineCampo, string mobilePhoneCampo, string emailCampo,
            string clientCampo, string providerCampo, string specialTaxpayerCampo, string additionalInformationCampo, string typeIdentificationIdCampo)
        {
            NuevoItemForm.Icontacto = this;
            FormularioPanel.MostrarFormulario(NuevoItemForm, NuevoItemForm.businessNameTextBox);
            NuevoItemForm.IdField = id;
            NuevoItemForm.TableBdd = TableBdd;
            NuevoItemForm.ValidaCampoContacto.ErrorProvider.Clear();
            NuevoItemForm.DatosIniciales();
            NuevoItemForm.aceptarButton.Text = accionBoton;

            NuevoItemForm.businessNameTextBox.Text = businessNameCampo;
            NuevoItemForm.businessNameTextBox.SelectAll();
            NuevoItemForm.tradenameTextBox.Text = tradenameCampo;
            NuevoItemForm.addressTextBox.Text = addressCampo;
            NuevoItemForm.idNumberTextBox.Text = idNumberCampo;
            NuevoItemForm.clientCheckBox.Checked = clientCampo != "0";
            NuevoItemForm.providerCheckBox.Checked = providerCampo != "0";
            NuevoItemForm.specialTaxpayerCheckBox.Checked = specialTaxpayerCampo != "0";
            NuevoItemForm.emailTextBox.Text = emailCampo;
            NuevoItemForm.landlineTextBox.Text = landlineCampo;
            NuevoItemForm.mobilePhoneTextBox.Text = mobilePhoneCampo;
            NuevoItemForm.additionalInformationTextBox.Text = additionalInformationCampo;
            NuevoItemForm.typeIdentificationComboBox.SelectedValue = (typeIdentificationIdCampo == "") ? "nulo" : typeIdentificationIdCampo; ;

        }

        public void Busqueda()
        {
            string busqueda = busquedaTextBox.Text.Replace("'", "\\'").Trim();
            listadoDataGridView.DataSource = ConsultasSql.Busqueda(TableBdd, "business_name", $"{ busqueda }", campoOrden: "business_name");
            listadoDataGridView.Sort(listadoDataGridView.Columns["business_name"], ListSortDirection.Ascending);
        }

        private void Contacto_Load(object sender, EventArgs e)
        {
            FocoEnTextBoxDeBusqueda();
            CrearBotonAccionesDatagridview("Editar", "editButton", Properties.Resources.edit_18px);
            CrearBotonAccionesDatagridview("Eliminar", "deleteButton", Properties.Resources.delete_bin_18px);
        }

        private void BusquedaTextBox_TextChanged(object sender, EventArgs e)
        {
            Busqueda();
        }

        private void listadoDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && listadoDataGridView.CurrentCell.OwningColumn.Name == "editButton")
            {
                DatosGuardarActualizar
                    (
                        listadoDataGridView.Rows[e.RowIndex].Cells["id"].Value.ToString(),
                        "Actualizar",
                        listadoDataGridView.Rows[e.RowIndex].Cells["id_number"].Value.ToString(),
                        listadoDataGridView.Rows[e.RowIndex].Cells["business_name"].Value.ToString(),
                        listadoDataGridView.Rows[e.RowIndex].Cells["tradename"].Value.ToString(),
                        listadoDataGridView.Rows[e.RowIndex].Cells["address"].Value.ToString(),
                        listadoDataGridView.Rows[e.RowIndex].Cells["landline"].Value.ToString(),
                        listadoDataGridView.Rows[e.RowIndex].Cells["mobile_phone"].Value.ToString(),
                        listadoDataGridView.Rows[e.RowIndex].Cells["email"].Value.ToString(),
                        listadoDataGridView.Rows[e.RowIndex].Cells["client"].Value.ToString(),
                        listadoDataGridView.Rows[e.RowIndex].Cells["provider"].Value.ToString(),
                        listadoDataGridView.Rows[e.RowIndex].Cells["special_taxpayer"].Value.ToString(),
                        listadoDataGridView.Rows[e.RowIndex].Cells["additional_information"].Value.ToString(),
                        listadoDataGridView.Rows[e.RowIndex].Cells["typeIdentificationId"].Value.ToString()
                    );
            }

            if (e.RowIndex >= 0 && listadoDataGridView.CurrentCell.OwningColumn.Name == "deleteButton")
            {
                if (MessageBox.Show("¿Está seguro que desea eliminar este item?", "Eliminar item", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (ConsultasSql.Eliminar(TableBdd, "id", $"'{listadoDataGridView.Rows[e.RowIndex].Cells["id"].Value}'"))
                    {
                        DatosIniciales();
                    }
                }
            }
        }
    }
}
