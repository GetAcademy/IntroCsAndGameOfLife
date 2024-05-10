namespace IntroCsAndGameOfLife
{
    internal class RandomDemo
    {
        public static void Run()
        {
            var random = new Random();
            var number1 = random.Next(90, 100);
            var number2 = random.Next(90, 100);
            var number3 = random.Next(90, 100);

            Console.WriteLine(number1);
            Console.WriteLine(number2);
            Console.WriteLine(number3);
        }
    }
}
