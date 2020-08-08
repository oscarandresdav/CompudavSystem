using System.Windows.Forms;

namespace CompudavSystem.utilitario
{
    public static class Validaciones
    {
        public static int Correos(int codigo)
        {
            if (
                (codigo < 48 || codigo > 57) && /// numeros "0 al 9"
                (codigo < 65 || codigo > 90) && /// letras "A al Z"
                (codigo < 97 || codigo > 122) && /// letras "a al z"
                codigo != 1 && /// ctrl+A
                codigo != 3 && /// ctrl+C
                codigo != 5 && /// ctrl+E
                codigo != 8 && /// backspace o retroceso
                codigo != 13 && /// enter
                codigo != 22 && /// ctrl+V
                codigo != 24 && /// ctrl+X
                codigo != 25 && /// ctrl+Y
                codigo != 26 &&/// ctrl+Z
                codigo != 45 &&/// -
                codigo != 46 &&/// .
                codigo != 64 &&/// @
                codigo != 95 /// _
                )
            {
                return 0;
            }
            else
            {
                return codigo;
            }
        }
        public static int Numeros(int codigo)
        {
            if (
                (codigo < 48 || codigo > 57) && /// numeros "0 al 9"
                codigo != 1 && /// ctrl+A
                codigo != 3 && /// ctrl+C
                codigo != 5 && /// ctrl+E
                codigo != 8 && /// backspace o retroceso
                codigo != 13 && /// enter
                codigo != 22 && /// ctrl+V
                codigo != 24 && /// ctrl+X
                codigo != 25 && /// ctrl+Y
                codigo != 26 /// ctrl+Z
                )
            {
                return 0;
            }
            else
            {
                return codigo;
            }
        }

        public static int NumerosPositivosYNegativos(int codigo)
        {
            if (
                (codigo < 48 || codigo > 57) && /// numeros "0 al 9"
                codigo != 1 && /// ctrl+A
                codigo != 3 && /// ctrl+C
                codigo != 5 && /// ctrl+E
                codigo != 8 && /// backspace o retroceso
                codigo != 13 && /// enter
                codigo != 22 && /// ctrl+V
                codigo != 24 && /// ctrl+X
                codigo != 25 && /// ctrl+Y
                codigo != 26 &&/// ctrl+Z
                codigo != 45 /// -
                )
            {
                return 0;
            }
            else
            {
                return codigo;
            }
        }

        public static int Telefonos(int codigo)
        {
            if (
                (codigo < 48 || codigo > 57) && /// numeros "0 al 9"
                codigo != 1 && /// ctrl+A
                codigo != 3 && /// ctrl+C
                codigo != 5 && /// ctrl+E
                codigo != 8 && /// backspace o retroceso
                codigo != 13 && /// enter
                codigo != 22 && /// ctrl+V
                codigo != 24 && /// ctrl+X
                codigo != 25 && /// ctrl+Y
                codigo != 26 && /// ctrl+Z
                codigo != 32 && /// espacio
                codigo != 40 && /// (
                codigo != 41 && /// )
                codigo != 43 && /// +
                codigo != 45 /// -
                )
            {
                return 0;
            }
            else
            {
                return codigo;
            }
        }

        public static int DecimalesPunto(int codigo)
        {
            if (
                (codigo < 48 || codigo > 57) && /// numeros "0 al 9"
                codigo != 1 && /// ctrl+A
                codigo != 3 && /// ctrl+C
                codigo != 5 && /// ctrl+E
                codigo != 8 && /// backspace o retroceso
                codigo != 13 && /// enter
                codigo != 22 && /// ctrl+V
                codigo != 24 && /// ctrl+X
                codigo != 25 && /// ctrl+Y
                codigo != 26 && /// ctrl+Z
                codigo != 46 /// punto "."
                )
            {
                return 0;
            }
            else
            {
                return codigo;
            }
        }

        public static bool UnSoloPunto(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public static bool SignoNegativo(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar == (char)Keys.OemMinus) && ((sender as TextBox).Text.IndexOf('-') > -1))
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
