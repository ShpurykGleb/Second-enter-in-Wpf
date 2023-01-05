using System;

namespace CSharpCalculatorWPF.Model
{
    //Model that calculates formula sqrt
    public class CalculateSqrtModel : IDisposable
    {
        //Standart constructor
        public CalculateSqrtModel() { }

        //Method that calculates formula sqrt
        public string GetSqrt(string formula)
        {
            //If formula is a sign
            if ((formula[formula.Length - 1].Equals('+') ||
                formula[formula.Length - 1].Equals('-') ||
                formula[formula.Length - 1].Equals('*') ||
                formula[formula.Length - 1].Equals('/')) && formula.Length == 1)
            {
                return "";
            }

            //Calculating
            string result = "";
            using (CalculateFormulaModel formulaModel = new CalculateFormulaModel())
            {
                result = formulaModel.Calculate(formula);
            }

            //Get result of calculating
            if (!result.Equals("∞"))
            {
                double resultToReturn = Convert.ToDouble(result);

                resultToReturn = Math.Sqrt(resultToReturn);

                return resultToReturn.ToString();
            }
            else
            {
                return result;
            }
        }

        //Destructor
        public void Dispose() { }
    }
}
