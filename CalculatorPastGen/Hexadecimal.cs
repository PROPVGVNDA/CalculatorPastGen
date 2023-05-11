namespace CalculatorPastGen
{
    public class Hexadecimal : Calculator
    {
        public Hexadecimal()
        {
            tag = "hex";
            numberBase = 16;
        }

        public override long ParseFromString(string str)
        {
            str = str.Replace(" ", "");
            return Convert.ToInt64(str, 16);
        }

        public override string ParseToStringFromStr(string str, ushort numberBase)
        {
            str = str.Replace(" ", "");
            bool isNegative = str[0] == '-';
            if (isNegative) { str = str[1..]; }
            long decimalNumber = Convert.ToInt64(str, numberBase);
            if (isNegative) { decimalNumber *= -1; }
            return Convert.ToString(decimalNumber, 16).ToUpper();
        }
    }
}
