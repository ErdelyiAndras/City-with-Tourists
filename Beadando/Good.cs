namespace Beadando
{
    public class Good : IState
    {
        private static Good? instance;

        private Good() { }

        public static Good Instance()
        {
            instance ??= new Good();
            return instance;
        }

        public double ActualMultiplier(Japanese tourist)
        {
            return 1.2;
        }

        public double ActualMultiplier(Westerner tourist)
        {
            return 1.3;
        }

        public double ActualMultiplier(Other tourist)
        {
            return 1.0;
        }

        public override string ToString()
        {
            return "Good";
        }
    }
}
