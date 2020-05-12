using System;
using System.Collections.Generic;
using System.Text;

namespace venditaVeicoliDLLProject
{
    [Serializable()]
    public class auto:veicolo
    {
        private string numairBag;
        public auto(string marca, string modello, int cilindrata, double potenza, DateTime dataImm,
            int chilometriPercorsi, string colore, bool usato, bool kmZero,double prezzo,string numairBag) : base(marca, modello, cilindrata,
                potenza, dataImm, chilometriPercorsi, colore, usato, kmZero,prezzo)
        {
            this.numairBag=numairBag;
        }

        public auto(string[] data) : base(data)
        {
            numairBag = data[10];
        }

        public auto() { }

        public string NumairBag { get => numairBag; set => numairBag = value; }

        public override string ToString()
        {
            return $"AUTO {base.ToString()} - {this.NumairBag} Aribag";
        }
    }
}
