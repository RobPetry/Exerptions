using Exceptions.Entities;
using Exceptions.Entities.Exceptions;
using System;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            bool run = true;
            while (run)
            {
                try
                {
                    Console.WriteLine("Enter account data:");
                    Console.Write("Number:");
                    int num;
                    int.TryParse(Console.ReadLine(), out num);
                    Console.Write("Holder:");
                    string holder = Console.ReadLine();
                    Console.Write("Initial balance:");
                    double balance;
                    double.TryParse(Console.ReadLine(), out balance);
                    Console.Write("Withdraw limit:");
                    double withdrawLimit;
                    double.TryParse(Console.ReadLine(), out withdrawLimit);
                    Account acc = new Account(num, holder, balance, withdrawLimit);
                    Console.WriteLine();
                    Console.Write("Enter amount to withdraw:");
                    double withdraw;
                    double.TryParse(Console.ReadLine(), out withdraw);
                    acc.WithDraw(withdraw);
                    Console.WriteLine();
                    Console.Write("New balance: " + acc.Balance); 
                    Console.Write("Close (y/n):");
                    if (char.Parse(Console.ReadLine()) == 'y')
                        run = false;
                }
                catch (AccountExceptions e)
                {
                    Console.WriteLine(e.Message);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Enexpected error: " + e.Message);
                }
            }
        }
    }
}
