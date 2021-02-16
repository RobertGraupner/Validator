﻿using System;

namespace Validator
{
    class Program
    {
        public static void Main()
        {
            string validateNumber;
            do
            {
                Console.WriteLine("Enter PESEL or NIP to validate");
                validateNumber = Console.ReadLine();
            }
            while (validateNumber.Length != 10 && validateNumber.Length != 11);


            if (validateNumber.Length == 11)
            {
               PeselValidator peselValidator = new PeselValidator();
               Console.WriteLine(peselValidator.Validate(validateNumber) ? "Pesel number correct" : "Pesel number incorrect");
            }
            else if (validateNumber.Length == 10)
            {
                NipValidator nipValidator = new NipValidator();
                Console.WriteLine(nipValidator.Validate(validateNumber) ? "Nip number correct" : "Nip number incorect");
            }

        }

    }
}


