using AlunoAPI.Entities;
using AlunoAPI.Repository;
using Microsoft.AspNetCore.Mvc;

namespace AlunoAPI.EndPoints
{
    public class AlunoGet
    {
        // Rota definida
        public static string? Template => "/aluno/{id:int}";
        public static string[]? Metodo => new string[] { HttpMethod.Get.ToString() };

        public static Delegate Funcao => Acao;

        public static IResult Acao([FromRoute] int id)
        {
            AlunoRepository alunocarga = new AlunoRepository();
            alunocarga.Criar();

            Aluno encontrado = AlunoRepository.BancoDeDados.FirstOrDefault(a => a.Id.Equals(id));

            if (alunocarga != null)
            {
                return Results.Ok(encontrado);
            }
            else
            {
                return Results.NotFound();
            }
        }
    }
}
