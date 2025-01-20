using TextFile;

namespace Beadando
{
    public class Program
    {
        static void Main(string[] args)
        {
            TextFileReader reader = new TextFileReader(@"input.txt");

            reader.ReadLine(out string initStateValueLine);
            int initStateValue = int.Parse(initStateValueLine);
            City city = new City(initStateValue, new List<Tourist>());

            int currentYear = 0;
            int bestYear = 0;
            int bestYearStateValue = initStateValue;

            char[] separators = new char[] { ' ', '\t' };

            while (reader.ReadLine(out string line))
            {
                string[] tokens = line.Split(separators, StringSplitOptions.RemoveEmptyEntries);

                List<Tourist> tourists =
                    new List<Tourist>
                    {
                        new Japanese(int.Parse(tokens[0])),
                        new Westerner(int.Parse(tokens[1])),
                        new Other(int.Parse(tokens[2]))
                    };

                currentYear++;
                city.SetTourists(tourists);
                Console.WriteLine($"Year: {currentYear}\n");
                Console.WriteLine($"State value of the city at the beginning of the year: {city.StateValue}");
                Console.WriteLine($"State of the at the beginning of the year: {city.State}");
                Console.WriteLine($"Expected number of tourists: {string.Join(" ", city.ExpectedTourists())}");
                Console.WriteLine($"Actual number of tourists: {string.Join(" ", city.ActualTourists())}");
                Console.WriteLine($"Revenue: {city.Revenue()} Ft");
                city.SimulateYear();
                Console.WriteLine($"State value of the city at the end of the year: {city.StateValue}");
                Console.WriteLine($"State of the at the end of the year: {city.State}\n");
                if (city.StateValue > bestYearStateValue)
                {
                    bestYearStateValue = city.StateValue;
                    bestYear = currentYear + 1;
                }
            }
            
            Console.Write("Best year: ");
            Console.WriteLine(bestYear);
        }
    }
}
