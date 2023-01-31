namespace LittOmLinqOgExceptions
{
    internal class AnonymousObjectsDemo
    {
        public static void Run()
        {
            var person = new
            {
                FirstName = "Terje",
                LastName = "Kolderup"
            };

            Console.WriteLine(person.FirstName);

            DoSomethingElse(person);
        }

        private static void DoSomethingElse(object person)
        {
            //Console.WriteLine(person.FirstName);
        }
    }
}
