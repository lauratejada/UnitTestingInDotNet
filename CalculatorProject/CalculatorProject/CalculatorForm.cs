using System.Windows.Forms;
using static System.Runtime.CompilerServices.RuntimeHelpers;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Button = System.Windows.Forms.Button;

namespace CalculatorProject
{
    public partial class CalculatorForm : Form
    {
        public double firstOperand, secondOperand;
        private CalculatorMethods _calculatorMethods { get; set; } = new CalculatorMethods();

        public CalculatorForm()
        {
            InitializeComponent();
            this.KeyPreview = true;
            firstOperand = 0;
            secondOperand = 0;
        }

        private void ButtonNumber0_Click(object sender, EventArgs e)
        {
            HandleButtonClick(sender, e);
        }

        private void ButtonNumber1_Click(object sender, EventArgs e)
        {
            HandleButtonClick(sender, e);
        }

        private void ButtonNumber2_Click(object sender, EventArgs e)
        {
            HandleButtonClick(sender, e);
        }

        private void ButtonNumber3_Click(object sender, EventArgs e)
        {
            HandleButtonClick(sender, e);
        }

        private void ButtonNumber4_Click(object sender, EventArgs e)
        {
            HandleButtonClick(sender, e);
        }

        private void ButtonNumber5_Click(object sender, EventArgs e)
        {
            HandleButtonClick(sender, e);
        }

        private void ButtonNumber6_Click(object sender, EventArgs e)
        {
            HandleButtonClick(sender, e);
        }

        private void ButtonNumber7_Click(object sender, EventArgs e)
        {
            HandleButtonClick(sender, e);
        }

        private void ButtonNumber8_Click(object sender, EventArgs e)
        {
            HandleButtonClick(sender, e);
        }

        private void ButtonNumber9_Click(object sender, EventArgs e)
        {
            HandleButtonClick(sender, e);
        }


        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            HandleOperationButtonClick(sender, e);
        }

        private void ButtonSubstract_Click(object sender, EventArgs e)
        {
            HandleOperationButtonClick(sender, e);
        }

        private void ButtonMultiply_Click(object sender, EventArgs e)
        {
            HandleOperationButtonClick(sender, e);
        }

        private void ButtonDivide_Click(object sender, EventArgs e)
        {
            HandleOperationButtonClick(sender, e);
        }

        private void ButtonEquals_Click(object sender, EventArgs e)
        {
            _calculatorMethods.HandleEqualsEntry();

            UpdateDisplaysValues();

            DisplayResults.Focus();
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            _calculatorMethods.HandleClearEntry();

            UpdateDisplaysValues();

            DisplayResults.Focus();
        }

        private void ButtonDot_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string buttonText = button.Text;
            _calculatorMethods.HandleNumericEntry(buttonText);
            UpdateDisplaysValues();
        }

        private void DisplayResults_TextChanged(object sender, EventArgs e)
        {
            _calculatorMethods.UpdateBinaryAndHexDisplay();
            UpdateDisplaysValues();
        }

        /// <summary>
        /// methods
        /// </summary>

        //HandleNumberEntry
        private void HandleButtonClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string buttonText = button.Text;

            _calculatorMethods.HandleNumericEntry(buttonText);

            UpdateDisplaysValues();

            DisplayResults.Focus();
        }

        private void HandleOperationButtonClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            char operation = button.Text[0];

            _calculatorMethods.HandleOperationEntry(operation.ToString());

            UpdateDisplaysValues();

            DisplayResults.Focus();
        }

        // Link: https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.keys?view=windowsdesktop-7.0
        // Handle the KeyDown event to determine the type of character entered into the control.
        
        private void Calculator_KeyDown(object sender, KeyEventArgs e)
        {
            KeysConverter kc = new KeysConverter();
            string entry = kc.ConvertToString(e.KeyCode);
            char digit = entry.Last();

            // Handle numeric keys (0-9) and decimal point (.)
            if (e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9)
            {
                //HandleKeyPress((char)(e.KeyCode - Keys.D0));
                HandleKeyPress(digit);
            }
            else if (e.KeyCode >= Keys.NumPad0 && e.KeyCode <= Keys.NumPad9)
            {
                // HandleKeyPress((char)(e.KeyCode - Keys.NumPad0));
                HandleKeyPress(digit);
            }
            else if (e.KeyCode == Keys.Decimal || e.KeyCode == Keys.OemPeriod)
            {
                _calculatorMethods.HandleNumericEntry(".");
                UpdateDisplaysValues();

              //  e.SuppressKeyPress = true;
            }

            // Operators (+, -, *, /)
            else if (e.KeyCode == Keys.Add || e.KeyCode == Keys.Subtract || e.KeyCode == Keys.Multiply || e.KeyCode == Keys.Divide)
            {

                if (!string.IsNullOrEmpty(DisplayResults.Text))
                {
                    switch (e.KeyValue)
                    {
                        case 107:
                            HandleOperationKeyEvent('+');
                            //ButtonAdd.PerformClick();
                            break;
                        case 109:
                            HandleOperationKeyEvent('-');
                            //ButtonSubstract.PerformClick();
                            break;
                        case 106:
                            HandleOperationKeyEvent('*');
                            //ButtonMultiply.PerformClick();
                            break;
                        case 111:
                            HandleOperationKeyEvent('/');
                            //ButtonDivide.PerformClick();
                            break;
                    }
                }

               // e.SuppressKeyPress = true;
            }
            // Handle equals (=) and clear (C)
            else if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    _calculatorMethods.HandleEqualsEntry();

                    UpdateDisplaysValues();

                    // helps to return cursor at the end
                    DisplayResults.Select(DisplayResults.Text.Length, 0); 

                }
                catch (Exception ex)
                {
                    _calculatorMethods.HandleClearEntry();

                    UpdateDisplaysValues();
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
            else if (e.KeyCode == Keys.Clear)
            {
                _calculatorMethods.HandleClearEntry();

                UpdateDisplaysValues();

                DisplayResults.Focus();
            }

        }

        // This event occurs after the KeyDown event and can be used to prevent characters from entering the control.
        private void Calculator_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit((char)e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '+' && e.KeyChar != '-' && e.KeyChar != '*' && e.KeyChar != '/')
            {
                // Stop these characters from being entered into the control 
                e.Handled = true; // Mark the key press as handled (invalid input)
            }
        }

        //HandleNumberEntry
        private void HandleKeyPress(char key)
        {
            string entryKey = key.ToString();

            _calculatorMethods.HandleNumericEntry(entryKey);

            UpdateDisplaysValues();
            // helps to return cursor at the end
            DisplayResults.Select(DisplayResults.Text.Length, 0);
        }

        private void HandleOperationKeyEvent(char op)
        {
            string operation = op.ToString();

            _calculatorMethods.HandleOperationEntry(operation);

            UpdateDisplaysValues();

            // helps to return cursor at the end
            DisplayResults.Select(DisplayResults.Text.Length, 0);
        }

        private void UpdateDisplaysValues()
        {
            DisplayResults.Text = _calculatorMethods.DisplayCalculationResultsLabel;
            DisplayOperationLabel.Text = _calculatorMethods.DisplayOperationLabel;
            ToBinaryDisplayValue.Text = _calculatorMethods.DisplayBinaryLabel;
            ToHexaDecimalDisplayValue.Text = _calculatorMethods.DisplayHexaDecimalLabel;
        }

        private void Calculator_Load(object sender, EventArgs e)
        {
            DisplayResults.Focus();
        }
    }
}