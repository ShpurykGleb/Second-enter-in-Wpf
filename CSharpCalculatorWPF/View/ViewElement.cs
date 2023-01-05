using CSharpCalculatorWPF.Controllers;
using System;
using System.Windows.Controls;

namespace CSharpCalculatorWPF.View
{
    //Model that shows result of calculating, pow, sqrt formula
    internal class ViewElement : IDisposable
    {
        //Result of calculating, pow, sqrt formula
        private string _result;

        //Standart constructor
        public ViewElement() { }

        //Method that show results of calculating formula
        public void SeeResultForCalculatingFormula(string formula, TextBox textBoxToShowResults)
        {
            using (CalculateFormulaController calculateFormulaController = new CalculateFormulaController())
            {
                _result = calculateFormulaController.GetResult(formula);
            }

            string fullFormula = formula + " = " + _result;
            textBoxToShowResults.Text = fullFormula;

            LogController.WriteCalculationToDatabase(fullFormula);
        }

        //Method that show results of formula pow
        public void SeeResultForPow(string formula, TextBox textBoxToShowResults)
        {

            using (CalculatePowController calculatePowController = new CalculatePowController())
            {
                _result = calculatePowController.GetResult(formula);
            }

            string fullFormula = "(" + formula + ")" + " * " + "(" + formula + ")" + " = " + _result;
            textBoxToShowResults.Text = fullFormula;

            LogController.WriteCalculationToDatabase(fullFormula);
        }

        //Method that show results of formula sqrt
        public void SeeResultForSqrt(string formula, TextBox textBoxToShowResults)
        {
            using (CalculateSqrtController calculateSqrtController = new CalculateSqrtController())
            {
                _result = calculateSqrtController.GetResult(formula);
            }

            string fullFormula = "√" + formula + " = " + _result;
            textBoxToShowResults.Text = fullFormula;

            LogController.WriteCalculationToDatabase(fullFormula);
        }

        //Destructor
        public void Dispose() { }
    }
}
