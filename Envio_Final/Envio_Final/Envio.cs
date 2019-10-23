using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.IO;

namespace Envio_Final
{
    class Envio
    {
        public  void enviarEmail_Jarsia(List<Aluno> aluno)
        {
            string chamado = "Prezada Jarsia, o Sistema de Gerenciamento de Projetos(SGP) vem por meio deste email informar que os seguintes alunos entraram na área de risco (Zona Vermelha)";
            string despedida = "Atenciosamente, SGP!";
            try
            {
                string mensagem = "";
                string mensagem_final1 = "";
                string[] mensagem_meio = new string[aluno.Count];
                string[] separa1 = new string[aluno.Count];
                string[] x = new string[aluno.Count];


                for (int i = 0; i < aluno.Count; i++)
                {
                    x[i] = aluno[i].ToString();
                }


                for (int i = 0; i < aluno.Count; i++)
                { 
                    mensagem += x[i];

                }

                for (int i = 0; i < aluno.Count; i++)
                {
                    mensagem_meio = mensagem.Split("  ");

                    separa1[i] = mensagem_meio[i];
                }
                for (int i = 0; i < aluno.Count; i++)
                {
                    mensagem_final1 += separa1[i];
                }

                StringBuilder msgCorpoEmail = new StringBuilder();
                string final = chamado + msgCorpoEmail.Append("<b><br/>") + msgCorpoEmail.Append("<b><br/>") + mensagem_final1 + msgCorpoEmail.Append("<b><br/>") + msgCorpoEmail.Append("<b><br/>") + despedida;




                //Smpt Client Details
                SmtpClient clientDetails = new SmtpClient();
                clientDetails.Port = 587;
                clientDetails.Host = "smtp.live.com";
                clientDetails.EnableSsl = true;
                clientDetails.DeliveryMethod = SmtpDeliveryMethod.Network;
                clientDetails.UseDefaultCredentials = false;
                clientDetails.Credentials = new System.Net.NetworkCredential("piocarvalho_1@hotmail.com", "felipe12");

                //Message Details

                MailMessage mailDetails = new MailMessage();
                mailDetails.From = new MailAddress("piocarvalho_1@hotmail.com");
                mailDetails.To.Add("felipec798@gmail.com");

                mailDetails.Subject = "Alunos que entraram na zona vermelha (Zona de risco)";

                mailDetails.IsBodyHtml = true;
                mailDetails.Body = final;

                clientDetails.Send(mailDetails);

                //Console.WriteLine("Your mail has been sent.");

                System.Diagnostics.Debug.WriteLine("Your mail has been sent.");
                //fileName = "";
            }
            catch (Exception ex)
            {
                //Console.WriteLine(ex.Message);
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }
        }
    }
}
