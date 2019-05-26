using System;
using System.IO;
using System.IO.Ports;

namespace APS_1_2019.Modelo
{
    public class PortaSerial : absPropriedades
    {

        public new void Executar()
        {
            this.mensagem = "";
            Configuracao config = new Configuracao();
            SerialPort arduinoData = new SerialPort();

            try
            {
                arduinoData.BaudRate = Configuracao.freqBaud;
                arduinoData.PortName = Configuracao.nomePorta; //pega as configurações necessárias para ler a porta serial.
                arduinoData.Open();

                this.dados = arduinoData.ReadLine();

                string[] arduinoInfo = this.dados.Split(new char[0], StringSplitOptions.RemoveEmptyEntries); //separa as informações da linha da porta serial em um vetor

                this.temperatura = arduinoInfo[0];
                this.umidade = arduinoInfo[1];
                this.resistChuva = Double.Parse(arduinoInfo[2]);


                //Define a saída que irá ter conforme se molha o sensor de chuva.
                if(resistChuva < 200)
                {
                    EstadoChuva = "Golden Shower!!!";
                }
                else if(resistChuva < 500)
                {
                    EstadoChuva = "Chuva Forte";
                }
                else if (resistChuva < 800)
                {
                    EstadoChuva = "Chuva Fraca";
                }
                else
                {
                    EstadoChuva = "Sem chuva";
                }

                arduinoData.Close();
            }
            catch (IOException)
            {
                this.mensagem = "A porta serial " + Configuracao.nomePorta + " não pode ser acessada. Talvez a porta de entrada esteja errada.";
            }
            catch (Exception e)
            {
                this.mensagem = e.Message;
            }
        }

        public PortaSerial()
        {
            Executar();
        }
    }
}
