namespace LittOmLinqOgExceptions
{
    internal class DemoIEnumerable
    {
        public static void Run()
        {
            var numbers1 = new DoubleNumbersSequence();
            foreach (var number in numbers1)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine();
            var numbers2 = new TripleNumbersSequence();
            foreach (var number in numbers2)
            {
                Console.WriteLine(number);
            }

            /* 
             * 1: Interface - bruke et eksisterende
             * 2: IEnumerable<> og IEnumerator
             *
             * 1
             * 2
             * 4
             * 8
             * 16
             * 32
             * ...
             */
        }
    }
}
