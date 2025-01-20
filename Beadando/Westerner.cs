namespace Beadando
{
    public class Westerner : Tourist
    {
        public Westerner(int expectedCount) : base(expectedCount) { }

        public override long DeteriorationCausedByVisit(City city)
        {
            return ActualCount(city.State) / 100;
        }

        public override long ActualCount(IState state)
        {
            return (long)(expectedCount * state.ActualMultiplier(this));
        }
    }
}
