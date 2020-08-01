using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompudavSystem.utilitario
{
    public class ValidaCampo
    {
        public bool ErrorStatus { get; set; }
        public ErrorProvider ErrorProvider { get; set; } = new ErrorProvider();
        public void Requerido(TextBox textBox, string mensaje)
        {
            ErrorStatus = true;
            if (textBox.Text == "")
            {
                ErrorProvider.SetError(textBox, mensaje);
                ErrorStatus = false;
            }
            else
            {
                ErrorProvider.SetError(textBox, "");
            }
        }

        public void Identificacion(TextBox textBox)
        {
            ErrorStatus = true;
            if (textBox.Text.Trim().Length > 0)
            {
                ErrorStatus = ValidaIDNumber.VerificaIdentificacion(textBox.Text);
            }
            if (ErrorStatus)
            {
                ErrorProvider.SetError(textBox, "");
            }
            else
            {
                ErrorProvider.SetError(textBox, "Verifica número de ID");
            }
        }
    }
}
