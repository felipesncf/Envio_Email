using System;
using System.Collections.Generic;

namespace Envio_Final
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Aluno> alunos = new List<Aluno>();
            Aluno aluno = new Aluno();
            aluno.Email = "felipec798@gmail.com";
            aluno.Idade = 18;
            aluno.Matricula = 12345;
            aluno.Nome = "Felipe";
            aluno.Professore.Nome = "Orra";
            aluno.Professore.Sobrenome = "Diaacho";

            Aluno aluno2 = new Aluno();
            aluno2.Email = "piocarvalho_1@hotmail.com";
            aluno2.Idade = 19;
            aluno2.Matricula = 54321;
            aluno2.Nome = "Zezin";
            aluno2.Professore.Nome = "Uoou";
            aluno2.Professore.Sobrenome = "Man";

            alunos.Add(aluno2);
            alunos.Add(aluno);

            Envio email = new Envio();
            //Console.Write(alunos.Count);

            email.enviarEmail_Jarsia(alunos);
        }
    }
}
