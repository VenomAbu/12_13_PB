using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_13_PB
{
    internal class Turma
    {
        private int _codigo;
        private Disciplina _disciplina;
        private Professor _professor;
        private List<Aluno> _alunos;

        public int Codigo { get => _codigo; set => _codigo = value; }
        internal Disciplina Disciplina { get => _disciplina; set => _disciplina = value; }
        internal Professor Professor { get => _professor; set => _professor = value; }
        internal List<Aluno> Alunos { get => _alunos; set => _alunos = value; }

        public Turma(int codigo, Disciplina disciplina, Professor professor)
        {
            Codigo = codigo;
            Disciplina = disciplina;
            Professor = professor;
            Alunos = new List<Aluno>(); 
        }

        public Turma()
        {
            Codigo = 0;
            Disciplina = new Disciplina();
            Professor = new Professor();
            Alunos = new List<Aluno>();
        }

        public string AddAluno(Aluno aluno)
        {
            if (Alunos.Count < 10)
            {
                Alunos.Add(aluno);
                return "Aluno " + aluno.Nome + " adicionado.";
            }
            else
            {
                return "Turma cheia.";
            }
        }

        public bool AbrirTurma()
        {
            // A lógica pode alterar a depender das regras de negócio.
            // Assumindo que a lógica de negócio diz que só possível abrir a turma caso ela tenha entre 2 a 10 alunos.
            if(Alunos.Count <= 10 || Alunos.Count >= 2) return true; return false;

        }

        public string gerarPauta()
        {
            string pauta = "Código: " + Codigo + "\nNome da disciplina: " + Disciplina.Nome + "\nLista de alunos inscritos:\n";
            foreach (Aluno aluno in Alunos)
            {
                pauta += "- " + aluno.Nome + "\n";
            }
            return pauta;
        }

        public override string ToString()
        {
            return "Código: " + Codigo + 
                " / Disciplina: " + Disciplina.Nome + 
                " / Professor: " + Professor.Nome + 
                " / Quantidade de Alunos: " + Alunos.Count;
        }
    }
}
