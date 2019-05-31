﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APS_1_2019.Modelo
{
    public class ValidacaoChuva : absPropriedades
    {
        public void LeituraChuva(double resistChuva)
        {
            if (resistChuva < 400)
            {
                EstadoChuva = "Chuva Forte";
            }
            else if (resistChuva < 700)
            {
                EstadoChuva = "Chuva Fraca";
            }
            else
            {
                EstadoChuva = "Sem chuva";
            }
        }
    }
}
