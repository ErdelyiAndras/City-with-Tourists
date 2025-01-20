namespace Beadando
{
    public class Other : Tourist
    {
        public Other(int expectedCount) : base(expectedCount) { }

        public override long DeteriorationCausedByVisit(City city)
        {
            return ActualCount(city.State) / 50;
        }

        public override long ActualCount(IState state)
        {
            return (long)(expectedCount * state.ActualMultiplier(this));
        }
    }
}
