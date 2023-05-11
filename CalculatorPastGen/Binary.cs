namespace CalculatorPastGen
{
    /// <summary>
    /// Represents a binary calculator.
    /// </summary>
    public class Binary : Calculator
    {
        /// <summary>
        /// Initializes a new instance of the Binary class.
        /// </summary>
        public Binary()
        {
            Tag = "bin";
            Base = 2;
        }

        /// <summary>
        /// Parses a binary string representation to a long decimal number.
        /// </summary>
        /// <param name="str">The binary string representation.</param>
        /// <returns>The parsed decimal number.</returns>
        public override long ParseFromString(string str)
        {
            string binaryString = str.Trim().Replace(" ", "");
            return Convert.ToInt64(binaryString, 2);
        }

        /// <summary>
        /// Parses a string representation to a binary string in the specified number base.
        /// </summary>
        /// <param name="str">The string representation of the number.</param>
        /// <param name="numberBase">The custom number base.</param>
        /// <returns>The parsed number as a binary string.</returns>
        public override string ParseToStringFromStr(string str, ushort numberBase)
        {
            str = str.Replace(" ", "");
            bool isNegative = str[0] == '-';
            if (isNegative)
            {
                str = str.Substring(1);
            }
            long decimalNumber = Convert.ToInt64(str, numberBase);
            if (isNegative)
            {
                decimalNumber *= -1;
            }
            return Convert.ToString(decimalNumber, 2);
        }
    }
}
