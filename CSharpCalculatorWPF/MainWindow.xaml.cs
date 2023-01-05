using CSharpCalculatorWPF.Controllers;
using CSharpCalculatorWPF.View;
using System.Globalization;
using System.Windows;

namespace CSharpCalculatorWPF
{
    //MainWindow logic
    public partial class MainWindow : Window
    {
        //Comma flag to control commas
        private bool _commaFlag;

        //Object of FormulaLengthController for work
        private readonly FormulaLengthController _formulaLengthController;

        //MainWindow constructor
        public MainWindow()
        {
            InitializeComponent();

            CultureInfo.CurrentCulture = new CultureInfo("en-US", false);

            _commaFlag = false;
            _formulaLengthController = new FormulaLengthController();
        }

        //Button "1" action
        private void ButtonNumberOne_Click(object sender, RoutedEventArgs e)
        {
            _formulaLengthController.DrawFormula(TextBoxFormula, '1');
        }

        //Button "2" action
        private void ButtonNumberTwo_Click(object sender, RoutedEventArgs e)
        {
            _formulaLengthController.DrawFormula(TextBoxFormula, '2');
        }

        //Button "3" action
        private void ButtonNumberThree_Click(object sender, RoutedEventArgs e)
        {
            _formulaLengthController.DrawFormula(TextBoxFormula, '3');
        }

        //Button "4" action
        private void ButtonNumberFour_Click(object sender, RoutedEventArgs e)
        {
            _formulaLengthController.DrawFormula(TextBoxFormula, '4');
        }

        //Button "5" action
        private void ButtonNumberFifth_Click(object sender, RoutedEventArgs e)
        {
            _formulaLengthController.DrawFormula(TextBoxFormula, '5');
        }

        //Button "6" action
        private void ButtonNumberSix_Click(object sender, RoutedEventArgs e)
        {
            _formulaLengthController.DrawFormula(TextBoxFormula, '6');
        }

        //Button "7" action
        private void ButtonNumberSeven_Click(object sender, RoutedEventArgs e)
        {
            _formulaLengthController.DrawFormula(TextBoxFormula, '7');
        }

        //Button "8" action
        private void ButtonNumberEight_Click(object sender, RoutedEventArgs e)
        {
            _formulaLengthController.DrawFormula(TextBoxFormula, '8');
        }

        //Button "9" action
        private void ButtonNumberNine_Click(object sender, RoutedEventArgs e)
        {
            _formulaLengthController.DrawFormula(TextBoxFormula, '9');
        }

        //Button "0" action
        private void ButtonNumberZero_Click(object sender, RoutedEventArgs e)
        {
            _formulaLengthController.DrawFormula(TextBoxFormula, '0');
        }

        //Button "=" action
        private void ButtonCalculate_Click(object sender, RoutedEventArgs e)
        {
            if (_formulaLengthController.Formula.Length == 0)
            {
                return;
            }

            using (ViewElement _viewElement = new ViewElement())
            {
                _viewElement.SeeResultForCalculatingFormula(_formulaLengthController.Formula, TextBoxFormula);
            }

            _formulaLengthController.Formula = "";
        }

        //Button "+" action
        private void ButtonPlus_Click(object sender, RoutedEventArgs e)
        {
            using (SignDuplicateController _signDuplicateController = new SignDuplicateController())
            {
                //Comma control
                if (ButtonComma.IsEnabled == false && !_signDuplicateController.SignControl(_formulaLengthController.Formula, ','))
                {
                    _commaFlag = false;
                    ButtonComma.IsEnabled = true;
                }
            }

            if (_formulaLengthController.Formula.Length > 0)
            {
                _formulaLengthController.DrawFormula(TextBoxFormula, '+');
            }
        }

        //Button "-" action
        private void ButtonMinus_Click(object sender, RoutedEventArgs e)
        {
            using (SignDuplicateController _signDuplicateController = new SignDuplicateController())
            {
                //Comma control
                if (ButtonComma.IsEnabled == false && !_signDuplicateController.SignControl(_formulaLengthController.Formula, ','))
                {
                    _commaFlag = false;
                    ButtonComma.IsEnabled = true;
                }
            }

            _formulaLengthController.DrawFormula(TextBoxFormula, '-');
        }

        //Button "," action
        private void ButtonComma_Click(object sender, RoutedEventArgs e)
        {

            using (SignDuplicateController _signDuplicateController = new SignDuplicateController())
            {
                //Comma control
                if (_commaFlag == false &&
                    (!_signDuplicateController.SignControl(_formulaLengthController.Formula, '+') ||
                    !_signDuplicateController.SignControl(_formulaLengthController.Formula, '-') ||
                    !_signDuplicateController.SignControl(_formulaLengthController.Formula, '*') ||
                        !_signDuplicateController.SignControl(_formulaLengthController.Formula, '/')))
                {
                    _commaFlag = true;
                    ButtonComma.IsEnabled = false;
                }
            }

            if (_formulaLengthController.Formula.Length > 0)
            {
                _formulaLengthController.DrawFormula(TextBoxFormula, ',');
            }
        }

        //Button "*" action
        private void ButtonMult_Click(object sender, RoutedEventArgs e)
        {
            using (SignDuplicateController _signDuplicateController = new SignDuplicateController())
            {
                //Comma control
                if (ButtonComma.IsEnabled == false && !_signDuplicateController.SignControl(_formulaLengthController.Formula, ','))
                {
                    _commaFlag = false;
                    ButtonComma.IsEnabled = true;
                }
            }

            if (_formulaLengthController.Formula.Length > 0)
            {
                _formulaLengthController.DrawFormula(TextBoxFormula, '*');
            }
        }

        //Button "C" action
        private void ButtonClear_Click(object sender, RoutedEventArgs e)
        {
            _formulaLengthController.Formula = "";
            TextBoxFormula.Text = "";
        }

        //Button "/" action
        private void ButtonDiv_Click(object sender, RoutedEventArgs e)
        {
            using (SignDuplicateController _signDuplicateController = new SignDuplicateController())
            {
                //Comma control
                if (ButtonComma.IsEnabled == false && !_signDuplicateController.SignControl(_formulaLengthController.Formula, ','))
                {
                    _commaFlag = false;
                    ButtonComma.IsEnabled = true;
                }
            }

            if (_formulaLengthController.Formula.Length > 0)
            {
                _formulaLengthController.DrawFormula(TextBoxFormula, '/');
            }
        }

        //Button "X" action
        private void ButtonRemove_Click(object sender, RoutedEventArgs e)
        {
            _formulaLengthController.RemoveLastSymbol();
            TextBoxFormula.Text = _formulaLengthController.Formula;
        }

        //Button "x*x" action
        private void ButtonPow_Click(object sender, RoutedEventArgs e)
        {
            if (!_formulaLengthController.Formula.Equals(""))
            {
                using (ViewElement _viewElement = new ViewElement())
                {
                    _viewElement.SeeResultForPow(_formulaLengthController.Formula, TextBoxFormula);
                }

                _formulaLengthController.Formula = "";
            }
        }

        //Button "√x" action
        private void ButtonSqrt_Click(object sender, RoutedEventArgs e)
        {
            if (!_formulaLengthController.Formula.Equals(""))
            {
                using (ViewElement _viewElement = new ViewElement())
                {
                    _viewElement.SeeResultForSqrt(_formulaLengthController.Formula, TextBoxFormula);
                }

                _formulaLengthController.Formula = "";
            }
        }
    }
}
