using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class BankCell
    {

        private string _holderName;
        private Guid _id;
        private double _balance;

        public BankCell(string name)
        {
            _holderName = name;
            _id = new Guid();
            _balance = default;
        }


        public double Balance
        {
            get
            {
                return _balance;
            }
        }

        public double cashOut(double sum)
        {
            if (sum <= _balance)
            {
                _balance -= sum;
                return sum;
            }
            else
                Console.WriteLine("You don't have enough money on your balance");
            return default;
        }

        public void cashIn(double sum)
        {
            _balance += sum;
        }
    }
}
