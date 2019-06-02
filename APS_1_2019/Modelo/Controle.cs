using Newtonsoft.Json;
using System;
using System.IO;

namespace APS_1_2019.Modelo
{
    public class Controle : absPropriedades
    {

        public void Executar()
        {
            try
            {
                this.mensagem = "";
                PortaSerial serial = new PortaSerial(); 

                if (serial.mensagem.Equals(""))
                {
                    //salva os dados que serão utilizados no arquivo .JSON
                    DadosJSON dadosArduino = new DadosJSON()
                    {
                        Temperatura = serial.Temperatura,
                        Umidade = serial.Umidade,           
                        EstadoChuva = serial.EstadoChuva
                    };

                    //realiza a criação do arquivo JSON
                    string dadosJSON = JsonConvert.SerializeObject(dadosArduino);
                    File.WriteAllText(path: Configuracao.caminhoDoc + @"\dataArduino.json", contents: dadosJSON);

                    //puxa os dados da Porta Serial que será mostrado no formulário.
                    this.temperatura = serial.Temperatura;
                    this.umidade = serial.Umidade;          
                    this.estadoChuva = serial.EstadoChuva;
                }
                else
                {
                    this.mensagem = serial.mensagem;
                }
            }
            catch(IOException e)
            {
                this.mensagem = "Erro na criação do arquivo JSON. Mensagem: " + e.Message;
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
