using System;
namespace Validator
{
    public abstract class IdentificationNumberValidator
    {
        protected abstract int[] GetWeights();
        protected abstract int GetNumberLenght();
        protected abstract int GetnumberControlModuloDigit();
        protected abstract int ModuloResult(int modulo);

        public string CountSum(string validateNumber)
        {
            int sum = 0;

            for (int i = 0; i < GetWeights().Length; i++)
            {
                sum += GetWeights()[i] * int.Parse(validateNumber[i].ToString());
            }
            int modulo = sum % GetnumberControlModuloDigit();

            return ModuloResult(modulo).ToString();
        }

        public bool Validate(string validateNumber)
        {
            bool valid = false;
            try
            {
                if(validateNumber.Length == GetNumberLenght())
                {
                    valid = CountSum(validateNumber).Equals(validateNumber[GetNumberLenght() - 1].ToString());
                }
            }
            catch (Exception)
            {
                valid = false;
            }
            return valid;
        }
    }
}
