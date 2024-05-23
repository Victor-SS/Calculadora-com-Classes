using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_Classe
{
    public static class Global
    {
        public static bool SomenteNumeros(char tecla, string texto, string excecao)
        {
            if((!char.IsDigit(tecla) &&
                tecla != (char)Keys.Back
                && excecao.IndexOf(tecla) == -1)
                || (excecao.IndexOf(tecla) != -1 &&
                texto.IndexOf(excecao) != -1))
            {
                return true;
            }
            return false;
        }
    }
}
