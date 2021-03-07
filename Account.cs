using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B02
{
    class Account
    {
        private string dateOfBirth;
        private int accountNumber;
        private string accountName;
        private double balance;
        private string address;
        private string accountType;
        static int next = 3300;
        private int transactions = 0;

        public string Address
        {
            get { return this.address; }
            set { this.address = value; }
        }
        public string AccountName
        {
            get { return this.accountName; }
            set { this.accountName = value; }
        }
        public int Transactions
        {
            get { return this.transactions; }
        }

        public double Balance
        {
            get { return this.balance; }
            set { this.balance = value; }
        }

        public string DateOfBirth
        {
            get { return this.dateOfBirth; }
            set { this.dateOfBirth = value; }
        }

        public string AccountType
        {
            get { return this.accountType; }
            set { this.accountType = value; }
        }


        public void AutoAcoountNumberGenarator()
        {
            this.accountNumber = next;
            next++;
        }

        public int AccountNumber
        {
            get { return this.accountNumber; }
        }

        virtual public void Withdraw(double amount)
        {
        }

        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                balance += amount;
            }
        }

        public void Transfer(double amount, Account receiver)
        {
            if (amount > 0 && amount <= balance)
            {
                balance -= amount;
                receiver.Deposit(amount);
            }
        }

       

    }
}
