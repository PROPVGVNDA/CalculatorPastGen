using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;

namespace CalculatorPastGen
{
    public partial class Form1 : Form
    {
        private Dictionary<string, Calculator> calculators;
        private Calculator previousCalculator;
        private Calculator calculator;
        private string operandBuffer;
        private char operation;

        public event EventHandler CalculatorChanged;

        public Form1()
        {
            // Initialize the calculator dictionary with different calculators
            calculators = new Dictionary<string, Calculator>
            {
                {"DEC", new Decimal()},
                {"BIN", new Binary()},
                {"OCT", new Octal()},
                {"HEX", new Hexadecimal()},
            };

            InitializeComponent();

            // Subscribe to the events for calculator changes and input updates
            CalculatorChanged += SetAvailableButtons;
            CalculatorChanged += UpdateInput;

            // Initialize the radio buttons for numerical systems
            InitializeNumericalSystemRadioButtons();
        }

        private void InitializeNumericalSystemRadioButtons()
        {
            // Set the checked state of the radio buttons to ensure an event is triggered
            // This is done at the beginning of the program to properly initialize default calculator
            foreach (RadioButton radioButton in numericalSystems.Controls)
            {
                radioButton.Checked = false;
                radioButton.Checked = true;
            }
        }

        private void SetAvailableButtons(object sender, EventArgs e)
        {
            // Enable or disable input buttons based on the selected calculator
            // This is done using tags on buttons
            foreach (Button button in inputButtons.Controls)
            {
                if (button.Tag != null)
                {
                    button.Enabled = button.Tag.ToString().Contains(calculator.Tag);
                }
            }
        }

        private void UpdateInput(object sender, EventArgs e)
        {
            // Update the input text based on the current calculator and previous calculator base
            ushort numberBase = previousCalculator == null ? calculator.Base : previousCalculator.Base;
            if (input.Text == string.Empty) return;
            if (input.Text == "Error")
            {
                FlushInput();
                return;
            }
            input.Text = calculator.ParseToStringFromStr(input.Text, numberBase);
        }

        private void FlushInput()
        {
            // Clear the input and reset the operand buffer and operation
            input.Text = "";
            operandBuffer = null;
            operation = '\0';
        }

        private void SetOperationAndBuffer(char op)
        {
            // Set the operation and operand buffer for the current calculation
            if (!string.IsNullOrEmpty(operandBuffer)) return;
            operation = op;
            operandBuffer = input.Text;
            input.Text = "";
        }

        private void ButtonClickHandlerNumericalInput(object sender, EventArgs e)
        {
            // Handle numerical button clicks and update the input text
            Button button = (Button)sender;
            input.Text += button.Text;
            try
            {
                input.Text = calculator.ParseToStringFromStr(input.Text, calculator.Base);
            }
            catch (Exception)
            {
                FlushInput();
                input.Text = "Error";
            }
        }

        private void ButtonClickHandlerOperationInput(object sender, EventArgs e)
        {
            // Handle operation button clicks and perform the corresponding action
            Button button = (Button)sender;
            if (input.Text == "Error")
            {
                input.Text = "";
            }

            switch (button.Text)
            {
                case "+/-":
                    ToggleSign();
                    break;
                case "C":
                    FlushInput();
                    break;
                case "=":
                    PerformOperation();
                    break;
                case "AND":
                case "OR":
                case "XOR":
                    SetOperationAndBuffer(button.Text[0]);
                    break;
                case "NOT":
                    string temp = input.Text;
                    FlushInput();
                    input.Text = Convert.ToString(~Convert.ToInt64(temp));
                    break;
                default:
                    SetOperationAndBuffer(button.Text[0]);
                    break;
            }
        }

        private void ToggleSign()
        {
            // Toggle the sign of the input number
            if (string.IsNullOrEmpty(input.Text)) return;
            long result = calculator.Calculate('-', 0, calculator.ParseFromString(input.Text));
            input.Text = calculator.ParseToStringFromStr(result.ToString(), 10);
        }

        private void PerformOperation()
        {
            // Perform the operation between the operand buffer and the current input number
            if (string.IsNullOrEmpty(operandBuffer) || operation == '\0') return;

            try
            {
                if (calculator == null) throw new CalculatorNullException("Calculator variable is null");

                long result = calculator.Calculate(operation,
                    calculator.ParseFromString(operandBuffer),
                    calculator.ParseFromString(input.Text));
                input.Text = calculator.ParseToStringFromStr(result.ToString(CultureInfo.InvariantCulture), 10);
            }
            catch (DivideByZeroException)
            {
                DisplayError();
                MessageBox.Show("Can't divide by zero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                DisplayError();
            }
            operandBuffer = "";
        }

        private void DisplayError()
        {
            // Display an error message and reset the input
            FlushInput();
            input.Text = "Error";
        }

        private void NumericalSystemCheckedChanged(object sender, EventArgs e)
        {
            // Handle the change of numerical system radio buttons
            if (sender is RadioButton radioButton && radioButton.Checked)
            {
                previousCalculator = calculator;
                calculator = calculators[radioButton.Text];
                CalculatorChanged?.Invoke(this, EventArgs.Empty);
            }
        }
    }
}
