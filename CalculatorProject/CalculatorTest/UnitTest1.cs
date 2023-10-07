using CalculatorProject;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System;

namespace CalculatorTest
{
    [TestClass]
    public class UnitTest1
    {
        public CalculatorMethods CalculatorMethods { get; set; } = new CalculatorMethods();

        [TestMethod]
        public void HandleNumbericEntry_NumberDecimalInput_AddingADecimalEntryInMainDisplay()
        {
            // arrange
            string initialValue = "0.5";

            //act
            CalculatorMethods.HandleNumericEntry(".");
            CalculatorMethods.HandleNumericEntry("5");
            var Display = CalculatorMethods.DisplayCalculationResultsLabel;

            // act and assert
            Assert.AreEqual(initialValue, Display);
        }

        [TestMethod]
        public void HandleNumbericEntry_NumberDecimalInput_IgnoreDecimalIfDecimalExistsInMainDisplay()
        {
            // arrange
            string initialValue = "1.0";

            //act
            CalculatorMethods.HandleNumericEntry("1");
            CalculatorMethods.HandleNumericEntry(".");
            CalculatorMethods.HandleNumericEntry("0");
            CalculatorMethods.HandleNumericEntry("."); // entry to Ignore
            var Display = CalculatorMethods.DisplayCalculationResultsLabel;

           // act and assert
           Assert.AreEqual(initialValue, Display);
        }

        [TestMethod]
        public void PerformOperation_Add_AddingTwoDecimalNumbers()
        {
            // arrange
            double firstValue = 1.5;
            double secondValue = 0.1;
            double resultValue = 1.6;
            char operationEntry = '+'; // Add

            //act
            CalculatorMethods.StoredOperand = firstValue;
            CalculatorMethods.StoredOperation = operationEntry;
            CalculatorMethods.PerformOperation(secondValue);

            var Display = double.Parse(CalculatorMethods.DisplayCalculationResultsLabel);

            // act and assert
            Assert.AreEqual(resultValue, Display);
        }

        [TestMethod]
        public void PerformOperation_Substraction_SubstractTwoDecimalNumbers()
        {
            // arrange
            double firstValue = 1.5;
            double secondValue = 0.1;
            double resultValue = 1.4;
            char operationEntry = '-'; // Substract

            //act
            CalculatorMethods.StoredOperand = firstValue;
            CalculatorMethods.StoredOperation = operationEntry;
            CalculatorMethods.PerformOperation(secondValue);

            var Display = double.Parse(CalculatorMethods.DisplayCalculationResultsLabel);

            // act and assert
            Assert.AreEqual(resultValue, Display);
        }

        [TestMethod]
        public void PerformOperation_Multiply_MultiplyOneNumberAndZeroNumber()
        {
            // arrange
            double firstValue = 1.5;
            double secondValue = 0;
            double resultValue = 0;
            char operationEntry = '*'; // Multiply

            //act
            CalculatorMethods.StoredOperand = firstValue;
            CalculatorMethods.StoredOperation = operationEntry;
            CalculatorMethods.PerformOperation(secondValue);

            var Display = double.Parse(CalculatorMethods.DisplayCalculationResultsLabel);

            // act and assert
            Assert.AreEqual(resultValue, Display);
        }

        [TestMethod]
        public void PerformOperation_Divide_GetErrorWhenDivideNumberByZero()
        {
            // arrange
            double firstValue = 1.5;
            double secondValue = 0;
            string errorMessage = "DIV/0"; // result
            char operationEntry = '/'; // Divide

            //act
            CalculatorMethods.StoredOperand = firstValue;
            CalculatorMethods.StoredOperation = operationEntry;
            CalculatorMethods.PerformOperation(secondValue);

            var Display = CalculatorMethods.DisplayCalculationResultsLabel;

            // act and assert
            Assert.AreEqual(errorMessage, Display);
        }

        [TestMethod]
        public void UpdateBinaryAndHexDisplay_DecimalBaseNumber_ConvertToBinaryBaseNumber()
        {
            // arrange
            string decimalBaseNumber = "1";
            string binaryBaseNumber = "00000001"; // 8-digits in binary base

            //act
            CalculatorMethods.DisplayCalculationResultsLabel = decimalBaseNumber;

            CalculatorMethods.UpdateBinaryAndHexDisplay();

            var Display = CalculatorMethods.DisplayBinaryLabel ;

            // act and assert
            Assert.AreEqual(binaryBaseNumber, Display);
        }

        [TestMethod]
        public void UpdateBinaryAndHexDisplay_DecimalBaseNumber_ConvertToHexaDecimalBaseNumber()
        {
            // arrange
            string decimalBaseNumber = "1";
            string hexadecimalBaseNumber = "01"; // in hexadecimal base

            //act
            CalculatorMethods.DisplayCalculationResultsLabel = decimalBaseNumber;

            CalculatorMethods.UpdateBinaryAndHexDisplay();

            var Display = CalculatorMethods.DisplayHexaDecimalLabel;

            // act and assert
            Assert.AreEqual(hexadecimalBaseNumber, Display);
        }
    }
}