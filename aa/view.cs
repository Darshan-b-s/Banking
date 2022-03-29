using System;
using System.Linq;
namespace aa
{
    public class view
    {
        /// <summary>
        /// function to retrive information from the database where it takes the account num as parameeter and retrives the iformation as that parameter
        /// </summary>
        /// <param name="acc"></param>
        public static void readdetails(int acc)
        {


            var dbContext = new Models.BankingContext();
            int countShort = dbContext.Customeraccounts.Count();
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
                        Console.WriteLine("Customer Name:{0} {1}", item.Firstname, item.Lasttname);
                        Console.WriteLine("Customer ID :{0}", item.Custid);
                        Console.WriteLine("Customer City:{0}", item.City);
                        Console.WriteLine("Customer Mobile Number:{0}", item.Mobileno);
                        Console.WriteLine("Customer Occupation:{0}", item.Occupation);
                        Console.WriteLine("Customer Age:{0}", item.Age);
                        Console.WriteLine("Customer Account Number:{0}", item.Accnumber);
                        Console.WriteLine("Customer Account balance :{0}", item.Balance);

                    }
                }
            }
        }
    }
}
