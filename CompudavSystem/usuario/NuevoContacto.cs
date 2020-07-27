using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CompudavSystem.bdd;

namespace CompudavSystem.usuario
{
    public partial class NuevoContacto : Form
    {
        public IContacto Icontacto { get; set; }
        public string TableBdd { get; set; }
        public string IdField { get; set; }
        public bool ErrorStatus { get; set; }
        public ErrorProvider ErrorProvider { get; set; } = new ErrorProvider();

        public NuevoContacto()
        {
            InitializeComponent();
            DatosIniciales();
        }

        public void DatosIniciales()
        {
            CargaDeDatosCombobox(typeIdentificationComboBox, "type_identification");
            CampoInicialComboBox(typeIdentificationComboBox, "sort");
        }

        private void CampoInicialComboBox(ComboBox comboBox, string sortColum = "sort")
        {
            DataTable dataTable = comboBox.DataSource as DataTable;
            DataRow dataRow = dataTable.NewRow();
            dataRow["id"] = "nulo";
            dataRow["description"] = "---------";
            if (sortColum == "sort") { dataRow["sort"] = -1; }
            dataTable.Rows.Add(dataRow);
            dataTable.DefaultView.Sort = $"{sortColum} asc";
            comboBox.DataSource = dataTable;
        }

        private void CargaDeDatosCombobox(ComboBox comboBox, string table, string displayMember = "description", string valueMember = "id", string campoOrden = "description")
        {
            comboBox.DataSource = ConsultasSql.ConsultaGeneral(table, campoOrden: campoOrden);
            comboBox.DisplayMember = displayMember;
            comboBox.ValueMember = valueMember;
            comboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        }

        private void AceptarButton_Click(object sender, EventArgs e)
        {
            ValidarCampoRequerido(idNumberTextBox, "Por favor ingrese el numero de Identificación");
            ValidarCampoRequerido(businessNameTextBox, "Por favor ingrese el Nombre");
            ValidarCampoRequerido(addressTextBox, "Por favor ingrese la Dirección");
            
            if (ErrorStatus)
            {
                Guardar();
            }
        }
        private void Guardar()
        {
            string idNumber = (idNumberTextBox.Text.Trim() == "") ? "null" : idNumberTextBox.Text.Trim();
            string businessName = businessNameTextBox.Text.Replace("'", "\\'").Trim();
            businessName = (businessName == "") ? "null" : $"'{businessName}'";
            string tradename = tradenameTextBox.Text.Replace("'", "\\'").Trim();
            tradename = (tradename == "") ? "null" : $"'{tradename}'";
            string address = addressTextBox.Text.Replace("'", "\\'").Trim();
            address = (address == "") ? "null" : $"'{address}'";
            string landline = (landlineTextBox.Text.Trim() == "") ? "null" : landlineTextBox.Text.Trim();
            string mobilePhone = (mobilePhoneTextBox.Text.Trim() == "") ? "null" : mobilePhoneTextBox.Text.Trim();
            string email = emailTextBox.Text.Replace("'", "\\'").Trim();
            email = (email == "") ? "null" : $"'{email}'";
            bool client = clientCheckBox.Checked;
            bool provider = providerCheckBox.Checked;
            bool specialTaxpayer = specialTaxpayerCheckBox.Checked;
            string additionalInformation = additionalInformationTextBox.Text.Replace("'", "\\'").Trim();
            additionalInformation = (additionalInformation == "") ? "null" : $"'{additionalInformation}'";
            string typeIdentification = (typeIdentificationComboBox.SelectedValue.ToString() == "nulo") ? "null" : $"'{typeIdentificationComboBox.SelectedValue}'";

            if (aceptarButton.Text == "Actualizar")
            {
                if (ConsultasSql.Actualizar(TableBdd,
                    $"id_number = {idNumber}, business_name = {businessName}, tradename = {tradename}, address = {address}, " +
                    $"landline = {landline}, mobile_phone = {mobilePhone}, email = {email}, client = {client}, provider = {provider}, " +
                    $"special_taxpayer = {specialTaxpayer}, additional_information = {additionalInformation}, typeIdentificationId = {typeIdentification}",
                    "id", $"'{IdField}'"))
                {
                    CerrarYRefrescarFormulario();
                }
            }

            if (aceptarButton.Text == "Guardar")
            {
                if (ConsultasSql.Insertar(
                    TableBdd,
                    "id_number, business_name, tradename, address, landline, mobile_phone, " +
                    "email, client, provider, special_taxpayer, additional_information, typeIdentificationId",
                    $"{idNumber}, {businessName}, {tradename}, {address}, {landline}, {mobilePhone}, {email}, " +
                    $"{client}, {provider}, {specialTaxpayer}, {additionalInformation}, {typeIdentification}"
                    ))
                {
                    CerrarYRefrescarFormulario();
                }
            }
            
        }

        private void CancelarButton_Click(object sender, EventArgs e)
        {
            CerrarYRefrescarFormulario();
        }

        private void CerrarYRefrescarFormulario()
        {
            Hide();
            Icontacto.FocoEnTextBoxDeBusqueda();
            Icontacto.Busqueda();
        }

        private bool ValidarCampoRequerido(TextBox textBox, string mensaje)
        {
            ErrorStatus = true;
            if (textBox.Text == "")
            {
                ErrorProvider.SetError(textBox, mensaje);
                ErrorStatus = false;
            }
            else
                ErrorProvider.SetError(textBox, "");
            return ErrorStatus;
        }

        private void BusinessNameTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) { CerrarYRefrescarFormulario(); }
            if (e.KeyCode == Keys.Enter) { tradenameTextBox.Focus(); }
        }
    }
}
