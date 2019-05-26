using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APS_1_2019.Modelo
{
    public class DadosJSON
    {
        public string Temperatura { get; set; }
        public string Umidade { get; set; }
        public string EstadoChuva { get; set; }
    }
}
