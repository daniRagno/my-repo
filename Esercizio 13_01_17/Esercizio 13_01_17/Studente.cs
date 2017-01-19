using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio_13_01_17
{
    class Studente : Persona
    {
        public string sezione { get; set; }

        public Studente(string nome, string cognome, int anni, string sezione) : base(nome, cognome, anni)
        {
            this.sezione = sezione;
        }

        public override string ToString()
        {
            return base.ToString() + " " + sezione;
        }

        public override string describe()
        {
            return base.describe() +
                 "sezione: " + sezione + System.Environment.NewLine;
        }
    }
}
