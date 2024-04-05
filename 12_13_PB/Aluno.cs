using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_13_PB
{
    internal class Aluno
    {
        private int _matricula;
        private string _nome;

        public int Matricula { get => _matricula; set => _matricula = value; }
        public string Nome { get => _nome; set => _nome = value; }

        public Aluno(int matricula, string nome)
        {
            Matricula = matricula;
            Nome = nome;
        }

        public Aluno()
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
