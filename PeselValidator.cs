using System;
namespace Validator
{
    public class PeselValidator : IdentificationNumberValidator
    {
        int[] weights = { 1, 3, 7, 9, 1, 3, 7, 9, 1, 3 };

        public bool ValidatePesel(string validateNumber)
        {
            bool valid = false;
            try
            {
                if (validateNumber.Length == 11)
                {
                    valid = CountSum(validateNumber).Equals(validateNumber[10].ToString());
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

            int modulo = sum % 10;
            return modulo == 0 ? modulo.ToString() : (10 - modulo).ToString();
        }
    }
}
