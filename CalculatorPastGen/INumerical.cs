namespace CalculatorPastGen
{
    public interface INumerical
    {
        Int64 Calculate(char? operation, Int64 a, Int64 b);
        Int64 ParseFromString(string str);

        string ParseToStringFromStr(string str, ushort numberBase);
    }
}
