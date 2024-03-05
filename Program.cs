using System;
using System.IO;
namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Exception[] exceptions = new Exception[5];

            exceptions[0] = new DriveNotFoundException();
            exceptions[1] = new Exception("My Error");
            exceptions[2] = new DivideByZeroException();
            exceptions[3] = new ArithmeticException();
            exceptions[4] = new FormatException();

            for (int i = 0; i < exceptions.Length; i++)
            {
                try
                {
                    throw exceptions[i];
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }
        }
    }
}
