using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_Classe
{
    public class Calculadora
    {
        public decimal Valor1 { get; set; }
        public decimal Valor2 { get; set; }
        public decimal Resultado { get; set; }
        public char Operacao { get; set; }

        private void Somar()
        {
            Resultado = Valor1 + Valor2;
        }
        private void Subtrair()
        {
            Resultado = Valor1 - Valor2;
        }
        private void Dividir()
        {
            Resultado = Valor1 / Valor2;
        }
        private void Multiplicar()
        {
            Resultado = Valor1 * Valor2;
        }

        public void Calcular()
        {
            if (Operacao == '+')
            {
                Somar();
            }
            else if (Operacao == '-')
            {
                Subtrair();
            }
            else if (Operacao == '/') 
            {
                Dividir();
            }
            else if (Operacao == '*')
            {
                Multiplicar();
            }       
        }
    }
}
