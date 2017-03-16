using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaVerifica_17_03_17
{
    class Utente
    {
        private string _name;
        public string name { get { return _name; } }

        private string _surname;
        public string surname { get { return _surname; } }

        private int _age;
        public int age { get { return _age; } }


        public Utente (string name, string surname, int age )
        {
            _name = name;
            _surname = surname;

            if (age < 1) age = 1;
            _age = age;
        }


        public override string ToString()
        {
            return name;
        }

        public string describe()
        {
            string output = "Nome Utente : " + name + Environment.NewLine;
            output += "Cognome Utente : " + surname + Environment.NewLine;
            output += "Età utente : " + age + Environment.NewLine;

            return output;
        }

        public virtual void studyTitle(Utente a)
        {

        }

    }
}
