using System;

namespace Conversioni
{
    public class ClasseBase64
    {
        public static string Conv64()
        {
            string parola = "Vorrei un 10";
            byte[] toEncodeAsBytes = System.Text.ASCIIEncoding.ASCII.GetBytes(parola);
            string risposta = Convert.ToBase64String(toEncodeAsBytes);
            return risposta;

        }
    }
}
