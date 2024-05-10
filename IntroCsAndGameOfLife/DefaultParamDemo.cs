using System.Xml.Linq;

namespace IntroCsAndGameOfLife
{
    internal class DefaultParamDemo
    {
        public static void Run()
        {
            Greet("Terje");
            Greet("Per");
            Greet();
        }

        static void Greet(string name = "du")
        {
            Console.WriteLine($"Hei, {name}!");
        }

        //static void Greet()
        //{
        //    Greet("du");
        //}

        //static void Greet(string name)
        //{
        //    Console.WriteLine($"Hei, {name}!");
        //}

    }
}
