using System;

namespace CONTAPOUPANCA
{
    class Program
    {
        static void Main(string[] args)
        {
            CONTAPOUPANCA.taxadejurosanual = 0.04;
            CONTAPOUPANCA Poupador1 = new CONTAPOUPANCA(2000);
            CONTAPOUPANCA Poupador2 = new CONTAPOUPANCA(3000);

            Console.WriteLine("O saldo do poupador 1 é de:" + Poupador1.Calcularjurosmensal());
            Console.WriteLine("O saldo do poupador 2 é de:" + Poupador2.Calcularjurosmensal());
            
            CONTAPOUPANCA.taxadejurosanual = 0.05;
            Console.WriteLine("O saldo do poupador 1 é de:" + Poupador1.Calcularjurosmensal());
            Console.WriteLine("O saldo do poupador 2 é de:" + Poupador2.Calcularjurosmensal());
            Console.ReadKey();

        }
    }
}
