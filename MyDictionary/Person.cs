﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionary
{
    class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }
    class Customer : Person
    {
        public string CreditCardNumber { get; set; }
    }

    class Employee : Person
    {
        public string EmployeeNumber { get; set; }
    }
}
