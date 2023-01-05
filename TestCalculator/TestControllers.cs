using CSharpCalculatorWPF;
using CSharpCalculatorWPF.Controllers;

namespace TestCalculator
{
    public class TestControllers
    {
        [Fact]
        public void TestCalculateFormulaControllerl()
        {
            CalculateFormulaController calculateFormulaModel = new CalculateFormulaController();

            Assert.Equal("21", calculateFormulaModel.GetResult("(56-32+15-39)+7*3"));
        }

        [Fact]
        public void TestCalculatePowController()
        {
            CalculatePowController calculatePowModel = new CalculatePowController();

            Assert.Equal("9", calculatePowModel.GetResult("3"));
        }

        [Fact]
        public void TestCalculateSqrtController()
        {
            CalculateSqrtController calculateSqrtModel = new CalculateSqrtController();

            Assert.Equal("4", calculateSqrtModel.GetResult("16"));
        }

        [Fact]
        public void TestFormulaLengthController()
        {
            FormulaLengthController formulaLengthController = new FormulaLengthController();

            formulaLengthController.Formula = "16-";

            formulaLengthController.RemoveLastSymbol();

            Assert.Equal("16", formulaLengthController.Formula);
        }

        [Fact]
        public void TestSignDuplicateController()
        {
            SignDuplicateController formulaLengthController = new SignDuplicateController();

            Assert.True(formulaLengthController.SignControl("16,,", ','));
        }
    }
}
