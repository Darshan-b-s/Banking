using System;
using System.Linq;
using System.Text.RegularExpressions;


namespace aa
{
    class Program
    {
        static void Main(string[] args)
        {

            bool endapp = false;
            while (!endapp)
            {
                try
                {

                    {
                        Console.WriteLine("---------------WELCOME-------------");
                        Console.WriteLine("What acction do you want to perform");
                        Console.WriteLine("\t 1--view details ");
                        Console.WriteLine("\t 2--Createaccount");
                        Console.WriteLine("\t 3--Withdraw");
                        Console.WriteLine("\t 4--Deposit");


                        string option = (Console.ReadLine());
                        switch (option)
                        {
                            case "1":
                                {
                                    Console.WriteLine("enter the account number of which you want to get details");
                                    int acc = int.Parse(Console.ReadLine());
                                    view.readdetails(acc);
                                    break;
                                }
                            case "2":
                                {
                                    accounts.createaccount();
                                    break;

                                }
                            case "3":
                                {

                                    Console.WriteLine("enter the account number of which you want to get details");
                                    int acc = int.Parse(Console.ReadLine());
                                    Console.WriteLine("enter the  amount which you want to withdraw from the account");
                                    int amount = int.Parse(Console.ReadLine());
                                    operations.withdraw(acc, amount);
                                    break;

                                }
                            case "4":
                                {
                                    Console.WriteLine("enter the account number of which you want to get details");
                                    int acc = int.Parse(Console.ReadLine());
                                    
                                    Console.WriteLine("enter the  amount which you want to deposit to the account");
                                    int amount = int.Parse(Console.ReadLine());
                                    operations.deposit(acc, amount);
                                    break;

                                }
                            default:
                                {
                                    Console.WriteLine("enter valid option");
                                    break;
                                }
                        }

                        Console.Write("Press 'n' and Enter to close the app, or press any other key and Enter to continue: ");
                        if (Console.ReadLine() == "n")
                        {
                            endapp = true;
                            Console.WriteLine("-----------THANK YOU------------");

                            Console.WriteLine("\n");
                        }
                    }
                }

                catch (Exception)
                {
                    Console.WriteLine("Exception occured try again later");

                }
            }

        }
    }
    
   
}