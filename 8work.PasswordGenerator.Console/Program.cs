using System;
using System.Security.Cryptography.X509Certificates;

using _8work.PasswordGenerator.Library;

namespace PasswordGeneratorTester
{
    class Program
    {
        static void Main(string[] args)
        {
            PasswordGenerator PG = new PasswordGenerator();

            string resultGenerate = PG.Generate();
            Console.WriteLine(resultGenerate);
        }
    }
}