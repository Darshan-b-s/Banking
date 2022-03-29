using System;
using System.Linq;

namespace aa
{
    /// <summary>
    /// class to handle withdraw and deposite operations
    /// </summary>

    public class operations
    {/// <summary>
     /// function to make deposit operation whihc takes account num in whihc you want to deposit and deposits the amount in that account
     /// </summary>
     /// <param name="acc">account number</param>
     /// <param name="amount">amount</param>
        public static void deposit(int acc, int amount)
        {

            var dbContext = new Models.BankingContext();
            int countShort = dbContext.Customeraccounts.Count();


            if (amount > 0)
            {
                if (countShort < acc)
                {
                    Console.WriteLine("Account not found ");

                }
                else
                {
                    var Customeraccounts = dbContext.Customeraccounts.ToList();
                    foreach (var item in Customeraccounts)
                    {
                        if (item.Accnumber == acc)
                        {
                            item.Balance = item.Balance + amount;
                            Console.WriteLine("your new balane is:{0}", item.Balance);

                            dbContext.SaveChanges();

                        }

                    }
                }
            }
            else
            {
                Console.WriteLine("enter valid input");
            }


        }

        /// <summary>
        /// A function to withdraw amount from your bank account whiohc takes in the parameters such as account number and amount to withdraw and
        /// check if the entered amount is in the withdrawable limit and if yes then deducts it from the balance is not shows the notification that
        /// the amoun  is excedding the balance limit and also is the account number is not found it will how as Account not found
        /// </summary>
        /// <param name="acc">account number in which you want to withdraw</param>
        /// <param name="amount">amount whihch you want to withdraw</param>
        public static void withdraw(int acc, int amount)
        {
            var dbContext = new Models.BankingContext();
            int countShort = dbContext.Customeraccounts.Count();
            if (amount > 0)
            {
                if (countShort < acc)
                {
                    Console.WriteLine("Account not found ");


                }
                else
                {

                    var Customeraccounts = dbContext.Customeraccounts.ToList();
                    foreach (var item in Customeraccounts)
                    {
                        if (item.Accnumber == acc)
                        {
                            if (item.Balance > amount)
                            {
                                item.Balance = item.Balance - amount;
                                Console.WriteLine("your new balane is:{0}", item.Balance);

                                dbContext.SaveChanges();
                            }
                            else
                            {
                                Console.WriteLine("Amount enter exceeds the existing balance");
                            }
                        }

                    }
                }
            }
            else
            {
                Console.WriteLine("enter valid amount");
            }


        }


    }
}
