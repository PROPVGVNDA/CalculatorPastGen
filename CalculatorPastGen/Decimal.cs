namespace CalculatorPastGen
{
    /// <summary>
    /// Represents a decimal calculator.
    /// </summary>
    public class Decimal : Calculator
    {
        /// <summary>
        /// Initializes a new instance of the Decimal class.
        /// </summary>
        public Decimal()
        {
            Tag = "dec";
            Base = 10;
        }

        /// <summary>
        /// Parses a string representation to a long decimal number.
        /// </summary>
        /// <param name="str">The string representation of the number.</param>
        /// <returns>The parsed decimal number.</returns>
        public override long ParseFromString(string str)
        {
            return long.Parse(str);
        }

        /// <summary>
        /// Parses a string representation to a decimal string in the specified number base.
        /// </summary>
        /// <param name="str">The string representation of the number.</param>
        /// <param name="numberBase">The custom number base.</param>
        /// <returns>The parsed number as a decimal string.</returns>
        public override string ParseToStringFromStr(string str, ushort numberBase)
        {
            bool containsMinus = str[0] == '-';
            if (containsMinus)
            {
                str = str[1..];
            }
            str = str.Replace(" ", "");
            long decimalNumber;
            try
            {
                decimalNumber = Convert.ToInt64(str, numberBase);
            }
            catch (System.OverflowException)
            {
                Console.WriteLine("[ERROR]: Value was too large");
                return containsMinus ? "-" + str : str;
            }
            return containsMinus ? "-" + decimalNumber.ToString() : decimalNumber.ToString();
        }
    }
}
