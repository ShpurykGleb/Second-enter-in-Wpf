using CSharpCalculatorWPF.Model;
using System;

namespace CSharpCalculatorWPF.Controllers
{
    //Controller that get results of calculating formula
    public class CalculateFormulaController : IDisposable
    {
        //Standart constructor
        public CalculateFormulaController() { }

        //Method that returns result of calculating expression
        public string GetResult(string formula)
        {
            using (CalculateFormulaModel calculateModel = new CalculateFormulaModel())
            {
                return calculateModel.Calculate(formula);
            }
        }

        //Destructor
        public void Dispose() { }
    }
}
