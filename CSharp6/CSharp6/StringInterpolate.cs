using System;

namespace CSharp6
{
    public static class StringInterpolate
    {
        public static void Sample()
        {
            string sampleString = "This is to test string interpolation";
            Console.WriteLine(string.Format("Before C# 6.0 : {0}", sampleString));
            Console.WriteLine($"In C# 6.0 : {sampleString}");
        }
    }
}
