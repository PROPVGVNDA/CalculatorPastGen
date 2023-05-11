namespace CalculatorPastGen
{
    /// <summary>
    /// Represents an octal calculator.
    /// </summary>
    public class Octal : Calculator
    {
        /// <summary>
        /// Initializes a new instance of the Octal class.
        /// </summary>
        public Octal()
        {
            Tag = "oct";
            Base = 8;
        }

        /// <summary>
        /// Parses a string representation to a long decimal number.
        /// </summary>
        /// <param name="str">The string representation of the number.</param>
        /// <returns>The parsed decimal number.</returns>
        public override long ParseFromString(string str)
        {
            return Convert.ToInt64(str, 8);
        }

        /// <summary>
        /// Parses a string representation to an octal string in the specified number base.
        /// </summary>
        /// <param name="str">The string representation of the number.</param>
        /// <param name="numberBase">The custom number base.</param>
        /// <returns>The parsed number as an octal string.</returns>
        public override string ParseToStringFromStr(string str, ushort numberBase)
        {
            str = str.Replace(" ", "");
            long decimalNumber = Convert.ToInt64(str, numberBase);
            return Convert.ToString(decimalNumber, 8);
        }
    }
}
