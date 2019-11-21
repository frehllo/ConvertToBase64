using System;

namespace Conversioni
{
    public class ClasseBase64
    {
        public static string Conv64()
        {
            string parola = "Prof Falucca, qua dovrebbe uscire un 10...";
            byte[] toEncodeAsBytes = System.Text.ASCIIEncoding.ASCII.GetBytes(parola);
            string risposta = Convert.ToBase64String(toEncodeAsBytes);
            Console.Write($"{parola}");
            return risposta;
        }
    }
}
