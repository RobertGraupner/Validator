using System;
namespace Validator
{
    public abstract class IdentificationNumberValidator
    {

        public abstract string CountSum(string validateNumber)
        {
            int sum = 0;
            for (int i = 0; i < weights.Length; i++)
            {
                sum += weights[i] * int.Parse(validateNumber[i].ToString());
            }

        }
    }
}
