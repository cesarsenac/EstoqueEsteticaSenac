using System;
using System.Windows.Forms;
using EstoqueEsteticaSenac.Forms;

namespace EstoqueEsteticaSenac
{
    public partial class Splash : Form
    {
        int contador = 100;
        public Splash()
        {
            InitializeComponent();
            timerSplash.Start();
        }

        private void timerSplash_Tick(object sender, EventArgs e)
        {
            if (contador != 0)
            {
                contador--;
                if (contador > 90)
                {
                    label1.Text = "Checando conexões de rede...";
                }
                else if (contador < 80 && contador > 60)
                {
                    label1.Text = "Conectando ao Banco de Dados...";
                }
                else if (contador < 40 && contador > 30)
                {
                    label1.Text = "Listando Dados...";
                }
                else if (contador < 20)
                {
                    label1.Text = "Carregando Interface...";
                }
            }
            else
            {
                timerSplash.Stop();
                FormLogin f = new FormLogin();
                f.Show();
                this.Hide();
            }
        }
    }
}
