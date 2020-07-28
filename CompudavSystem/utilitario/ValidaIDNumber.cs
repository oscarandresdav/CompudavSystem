namespace CompudavSystem.utilitario
{
    public static class ValidaIDNumber
    {
        public static bool VerificaIdentificacion(string identificacion)
        {
            bool estado = false;
            _ = new char[13];
            int provincia;

            if (identificacion.Length >= 10)
            {
                char[] valId = identificacion.Trim().ToCharArray();
                provincia = int.Parse(valId[0].ToString() + valId[1].ToString());

                if (provincia > 0 && provincia < 25)
                {
                    if (int.Parse(valId[2].ToString()) < 6)
                    {
                        estado = Cedula(valId);
                    }
                    else if (int.Parse(valId[2].ToString()) == 6)
                    {
                        estado = Publico(valId);
                    }
                    else if (int.Parse(valId[2].ToString()) == 9)
                    {
                        estado = Juridica(valId);
                    }
                }
            }

            return estado;
        }

        private static bool Cedula(char[] validarIdentificacion)
        {
            int aux = 0, par = 0, impar = 0, digitoVerificador;

            for (int i = 0; i < 9; i += 2)
            {
                aux = 2 * int.Parse(validarIdentificacion[i].ToString());
                if (aux > 9)
                {
                    aux -= 9;
                }
                par += aux;
            }
            for (int i = 1; i < 9; i += 2)
            {
                impar += int.Parse(validarIdentificacion[i].ToString());
            }
            aux = par + impar;
            if (aux % 10 != 0)
            {
                digitoVerificador = 10 - (aux % 10);
            }
            else
            {
                digitoVerificador = 0;
            }

            if (digitoVerificador == int.Parse(validarIdentificacion[9].ToString()))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static bool Publico(char[] validarIdentificacion)
        {
            int aux = 0, producto, digitoVerificador;
            digitoVerificador = int.Parse(validarIdentificacion[9].ToString()) + int.Parse(validarIdentificacion[10].ToString()) + int.Parse(validarIdentificacion[11].ToString()) + int.Parse(validarIdentificacion[12].ToString());
            if (digitoVerificador > 0)
            {
                int[] coeficiente = new int[8] { 3, 2, 7, 6, 5, 4, 3, 2 };

                for (int i = 0; i < 8; i++)
                {
                    producto = int.Parse(validarIdentificacion[i].ToString()) * coeficiente[i];
                    aux += producto;
                }

                if (aux % 11 == 0)
                {
                    digitoVerificador = 0;
                }
                else if (aux % 11 == 1)
                {
                    return false;
                }
                else
                {
                    aux %= 11;
                    digitoVerificador = 11 - aux;
                }

                if (digitoVerificador == int.Parse(validarIdentificacion[8].ToString()))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        private static bool Juridica(char[] validarIdentificacion)
        {
            int aux = 0, producto, digitoVerificador;

            digitoVerificador = int.Parse(validarIdentificacion[10].ToString()) + int.Parse(validarIdentificacion[11].ToString()) + int.Parse(validarIdentificacion[12].ToString());

            if (digitoVerificador > 0)
            {
                int[] coeficiente = new int[9] { 4, 3, 2, 7, 6, 5, 4, 3, 2 };
                for (int i = 0; i < 9; i++)
                {
                    producto = int.Parse(validarIdentificacion[i].ToString()) * coeficiente[i];
                    aux += producto;
                }
                if (aux % 11 == 0)
                {
                    digitoVerificador = 0;
                }
                else if (aux % 11 == 1)
                {
                    return false;
                }
                else
                {
                    aux %= 11;
                    digitoVerificador = 11 - aux;
                }
                if (digitoVerificador == int.Parse(validarIdentificacion[9].ToString()))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }

}
