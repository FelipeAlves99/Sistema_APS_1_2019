using APS_1_2019.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                if (File.Exists("ConfiguracaoArduino.txt"))
                {
                    StreamReader arquivo = new StreamReader("ConfiguracaoArduino.txt");
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
                    File.Create("ConfiguracaoArduino.txt");
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
                txtPath.Enabled = false;
                txtPorta.Enabled = false;
            }
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if(btnEditar.Text == "Editar")
            {
                txtBaud.Enabled = true;
                txtPath.Enabled = true;
                txtPorta.Enabled = true;
                btnEditar.Text = "Salvar";
                btnCancelar.Visible = true;
            }
            else
            {
                try
                {
                    StreamWriter arquivo = new StreamWriter("ConfiguracaoArduino.txt", false);
                    arquivo.WriteLine(txtPorta.Text);
                    arquivo.WriteLine(txtBaud.Text);
                    arquivo.WriteLine(txtPath.Text);
                    arquivo.Close();

                    MessageBox.Show("Arquivo atualizado com sucesso.", "Atualizado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    btnCancelar.Visible = false;
                    btnEditar.Text = "Editar";
                    txtBaud.Enabled = false;
                    txtPath.Enabled = false;
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
