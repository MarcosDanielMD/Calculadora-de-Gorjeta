using System.ComponentModel;

namespace CalculardoraGorjeta_MarcosDaniel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MessageBox.Show("Bem vindo a calculadora de gorjeta!");
            MessageBox.Show("Clique na imagem do item que consumiu e informe a gorjeta."); //Breve mensagem ensinando o usu�rio a como funcionar� o programa
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            groupBoxFeijoada.Visible = true; //Ao clicar na imagem, aparecer�o mais informa��es sobre o produto 
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            groupBoxHamburguer.Visible = true; //Ao clicar na imagem, aparecer�o mais informa��es sobre o produto
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            groupBoxBoloChoco.Visible = true; //Ao clicar na imagem, aparecer�o mais informa��es sobre o produto
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            buttonCalcular.Enabled = false; //desativa o bot�o de enviar, assim o us�rio n�o consegue quebrar o programa

            groupBoxTotal.Visible = true; //Mostra o grupo onde o resultado final aparece.

            textBoxValorConta.Text = Convert.ToString(Quantidade.valor);

            if (radioButton10.Checked)
            {
                Quantidade.valor *= 0.10; //pega 10% do valor final
            }

            if (radioButton15.Checked)
            {
                Quantidade.valor *= 0.15; //pega 15% do valor final
            }

            if (radioButton20.Checked)
            {
                Quantidade.valor *= 0.20; //pega 20% do valor final
            }
            if (radioButton30.Checked)
            {
                Quantidade.valor *= 0.30; //pega 30% do valor final
            }
            if (radioButton40.Checked)
            {

                Quantidade.valor *= 0.40; //pega 40% do valor final
            }
            if (radioButton50.Checked)
            {

                Quantidade.valor *= 0.50; //pega 50% do valor final
            }


            if (checkBoxTaxaServico.Checked)
            {
                double taxaServico = Quantidade.valor * 0.1;
                // caso a taxa de servi�o seja marcada, o programa realizar� o c�culo e adicionar� ao valor final
            }

            if (checkBoxDividirConta.Checked)
            {
                int numPessoas = (int)numericUpDownPessoas.Value;
                Quantidade.valor /= numPessoas; //o programa tamb�m ir� calcular a quantidade de pessoas que est�o usando o servi�o e destribuir� o valor da gorjeta para cada pessoa
            }

            labelValorTotal.Text = Quantidade.valor.ToString("C"); //retornar� o valor final a label dentro do grupo final
        }

        private void checkBoxDividirConta_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxDividirConta.Checked)
            {
                numericUpDownPessoas.Visible = true; //caso a checkbox seja selecionada, a caixa num�rica aparece
                labelPessoas.Visible = true;

            }
            else
            {
                numericUpDownPessoas.Visible = false; //se a ciaxa n�o estiver selecionada, ent�o a caixa num�rica n�o aparecer�
                labelPessoas.Visible = false;

            }
        }

        private void buttonFeijoada_Click(object sender, EventArgs e)
        {
            int valorQuant = (int)numericUpDownFeijoada.Value; //pega o valor da caixa num�rica quantidade

            int valorSubTotal = valorQuant * 45; //multiplica com o valor pr�-definido.


            Quantidade.valor += valorSubTotal; //retorna ao valor final

            textBoxValorConta.Text = Quantidade.valor.ToString("C");
        }

        private void buttonComprarHb_Click(object sender, EventArgs e)
        {
            int valorQuant = (int)numericUpDownHamburguer.Value;

            int valorSubTotal = valorQuant * 30;

            Quantidade.valor += valorSubTotal;

            textBoxValorConta.Text = Quantidade.valor.ToString("C");
        }

        private void buttonBolo_Click(object sender, EventArgs e)
        {
            int valorQuant = (int)numericUpDownBoloChoco.Value;

            int valorSubTotal = valorQuant * 30;

            Quantidade.valor += valorSubTotal;

            textBoxValorConta.Text = Quantidade.valor.ToString("C");
        }


        private void buttonReset_Click(object sender, EventArgs e)
        {
            textBoxValorConta.Text = ""; //apaga todas as informa��es das caixas.
            numericUpDownBoloChoco.Text = "";
            numericUpDownFeijoada.Text = "";
            numericUpDownHamburguer.Text = "";
            labelValorTotal.Text = "";
            numericUpDownPessoas.Text = "";
            Quantidade.valor = 0;
            groupBoxTotal.Visible = false; //desativa a visibilidade da caixa que mostra o resultado final
            buttonCalcular.Enabled = true; //reativa do bot�o de enviar
        }

        private void Sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //informa��o extra: as caixas num�ricas est�o limitadas a apenas 10 pedidos por vez
    }
}

