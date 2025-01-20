using Beadando;

namespace BeadandoTest
{
    [TestClass]
    public class BadStateTest
    {
        [TestMethod]
        public void BadActualMultiplierTestOnJapaneseTourist()
        {
            Bad bad = Bad.Instance();
            Japanese tourist = new Japanese(0);
            Assert.AreEqual(0.0, bad.ActualMultiplier(tourist));
        }

        [TestMethod]
        public void BadActualMultiplierTestOnWesternerTourist()
        {
            Bad bad = Bad.Instance();
            Westerner tourist = new Westerner(0);
            Assert.AreEqual(1.0, bad.ActualMultiplier(tourist));
        }

        [TestMethod]
        public void BadActualMultiplierTestOnOtherTourist()
        {
            Bad bad = Bad.Instance();
            Other tourist = new Other(0);
            Assert.AreEqual(1.0, bad.ActualMultiplier(tourist));
        }
    }
}