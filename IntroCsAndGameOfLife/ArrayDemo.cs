namespace IntroCsAndGameOfLife
{
    internal class ArrayDemo
    {
        /*
         * Viktigste forskjeller fra JS:
         * - fast lengde, kan ikke endres
         * - sterkt typet + samme datatype for alle elementer
         * - en "fersk" array blir initialisert med default-verdi til datatypen
         */
        public static void Run()
        {
            var values = new int[10];          // JS: let numbers = []; numbers.length = 10;
            values[0] = 1;
            values[1] = 2;
            values[2] = 3;
            values[3] = 4;

            var values2 = new int[] { 1, 2, 3, 4, 5 };

            foreach (var number in values2) // JS: for( let number of numbers)
            {
                Console.WriteLine(number);
            }

            for (var index = 0; index < values2.Length; index++)
            {
                var number = values2[index];
                Console.WriteLine(number);
            }
        }
    }
}
