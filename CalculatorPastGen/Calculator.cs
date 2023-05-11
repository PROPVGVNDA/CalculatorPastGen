namespace CalculatorPastGen
{
    /// <summary>
    /// Represents a calculator with numerical operations.
    /// </summary>
    public abstract class Calculator : INumerical
    {
        /// <summary>
        /// Gets or sets the calculator's tag.
        /// </summary>
        public string Tag { get; protected set; } = string.Empty;

        /// <summary>
        /// Gets or sets the calculator's number base.
        /// </summary>
        public ushort Base { get; protected set; } = 0;

        /// <summary>
        /// Calculates the result of the given operation on two numbers.
        /// </summary>
        /// <param name="operation">The operation to perform.</param>
        /// <param name="a">The first number.</param>
        /// <param name="b">The second number.</param>
        /// <returns>The calculated result.</returns>
        public long Calculate(char? operation, long a, long b)
        {
            switch (operation)
            {
                case '+':
                    return a + b;
                case '-':
                    return a - b;
                case '/':
                    if (b == 0)
                        throw new DivideByZeroException();
                    return a / b;
                case '*':
                    return a * b;
                case '<':
                    return a << (int)b;
                case '>':
                    return a >> (int)b;
                case '&':
                    return a & b;
                case '|':
                    return a | b;
                case '^':
                    return a ^ b;
                default:
                    throw new ArgumentNullException(nameof(operation), "Operation cannot be processed");
            }
        }

        /// <summary>
        /// Parses a string representation of a number to a long.
        /// </summary>
        /// <param name="str">The string representation of the number.</param>
        /// <returns>The parsed long number.</returns>
        public abstract long ParseFromString(string str);

        /// <summary>
        /// Parses a string representation of a number with a custom base to a base of a class.
        /// </summary>
        /// <param name="str">The string representation of the number.</param>
        /// <param name="numberBase">The number base of a provided number.</param>
        /// <returns>The parsed number as a string with a class base.</returns>
        public abstract string ParseToStringFromStr(string str, ushort numberBase);
    }
}
