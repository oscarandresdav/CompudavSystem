using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompudavSystem.utilitario
{
    public static class Validaciones
    {
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
    }
}
