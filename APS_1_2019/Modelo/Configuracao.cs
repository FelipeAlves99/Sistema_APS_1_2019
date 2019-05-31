using System;
using System.IO;

namespace APS_1_2019.Modelo
{
    public class Configuracao
    {
        public void Executar()
        {
            try
            {
                //lê o arquivo de configuração, que guarda a porta e frequência da porta serial
                StreamReader arquivo = new StreamReader(@"ConfiguracaoArduino.txt");
                nomePorta = arquivo.ReadLine();
                freqBaud = Convert.ToInt32(arquivo.ReadLine());
                caminhoDoc = arquivo.ReadLine();
                arquivo.Close();
            }
            catch (Exception)
            {
            }
        }
        
        //são statics para serem chamadas em qualquer parte do programa.
        public static String nomePorta; 
        public static int freqBaud;
        public static String caminhoDoc = @"C:\UNIP-APS\aps-terceiro-semestre\frontend\src\data"; // caminho padrão do diretório pro JSON
    }
}
