using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1st_lecture
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount d1 = new BankAccount("1", 0);
            d1.Deposit(43.70m);
            d1.Deposit(77.30m);
            d1.Withdraw(21);

            BankAccount e1 = new BankAccount("31", 500);
            d1.Deposit(70);
            d1.Deposit(121.03m);
            d1.Withdraw(91);

            List<BankAccount> y1account = new List<BankAccount>() { d1, e1 };
            Person y1 = new Person("Georgi", 55, y1account);
            y1.Balance();

         //--------------------------------------------------------------------------//

            BankAccount a1 = new BankAccount("15", 1000000.1m);
            d1.Deposit(39);
            d1.Deposit(56.90m);
            d1.Withdraw(61);

            List<BankAccount> n1account = new List<BankAccount>() { a1 };
            Person n1 = new Person("Dimo", 26, n1account);
            n1.Balance();

            Console.ReadLine();
        }

    }
    class Person
    {
        private string name;

        private int age;

        private List<BankAccount> account;
        public string Name
        {
            get { return name; }
            private set { name = value; }
        }

        public int Age
        {
            get { return age; }
            private set { age = value; }
        }

        public List<BankAccount> Account
        {
            get { return account; }
            private set { account = value; }
        }
        public Person(string name, int age) : this(name, age, new List<BankAccount>())
        {

        }

        public Person(string name, int age, List<BankAccount> acc)
        {
            this.name = name;
            this.age = age;
            this.account = acc;
        }

        public void Balance()
        {
            if (account.Count > 0) 
            {
                Console.WriteLine($"Name: {Name}");
                foreach (var item in account)
                {
                    Console.WriteLine($"ID: {item.ID} Balance: {item.Balance}");
                }
            }
            else
            {
                Console.WriteLine($"There is no bank account for {Name}");
            }

        }   

        public override string ToString()
        {
            return $"Name: {Name} ; Age: {Age}";
        }

    }

    class BankAccount
    {
        private decimal balance;

        private string id;

        public decimal Balance
        {
            get { return balance; }
            private set { balance = value; }
        }

        public string ID
        {
            get { return id; }
            private set { id = value; }
        }

        public BankAccount(string id, decimal amount)
        {
            this.ID = id;
            this.Balance = amount;
        }

        public void Deposit(decimal amount)
        {
            this.Balance = Arithmetics.Sum(Balance, amount);
        }

        public void Withdraw (decimal amount)
        {
            this.Balance = Arithmetics.Substract(Balance, amount);
        }

        public override string ToString()
        {
            return $"ID: {ID} Balance : {Balance}";
        }
    }

    class Arithmetics
    {
        public static decimal Sum(decimal a, decimal b)
        {
            return a + b;
        }

        public static decimal Substract(decimal a, decimal b)
        {
            return a - b;
        }
    }
}
