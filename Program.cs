using System;

namespace Validator
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Enter PESEL or NIP to validate");
            string validateNumber = Console.ReadLine();
            if(validateNumber.Length == 11)
            {
               PeselValidator peselValidator = new PeselValidator();
               Console.WriteLine(peselValidator.ValidatePesel(validateNumber) ? "Pesel number correct" : "Pesel number incorrect");
            }
            else if (validateNumber.Length== 10)
            {
                NipValidator nipValidator = new NipValidator();
                Console.WriteLine(nipValidator.ValidateNip(validateNumber) ? "Nip number correct" : "Nip number incorect");
            }
            else
            {
                Console.WriteLine("Enter correct PESEL or NIP to validate");
                validateNumber = Console.ReadLine();
            }

        }
    }
}
