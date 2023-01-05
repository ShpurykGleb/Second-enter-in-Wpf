using System;

namespace CSharpCalculatorWPF.Model
{
    //Model that calculates formula pow
    public class CalculatePowModel : IDisposable
    {
        //Standart constructor
        public CalculatePowModel() { }

        //Method that calculates formula pow
        public string GetPow(string formula)
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

                resultToReturn = Math.Pow(resultToReturn, 2);

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
