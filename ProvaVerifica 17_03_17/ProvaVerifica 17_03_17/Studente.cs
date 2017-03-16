using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaVerifica_17_03_17
{
    class Studente : Utente
    {
        private string _school;
        public string school { get { return _school; } }


        public Studente (string name, string surname, int age, string school) : base (name, surname, age)
        {
            _school = school;
        }


        public override void studyTitle(Utente a)
        {
            base.studyTitle(a);
        }

    }
}
