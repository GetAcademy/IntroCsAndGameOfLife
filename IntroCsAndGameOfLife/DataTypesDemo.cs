namespace IntroCsAndGameOfLife
{
    internal class DataTypesDemo
    {
        static string name;

        public static void Run()
        {
            Console.Write("I hvilket år er du født? ");
            string birthYearStr = Console.ReadLine();
            int birthYear = Convert.ToInt32(birthYearStr);
            int birthYear2 = int.Parse(birthYearStr);
            int age = 2024 - birthYear;
            Console.WriteLine($"Du er {age} år gammel.");

        }
        public static void Run2()
        {
            name = "Terje";
            int i;
            i = 5;

            var n = 5;
            var myNumber = GetMyNumber();
            //          01234567
            var s = "fklhgkfh";
            var c = s[5];
            var d = 3.3;
            var b = true;
            var yesOrOn = b ? "Ja" : "Nei";
            double d2 = i;

            /*
                         int    char    double    string   bool

            int           x              auto
            char                  x
            double    
            string      Convert
            bool

             */
        }

        static int GetMyNumber()
        {
            return 7;
        }
    }
}
