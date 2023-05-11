namespace CalculatorPastGen
{
    public class Binary : Calculator
    {
        public Binary()
        {
            tag = "bin";
            numberBase = 2;
        }
        public override Int64 ParseFromString(string str)
        {
            string binaryString = str.Trim().Replace(" ", "");
            return Convert.ToInt64(binaryString, 2);
        }

        public override string ParseToStringFromStr(string str, ushort numberBase)
        {
            str = str.Replace(" ", "");
            bool isNegative = str[0] == '-';
            if (isNegative) { str = str.Substring(1); }
            long decimalNumber = Convert.ToInt64(str, numberBase);
            if (isNegative) { decimalNumber *= -1; }
            return Convert.ToString(decimalNumber, 2);
        }
    }
}
