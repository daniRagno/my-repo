using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio_13_01_17
{
    class Persona
    {
        private string _nome;
        public string nome { get { return _nome; } }

        private string _cognome;
        public string cognome { get { return _cognome; } }

        private int _anni;
        public int anni { get { return _anni; } }


        private string _codiceFiscale;
        public string codiceFiscale { get { return _codiceFiscale; } }

        public Persona(string nome, string cognome, int anni, string codiceFiscale)
        {
            _nome = nome;

            _cognome = cognome;

            if (anni < 1) anni = 1;
            _anni = anni;

            _codiceFiscale = codiceFiscale;
        }

        public string describe()
        {
            string output = "Nome: " + nome + "\r\n";
            output += "Anni: " + anni + "\r\n";
            output += "CF: " + codiceFiscale + "\r\n";

            return output;
        }

    }
}
