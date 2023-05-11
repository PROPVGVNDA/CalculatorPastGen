namespace CalculatorPastGen
{
    /// <summary>
    /// Represents a numerical calculator interface.
    /// </summary>
    public interface INumerical
    {
        /// <summary>
        /// Calculates the result of the given operation on two numbers.
        /// </summary>
        /// <param name="operation">The operation to perform.</param>
        /// <param name="a">The first number.</param>
        /// <param name="b">The second number.</param>
        /// <returns>The calculated result.</returns>
        long Calculate(char? operation, long a, long b);

        /// <summary>
        /// Parses a string representation of a number to a long.
        /// </summary>
        /// <param name="str">The string representation of the number.</param>
        /// <returns>The parsed long number.</returns>
        long ParseFromString(string str);

        /// <summary>
        /// Parses a string representation of a number to a custom base.
        /// </summary>
        /// <param name="str">The string representation of the number.</param>
        /// <param name="numberBase">The custom number base.</param>
        /// <returns>The parsed number as a string in the specified base.</returns>
        string ParseToStringFromStr(string str, ushort numberBase);
    }
}
