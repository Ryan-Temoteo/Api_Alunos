using AlunoAPI.Entities;

namespace AlunoAPI.Repository
{
    public class AlunoRepository
    {
        public static List<Aluno> BancoDeDados { get; set; } = new List<Aluno>();

        public void Criar()
        {
            Aluno aluno1 = new Aluno(1 , "Ryan", "Matriculado", 3245);
            Aluno aluno2 = new Aluno(2 , "João", "Desmatriculado", 7865);
            Aluno aluno3 = new Aluno(3 , "Aline", "Matriculado", 9876);
            Aluno aluno4 = new Aluno(4, "Rafael", "Desmatriculado", 9075);

            BancoDeDados.Add(aluno1);
            BancoDeDados.Add(aluno2);
            BancoDeDados.Add(aluno3);
            BancoDeDados.Add(aluno4);
        }
    }
}
