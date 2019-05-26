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
                StreamReader arquivo = new StreamReader(Configuracao.caminhoDoc + @"\ConfiguracaoArduino.txt");
                nomePorta = arquivo.ReadLine();
                freqBaud = Convert.ToInt32(arquivo.ReadLine());
                caminhoDoc = arquivo.ReadLine();
                arquivo.Close();
            }
            catch (Exception)
            {
            }
        }
        
        public static String nomePorta; 
        public static int freqBaud;
        public static String caminhoDoc = @"C:\APS3";
    }
}
