﻿using System;

namespace venditaVeicoliDLLProject
{
    [Serializable()]
    public class moto:veicolo
    {
        private string marcaSella;
        public moto( string marca, string modello, int cilindrata, double potenza, DateTime dataImm,
    int chilometriPercorsi, string colore, bool usato, bool kmZero,double prezzo,string MarcaSella) : base(marca, modello, cilindrata,
        potenza, dataImm, chilometriPercorsi, colore, usato, kmZero,prezzo)
        {
            this.MarcaSella = MarcaSella;
        }
        public moto(string[] data) : base(data)
        {
            marcaSella = data[10];
        }

        public moto() { }
        public string MarcaSella { get => marcaSella; set => marcaSella = value; }

        public override string ToString()
        {
            return $"MOTO {base.ToString()} - marca sella:{MarcaSella}";
        }
    }
}
