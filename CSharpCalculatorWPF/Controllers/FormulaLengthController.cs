using CSharpCalculatorWPF.Controllers;
using System.Windows.Controls;

namespace CSharpCalculatorWPF
{
    //Controller that controls formula length
    public class FormulaLengthController
    {
        //Formula
        private string _formula;

        //Max formula length
        private readonly int _maxFormulaLength = 16;

        //Formula property
        public string Formula { get { return _formula; } set { _formula = value; } }

        //Standart constructor
        public FormulaLengthController()
        {
            _formula = "";
        }

        //Method that show formula on user screen
        public void DrawFormula(TextBox textBoxToDrawFormula, char symbol)
        {
            using (SignDuplicateController _signDuplicateController = new SignDuplicateController())
            {
                if (!_signDuplicateController.SignControl(_formula, symbol))
                {
                    if (_formula.Length <= _maxFormulaLength)
                    {
                        _formula += symbol;
                    }
                }
            }

            textBoxToDrawFormula.Text = _formula;
        }

        //Method that removes last symbol in formula
        public void RemoveLastSymbol()
        {
            if (_formula.Length > 0)
            {
                _formula = _formula.Remove(_formula.Length - 1);
            }
        }
    }
}
