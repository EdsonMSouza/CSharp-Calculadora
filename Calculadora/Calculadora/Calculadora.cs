using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class frmCalculadora : Form
    {
        public frmCalculadora()
        {
            InitializeComponent();
        }

        

        private void btAdicao_Click(object sender, EventArgs e)
        {
            /* Declarando as variáveis para manipular os valores e o resultado */
            int valor1 = 0;
            int valor2 = 0;
            int resultado = 0;

            /* Recuperando o valor digitado nas caixas de texto, convertendo para inteiro e atribuindo às variáveis valor1 e valor2.
             * Neste procedimento existe um Tratamento de Erros realizado pela estrutura:
             * 
             * try{
             *      Tenta realizar a operação e, caso não consiga envia para o bloco a seguir
             * }
             * catch (FormatException fe)
             * {
             *      Aqui você pode exibir uma mensagem personalizada, ou então usar a variável "fe" para apresentar o erro
             * }
            */
            try
            {
                valor1 = Convert.ToInt32(txtValor1.Text);
                valor2 = Convert.ToInt32(txtValor2.Text);

                /* Realizando a operação*/
                resultado = (valor1 + valor2);

                /* Exibindo resultado em uma caixa de Mensagem */
                /* O primeiro parâmetro é o valor ser mostrado no Corpo da caixa e o segundo o Título*/
                MessageBox.Show(resultado.ToString(), "Resultado da Operação");

                /* Uma opção mais elabora pode ser vista no código a seguir, após clicar em OK na caixa anterior */
                String textoResultado = "A soma entre (" + txtValor1.Text + " e " + txtValor2.Text + ") é = ";
                MessageBox.Show(textoResultado + resultado.ToString(), "Resultado da Operação");
            }
            catch (FormatException fe)
            {
                MessageBox.Show("Os valores devem ser números Inteiros!\n" + fe.Message, "ATENÇÃO");
            }
        }

        private void btSubtracao_Click(object sender, EventArgs e)
        {
            /* Declarando as variáveis para manipular os valores e o resultado */
            int valor1 = 0;
            int valor2 = 0;
            int resultado = 0;

            /* Recuperando o valor digitado nas caixas de texto, convertendo para inteiro e atribuindo às variáveis valor1 e valor2.
             * Neste procedimento existe um Tratamento de Erros realizado pela estrutura:
             * 
             * try{
             *      Tenta realizar a operação e, caso não consiga envia para o bloco a seguir
             * }
             * catch (FormatException fe)
             * {
             *      Aqui você pode exibir uma mensagem personalizada, ou então usar a variável "fe" para apresentar o erro
             * }
            */
            try
            {
                valor1 = Convert.ToInt32(txtValor1.Text);
                valor2 = Convert.ToInt32(txtValor2.Text);

                /* Realizando a operação*/
                resultado = (valor1 - valor2);

                /* Exibindo resultado em uma caixa de Mensagem */
                /* O primeiro parâmetro é o valor ser mostrado no Corpo da caixa e o segundo o Título*/
                MessageBox.Show(resultado.ToString(), "Resultado da Operação");
            }
            catch (FormatException fe)
            {
                MessageBox.Show("Os valores devem ser números Inteiros!\n" + fe.Message, "ATENÇÃO");
            }
        }

        private void btMultiplicacao_Click(object sender, EventArgs e)
        {
            /* Declarando as variáveis para manipular os valores e o resultado */
            int valor1 = 0;
            int valor2 = 0;
            int resultado = 0;

            /* Recuperando o valor digitado nas caixas de texto, convertendo para inteiro e atribuindo às variáveis valor1 e valor2.
             * Neste procedimento existe um Tratamento de Erros realizado pela estrutura:
             * 
             * try{
             *      Tenta realizar a operação e, caso não consiga envia para o bloco a seguir
             * }
             * catch (FormatException fe)
             * {
             *      Aqui você pode exibir uma mensagem personalizada, ou então usar a variável "fe" para apresentar o erro
             * }
            */
            try
            {
                valor1 = Convert.ToInt32(txtValor1.Text);
                valor2 = Convert.ToInt32(txtValor2.Text);

                /* Realizando a operação*/
                resultado = (valor1 * valor2);

                /* Exibindo resultado em uma caixa de Mensagem */
                /* O primeiro parâmetro é o valor ser mostrado no Corpo da caixa e o segundo o Título*/
                MessageBox.Show(resultado.ToString(), "Resultado da Operação");
            }
            catch (FormatException fe)
            {
                MessageBox.Show("Os valores devem ser números Inteiros!\n" + fe.Message, "ATENÇÃO");
            }
        }

        private void btDivisao_Click(object sender, EventArgs e)
        {
            /* Declarando as variáveis para manipular os valores e o resultado */
            double valor1 = 0;
            double valor2 = 0;
            double resultado = 0;

            /* Recuperando o valor digitado nas caixas de texto, convertendo para inteiro e atribuindo às variáveis valor1 e valor2.
             * Neste procedimento existe um Tratamento de Erros realizado pela estrutura:
             * 
             * try{
             *      Tenta realizar a operação e, caso não consiga envia para o bloco a seguir
             * }
             * catch (FormatException fe)
             * {
             *      Aqui você pode exibir uma mensagem personalizada, ou então usar a variável "fe" para apresentar o erro
             * }
            */
            try
            {
                valor1 = Convert.ToDouble(txtValor1.Text);
                valor2 = Convert.ToDouble(txtValor2.Text);

                /* Realizando a operação*/
                resultado = (valor1 / valor2);

                /* Exibindo resultado em uma caixa de Mensagem */
                /* O primeiro parâmetro é o valor ser mostrado no Corpo da caixa e o segundo o Título*/
                MessageBox.Show(resultado.ToString(), "Resultado da Operação");
            }
            catch (FormatException fe)
            {
                MessageBox.Show(fe.Message, "ATENÇÃO");
            }
        }
    }
}
