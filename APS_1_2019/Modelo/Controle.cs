using Newtonsoft.Json;
using System;
using System.IO;

namespace APS_1_2019.Modelo
{
    public class Controle : absPropriedades
    {

        public new void Executar()
        {
            try
            {
                this.mensagem = "";
                PortaSerial serial = new PortaSerial(); //puxa os dados do arduino
                if (serial.mensagem.Equals(""))
                {
                    DadosJSON dadosArduino = new DadosJSON()
                    {
                        Temperatura = serial.Temperatura,
                        Umidade = serial.Umidade,           //salva os dados que serão utilizados no arquivo .JSON
                        EstadoChuva = serial.EstadoChuva
                    };

                    string dadosJSON = JsonConvert.SerializeObject(dadosArduino);
                    File.WriteAllText(path: Configuracao.caminhoDoc + @"\dadosArduino.json", contents: dadosJSON); //cria o arquivo .JSON que será utilizado pelo site

                    this.temperatura = serial.Temperatura;
                    this.umidade = serial.Umidade;          //puxa os dados da Porta Serial que será mostrado no formulário.
                    this.estadoChuva = serial.EstadoChuva;
                }
                else
                {
                    this.mensagem = serial.mensagem;
                }
            }
            catch(DirectoryNotFoundException)
            {
                this.mensagem = "Diretório " + Configuracao.caminhoDoc + " não foi encontrado ou não pode ser acessado.";
            }
            catch(IOException)
            {
                this.mensagem = "A porta serial " + Configuracao.nomePorta + " não pode ser acessada. Talvez a porta de entrada esteja errada.";
            }
            catch (Exception e)
            {
                this.mensagem = e.Message;
            }
        }

        public Controle()
        {
            Executar();
        }
    }
}
