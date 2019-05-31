using System;
using System.Windows.Forms;
using APS_1_2019.Modelo;
using APS_1_2019.Apresentacao;
using System.IO;

namespace APS_1_2019
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }


        private void BtnChecar_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            if (controle.mensagem.Equals(""))
            {
                lblTemperatura.Text = controle.Temperatura;
                lblUmidade.Text = controle.Umidade;
                lblChuva.Text = controle.EstadoChuva;
            }
            else
            {
                MessageBox.Show(controle.mensagem, "Erro de leitura", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnConfig_Click(object sender, EventArgs e)
        {
            frmConfiguracao config = new frmConfiguracao();
            TimerArduino.Stop();
            config.ShowDialog();            
        }

        private void TimerArduino_Tick(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            if (controle.mensagem.Equals(""))
            {
                lblTemperatura.Text = controle.Temperatura;
                lblUmidade.Text = controle.Umidade;
                lblChuva.Text = controle.EstadoChuva;
            }
            else
            {
                MessageBox.Show(controle.mensagem, "Erro de leitura", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            if (File.Exists(@"ConfiguracaoArduino.txt"))
            {
                TimerArduino.Start();
                Configuracao config = new Configuracao();
                config.Executar();              
            }
            else
            {
                frmConfiguracao frmC = new frmConfiguracao();
                frmC.ShowDialog();
                Configuracao config = new Configuracao();
            }
        }
    }
}
