using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.LastName = "Ali";
            customer1.Name = "Yılmaz";
            customer1.City = "Adana";
            customer1.CreditCardNumber = "1234";

            Customer customer2 = new Customer();
            customer2.Id = 2;
            customer2.LastName = "Ali";
            customer2.Name = "Yılmaz";
            customer2.City = "Adana";
            customer2.CreditCardNumber = "1234";

            Customer customer3 = new Customer();
            customer3.Id = 3;
            customer3.LastName = "Ali";
            customer3.Name = "Yılmaz";
            customer3.City = "Adana";
            customer3.CreditCardNumber = "1234";

            Customer customer4 = new Customer();
            customer4.Id = 4;
            customer4.LastName = "Ali";
            customer4.Name = "Yılmaz";
            customer4.City = "Adana";
            customer4.CreditCardNumber = "1234";


            MyList<Person> myList = new MyList<Person> ();
            myList.Add(customer1);
            myList.Add(customer2);
            myList.Add(customer3);
            myList.Add(customer4);
            Console.WriteLine(myList.Count);
            
        }
    }
}
