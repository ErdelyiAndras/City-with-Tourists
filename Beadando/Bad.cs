namespace Beadando
{
    public class Bad : IState
    {
        private static Bad? instance;

        private Bad() { }

        public static Bad Instance()
        {
            instance ??= new Bad();
            return instance;
        }

        public double ActualMultiplier(Japanese tourist)
        {
            return 0.0;
        }

        public double ActualMultiplier(Westerner tourist)
        {
            return 1.0;
        }

        public double ActualMultiplier(Other tourist)
        {
            return 1.0;
        }

        public override string ToString()
        {
            return "Bad";
        }
    }
}
