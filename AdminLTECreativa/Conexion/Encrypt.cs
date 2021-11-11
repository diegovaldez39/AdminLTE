using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;

namespace AdminLTECreativa.Conexion
{
    public class Encrypt
    {
        static string urlDomain = "https://localhost:44385";
        public static string GetSHA256(string str)
        {
            SHA256 sha256 = SHA256Managed.Create();
            ASCIIEncoding encoding = new ASCIIEncoding();
            byte[] stream = null;
            StringBuilder sb = new StringBuilder();
            stream = sha256.ComputeHash(encoding.GetBytes(str));
            for (int i = 0; i < stream.Length; i++) sb.AppendFormat("{0:x2}", stream[i]);
            return sb.ToString();
        }
        public static void SendEmail(string EmailDestino, string token)
        {
            string EmailOrigen = "dieguitopolo393@gmail.com";
            string password = "Blackeyedpeas1";
            string url = urlDomain + "/Account/Recovery/?token="+token;

            MailMessage oMailMessage = new MailMessage(EmailOrigen, EmailDestino, "Recuperacion de contraseña AdminLTE Creativa", "<b>Email para recuperacion de contraseña</b><br>"+"<a href='"+url+"'>Da click aqui!</a>");

            oMailMessage.IsBodyHtml = true;

            SmtpClient oSmtpCliente = new SmtpClient("smtp.gmail.com");
            oSmtpCliente.EnableSsl = true;
            oSmtpCliente.UseDefaultCredentials = false;
            oSmtpCliente.Port = 587;
            oSmtpCliente.Credentials = new System.Net.NetworkCredential(EmailOrigen, password);

            oSmtpCliente.Send(oMailMessage);

            oSmtpCliente.Dispose();
        }
    }
}
