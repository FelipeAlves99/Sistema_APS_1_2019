using System;
using System.IO;
using System.IO.Ports;

namespace APS_1_2019.Modelo
{
    public class PortaSerial : absPropriedades
    {

        public void Executar()
        {
            this.mensagem = "";
            SerialPort arduinoData = new SerialPort();

            try
            {
                //pega as configurações necessárias para ler a porta serial e começa sua leitura.
                arduinoData.BaudRate = Configuracao.freqBaud;
                arduinoData.PortName = Configuracao.nomePorta;
                arduinoData.Open();

                //coloca os dados vindos da porta serial e os guarda em uma array
                this.dados = arduinoData.ReadLine();
                string[] arduinoInfo = this.dados.Split(new char[0], StringSplitOptions.RemoveEmptyEntries); //separa as informações da linha da porta serial em um vetor

                //guarda os dados vindos da porta serial
                this.temperatura = arduinoInfo[0];
                this.umidade = arduinoInfo[1];
                this.resistChuva = Double.Parse(arduinoInfo[2]);

                //faz a analise da resistencia da chuva e transforma em um texto informativo
                ValidacaoChuva validarChuva = new ValidacaoChuva();
                validarChuva.LeituraChuva(resistChuva);
                this.EstadoChuva = validarChuva.EstadoChuva;
                
                //fecha a conexão para a porta parar de ser utilizada
                arduinoData.Close();
            }
            catch (IOException e)
            {
                this.mensagem = "A porta serial " + Configuracao.nomePorta + " não pode ser acessada. Talvez a porta de entrada esteja errada. Mensagem: " + e.Message;
            }
            catch (Exception e)
            {
                this.mensagem = "Classe PortaSerial " + e.Message;
            }
        }

        public PortaSerial()
        {
            Executar();
        }
    }
}
