using APS_1_2019.Modelo;
using System;
using System.IO;
using System.Windows.Forms;

namespace APS_1_2019.Apresentacao
{
    public partial class frmConfiguracao : Form
    {
        

        public frmConfiguracao()
        {
            InitializeComponent();
        }

        private void FrmConfiguracao_Load(object sender, EventArgs e)
        {
            try
            {
                if (!Directory.Exists(Configuracao.caminhoDoc))
                {
                    DirectoryInfo di = Directory.CreateDirectory(Configuracao.caminhoDoc);
                    MessageBox.Show("Um novo diretório foi criado para seu programa!\nCaminho: " + Configuracao.caminhoDoc, "Criação de diretório", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                if (File.Exists(Configuracao.caminhoDoc + @"\ConfiguracaoArduino.txt"))
                {
                    StreamReader arquivo = new StreamReader(Configuracao.caminhoDoc + @"\ConfiguracaoArduino.txt");
                    txtPorta.Text = arquivo.ReadLine();
                    txtBaud.Text = arquivo.ReadLine();
                    txtPath.Text = arquivo.ReadLine();
                    arquivo.Close();

                    Configuracao config = new Configuracao();
                    config.Executar();
                    txtPorta.Text = Configuracao.nomePorta;
                    txtBaud.Text = Convert.ToString(Configuracao.freqBaud);
                    txtPath.Text = Configuracao.caminhoDoc;
                }
                else
                {
                    txtPath.Text = Configuracao.caminhoDoc;
                    //File.Create(Configuracao.caminhoDoc + @"\ConfiguracaoArduino.txt"); será feito no botão editar/salvar
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            if(btnEditar.Text == "Salvar")
            {
                btnCancelar.Visible = false;
                btnEditar.Text = "Editar";
                txtBaud.Enabled = false;
                txtPorta.Enabled = false;
            }
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if(btnEditar.Text == "Editar")
            {
                txtBaud.Enabled = true;
                txtPorta.Enabled = true;
                btnEditar.Text = "Salvar";
                btnCancelar.Visible = true;
            }
            else
            {
                try
                {
                    StreamWriter arquivo = new StreamWriter(Configuracao.caminhoDoc + @"\ConfiguracaoArduino.txt", false);
                    arquivo.WriteLine(txtPorta.Text);
                    arquivo.WriteLine(txtBaud.Text);
                    arquivo.WriteLine(txtPath.Text);
                    arquivo.Close();

                    MessageBox.Show("Arquivo atualizado com sucesso.", "Atualizado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    btnCancelar.Visible = false;
                    btnEditar.Text = "Editar";
                    txtBaud.Enabled = false;
                    txtPorta.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
