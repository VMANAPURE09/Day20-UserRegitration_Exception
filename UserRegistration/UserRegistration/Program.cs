﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ExceptionProblem validateUser = new ExceptionProblem();
            validateUser.validateFirstName("Vaibhav");
            Console.WriteLine("--------------------");

            validateUser.validateLastName("Manapure");
            Console.WriteLine("--------------------------------------");

            validateUser.validateEmailId("manapure.vaibhav542@gmail.com");
            Console.WriteLine("--------------------------------------");

            Console.ReadKey();
        }
    }
}
