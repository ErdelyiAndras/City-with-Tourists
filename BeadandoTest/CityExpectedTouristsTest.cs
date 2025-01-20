using Beadando;

namespace BeadandoTest
{
    [TestClass]
    public class CityExpectedTouristsTest
    {
        [TestMethod]
        public void ExpectedTouristsTestEmptyList()
        {
            City city = new City(50, []);
            CollectionAssert.AreEqual(new List<long>(), city.ExpectedTourists());
        }

        [DataTestMethod]
        [DataRow(0)]
        [DataRow(1)]
        [DataRow(1000)]
        [DataRow(9999)]
        [DataRow(48734)]
        public void ExpectedTouristsTestOneJapaneseInList(int japaneseCount)
        {
            List<Tourist> tourists = [new Japanese(japaneseCount)];
            City city = new City(50, tourists);
            CollectionAssert.AreEqual(new List<long>([japaneseCount]), city.ExpectedTourists());
        }

        [DataTestMethod]
        [DataRow(0)]
        [DataRow(1)]
        [DataRow(1000)]
        [DataRow(9999)]
        [DataRow(48734)]
        public void ExpectedTouristsTestOneWesternerInList(int westernerCount)
        {
            List<Tourist> tourists = [new Westerner(westernerCount)];
            City city = new City(50, tourists);
            CollectionAssert.AreEqual(new List<long>([westernerCount]), city.ExpectedTourists());
        }

        [DataTestMethod]
        [DataRow(0)]
        [DataRow(1)]
        [DataRow(1000)]
        [DataRow(9999)]
        [DataRow(48734)]
        public void ExpectedTouristsTestOneOtherInList(int otherCount)
        {
            List<Tourist> tourists = [new Japanese(otherCount)];
            City city = new City(50, tourists);
            CollectionAssert.AreEqual(new List<long>([otherCount]), city.ExpectedTourists());
        }

        [DataTestMethod]
        [DataRow(0, 0, 0)]
        [DataRow(1, 1, 1)]
        [DataRow(1000, 1000, 2000)]
        [DataRow(9999, 10000, 10001)]
        [DataRow(48734, 23423, 86431)]
        public void ExpectedTouristsTestMultipleTouristsInList(int japaneseCount, int westernerCount, int otherCount)
        {
            List<Tourist> tourists = [new Japanese(japaneseCount), new Westerner(westernerCount), new Other(otherCount)];
            City city = new City(50, tourists);
            CollectionAssert.AreEqual(new List<long>([japaneseCount, westernerCount, otherCount]), city.ExpectedTourists());
        }
    }
}