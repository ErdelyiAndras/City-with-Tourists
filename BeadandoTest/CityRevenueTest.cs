using Beadando;

namespace BeadandoTest
{
    [TestClass]
    public class CityRevenueTest
    {
        [TestMethod]
        public void RevenueTestEmptyList()
        {
            City city = new City(50, []);
            Assert.AreEqual(0, city.Revenue());
        }

        [DataTestMethod]
        [DataRow(0)]
        [DataRow(1)]
        [DataRow(1000)]
        [DataRow(9999)]
        [DataRow(48734)]
        public void RevenueTestOneJapaneseInListOnBadCity(int japaneseCount)
        {
            List<Tourist> tourists = [new Japanese(japaneseCount)];
            City city = new City(10, tourists);
            Assert.AreEqual(0, city.Revenue());
        }

        [DataTestMethod]
        [DataRow(0)]
        [DataRow(1)]
        [DataRow(1000)]
        [DataRow(9999)]
        [DataRow(48734)]
        public void RevenueTestOneWesternerInListOnBadCity(int westernerCount)
        {
            List<Tourist> tourists = [new Westerner(westernerCount)];
            City city = new City(10, tourists);
            Assert.AreEqual((long)(westernerCount * 1.0) * 100_000, city.Revenue());
        }

        [DataTestMethod]
        [DataRow(0)]
        [DataRow(1)]
        [DataRow(1000)]
        [DataRow(9999)]
        [DataRow(48734)]
        public void RevenueTestOneOtherInListOnBadCity(int otherCount)
        {
            List<Tourist> tourists = [new Other(otherCount)];
            City city = new City(10, tourists);
            Assert.AreEqual((long)(otherCount * 1.0) * 100_000, city.Revenue());
        }

        [DataTestMethod]
        [DataRow(0, 0, 0)]
        [DataRow(1, 1, 1)]
        [DataRow(1000, 1000, 2000)]
        [DataRow(9999, 10000, 10001)]
        [DataRow(48734, 23423, 86431)]
        public void RevenueTestMultipleTouristsInListOnBadCity(int japaneseCount, int westernerCount, int otherCount)
        {
            List<Tourist> tourists = [new Japanese(japaneseCount), new Westerner(westernerCount), new Other(otherCount)];
            City city = new City(10, tourists);
            long revenue = 0 + (long)(westernerCount * 1.0) * 100_000 + (long)(otherCount * 1.0) * 100_000;
            Assert.AreEqual(revenue, city.Revenue());
        }

        [DataTestMethod]
        [DataRow(0)]
        [DataRow(1)]
        [DataRow(1000)]
        [DataRow(9999)]
        [DataRow(48734)]
        public void RevenueTestOneJapaneseInListOnAverageCity(int japaneseCount)
        {
            List<Tourist> tourists = [new Japanese(japaneseCount)];
            City city = new City(50, tourists);
            Assert.AreEqual((long)(japaneseCount * 1.0) * 100_000, city.Revenue());
        }

        [DataTestMethod]
        [DataRow(0)]
        [DataRow(1)]
        [DataRow(1000)]
        [DataRow(9999)]
        [DataRow(48734)]
        public void RevenueTestOneWesternerInListOnAverageCity(int westernerCount)
        {
            List<Tourist> tourists = [new Westerner(westernerCount)];
            City city = new City(50, tourists);
            Assert.AreEqual((long)(westernerCount * 1.1) * 100_000, city.Revenue());
        }

        [DataTestMethod]
        [DataRow(0)]
        [DataRow(1)]
        [DataRow(1000)]
        [DataRow(9999)]
        [DataRow(48734)]
        public void RevenueTestOneOtherInListOnAverageCity(int otherCount)
        {
            List<Tourist> tourists = [new Other(otherCount)];
            City city = new City(50, tourists);
            Assert.AreEqual((long)(otherCount * 1.1) * 100_000, city.Revenue());
        }

        [DataTestMethod]
        [DataRow(0, 0, 0)]
        [DataRow(1, 1, 1)]
        [DataRow(1000, 1000, 2000)]
        [DataRow(9999, 10000, 10001)]
        [DataRow(21231, 23423, 12347)]
        public void RevenueTestMultipleTouristsInListOnAverageCity(int japaneseCount, int westernerCount, int otherCount)
        {
            List<Tourist> tourists = [new Japanese(japaneseCount), new Westerner(westernerCount), new Other(otherCount)];
            City city = new City(50, tourists);
            long revenue = (long)(japaneseCount * 1.0) * 100_000 + (long)(westernerCount * 1.1) * 100_000 + (long)(otherCount * 1.1) * 100_000;
            Assert.AreEqual(revenue, city.Revenue());
        }

        [DataTestMethod]
        [DataRow(0)]
        [DataRow(1)]
        [DataRow(1000)]
        [DataRow(9999)]
        [DataRow(48734)]
        public void RevenueTestOneJapaneseInListOnGoodCity(int japaneseCount)
        {
            List<Tourist> tourists = [new Japanese(japaneseCount)];
            City city = new City(80, tourists);
            Assert.AreEqual((long)(japaneseCount * 1.2) * 100_000, city.Revenue());
        }

        [DataTestMethod]
        [DataRow(0)]
        [DataRow(1)]
        [DataRow(1000)]
        [DataRow(9999)]
        [DataRow(48734)]
        public void RevenueTestOneWesternerInListOnGoodCity(int westernerCount)
        {
            List<Tourist> tourists = [new Westerner(westernerCount)];
            City city = new City(80, tourists);
            Assert.AreEqual((long)(westernerCount * 1.3) * 100_000, city.Revenue());
        }

        [DataTestMethod]
        [DataRow(0)]
        [DataRow(1)]
        [DataRow(1000)]
        [DataRow(9999)]
        [DataRow(48734)]
        public void RevenueTestOneOtherInListOnGoodCity(int otherCount)
        {
            List<Tourist> tourists = [new Other(otherCount)];
            City city = new City(80, tourists);
            Assert.AreEqual((long)(otherCount * 1.0) * 100_000, city.Revenue());
        }

        [DataTestMethod]
        [DataRow(0, 0, 0)]
        [DataRow(1, 1, 1)]
        [DataRow(1000, 1000, 2000)]
        [DataRow(9999, 10000, 10001)]
        [DataRow(21231, 23423, 12347)]
        public void RevenueTestMultipleTouristsInListOnGoodCity(int japaneseCount, int westernerCount, int otherCount)
        {
            List<Tourist> tourists = [new Japanese(japaneseCount), new Westerner(westernerCount), new Other(otherCount)];
            City city = new City(80, tourists);
            long revenue = (long)(japaneseCount * 1.2) * 100_000 + (long)(westernerCount * 1.3) * 100_000 + (long)(otherCount * 1.0) * 100_000;
            Assert.AreEqual(revenue, city.Revenue());
        }
    }
}