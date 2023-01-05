using System.IO;

namespace CSharpCalculatorWPF.Controllers
{
    //Controller that logs calculation results
    internal class LogController
    {
        //Database with calculation log path
        private static readonly string _databaseWithCalculcationsPath = "Calculation log.txt";

        //Static object of LogController
        private static LogController _logController;

        //Private standart constructor
        private LogController() { }

        //Method that get object of LogController
        public static LogController GetInstance()
        {
            if (_logController is null)
            {
                _logController = new LogController();
            }

            return _logController;
        }

        //Method that writes calculation result to database with calculation log
        public static void WriteCalculationToDatabase(string fullFormula) => File.AppendAllText(_databaseWithCalculcationsPath, fullFormula + "\n");

    }
}
