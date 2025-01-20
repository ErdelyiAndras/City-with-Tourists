using Beadando;

namespace BeadandoTest
{
    [TestClass]
    public class WesternerTouristTest
    {
        private readonly double badMultiplier = 1.0;
        private readonly double averageMultiplier = 1.1;
        private readonly double goodMultiplier = 1.3;

        [DataTestMethod]
        [DataRow(0)]
        [DataRow(1)]
        [DataRow(1000)]
        [DataRow(9999)]
        [DataRow(48734)]
        public void WesternerExpectedCountTest(int expectedCount)
        {
            Westerner tourist = new Westerner(expectedCount);
            Assert.AreEqual(expectedCount, tourist.ExpectedCount());
        }

        [DataTestMethod]
        [DataRow(0)]
        [DataRow(1)]
        [DataRow(1000)]
        [DataRow(9999)]
        [DataRow(48734)]
        public void WesternerActualCountTestOnBadCity(int expectedCount)
        {
            Westerner tourist = new Westerner(expectedCount);
            Assert.AreEqual((long)(expectedCount * badMultiplier), tourist.ActualCount(Bad.Instance()));
        }

        [DataTestMethod]
        [DataRow(0)]
        [DataRow(1)]
        [DataRow(1000)]
        [DataRow(9999)]
        [DataRow(48734)]
        public void WesternerDeteriorationCausedByVisitTestOnBadCity(int expectedCount)
        {
            City city = new City(10, new List<Tourist>());
            Westerner tourist = new Westerner(expectedCount);
            Assert.AreEqual(((long)(expectedCount * badMultiplier)) / 100, tourist.DeteriorationCausedByVisit(city));
        }

        [DataTestMethod]
        [DataRow(0)]
        [DataRow(1)]
        [DataRow(1000)]
        [DataRow(9999)]
        [DataRow(48734)]
        public void WesternerRevenueTestOnBadCity(int expectedCount)
        {
            City city = new City(10, new List<Tourist>());
            Westerner tourist = new Westerner(expectedCount);
            Assert.AreEqual((long)(expectedCount * badMultiplier) * 100_000, tourist.Revenue(city));
        }

        [DataTestMethod]
        [DataRow(0)]
        [DataRow(1)]
        [DataRow(1000)]
        [DataRow(9999)]
        [DataRow(48734)]
        public void WesternerActualCountTestOnAverageCity(int expectedCount)
        {
            Westerner tourist = new Westerner(expectedCount);
            Assert.AreEqual((long)(expectedCount * averageMultiplier), tourist.ActualCount(Average.Instance()));
        }

        [DataTestMethod]
        [DataRow(0)]
        [DataRow(1)]
        [DataRow(1000)]
        [DataRow(9999)]
        [DataRow(48734)]
        public void WesternerDeteriorationCausedByVisitTestOnAverageCity(int expectedCount)
        {
            City city = new City(50, new List<Tourist>());
            Westerner tourist = new Westerner(expectedCount);
            Assert.AreEqual(((long)(expectedCount * averageMultiplier)) / 100, tourist.DeteriorationCausedByVisit(city));
        }

        [DataTestMethod]
        [DataRow(0)]
        [DataRow(1)]
        [DataRow(1000)]
        [DataRow(9999)]
        [DataRow(48734)]
        public void WesternerRevenueTestOnAverageCity(int expectedCount)
        {
            City city = new City(50, new List<Tourist>());
            Westerner tourist = new Westerner(expectedCount);
            Assert.AreEqual((long)(expectedCount * averageMultiplier) * 100_000, tourist.Revenue(city));
        }

        [DataTestMethod]
        [DataRow(0)]
        [DataRow(1)]
        [DataRow(1000)]
        [DataRow(9999)]
        [DataRow(48734)]
        public void WesternerActualCountTestOnGoodCity(int expectedCount)
        {
            Westerner tourist = new Westerner(expectedCount);
            Assert.AreEqual((long)(expectedCount * goodMultiplier), tourist.ActualCount(Good.Instance()));
        }

        [DataTestMethod]
        [DataRow(0)]
        [DataRow(1)]
        [DataRow(1000)]
        [DataRow(9999)]
        [DataRow(48734)]
        public void WesternerDeteriorationCausedByVisitTestOnGoodCity(int expectedCount)
        {
            City city = new City(80, new List<Tourist>());
            Westerner tourist = new Westerner(expectedCount);
            Assert.AreEqual(((long)(expectedCount * goodMultiplier)) / 100, tourist.DeteriorationCausedByVisit(city));
        }

        [DataTestMethod]
        [DataRow(0)]
        [DataRow(1)]
        [DataRow(1000)]
        [DataRow(9999)]
        [DataRow(48734)]
        public void WesternerRevenueTestOnGoodCity(int expectedCount)
        {
            City city = new City(80, new List<Tourist>());
            Westerner tourist = new Westerner(expectedCount);
            Assert.AreEqual((long)(expectedCount * goodMultiplier) * 100_000, tourist.Revenue(city));
        }
    }
}