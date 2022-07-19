using System;

namespace ProjetoTryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Digite uma data no formato dia/mes/ano(DD/MM/AAAA): ");
            //string data = Console.ReadLine();

            //var retorno = Excecao.VerificarData(data);
            //Console.WriteLine(retorno);

            //Console.Write("Digite um numero: ");
            //string numero = Console.ReadLine();

            //var retorno = Excecao.VerificarInteiro(numero);
            //Console.WriteLine(retorno);

            Console.Write("Digite um e-mail para validação: ");
            string emailUsuario = Console.ReadLine();
            bool retorno = Excecao.VerificarEmail(emailUsuario);
            Console.WriteLine(retorno);
            

        }
    }
}
