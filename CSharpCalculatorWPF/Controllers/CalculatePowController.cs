using CSharpCalculatorWPF.Model;
using System;

namespace CSharpCalculatorWPF.Controllers
{
    //Controller that get results of formula pow
    public class CalculatePowController : IDisposable
    {
        //Standart constructor
        public CalculatePowController() { }

        //Method that returns result of expression pow
        public string GetResult(string formula)
        {
            using (CalculatePowModel calculatePow = new CalculatePowModel())
            {
                return calculatePow.GetPow(formula);
            }
        }

        //Destructor
        public void Dispose() { }
    }
}
