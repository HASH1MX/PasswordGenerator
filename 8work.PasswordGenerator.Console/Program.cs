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

            string resultGenerate1 = PG.Generate(8);
            Console.WriteLine(resultGenerate1);

            string resultGenerate2 = PG.Generate(isNumeric: true, length: 10);
            Console.WriteLine(resultGenerate2);


            string resultGenerate3 = PG.Generate(false, 12);
            Console.WriteLine(resultGenerate3);

            string resultGenerate4 = PG.Generate(true, false, 10);
            Console.WriteLine(resultGenerate4);

            resultGenerate4 = PG.Generate(true, true, 10);
            Console.WriteLine(resultGenerate4);

            resultGenerate4 = PG.Generate(isNumeric: false, isSpecial: false, length: 10);
            Console.WriteLine(resultGenerate4);

            resultGenerate4 = PG.Generate(10);
            Console.WriteLine(resultGenerate4);


        }
    }
}