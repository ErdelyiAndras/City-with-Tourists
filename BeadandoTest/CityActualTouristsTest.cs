using Beadando;

namespace BeadandoTest
{
    [TestClass]
    public class CityActualTouristsTest
    {
        [TestMethod]
        public void ActualTouristsTestEmptyList()
        {
            City city = new City(50, []);
            CollectionAssert.AreEqual(new List<long>(), city.ActualTourists());
        }

        [DataTestMethod]
        [DataRow(0)]
        [DataRow(1)]
        [DataRow(1000)]
        [DataRow(9999)]
        [DataRow(48734)]
        public void ActualTouristsTestOneJapaneseInListOnBadCity(int japaneseCount)
        {
            List<Tourist> tourists = [new Japanese(japaneseCount)];
            City city = new City(10, tourists);
            CollectionAssert.AreEqual(new List<long>([(long)(japaneseCount * 0.0)]), city.ActualTourists());
        }

        [DataTestMethod]
        [DataRow(0)]
        [DataRow(1)]
        [DataRow(1000)]
        [DataRow(9999)]
        [DataRow(48734)]
        public void ActualTouristsTestOneWesternerInListOnBadCity(int westernerCount)
        {
            List<Tourist> tourists = [new Westerner(westernerCount)];
            City city = new City(10, tourists);
            CollectionAssert.AreEqual(new List<long>([(long)(westernerCount * 1.0)]), city.ActualTourists());
        }

        [DataTestMethod]
        [DataRow(0)]
        [DataRow(1)]
        [DataRow(1000)]
        [DataRow(9999)]
        [DataRow(48734)]
        public void ActualTouristsTestOneOtherInListOnBadCity(int otherCount)
        {
            List<Tourist> tourists = [new Other(otherCount)];
            City city = new City(10, tourists);
            CollectionAssert.AreEqual(new List<long>([(long)(otherCount * 1.0)]), city.ActualTourists());
        }

        [DataTestMethod]
        [DataRow(0, 0, 0)]
        [DataRow(1, 1, 1)]
        [DataRow(1000, 1000, 2000)]
        [DataRow(9999, 10000, 10001)]
        [DataRow(48734, 23423, 86431)]
        public void ActualTouristsTestMultipleTouristsInListOnBadCity(int japaneseCount, int westernerCount, int otherCount)
        {
            List<Tourist> tourists = [new Japanese(japaneseCount), new Westerner(westernerCount), new Other(otherCount)];
            City city = new City(10, tourists);
            List<long> actualTourists = [(long)(japaneseCount * 0.0), (long)(westernerCount * 1.0), (long)(otherCount * 1.0)];
            CollectionAssert.AreEqual(actualTourists, city.ActualTourists());
        }

        [DataTestMethod]
        [DataRow(0)]
        [DataRow(1)]
        [DataRow(1000)]
        [DataRow(9999)]
        [DataRow(48734)]
        public void ActualTouristsTestOneJapaneseInListOnAverageCity(int japaneseCount)
        {
            List<Tourist> tourists = [new Japanese(japaneseCount)];
            City city = new City(50, tourists);
            CollectionAssert.AreEqual(new List<long>([(long)(japaneseCount * 1.0)]), city.ActualTourists());
        }

        [DataTestMethod]
        [DataRow(0)]
        [DataRow(1)]
        [DataRow(1000)]
        [DataRow(9999)]
        [DataRow(48734)]
        public void ActualTouristsTestOneWesternerInListOnAverageCity(int westernerCount)
        {
            List<Tourist> tourists = [new Westerner(westernerCount)];
            City city = new City(50, tourists);
            CollectionAssert.AreEqual(new List<long>([(long)(westernerCount * 1.1)]), city.ActualTourists());
        }

        [DataTestMethod]
        [DataRow(0)]
        [DataRow(1)]
        [DataRow(1000)]
        [DataRow(9999)]
        [DataRow(48734)]
        public void ActualTouristsTestOneOtherInListOnAverageCity(int otherCount)
        {
            List<Tourist> tourists = [new Other(otherCount)];
            City city = new City(50, tourists);
            CollectionAssert.AreEqual(new List<long>([(long)(otherCount * 1.1)]), city.ActualTourists());
        }

        [DataTestMethod]
        [DataRow(0, 0, 0)]
        [DataRow(1, 1, 1)]
        [DataRow(1000, 1000, 2000)]
        [DataRow(9999, 10000, 10001)]
        [DataRow(48734, 23423, 86431)]
        public void ActualTouristsTestMultipleTouristsInListOnAverageCity(int japaneseCount, int westernerCount, int otherCount)
        {
            List<Tourist> tourists = [new Japanese(japaneseCount), new Westerner(westernerCount), new Other(otherCount)];
            City city = new City(50, tourists);
            List<long> actualTourists = [(long)(japaneseCount * 1.0), (long)(westernerCount * 1.1), (long)(otherCount * 1.1)];
            CollectionAssert.AreEqual(actualTourists, city.ActualTourists());
        }

        [DataTestMethod]
        [DataRow(0)]
        [DataRow(1)]
        [DataRow(1000)]
        [DataRow(9999)]
        [DataRow(48734)]
        public void ActualTouristsTestOneJapaneseInListOnGoodCity(int japaneseCount)
        {
            List<Tourist> tourists = [new Japanese(japaneseCount)];
            City city = new City(80, tourists);
            CollectionAssert.AreEqual(new List<long>([(long)(japaneseCount * 1.2)]), city.ActualTourists());
        }

        [DataTestMethod]
        [DataRow(0)]
        [DataRow(1)]
        [DataRow(1000)]
        [DataRow(9999)]
        [DataRow(48734)]
        public void ActualTouristsTestOneWesternerInListOnGoodCity(int westernerCount)
        {
            List<Tourist> tourists = [new Westerner(westernerCount)];
            City city = new City(80, tourists);
            CollectionAssert.AreEqual(new List<long>([(long)(westernerCount * 1.3)]), city.ActualTourists());
        }

        [DataTestMethod]
        [DataRow(0)]
        [DataRow(1)]
        [DataRow(1000)]
        [DataRow(9999)]
        [DataRow(48734)]
        public void ActualTouristsTestOneOtherInListOnGoodCity(int otherCount)
        {
            List<Tourist> tourists = [new Other(otherCount)];
            City city = new City(80, tourists);
            CollectionAssert.AreEqual(new List<long>([(long)(otherCount * 1.0)]), city.ActualTourists());
        }

        [DataTestMethod]
        [DataRow(0, 0, 0)]
        [DataRow(1, 1, 1)]
        [DataRow(1000, 1000, 2000)]
        [DataRow(9999, 10000, 10001)]
        [DataRow(48734, 23423, 86431)]
        public void ActualTouristsTestMultipleTouristsInListOnGoodCity(int japaneseCount, int westernerCount, int otherCount)
        {
            List<Tourist> tourists = [new Japanese(japaneseCount), new Westerner(westernerCount), new Other(otherCount)];
            City city = new City(80, tourists);
            List<long> actualTourists = [(long)(japaneseCount * 1.2), (long)(westernerCount * 1.3), (long)(otherCount * 1.0)];
            CollectionAssert.AreEqual(actualTourists, city.ActualTourists());
        }
    }
}