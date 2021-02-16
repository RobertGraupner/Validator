using System;
namespace Validator
{
    public class NipValidator : IdentificationNumberValidator
    {
        protected override int[] GetWeights()
        {
            return new int[] { 6, 5, 7, 2, 3, 4, 5, 6, 7};
        }
        protected override int GetNumberLenght()
        {
            return 10;
        }
        protected override int GetnumberControlModuloDigit()
        {
            return 11;
        }
    }
}
