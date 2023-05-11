namespace CalculatorPastGen
{
    /// <summary>
    /// Represents a hexadecimal calculator.
    /// </summary>
    public class Hexadecimal : Calculator
    {
        /// <summary>
        /// Initializes a new instance of the Hexadecimal class.
        /// </summary>
        public Hexadecimal()
        {
            Tag = "hex";
            Base = 16;
        }

        /// <summary>
        /// Parses a string representation to a long decimal number.
        /// </summary>
        /// <param name="str">The string representation of the number.</param>
        /// <returns>The parsed decimal number.</returns>
        public override long ParseFromString(string str)
        {
            str = str.Replace(" ", "");
            return Convert.ToInt64(str, 16);
        }

        /// <summary>
        /// Parses a string representation to a hexadecimal string in the specified number base.
        /// </summary>
        /// <param name="str">The string representation of the number.</param>
        /// <param name="numberBase">The custom number base.</param>
        /// <returns>The parsed number as a hexadecimal string.</returns>
        public override string ParseToStringFromStr(string str, ushort numberBase)
        {
            str = str.Replace(" ", "");
            bool isNegative = str[0] == '-';
            if (isNegative)
            {
                str = str[1..];
            }
            long decimalNumber = Convert.ToInt64(str, numberBase);
            if (isNegative)
            {
                decimalNumber *= -1;
            }
            return Convert.ToString(decimalNumber, 16).ToUpper();
        }
    }
}
