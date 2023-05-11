namespace CalculatorPastGen
{
    public class Octal : Calculator
    {
        public Octal()
        {
            tag = "oct";
            numberBase = 8;
        }

        public override Int64 ParseFromString(string str)
        {
            return Convert.ToInt64(str, 8);
        }

        public override string ParseToStringFromStr(string str, ushort numberBase)
        {
            str = str.Replace(" ", "");
            Int64 decimalNumber = Convert.ToInt64(str, numberBase);
            return Convert.ToString(decimalNumber, 8);
        }
    }
}
