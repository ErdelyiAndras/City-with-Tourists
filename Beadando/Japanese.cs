namespace Beadando
{
    public class Japanese : Tourist
    {
        public Japanese(int expectedCount) : base(expectedCount) { }

        public override long DeteriorationCausedByVisit(City city)
        {
            return 0;
        }

        public override long ActualCount(IState state)
        {
            return (long)(expectedCount * state.ActualMultiplier(this));
        }
    }
}
