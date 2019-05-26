using System;

namespace APS_1_2019.Modelo
{
    public abstract class absPropriedades
    {
        public String mensagem;
        protected String[] arduinoinfo;
        protected String temperatura;
        protected String estadoChuva;
        public String EstadoChuva
        {
            get { return estadoChuva; }
            set { this.estadoChuva = value; }
        }
        public String Temperatura
        {
            get { return temperatura; }
            set { this.temperatura = value; }
        }

        protected String umidade;
        public String Umidade
        {
            get { return umidade; }
            set { this.umidade = value; }
        }

        protected Double resistChuva;
        public Double ResistChuva
        {
            get { return resistChuva; }
            set { this.resistChuva = value; }
        }
        protected String dados;
    }
}
