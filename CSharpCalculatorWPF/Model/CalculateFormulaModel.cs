using System;
using System.Data;

namespace CSharpCalculatorWPF.Model
{
    //Model that calculates formula
    public class CalculateFormulaModel : IDisposable
    {
        //Standart constructor
        public CalculateFormulaModel() { }

        //Method that calculates formula
        public string Calculate(string formula)
        {
            //If last symbol in formula is sign, or formula is a sign
            if (formula[formula.Length - 1].Equals('+') ||
                formula[formula.Length - 1].Equals('-') ||
                formula[formula.Length - 1].Equals('*') ||
                formula[formula.Length - 1].Equals('/'))
            {
                formula = formula.Remove(formula.Length - 1);
            }

            try
            {
                //Calculating
                using (DataTable dt = new DataTable())
                {
                    string result = dt.Compute(formula.Replace(',', '.'), "").ToString();

                    //Get result of calculating
                    if (result.Equals("∞"))
                    {
                        return "∞";
                    }
                    else
                    {
                        return result;
                    }
                }
            }
            catch (DivideByZeroException) // if formula contains /0
            {
                return "∞";
            }

        }

        //Destructor
        public void Dispose() { }
    }
}
