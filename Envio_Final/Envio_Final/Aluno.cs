using System;
using System.Collections.Generic;
using System.Text;

namespace Envio_Final
{
    class Aluno
    {
        public int Matricula { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Email { get; set; }
        public Professor Professore { get; set; } = new Professor();

        public override string ToString()
        {
            StringBuilder msgCorpoEmail = new StringBuilder();
            return "Matricula: " + Matricula + msgCorpoEmail.Append("<b><br/>")+ "Nome: " + Nome + msgCorpoEmail.Append("<b><br/>") +  "Idade: " + Idade + msgCorpoEmail.Append("<b><br/>") + "Professor: " + Professore.Nome + " " + Professore.Sobrenome  +msgCorpoEmail.Append("<b><br/>")  +"  ";
        }
    }
}
