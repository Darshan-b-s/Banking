using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace aa

{
    /// <summary>
    /// class to handle account operations like createaccount or get details of account
    /// </summary>
    public class accounts
    {
       
        /// <summary>
        /// function to create a new account which takes all the ifformation from the user and stores it in that database
        /// </summary>

        public static void createaccount()
        {
            int vage = 0;
            var dbContext = new Models.BankingContext();
            Models.Customeraccount customer = new Models.Customeraccount();
            Console.WriteLine("Enter  your details to create account");
            Console.WriteLine("Enter the first name");
            string f_name = Console.ReadLine();
            while (!Regex.IsMatch(f_name, @"^[a-zA-Z]+$"))
            {
                Console.WriteLine("enter valid first name");
                f_name = (Console.ReadLine());
            }
            customer.Firstname = f_name;

            Console.WriteLine("Enter the last name");
            string l_name = Console.ReadLine();
            while (!Regex.IsMatch(l_name, @"^[a-zA-Z]+$"))
            {
                Console.WriteLine("enter valid last name");
                l_name = (Console.ReadLine());
            }
            customer.Lasttname = l_name;
            Console.WriteLine("Enter your cityname");
            string city = Console.ReadLine();
            while (!Regex.IsMatch(city, @"^[a-zA-Z]+$"))
            {
                Console.WriteLine("enter valid city name");
                city = (Console.ReadLine());
            }
            customer.City = city;
            Console.WriteLine("Enter your mobile number");
            string mob = Console.ReadLine();
            while ((!Regex.IsMatch(mob, @"^[0-9]{12}$")))
            {
                Console.WriteLine("enter valid mobile number");
                mob = (Console.ReadLine());
            }
            customer.Mobileno = mob;

        start:
            Console.WriteLine("Enter the age");

            string age = Console.ReadLine();
            while (!(int.TryParse(age, out vage)))
            {
                Console.WriteLine("Enter valid age");
                age = Console.ReadLine();
            }
            if (vage > 0 && vage < 120)
            {
                customer.Age = vage;
            }
            else
            {
                goto start;
            }

            Console.WriteLine("Enter your occupation");
            string occupation = Console.ReadLine();
            while (!Regex.IsMatch(occupation, @"^[a-zA-Z]+$"))
            {
                Console.WriteLine("enter valid occupation");
                occupation = (Console.ReadLine());
            }
            customer.Occupation = occupation;

            Console.WriteLine("Enter your Customer ID:");// IN THE FORMAR OF A FOLLOWED BY ACCOUNT NUMBER FOR EXAMPLE A001
            string customerid = Console.ReadLine();
            while (!Regex.IsMatch(customerid, @"^[A-Z]{1}[0-9]{3}$"))
            {
                Console.WriteLine("enter valid Customer ID name Of form A001");
                customerid = (Console.ReadLine());
            }

            customer.Custid = customerid;
            dbContext.Customeraccounts.Add(customer);
            dbContext.SaveChanges();
            dbContext.Customeraccounts.Remove(customer);
        }
    }
}

