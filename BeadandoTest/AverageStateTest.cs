using Beadando;

namespace BeadandoTest
{
    [TestClass]
    public class AverageStateTest
    {
        [TestMethod]
        public void AverageActualMultiplierTestOnJapaneseTourist()
        {
            Average average = Average.Instance();
            Japanese tourist = new Japanese(0);
            Assert.AreEqual(1.0, average.ActualMultiplier(tourist));
        }

        [TestMethod]
        public void AverageActualMultiplierTestOnWesternerTourist()
        {
            Average average = Average.Instance();
            Westerner tourist = new Westerner(0);
            Assert.AreEqual(1.1, average.ActualMultiplier(tourist));
        }

        [TestMethod]
        public void AverageActualMultiplierTestOnOtherTourist()
        {
            Average average = Average.Instance();
            Other tourist = new Other(0);
            Assert.AreEqual(1.1, average.ActualMultiplier(tourist));
        }
    }
}