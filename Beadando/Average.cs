namespace Beadando
{
    public class Average : IState
    {
        private static Average? instance;

        private Average() { }

        public static Average Instance()
        {
            instance ??= new Average();
            return instance;
        }

        public double ActualMultiplier(Japanese tourist)
        {
            return 1.0;
        }

        public double ActualMultiplier(Westerner tourist)
        {
            return 1.1;
        }

        public double ActualMultiplier(Other tourist)
        {
            return 1.1;
        }

        public override string ToString()
        {
            return "Average";
        }
    }
}
