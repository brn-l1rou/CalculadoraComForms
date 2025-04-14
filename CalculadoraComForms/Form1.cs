namespace CalculadoraComForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int operacao;

        private void Um_Click(object sender, EventArgs e)
        {
            CaixadeTexto.Text = CaixadeTexto.Text + 1;
        }

        private void Dois_Click(object sender, EventArgs e)
        {
            CaixadeTexto.Text = CaixadeTexto.Text + 2;
        }

        private void Tres_Click(object sender, EventArgs e)
        {
            CaixadeTexto.Text = CaixadeTexto.Text + 3;
        }

        private void Quatro_Click(object sender, EventArgs e)
        {
            CaixadeTexto.Text = CaixadeTexto.Text + 4;
        }

        private void Cinco_Click(object sender, EventArgs e)
        {
            CaixadeTexto.Text = CaixadeTexto.Text + 5;
        }

        private void Seis_Click(object sender, EventArgs e)
        {
            CaixadeTexto.Text = CaixadeTexto.Text + 6;
        }

        private void Sete_Click(object sender, EventArgs e)
        {
            CaixadeTexto.Text = CaixadeTexto.Text + 7;
        }

        private void Oito_Click(object sender, EventArgs e)
        {
            CaixadeTexto.Text = CaixadeTexto.Text + 8;
        }

        private void Nove_Click(object sender, EventArgs e)
        {
            CaixadeTexto.Text = CaixadeTexto.Text + 9;
        }
        private void Zero_Click(object sender, EventArgs e)
        {
            CaixadeTexto.Text = CaixadeTexto.Text + 0;
        }

        private void Clear_Click(object sender, EventArgs e)
        {
           CaixadeTexto.Clear();
           LabelOperador.Text = "Operação sendo realizada: ";
           operacao = 0;
        }

        private void Virgula_Click(object sender, EventArgs e)
        {
            int c = CaixadeTexto.TextLength;
            bool flag = false;
            for (int i = 0; i < c; i++)
            {
                if (CaixadeTexto.Text[i].ToString() == ",")
                {
                    flag = true;
                    break;
                }
            }
            if (!flag)
            {
                CaixadeTexto.Text = CaixadeTexto.Text + ",";
            }
        }

        private float primeiroNumero;
        private bool segundoNumeroDigitado = false;
        
        private void Divisao_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(CaixadeTexto.Text))
            {
                primeiroNumero = float.Parse(CaixadeTexto.Text);
                operacao = 4;
                LabelOperador.Text = LabelOperador.Text + "Divisão";
                CaixadeTexto.Clear();
                segundoNumeroDigitado = true;
            }
        }

        private void Multi_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(CaixadeTexto.Text))
            {
                primeiroNumero = float.Parse(CaixadeTexto.Text);
                operacao = 3;
                LabelOperador.Text = LabelOperador.Text + "Multiplicação";
                CaixadeTexto.Clear();
                segundoNumeroDigitado = true;
            }
        }

        private void Soma_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(CaixadeTexto.Text))
            {
                primeiroNumero = float.Parse(CaixadeTexto.Text);
                operacao = 2;
                LabelOperador.Text = LabelOperador.Text + "Soma";
                CaixadeTexto.Clear();
                segundoNumeroDigitado = true;
            }
        }

        private void Sub_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(CaixadeTexto.Text))
            {
                CaixadeTexto.Text = "-";
            }
            else
            {
                primeiroNumero = float.Parse(CaixadeTexto.Text);
                operacao = 1;
                LabelOperador.Text = LabelOperador.Text + "Subtração";
                CaixadeTexto.Clear();
                segundoNumeroDigitado = true;
            }
        }
        
        private void Igual_Click(object sender, EventArgs e)
        {
            if(segundoNumeroDigitado && !string.IsNullOrEmpty(CaixadeTexto.Text))
            {
                float segundoNumero = float.Parse(CaixadeTexto.Text);
                float resultado = 0;

                switch (operacao)
                {
                    case 1:
                    resultado = primeiroNumero - segundoNumero;
                    break;

                    case 2:
                    resultado = primeiroNumero + segundoNumero;
                    break;

                    case 3:
                    resultado = primeiroNumero * segundoNumero;
                    break;

                    case 4:
                    if(segundoNumero != 0)
                    {
                        resultado = primeiroNumero / segundoNumero;
                    }
                    else
                    {
                        CaixadeTexto.Text = "!divisão por zero";
                        return;
                    }
                    break;

                    default:
                    break;
                }
                CaixadeTexto.Text = resultado.ToString();
                LabelOperador.Text = "Operação sendo realizada: ";
                segundoNumeroDigitado = false;
            }
        }
    }
}
