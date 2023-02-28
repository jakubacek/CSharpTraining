namespace CS6
{
    using static Math;
    using static Console;
    public static class StaticImport
    {
        public static void Test()
        {
            var ran = new Random();
            var a = ran.Next();
            var b = ran.Next();
            var c = Max(a, b);
            WriteLine(c);
            WriteLine(PI);
        }
    }
}