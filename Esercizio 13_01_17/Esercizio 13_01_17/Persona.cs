using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio_13_01_17
{
    class Persona
    {
        public string nome { get; set; }
       
        public string cognome { get; set; }

        private int _anni;
        public int anni
        {
            get
            {
                return _anni;
            }

            set
            {
                if (value <= 0) value = 1;
                _anni = value;
            }
        }

        public string codiceFiscale
        {
            get
            {
                return nome + cognome + anni.ToString();
            }
        }

        public virtual string describe()
        {
            return
                "nome: " + nome + System.Environment.NewLine +
                "cognome: " + cognome + System.Environment.NewLine +
                "anni: " + anni.ToString() + System.Environment.NewLine;
        }

        public Persona(string nome, string cognome, int anni)
        {
            this.nome = nome;
            this.cognome = cognome;
            this.anni = anni;
        }
        public override string ToString()
        {
            return this.nome + " " + this.cognome;
        }

    }
}
