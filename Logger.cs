namespace ZConfigHelpers
{
    public class Logger
    {
        public delegate void PrintLog(string log);
        public static PrintLog print;
    }
}
