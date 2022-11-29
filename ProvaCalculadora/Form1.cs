namespace ProvaCalculadora
{
    public partial class Form1 : Form
    {
        Calculadora funcaoCalculadora = new Calculadora();
        public Form1()
        {
            InitializeComponent();
        }

        private void botao1_Click(object sender, EventArgs e)
        {
            caixaTexto.Text = caixaTexto.Text + botao1.Text;
        }

        private void botao2_Click(object sender, EventArgs e)
        {
            caixaTexto.Text = caixaTexto.Text + botao2.Text;
        }

        private void botao3_Click(object sender, EventArgs e)
        {
            caixaTexto.Text = caixaTexto.Text + botao3.Text;
        }

        private void botao4_Click(object sender, EventArgs e)
        {
            caixaTexto.Text = caixaTexto.Text + botao4.Text;
        }

        private void botao5_Click(object sender, EventArgs e)
        {
            caixaTexto.Text = caixaTexto.Text + botao5.Text;
        }

        private void botao6_Click(object sender, EventArgs e)
        {
            caixaTexto.Text = caixaTexto.Text + botao6.Text;
        }

        private void botao7_Click(object sender, EventArgs e)
        {
            caixaTexto.Text = caixaTexto.Text + botao7.Text;
        }

        private void botao8_Click(object sender, EventArgs e)
        {
            caixaTexto.Text = caixaTexto.Text + botao8.Text;
        }

        private void botao9_Click(object sender, EventArgs e)
        {
            caixaTexto.Text = caixaTexto.Text + botao9.Text;
        }

        private void botao0_Click(object sender, EventArgs e)
        {
            caixaTexto.Text = caixaTexto.Text + botao0.Text;
        }

        private void botaoLimpar_Click(object sender, EventArgs e)
        {
            caixaTexto.Text = "";
        }

        private void botaoVirgula_Click(object sender, EventArgs e)
        {
            caixaTexto.Text = caixaTexto.Text + botaoVirgula.Text;
        }

        private void botaoSoma_Click(object sender, EventArgs e)
        {
            labelOperacao.Text = botaoSoma.Text;
            funcaoCalculadora.Setelemento1(double.Parse(caixaTexto.Text));
            funcaoCalculadora.Setoperacao("+");
            caixaTexto.Text = "";
        }

        private void caixaTexto_TextChanged(object sender, EventArgs e)
        {
        }

        private void botaoIgual_Click(object sender, EventArgs e)
        {
            labelOperacao.Text = "";
            funcaoCalculadora.Setelemento2(double.Parse(caixaTexto.Text));
            caixaTexto.Text = funcaoCalculadora.executarOperacao().ToString();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void botaoMenos_Click(object sender, EventArgs e)
        {
            labelOperacao.Text = botaoMenos.Text;
            funcaoCalculadora.Setelemento1(double.Parse(caixaTexto.Text));
            funcaoCalculadora.Setoperacao(botaoMenos.Text);
            caixaTexto.Text = "";
        }

        private void botaoVezes_Click(object sender, EventArgs e)
        {
            labelOperacao.Text = botaoVezes.Text;
            funcaoCalculadora.Setelemento1(double.Parse(caixaTexto.Text));
            funcaoCalculadora.Setoperacao("*");
            caixaTexto.Text = "";
        }

        private void botaoDivisor_Click(object sender, EventArgs e)
        {
            labelOperacao.Text = botaoDivisor.Text;
            funcaoCalculadora.Setelemento1(double.Parse(caixaTexto.Text));
            funcaoCalculadora.Setoperacao("/");
            caixaTexto.Text = "";
        }
    }
}