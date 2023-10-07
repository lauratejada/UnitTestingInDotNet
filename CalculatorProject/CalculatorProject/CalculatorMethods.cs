using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorProject
{
    public class CalculatorMethods
    {
        public string DisplayCalculationResultsLabel { get; set; }
        public string DisplayOperationLabel { get; set; }
        public string DisplayBinaryLabel { get; set; }
        public string DisplayHexaDecimalLabel { get; set; }
        public double StoredOperand { get; set; } // the current or acumulated value
        public char StoredOperation { get; set; } // character for '+-*/'
        public bool IsNewInput { get; set; } // verify if is first operand or second operand

        public CalculatorMethods() 
        {
            DisplayCalculationResultsLabel = "0";
            DisplayOperationLabel = "";
            DisplayBinaryLabel = "";
            DisplayHexaDecimalLabel = "";
            StoredOperand = 0; 
            StoredOperation = ' '; 
            IsNewInput = true; 
        }
         
        public void HandleNumericEntry(string entry) 
        {
            if (IsNewInput)
            {
                DisplayCalculationResultsLabel = "";
                IsNewInput = false;
            }

            if (entry == "." && !DisplayCalculationResultsLabel.Contains("."))
            {
                if (DisplayCalculationResultsLabel == "")
                {
                    DisplayCalculationResultsLabel += "0.";
                }
                else
                {
                    DisplayCalculationResultsLabel += ".";
                }
            }
            else if (entry != ".")
            {
                DisplayCalculationResultsLabel += entry;
            }
        }

        public void HandleOperationEntry(string operationEntry)
        {
            char operation = operationEntry[0];

            //OperationOption();
            if (!IsNewInput)
            {
                double currentValue = double.Parse(DisplayCalculationResultsLabel);

                if (StoredOperation != ' ')
                {
                    // Perform the previous operation and update the stored value
                    PerformOperation(currentValue);
                }
                else
                {
                    StoredOperand = currentValue;
                }
            }

            // Display the operation symbol in the label
            DisplayOperationLabel = operation.ToString();

            // Clear the current input
            IsNewInput = true;

            // Store the selected operation
            StoredOperation = operation;
        }

        public void HandleEqualsEntry()
        {
            if (!IsNewInput)
            {
                // If there is a value in the display, perform the stored operation
                double currentValue = double.Parse(DisplayCalculationResultsLabel);

                PerformOperation(currentValue);
                
                IsNewInput = true;
                StoredOperation = ' ';
                DisplayOperationLabel = "";
            }
        }

        public void PerformOperation(double currentValue)
        {
            try
            {
              //  double currentValue = double.Parse(DisplayCalculationResultsLabel);

                switch (StoredOperation)
                {
                    case '+':
                        StoredOperand += currentValue;
                        break;
                    case '-':
                        StoredOperand -= currentValue;
                        break;
                    case '*':
                        StoredOperand *= currentValue;
                        break;
                    case '/':
                        if (currentValue != 0)
                        {
                            StoredOperand /= currentValue;
                        }
                        else
                        {
                            DisplayCalculationResultsLabel = "DIV/0";
                            return;
                        }
                        break;
                }

                DisplayCalculationResultsLabel = StoredOperand.ToString();
            }
            catch (Exception ex)
            {
                DisplayCalculationResultsLabel = "Error: " + ex.Message;
            }
        }

        public void UpdateBinaryAndHexDisplay()
        {
            if (string.IsNullOrWhiteSpace(DisplayCalculationResultsLabel))
            {
                DisplayBinaryLabel = "";
                DisplayHexaDecimalLabel  = "";
                return;
            }

            try
            {
                double inputValue;
                if (double.TryParse(DisplayCalculationResultsLabel, out inputValue))
                {
                    long decimalValue = (long)Math.Round(inputValue);

                    if (decimalValue >= -128 && decimalValue <= 255) // 8-bit signed range
                    {
                        if (decimalValue >= 0)
                        {
                            DisplayBinaryLabel = Convert.ToString(decimalValue, 2).PadLeft(8, '0');
                            DisplayHexaDecimalLabel  = Convert.ToString(decimalValue, 16).ToUpper().PadLeft(2, '0');
                        }
                        // If the number is negative
                        else if (decimalValue < 0)
                        {
                            DisplayBinaryLabel = Convert.ToString(decimalValue, 2).PadLeft(8, '1'); // Assuming 8-bit signed representation
                            DisplayHexaDecimalLabel  = Convert.ToString(decimalValue, 16).ToUpper().PadLeft(2, '1');
                        }

                        if (DisplayBinaryLabel.Length > 8 || DisplayHexaDecimalLabel .Length > 8)
                        {
                            DisplayBinaryLabel = "OUT OF RNG";
                            DisplayHexaDecimalLabel  = "OUT OF RNG";
                        }

                    }
                    else
                    {
                        DisplayBinaryLabel = "OUT OF RNG";
                        DisplayHexaDecimalLabel  = "OUT OF RNG";
                    }
                }
                else
                {
                    DisplayBinaryLabel = "INVALID INPUT";
                    DisplayHexaDecimalLabel  = "INVALID INPUT";
                }
            }
            catch (Exception ex)
            {
                DisplayCalculationResultsLabel = "Error: " + ex.Message;
            }
        }

        // clear the displays and values
        public void HandleClearEntry()
        {
            DisplayCalculationResultsLabel = "";
            DisplayOperationLabel = "";
            DisplayBinaryLabel = "";
            DisplayHexaDecimalLabel = "";
            StoredOperand = 0;
            StoredOperation = ' ';
            IsNewInput = true;
        }
    }
}
