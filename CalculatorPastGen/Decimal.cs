namespace CalculatorPastGen
{
    public class Decimal : Calculator
    {
        public Decimal()
        {
            tag = "dec";
            numberBase = 10;
        }

        public override Int64 ParseFromString(string str)
        {
            return Int64.Parse(str);
        }

        public override string ParseToStringFromStr(string str, ushort numberBase)
        {
            bool containsMinus = str[0] == '-';
            if (containsMinus) { str = str[1..]; }
            str = str.Replace(" ", "");
            Int64 decimalNumber;
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
