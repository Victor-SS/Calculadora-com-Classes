using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_Classe
{
    public partial class frmCalculadoraClasse : Form
    {
        public frmCalculadoraClasse()
        {
            InitializeComponent();
        }
        Calculadora calculadora = new Calculadora();
        private void PreencherOperacao(char operacao)
        {
            calculadora.Operacao = operacao;
            if (operacao == '+')
            {
                txtOperacao.Text = "Somar";
            }
            else if (operacao == '-')
            {
                txtOperacao.Text = "Subtrair";
            }
            else if (operacao == '/')
            {
                txtOperacao.Text = "Dividir";
            }
            else if (operacao == '*')
            {
                txtOperacao.Text = "Multiplicar";
            }
        }
        private void PreencherClasse()
        {
            calculadora.Valor1 = decimal.Parse(txtValor1.Text);
            calculadora.Valor2 = decimal.Parse(txtValor2.Text);
        }
        private string ValidarPreenchimento()
        {
            string msgErro = string.Empty;

            if (txtValor1.Text == string.Empty)
            {
                msgErro = "Campo VALOR 1 em branco!\n";
            }          
            if (txtValor2.Text == string.Empty)
            {
                msgErro += "Campo VALOR 2 em branco!\n";
            }          
            if (txtOperacao.Text == string.Empty)
            {
                msgErro += "Selecione a OPERAÇÃO!\n";
            }
            else if(decimal.Parse(txtValor2.Text) == 0 && 
                calculadora.Operacao == '/')
            {
                msgErro += "Não é possível dividir por zero!\n";
            }

            return msgErro;
        }
        private void btnMais_Click(object sender, EventArgs e)
        {
            PreencherOperacao('+');
        }
        private void btnMenos_Click(object sender, EventArgs e)
        {
            PreencherOperacao('-');
        }
        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            PreencherOperacao('*');
        }
        private void btnDividir_Click(object sender, EventArgs e)
        {
            PreencherOperacao('/');
        }
        private void txtValor1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Global.SomenteNumeros(e.KeyChar, txtValor1.Text, ",");
        }
        private void txtValor2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = Global.SomenteNumeros(e.KeyChar, txtValor2.Text, ",");
        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string mensagem = ValidarPreenchimento();
            if(mensagem != string.Empty)
            {
                MessageBox.Show(mensagem, "Erro de Preenchimento!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            PreencherClasse();
            calculadora.Calcular();
            txtResultado.Text = calculadora.Resultado.ToString();
        }
        private void LimparCampos()
        {
            calculadora = new Calculadora();
            txtValor1.Clear();
            txtValor2.Clear();
            txtOperacao.Clear();
            txtResultado.Clear();
            txtValor1.Focus();
        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }
    }
}
