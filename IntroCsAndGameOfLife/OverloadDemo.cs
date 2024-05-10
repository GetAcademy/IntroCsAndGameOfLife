namespace IntroCsAndGameOfLife
{
    internal class OverloadDemo
    {
        public static void Run()
        {
            Greet("Terje");
            Greet("Per");
            Greet();
        }

        static void Greet(string name)
        {
            Console.WriteLine($"Hei, {name}!");
        }

        static void Greet()
        {
            Console.WriteLine($"Hei på deg!");
        }

    }
}
