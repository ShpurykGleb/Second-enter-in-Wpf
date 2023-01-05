using CSharpCalculatorWPF.Model;

namespace TestCalculator
{
    public class TestModels
    {
        [Fact]
        public void TestCalculateFormulaModel()
        {
            CalculateFormulaModel calculateFormulaModel = new CalculateFormulaModel();

            Assert.Equal("21", calculateFormulaModel.Calculate("(56-32+15-39)+7*3"));
        }

        [Fact]
        public void TestCalculatePowModel()
        {
            CalculatePowModel calculatePowModel = new CalculatePowModel();

            Assert.Equal("9", calculatePowModel.GetPow("3"));
        }

        [Fact]
        public void TestCalculateSqrtModel()
        {
            CalculateSqrtModel calculateSqrtModel = new CalculateSqrtModel();

            Assert.Equal("4", calculateSqrtModel.GetSqrt("16"));
        }
    }
}