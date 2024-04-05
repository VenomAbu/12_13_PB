using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_13_PB
{
    internal class Professor
    {
        private int _matricula;
        private string _nome;

        public int Matricula { get => _matricula; set => _matricula = value; }
        public string Nome { get => _nome; set => _nome = value; }

        public Professor(int matricula, string nome)
        {
            Matricula = matricula;
            Nome = nome;
        }

        public Professor()
        {
            Matricula = 0;
            Nome = "";
        }

        public override string ToString()
        {
            return "Matrícula: " + Matricula + " / Nome: " + Nome;
        }
    }
}
