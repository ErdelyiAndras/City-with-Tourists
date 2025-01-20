using Beadando;

namespace BeadandoTest
{
    [TestClass]
    public class GoodStateTest
    {
        [TestMethod]
        public void GoodActualMultiplierTestOnJapaneseTourist()
        {
            Good good = Good.Instance();
            Japanese tourist = new Japanese(0);
            Assert.AreEqual(1.2, good.ActualMultiplier(tourist));
        }

        [TestMethod]
        public void GoodActualMultiplierTestOnWesternerTourist()
        {
            Good good = Good.Instance();
            Westerner tourist = new Westerner(0);
            Assert.AreEqual(1.3, good.ActualMultiplier(tourist));
        }

        [TestMethod]
        public void GoodActualMultiplierTestOnOtherTourist()
        {
            Good good = Good.Instance();
            Other tourist = new Other(0);
            Assert.AreEqual(1.0, good.ActualMultiplier(tourist));
        }
    }
}