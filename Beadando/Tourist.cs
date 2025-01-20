namespace Beadando
{
    public abstract class Tourist
    {
        protected long expectedCount;

        protected Tourist(int expectedCount)
        {
            this.expectedCount = expectedCount;
        }

        public abstract long DeteriorationCausedByVisit(City city);

        public abstract long ActualCount(IState state);

        public long ExpectedCount()
        {
            return expectedCount;
        }

        public long Revenue(City city)
        {
            return ActualCount(city.State) * 100_000;
        }
    }
}
