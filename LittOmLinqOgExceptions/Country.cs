namespace LittOmLinqOgExceptions
{
    internal class Country
    {
        public int Rank { get; }
        public string Name { get; }
        public int Population { get; }
        public int Area { get; }

        public Country(int rank, string name, int population, int area)
        {
            Area = area;
            Population = population;
            Name = name;
            Rank = rank;
        }
    }
}
