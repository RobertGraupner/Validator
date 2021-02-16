using System;
namespace Validator
{
    public class PeselValidator : IdentificationNumberValidator
    {
        protected override int[] GetWeights()
        {
            return new int[] { 1, 3, 7, 9, 1, 3, 7, 9, 1, 3};
        }
        protected override int GetNumberLenght()
        {
            return 11;
        }
        protected override int GetnumberControlModuloDigit()
        {
            return 10;
        }
    }
}
