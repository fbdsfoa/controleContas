using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controleContas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Conta conta1 = new Conta();
            conta1.Numero = 123456;
            Console.WriteLine(conta1.Numero);
        }
    }
}
