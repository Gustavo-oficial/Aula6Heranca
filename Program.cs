using System;

namespace Aula6Herança
{
    class Program
    {
        static void Main(string[] args)
        {
            CNPJ cnpj = new CNPJ();

            cnpj.nome = "Gustavo";

            Console.WriteLine(cnpj.Saudar());

        }
    }
}
