using System.Globalization;

namespace CalculatorPastGen
{
    public partial class Form1 : Form
    {
        private Dictionary<string, Calculator> calculators;
        private Calculator previousCalculator = null;
        private Calculator calculator;
        private string? operandBuffer = null;
        private char? operation = null;

        public event EventHandler CalculatorChanged;

        public Form1()
        {
            calculators = new Dictionary<string, Calculator>
            {
                {"DEC", new Decimal()},
                {"BIN", new Binary()},
                {"OCT", new Octal()},
                {"HEX", new Hexadecimal()},
            };
            InitializeComponent();
            CalculatorChanged += SetAvailableButtons;
            CalculatorChanged += UpdateInput;
            InitializeNumericalSystemRadioButtons();
        }
        private void InitializeNumericalSystemRadioButtons()
        {
            foreach (var control in numericalSystems.Controls)
            {
                if (control is RadioButton radioButton && radioButton.Checked)
                {
                    radioButton.Checked = false;
                    radioButton.Checked = true;
                }
            }
        }
        private void SetAvailableButtons(object sender, EventArgs e)
        {
            foreach (var control in inputButtons.Controls)
            {
                if (control is Button btn && btn.Tag != null)
                {
                    btn.Enabled = btn.Tag.ToString().Contains(calculator.Tag);
                }
            }
        }

        private void UpdateInput(object? sender, System.EventArgs e)
        {
            UInt16 numberBase = previousCalculator == null ? calculator.Base : previousCalculator.Base;
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
            input.Text = "";
            operandBuffer = null;
            operation = null;
        }
        private void SetOperationAndBuffer(char op)
        {
            if (!string.IsNullOrEmpty(operandBuffer)) return;
            operation = op;
            operandBuffer = input.Text;
            input.Text = "";
        }

        private void ButtonClickHandlerNumericalInput(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            input.Text += btn.Text;
            try
            {
                input.Text = calculator.ParseToStringFromStr(input.Text, calculator.Base);
            }
            catch (Exception ex)
            {
                FlushInput();
                input.Text = "Error";
            }
        }

        private void ButtonClickHandlerOperationInput(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (input.Text == "Error") { input.Text = ""; }

            switch (btn.Text)
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
                    SetOperationAndBuffer('&');
                    break;
                case "OR":
                    SetOperationAndBuffer('|');
                    break;
                case "XOR":
                    SetOperationAndBuffer('^');
                    break;
                case "NOT":
                    string temp = input.Text;
                    FlushInput();
                    input.Text = Convert.ToString(~Convert.ToInt64(temp));
                    break;
                default:
                    SetOperationAndBuffer(btn.Text[0]);
                    break;
            }
        }

        private void ToggleSign()
        {
            if (string.IsNullOrEmpty(input.Text)) { return; }
            var result = calculator.Calculate('-', 0, calculator.ParseFromString(input.Text)).ToString();
            input.Text = calculator.ParseToStringFromStr(result, 10);
        }

        private void PerformOperation()
        {
            if (string.IsNullOrEmpty(operandBuffer) || operation == '\0') { return; }

            try
            {
                if (calculator == null) { throw new CalculatorNullException("Calculator variable is null"); }

                var result = calculator.Calculate(operation,
                    calculator.ParseFromString(operandBuffer),
                    calculator.ParseFromString(input.Text)).ToString(CultureInfo.InvariantCulture);
                input.Text = calculator.ParseToStringFromStr(result, 10);
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
            FlushInput();
            input.Text = "Error";
        }

        private void NumericalSystemCheckedChanged(object sender, EventArgs e)
        {
            if (sender is RadioButton radioButton && radioButton.Checked)
            {
                previousCalculator = calculator;
                calculator = calculators[radioButton.Text];
                CalculatorChanged?.Invoke(this, EventArgs.Empty);
            }
        }
    }
}