using Beadando;

namespace BeadandoTest
{
    [TestClass]
    public class CityTest
    {
        [DataTestMethod]
        [DataRow(1, -1, 0, 0, 0)]
        [DataRow(1, 0, 10, 0, 10)]
        [DataRow(10, 10, 100, 10, 0)]
        [DataRow(33, 33, 0, 210, 0)]
        [DataRow(34, 34, 1000, 10000, 5000)]
        [DataRow(50, 50, 400, 0, 0)]
        [DataRow(67, 67, 0, 0, 300)]
        [DataRow(68, 68, 0, 30, 20000)]
        [DataRow(80, 80, 70, 100, 5000)]
        [DataRow(100, 100, 1000, 4000, 6000)]
        [DataRow(100, 101, 1, 1, 1)]
        public void CityConstructorTest(int expected, int stateValue, int japaneseCount, int westernerCount, int otherCount)
        {
            IState state = Average.Instance();
            if (stateValue < 34)
            {
                state = Bad.Instance();
            }
            else if (stateValue > 67)
            {
                state = Good.Instance();
            }
            List<Tourist> tourists = [new Japanese(japaneseCount), new Westerner(westernerCount), new Other(otherCount)];
            City city = new City(stateValue, tourists);
            Assert.AreEqual(expected, city.StateValue);
            Assert.AreEqual(state.ToString(), city.State.ToString());
            CollectionAssert.AreEqual(tourists, city.Tourists);
        }

        [DataTestMethod]
        [DataRow(1, -1)]
        [DataRow(1, 0)]
        [DataRow(10, 10)]
        [DataRow(33, 33)]
        [DataRow(34, 34)]
        [DataRow(50, 50)]
        [DataRow(67, 67)]
        [DataRow(68, 68)]
        [DataRow(80, 80)]
        [DataRow(100, 100)]
        [DataRow(100, 101)]
        public void SimulateYearTestEmptyList(int expectedState, int initState)
        {
            City city = new City(initState, new List<Tourist>());
            city.SimulateYear();
            Assert.AreEqual(expectedState, city.StateValue);
        }

        [DataTestMethod]
        [DataRow(1, -1, 0)]
        [DataRow(1, 0, 0)]
        [DataRow(10, 10, 10)]
        [DataRow(33, 33, 10)]
        [DataRow(34, 34, 100)]
        [DataRow(50, 50, 100)]
        [DataRow(67, 67, 1000)]
        [DataRow(68, 68, 1000)]
        [DataRow(80, 80, 10000)]
        [DataRow(100, 100, 10000)]
        [DataRow(100, 101, 3435)]
        public void SimulateYearTestOneJapaneseInList(int expectedState, int initState, int japaneseCount)
        {
            List<Tourist> tourists = new List<Tourist>([new Japanese(japaneseCount)]);
            City city = new City(initState, tourists);
            city.SimulateYear();
            Assert.AreEqual(expectedState, city.StateValue);
        }

        [DataTestMethod]
        [DataRow(1, -1, 0)]
        [DataRow(1, 0, 0)]
        [DataRow(10, 10, 10)]
        [DataRow(33, 33, 10)]
        [DataRow(33, 34, 100)]
        [DataRow(49, 50, 100)]
        [DataRow(56, 67, 1000)]
        [DataRow(55, 68, 1000)]
        [DataRow(1, 80, 10000)]
        [DataRow(1, 100, 10000)]
        [DataRow(56, 101, 3435)]
        public void SimulateYearTestOneWesternerInList(int expectedState, int initState, int westernerCount)
        {
            List<Tourist> tourists = new List<Tourist>([new Westerner(westernerCount)]);
            City city = new City(initState, tourists);
            city.SimulateYear();
            Assert.AreEqual(expectedState, city.StateValue);
        }

        [DataTestMethod]
        [DataRow(1, -1, 0)]
        [DataRow(1, 0, 0)]
        [DataRow(10, 10, 10)]
        [DataRow(33, 33, 10)]
        [DataRow(32, 34, 100)]
        [DataRow(48, 50, 100)]
        [DataRow(45, 67, 1000)]
        [DataRow(48, 68, 1000)]
        [DataRow(1, 80, 10000)]
        [DataRow(1, 100, 10000)]
        [DataRow(32, 101, 3435)]
        public void SimulateYearTestOneOtherInList(int expectedState, int initState, int otherCount)
        {
            List<Tourist> tourists = new List<Tourist>([new Other(otherCount)]);
            City city = new City(initState, tourists);
            city.SimulateYear();
            Assert.AreEqual(expectedState, city.StateValue);
        }

        [DataTestMethod]
        [DataRow(1, -1, 0, 0, 0)]
        [DataRow(1, 0, 0, 0, 0)]
        [DataRow(10, 10, 10, 10, 10)]
        [DataRow(33, 33, 10, 10, 20)]
        [DataRow(26, 34, 100, 200, 300)]
        [DataRow(28, 50, 100, 300, 900)]
        [DataRow(37, 67, 1000, 1200, 800)]
        [DataRow(34, 68, 1000, 800, 1200)]
        [DataRow(1, 80, 10000, 20000, 30000)]
        [DataRow(1, 100, 10000, 100000, 1000000)]
        [DataRow(1, 101, 3435, 4541, 7541)]
        public void SimulateYearTestMultipleTouristsInList(int expectedState, int initState, int japaneseCount, int westernerCount, int otherCount)
        {
            List<Tourist> tourists = new List<Tourist>([new Japanese(japaneseCount), new Westerner(westernerCount), new Other(otherCount)]);
            City city = new City(initState, tourists);
            city.SimulateYear();
            Assert.AreEqual(expectedState, city.StateValue);
        }
    }
}