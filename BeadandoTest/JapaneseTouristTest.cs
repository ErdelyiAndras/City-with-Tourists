using Beadando;

namespace BeadandoTest
{
    [TestClass]
    public class JapaneseTouristTest
    {
        private readonly double badMultiplier = 0.0;
        private readonly double averageMultiplier = 1.0;
        private readonly double goodMultiplier = 1.2;

        [DataTestMethod]
        [DataRow(0)]
        [DataRow(1)]
        [DataRow(1000)]
        [DataRow(9999)]
        [DataRow(48734)]
        public void JapaneseExpectedCountTest(int expectedCount)
        {
            Japanese tourist = new Japanese(expectedCount);
            Assert.AreEqual(expectedCount, tourist.ExpectedCount());
        }

        [DataTestMethod]
        [DataRow(0)]
        [DataRow(1)]
        [DataRow(1000)]
        [DataRow(9999)]
        [DataRow(48734)]
        public void JapaneseActualCountTestOnBadCity(int expectedCount)
        {
            Japanese tourist = new Japanese(expectedCount);
            Assert.AreEqual((long)(expectedCount * badMultiplier), tourist.ActualCount(Bad.Instance()));
        }

        [DataTestMethod]
        [DataRow(0)]
        [DataRow(1)]
        [DataRow(1000)]
        [DataRow(9999)]
        [DataRow(48734)]
        public void JapaneseDeteriorationCausedByVisitTestOnBadCity(int expectedCount)
        {
            City city = new City(10, new List<Tourist>());
            Japanese tourist = new Japanese(expectedCount);
            Assert.AreEqual(0, tourist.DeteriorationCausedByVisit(city));
        }

        [DataTestMethod]
        [DataRow(0)]
        [DataRow(1)]
        [DataRow(1000)]
        [DataRow(9999)]
        [DataRow(48734)]
        public void JapaneseRevenueTestOnBadCity(int expectedCount)
        {
            City city = new City(10, new List<Tourist>());
            Japanese tourist = new Japanese(expectedCount);
            Assert.AreEqual((long)(expectedCount * badMultiplier) * 100_000, tourist.Revenue(city));
        }

        [DataTestMethod]
        [DataRow(0)]
        [DataRow(1)]
        [DataRow(1000)]
        [DataRow(9999)]
        [DataRow(48734)]
        public void JapaneseActualCountTestOnAverageCity(int expectedCount)
        {
            Japanese tourist = new Japanese(expectedCount);
            Assert.AreEqual((long)(expectedCount * averageMultiplier), tourist.ActualCount(Average.Instance()));
        }

        [DataTestMethod]
        [DataRow(0)]
        [DataRow(1)]
        [DataRow(1000)]
        [DataRow(9999)]
        [DataRow(48734)]
        public void JapaneseDeteriorationCausedByVisitTestOnAverageCity(int expectedCount)
        {
            City city = new City(50, new List<Tourist>());
            Japanese tourist = new Japanese(expectedCount);
            Assert.AreEqual(0, tourist.DeteriorationCausedByVisit(city));
        }

        [DataTestMethod]
        [DataRow(0)]
        [DataRow(1)]
        [DataRow(1000)]
        [DataRow(9999)]
        [DataRow(48734)]
        public void JapaneseRevenueTestOnAverageCity(int expectedCount)
        {
            City city = new City(50, new List<Tourist>());
            Japanese tourist = new Japanese(expectedCount);
            Assert.AreEqual((long)(expectedCount * averageMultiplier) * 100_000, tourist.Revenue(city));
        }

        [DataTestMethod]
        [DataRow(0)]
        [DataRow(1)]
        [DataRow(1000)]
        [DataRow(9999)]
        [DataRow(48734)]
        public void JapaneseActualCountTestOnGoodCity(int expectedCount)
        {
            Japanese tourist = new Japanese(expectedCount);
            Assert.AreEqual((long)(expectedCount * goodMultiplier), tourist.ActualCount(Good.Instance()));
        }

        [DataTestMethod]
        [DataRow(0)]
        [DataRow(1)]
        [DataRow(1000)]
        [DataRow(9999)]
        [DataRow(48734)]
        public void JapaneseDeteriorationCausedByVisitTestOnGoodCity(int expectedCount)
        {
            City city = new City(80, new List<Tourist>());
            Japanese tourist = new Japanese(expectedCount);
            Assert.AreEqual(0, tourist.DeteriorationCausedByVisit(city));
        }

        [DataTestMethod]
        [DataRow(0)]
        [DataRow(1)]
        [DataRow(1000)]
        [DataRow(9999)]
        [DataRow(48734)]
        public void JapaneseRevenueTestOnGoodCity(int expectedCount)
        {
            City city = new City(80, new List<Tourist>());
            Japanese tourist = new Japanese(expectedCount);
            Assert.AreEqual((long)(expectedCount * goodMultiplier) * 100_000, tourist.Revenue(city));
        }
    }
}