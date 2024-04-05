using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;

namespace _12_13_PB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Crie uma turma com um professor e uma disciplina
            Console.WriteLine("a. Crie uma turma com um professor e uma disciplina.\n");
            Turma turma = new Turma(001, new Disciplina(101, "Java"), new Professor(111, "Elberth"));
            Console.WriteLine(turma);


            // Adicione dois alunos na turma criada anteriormente e verifique se é possível abrir a turma
            Console.WriteLine("\n\nb. Adicione dois alunos na turma criada anteriormente e verifique se é possível abrir a turma.\n");

            Console.WriteLine(turma.AddAluno(new Aluno(201, "Bob Esponja")));
            Console.WriteLine(turma.AddAluno(new Aluno(202, "Patrick Estrela")));
            Console.WriteLine(turma.AbrirTurma());

            // Adicione mais oito alunos e depois tente adicionar outro aluno e verifique se é possível
            Console.WriteLine("\n\nc. Adicione mais oito alunos e depois tente adicionar outro aluno e verifique se é possível.\n");

            Console.WriteLine(turma.AddAluno(new Aluno(201, "Bob Esponja")));
            Console.WriteLine(turma.AddAluno(new Aluno(202, "Patrick Estrela")));
            Console.WriteLine(turma.AddAluno(new Aluno(203, "Lula Molusco")));
            Console.WriteLine(turma.AddAluno(new Aluno(204, "Sandy Bochechas")));
            Console.WriteLine(turma.AddAluno(new Aluno(205, "Mechilhãozinho")));
            Console.WriteLine(turma.AddAluno(new Aluno(206, "Homem Sereia")));
            Console.WriteLine(turma.AddAluno(new Aluno(207, "Larry Lagosta")));
            Console.WriteLine(turma.AddAluno(new Aluno(208, "Seu Siriguejo")));
            Console.WriteLine(turma.AddAluno(new Aluno(209, "Plankton")));

            // Depois gere a pauta conforme descrito na questão anterior
            Console.WriteLine("\n\nd. Depois gere a pauta conforme descrito na questão anterior.\n");

            Console.WriteLine(turma.gerarPauta());

        }
    }
}
