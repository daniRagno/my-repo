using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio_13_01_17
{
    class Studente : Persona
    {
        private string _sezione;
        public string sezione { get { return _sezione; } }

        public Studente(string nome, string cognome, int anni, string codiceFiscale, string sezione) : base (nome, cognome, anni, codiceFiscale)
        {
            _sezione = sezione;
        }
    }
}
