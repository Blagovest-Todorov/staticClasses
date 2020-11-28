using System;

namespace _04.CallingInstanceMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            String sampleLower = new String('a', 5);
            String sampleUpper = sampleLower.ToUpper();

            Console.WriteLine(sampleLower);
            Console.WriteLine(sampleUpper);

            DateTime now = DateTime.Now;
            DateTime later = now.AddHours(8);

            Console.WriteLine("Now: {0}, now", now);
            Console.WriteLine("8 hours later:{0}", later);
        } //Math is static class, all methods in it are static, Math.Pi, Math.Round, Math.Pow ...
    }
}
