namespace CalculatorPastGen
{
    abstract public class Calculator : INumerical
    {
        protected string tag = string.Empty;

        protected UInt16 numberBase = 0;

        public string Tag => tag;
        public ushort Base => numberBase;

        public Int64 Calculate(char? operation, Int64 a, Int64 b)
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
                    return a << (Int32)b;
                case '>':
                    return a >> (Int32)b;
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

        abstract public Int64 ParseFromString(string str);

        abstract public string ParseToStringFromStr(string str, ushort numberBase);
    }
}
