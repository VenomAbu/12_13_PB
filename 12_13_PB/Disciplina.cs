using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_13_PB
{
    internal class Disciplina
    {
        private int _codigo;
        private string _nome;

        public int Codigo { get => _codigo; set => _codigo = value; }
        public string Nome { get => _nome; set => _nome = value; }

        public Disciplina(int codigo, string nome)
        {
            Codigo = codigo;
            Nome = nome;
        }

        public Disciplina()
        {
            Codigo = 0;
            Nome = "";
        }

        public override string ToString()
        {
            return "Código: " + Codigo + " / Nome: " + Nome;
        }
    }
}
