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
            listadoDataGridView.DataSource = ConsultasSql.ConsultaGeneral(TableBdd);
            listadoDataGridView.Sort(listadoDataGridView.Columns["name"], ListSortDirection.Ascending);
            listadoDataGridView.Columns["name"].HeaderText = "Descripción";
            listadoDataGridView.Columns["name"].Width = 347;

            listadoDataGridView.Columns["cost"].HeaderText = "Costo";
            listadoDataGridView.Columns["price"].HeaderText = "P.V.P.";
            listadoDataGridView.Columns["stock"].HeaderText = "Existencias";
            listadoDataGridView.Columns["stock"].Width = 90;

            listadoDataGridView.Columns["id"].Visible = false;
            listadoDataGridView.Columns["main_code"].Visible = false;
            listadoDataGridView.Columns["aux_code"].Visible = false;
            listadoDataGridView.Columns["detail"].Visible = false;
            listadoDataGridView.Columns["minimum_stock_level"].Visible = false;
            listadoDataGridView.Columns["percentage_price"].Visible = false;
            listadoDataGridView.Columns["percentage_price2"].Visible = false;
            listadoDataGridView.Columns["price2"].Visible = false;
            listadoDataGridView.Columns["percentage_price3"].Visible = false;
            listadoDataGridView.Columns["price3"].Visible = false;
            listadoDataGridView.Columns["status"].Visible = false;
            listadoDataGridView.Columns["created_at"].Visible = false;
            listadoDataGridView.Columns["modified_at"].Visible = false;
            listadoDataGridView.Columns["revision"].Visible = false;
            listadoDataGridView.Columns["categoryId"].Visible = false;
            listadoDataGridView.Columns["manufacturerId"].Visible = false;
            listadoDataGridView.Columns["iceRateId"].Visible = false;
            listadoDataGridView.Columns["ivaRateId"].Visible = false;
            listadoDataGridView.Columns["typeProductId"].Visible = false;
            listadoDataGridView.Columns["unitMeasurementId"].Visible = false;
        }



        public void FocoEnTextBoxDeBusqueda()
        {
            busquedaTextBox.Focus();
        }
        private void AgregarButton_Click(object sender, EventArgs e)
        {

        }

        private void DatosGuardarActualizar(string id, string accionBoton, string mainCodeCampo, string auxCodeCampo,
            string nameCampo, string detailCampo, string stockCampo, string minimumStockLevelCampo, string costCampo,
            string percentagePrice1Campo, string price1Campo, string percentagePrice2Campo, string price2Campo,
            string percentagePrice3Campo, string price3Campo, string categoryIdCampo, string manufacturerIdCampo,
            string iceRateIdCampo, string ivaRateIdCampo, string typeProductIdCampo, string unitMeasurementIdCampo)
        {
            NuevoItemForm.Icontacto = this;
            NuevoItemForm.Show();
            NuevoItemForm.BringToFront();
            NuevoItemForm.IdField = id;
            NuevoItemForm.TableBdd = TableBdd;
            //NuevoItemForm.ErrorProvider.Clear();
            //NuevoItemForm.DatosIniciales();
            NuevoItemForm.aceptarButton.Text = accionBoton;

            //NuevoItemForm.nameTextBox.Text = nameCampo;
            //NuevoItemForm.nameTextBox.Focus();
            //NuevoItemForm.nameTextBox.SelectAll();
            //NuevoItemForm.mainCodeTextBox.Text = mainCodeCampo;
            //NuevoItemForm.auxCodeTextBox.Text = auxCodeCampo;
            //NuevoItemForm.descripcionTextBox.Text = detailCampo;
            //NuevoItemForm.stockTextBox.Text = stockCampo;
            //NuevoItemForm.minimumStockLevelTextBox.Text = minimumStockLevelCampo;
            //NuevoItemForm.costTextBox.Text = costCampo;
            //NuevoItemForm.percentagePrice1TextBox.Text = percentagePrice1Campo;
            //NuevoItemForm.price1TextBox.Text = price1Campo;
            //NuevoItemForm.percentagePrice2TextBox.Text = percentagePrice2Campo;
            //NuevoItemForm.price2TextBox.Text = price2Campo;
            //NuevoItemForm.percentagePrice3TextBox.Text = percentagePrice3Campo;
            //NuevoItemForm.price3TextBox.Text = price3Campo;
            //NuevoItemForm.categoryComboBox.SelectedValue = (categoryIdCampo == "") ? "nulo" : categoryIdCampo;
            //NuevoItemForm.manufacturerComboBox.SelectedValue = (manufacturerIdCampo == "") ? "nulo" : manufacturerIdCampo;
            //NuevoItemForm.iceRateComboBox.SelectedValue = (iceRateIdCampo == "") ? "nulo" : iceRateIdCampo;
            //NuevoItemForm.unitMeasurementComboBox.SelectedValue = (unitMeasurementIdCampo == "") ? "nulo" : unitMeasurementIdCampo;

            if (accionBoton == "Actualizar")
            {
                //NuevoItemForm.typeProductComboBox.SelectedValue = typeProductIdCampo;
                //NuevoItemForm.ivaRateComboBox.SelectedValue = ivaRateIdCampo;
                //NuevoItemForm.stockTextBox.ReadOnly = true;
            }
            else if (accionBoton == "Guardar")
            {
                //NuevoItemForm.typeProductComboBox.SelectedIndex = 0;
                //NuevoItemForm.ivaRateComboBox.SelectedIndex = 0;
                //NuevoItemForm.stockTextBox.ReadOnly = false;
            }
        }

        public void Busqueda()
        {
            string busqueda = busquedaTextBox.Text.Replace("'", "\\'").Trim();
            listadoDataGridView.DataSource = ConsultasSql.Busqueda(TableBdd, "name", $"{ busqueda }");
            listadoDataGridView.Sort(listadoDataGridView.Columns["name"], ListSortDirection.Ascending);
        }
    }
}
