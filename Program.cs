using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testapp
{
    class account
    {
        public account()   //constructor to play with
        {
            Console.WriteLine("he ha");
        }

        private double balance = 10;
        public void deposit(double a)
        {
            balance = balance + a;
        }

        public void rm(double b)
        {
            balance = balance - b;
        }

        public double showb()
        {
         return balance;
          }

     }
        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Enter amount: ");
                double inpu = Convert.ToInt16(Console.ReadLine());

                Console.WriteLine("Enter number: ");
                double useri = Convert.ToInt16(Console.ReadLine());

            account acc = new account();

            if (useri == 1)
                {
                    acc.deposit(inpu);
                }
            else
                {
                    acc.rm(inpu);
                }
            Console.WriteLine(acc.showb());

            }
        }

       
}




