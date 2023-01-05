using CSharpCalculatorWPF.Model;
using System;

namespace CSharpCalculatorWPF.Controllers
{
    //Controller that get results of formula sqrt
    public class CalculateSqrtController : IDisposable
    {
        //Standart constructor
        public CalculateSqrtController() { }

        //Method that returns result of expression sqrt
        public string GetResult(string formula)
        {
            using (CalculateSqrtModel calculateSqrt = new CalculateSqrtModel())
            {
                return calculateSqrt.GetSqrt(formula);
            }
        }

        //Destructor
        public void Dispose() { }
    }
}
