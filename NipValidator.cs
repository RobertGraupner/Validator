using System;
namespace Validator
{
    public class NipValidator : IdentificationNumberValidator
    {
        int[] weights = { 6, 5, 7, 2, 3, 4, 5, 6, 7 };

        public bool ValidateNip(string validateNumber)
        {
            bool valid = false;
            try
            {
                if (validateNumber.Length == 10)
                {
                    valid = CountSum(validateNumber).Equals(validateNumber[9].ToString());
                }
            }
            catch (Exception)
            {
                valid = false;
            }
            return valid;

        }

        public override string CountSum(string validateNumber)
        {
         
            int modulo = sum % 11;
            return modulo.ToString();
        }
    }
}
