using System;

namespace BancoJequiti
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta c;
            c = new Conta();

            Console.WriteLine("Informe a Agência: ");
            c.SetAgencia(Convert.ToInt32(Console.ReadLine()));

            Console.WriteLine("Informe o Número: ");
            c.SetNumero(Convert.ToInt32(Console.ReadLine()));

            Console.WriteLine("Informe o Saldo: ");
            c.SetSaldo(Convert.ToInt32(Console.ReadLine()));

            Console.WriteLine("Agência informada: " + c.GetAgencia());
            Console.WriteLine("Número informado: " + c.GetNumero());
            Console.WriteLine("Saldo informado: " + c.GetSaldo());

            Console.ReadKey();
        }
    }
}

