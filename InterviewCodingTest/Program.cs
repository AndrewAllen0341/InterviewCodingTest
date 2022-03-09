using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace InterviewCodingTest
{
    class Program
    {
        interface ICodeTest
        {
            void XmlTester();
        }
        class testClass : ICodeTest
        {
            public void XmlTester()
            {
                Console.Write("Please enter a string in XML format: ");
                string xmlInput = Console.ReadLine();
                using (XmlReader xr = XmlReader.Create(
                    new StringReader(xmlInput)))
                {
                    try
                    {
                        while (xr.Read()) { }
                        Console.WriteLine("\nWell-formed");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("\nNot well-formed: " + ex.Message);
                    }
                }
            }
            public void Fibonacci()
            {
                Console.Write("Please enter an integer for the fibinacci sequence start: ");
                int fibStart = Convert.ToInt32(Console.ReadLine());
                Console.Write("Please enter an integer for the fibinacci sequence length: ");
                int fibLen = Convert.ToInt32(Console.ReadLine());

                int a = 0, b = fibStart, c = 0;
                Console.Write("{0} {1}", a, b);
                for (int i = 2; i < fibLen; i++)
                {
                    c = a + b;
                    Console.Write(" {0}\n", c);
                    a = b;
                    b = c;
                }
            }
            public void HelloWorld()
            {
                Console.Write("Please enter an integer to use for iteration length: ");
                int n = Convert.ToInt32(Console.ReadLine());
                Console.Write("Please enter an integer to use for a divisible variable: ");
                int p = Convert.ToInt32(Console.ReadLine());
                Console.Write("Please enter another ineger to use for a divisible variable: ");
                int q = Convert.ToInt32(Console.ReadLine());

                for (int i = 1; i <= n; i++)
                {
                    string str = "";
                    if (i % p == 0)
                    {
                        str += "Hello";
                    }
                    if (i % q == 0)
                    {
                        str += "World";
                    }
                    if (str.Length == 0)
                    {
                        str = i.ToString();
                    }
                    Console.WriteLine(str);
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Junior Developer Coding Test\nName: Andrew Allen\nDate Created: 03/08/2022\n");
            bool Exit = false;
            Console.WriteLine("Press any key to continue to C# portion of the test.");
            while (Exit == false)
            {
                string UserInput = Console.ReadKey(true).Key.ToString();
                Console.WriteLine("\nPlease select a class to run:\nA: Xml Tester\nB: Fibonacci Sequence\nC: HelloWorld Append Function\nD: Exit\n");
                UserInput = Console.ReadKey(true).Key.ToString();
                Console.Clear();
                switch (UserInput)
                {
                    case "A":
                        testClass t = new testClass();
                        t.XmlTester();
                        break;
                    case "B":
                        testClass f = new testClass();
                        f.Fibonacci();
                        break;
                    case "C":
                        testClass h = new testClass();
                        h.HelloWorld();
                        break;
                    case "D":
                        Console.WriteLine("Thank you for your time, I hope to hear back from you soon.");
                        Exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid input please select only one of the listed options.");
                        break;
                }
            };
        }
    }
}
