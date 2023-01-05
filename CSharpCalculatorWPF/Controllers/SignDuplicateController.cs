using System;

namespace CSharpCalculatorWPF.Controllers
{
    //Method that control sign duplicates in formula
    public class SignDuplicateController : IDisposable
    {
        //Standart constructor
        public SignDuplicateController() { }

        //Method that controls sign duplicates in formula
        public bool SignControl(string formula, char symbol)
        {
            if (formula.Length != 0)
            {
                if ((formula[formula.Length - 1].Equals('-') ||
                    formula[formula.Length - 1].Equals('+') ||
                    formula[formula.Length - 1].Equals('*') ||
                    formula[formula.Length - 1].Equals('/') ||
                    formula[formula.Length - 1].Equals(',')) &&
                    (symbol == '-' ||
                    symbol == '+' ||
                    symbol == '*' ||
                    symbol == '/' ||
                    symbol == ','))
                {
                    return true;
                }            
            }

            return false;
        }

        //Destructor
        public void Dispose() { }
    }
}
