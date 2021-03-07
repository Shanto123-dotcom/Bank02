using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B02
{
    class Checking_Account : Account
    {
        

        public override void Withdraw(double amount)
        {
            if (amount > 0 && amount <= Balance && (Balance - amount > 0))
            {
                Balance -= amount;
            }
            else
            {
                Console.WriteLine("Sorry The Amount Couldnt Be Withdrawn..");
            }
        }
    }
}
