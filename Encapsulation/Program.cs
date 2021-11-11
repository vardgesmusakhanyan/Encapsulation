using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            BankCell bankCell = new BankCell("Murad");

            double sum,cash;
            Console.WriteLine("Please write your sum to be added to balance");
            sum = Convert.ToDouble(Console.ReadLine());
            bankCell.cashIn(sum);
            Console.WriteLine(bankCell.Balance);
            Console.WriteLine("Please write the sum you want to cash out");
            cash = Convert.ToDouble(Console.ReadLine());
            bankCell.cashOut(cash);
            Console.WriteLine(bankCell.Balance);

            Console.ReadKey();


        }
    }
}
