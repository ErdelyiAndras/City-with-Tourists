using Beadando;

namespace BeadandoTest
{
    [TestClass]
    public class OtherTouristTest
    {
        private readonly double badMultiplier = 1.0;
        private readonly double averageMultiplier = 1.1;
        private readonly double goodMultiplier = 1.0;

        [DataTestMethod]
        [DataRow(0)]
        [DataRow(1)]
        [DataRow(1000)]
        [DataRow(9999)]
        [DataRow(48734)]
        public void OtherExpectedCountTest(int expectedCount)
        {
            Other tourist = new Other(expectedCount);
            Assert.AreEqual(expectedCount, tourist.ExpectedCount());
        }

        [DataTestMethod]
        [DataRow(0)]
        [DataRow(1)]
        [DataRow(1000)]
        [DataRow(9999)]
        [DataRow(48734)]
        public void OtherActualCountTestOnBadCity(int expectedCount)
        {
            Other tourist = new Other(expectedCount);
            Assert.AreEqual((long)(expectedCount * badMultiplier), tourist.ActualCount(Bad.Instance()));
        }

        [DataTestMethod]
        [DataRow(0)]
        [DataRow(1)]
        [DataRow(1000)]
        [DataRow(9999)]
        [DataRow(48734)]
        public void OtherDeteriorationCausedByVisitTestOnBadCity(int expectedCount)
        {
            City city = new City(10, new List<Tourist>());
            Other tourist = new Other(expectedCount);
            Assert.AreEqual(((long)(expectedCount * badMultiplier)) / 50, tourist.DeteriorationCausedByVisit(city));
        }

        [DataTestMethod]
        [DataRow(0)]
        [DataRow(1)]
        [DataRow(1000)]
        [DataRow(9999)]
        [DataRow(48734)]
        public void OtherRevenueTestOnBadCity(int expectedCount)
        {
            City city = new City(10, new List<Tourist>());
            Other tourist = new Other(expectedCount);
            Assert.AreEqual((long)(expectedCount * badMultiplier) * 100_000, tourist.Revenue(city));
        }

        [DataTestMethod]
        [DataRow(0)]
        [DataRow(1)]
        [DataRow(1000)]
        [DataRow(9999)]
        [DataRow(48734)]
        public void OtherActualCountTestOnAverageCity(int expectedCount)
        {
            Other tourist = new Other(expectedCount);
            Assert.AreEqual((long)(expectedCount * averageMultiplier), tourist.ActualCount(Average.Instance()));
        }

        [DataTestMethod]
        [DataRow(0)]
        [DataRow(1)]
        [DataRow(1000)]
        [DataRow(9999)]
        [DataRow(48734)]
        public void OtherDeteriorationCausedByVisitTestOnAverageCity(int expectedCount)
        {
            City city = new City(50, new List<Tourist>());
            Other tourist = new Other(expectedCount);
            Assert.AreEqual(((long)(expectedCount * averageMultiplier)) / 50, tourist.DeteriorationCausedByVisit(city));
        }

        [DataTestMethod]
        [DataRow(0)]
        [DataRow(1)]
        [DataRow(1000)]
        [DataRow(9999)]
        [DataRow(48734)]
        public void OtherRevenueTestOnAverageCity(int expectedCount)
        {
            City city = new City(50, new List<Tourist>());
            Other tourist = new Other(expectedCount);
            Assert.AreEqual((long)(expectedCount * averageMultiplier) * 100_000, tourist.Revenue(city));
        }

        [DataTestMethod]
        [DataRow(0)]
        [DataRow(1)]
        [DataRow(1000)]
        [DataRow(9999)]
        [DataRow(48734)]
        public void OtherActualCountTestOnGoodCity(int expectedCount)
        {
            Other tourist = new Other(expectedCount);
            Assert.AreEqual((long)(expectedCount * goodMultiplier), tourist.ActualCount(Good.Instance()));
        }

        [DataTestMethod]
        [DataRow(0)]
        [DataRow(1)]
        [DataRow(1000)]
        [DataRow(9999)]
        [DataRow(48734)]
        public void OtherDeteriorationCausedByVisitTestOnGoodCity(int expectedCount)
        {
            City city = new City(80, new List<Tourist>());
            Other tourist = new Other(expectedCount);
            Assert.AreEqual(((long)(expectedCount * goodMultiplier)) / 50, tourist.DeteriorationCausedByVisit(city));
        }

        [DataTestMethod]
        [DataRow(0)]
        [DataRow(1)]
        [DataRow(1000)]
        [DataRow(9999)]
        [DataRow(48734)]
        public void OtherRevenueTestOnGoodCity(int expectedCount)
        {
            City city = new City(80, new List<Tourist>());
            Other tourist = new Other(expectedCount);
            Assert.AreEqual((long)(expectedCount * goodMultiplier) * 100_000, tourist.Revenue(city));
        }
    }
}