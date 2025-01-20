namespace Beadando
{
    public class City
    {
        private int stateValue;
        private IState state = null!;
        private List<Tourist> tourists = null!;

        public int StateValue
        {
            get
            {
                return stateValue;
            }
        }

        public IState State
        {
            get
            {
                return state;
            }
        }

        public List<Tourist> Tourists
        {
            get
            {
                return tourists;
            }
        }

        public City(int initStateValue, List<Tourist> initTourists)
        {
            SetStateValue(initStateValue);
            SetState();
            SetTourists(initTourists);
        }

        private void SetStateValue(int newStateValue)
        {
            if (newStateValue < 1)
            {
                stateValue = 1;
            }
            else if (newStateValue > 100)
            {
                stateValue = 100;
            }
            else
            {
                stateValue = newStateValue;
            }
        }

        private void SetState()
        {
            if (1 <= stateValue && stateValue <= 33)
            {
                state = Bad.Instance();
            }
            else if (34 <= stateValue && stateValue <= 67)
            {
                state = Average.Instance();
            }
            else if (68 <= stateValue && stateValue <= 100)
            {
                state = Good.Instance();
            }
            else
            {
                throw new ArgumentOutOfRangeException("Invalid state value");
            }
        }

        public void SetTourists(List<Tourist> tourists)
        {
            this.tourists = tourists;
        }

        public List<long> ExpectedTourists()
        {
            List<long> expectedTourists = new List<long>();
            foreach (Tourist t in tourists)
            {
                expectedTourists.Add(t.ExpectedCount());
            }
            return expectedTourists;
        }

        public List<long> ActualTourists()
        {
            List<long> actualTourists = new List<long>();
            foreach (Tourist t in tourists)
            {
                actualTourists.Add(t.ActualCount(state));
            }
            return actualTourists;
        }

        public long Revenue()
        {
            long revenue = 0;
            foreach (Tourist t in tourists)
            {
                revenue += t.Revenue(this);
            }
            return revenue;
        }

        private long Deterioration()
        {
            long deterioration = 0;
            foreach (Tourist t in tourists)
            {
                deterioration += t.DeteriorationCausedByVisit(this);
            }
            return deterioration;
        }

        private long Improvement()
        {
            if (Revenue() < 20_000_000_000)
            {
                return 0;
            }
            return ((Revenue() - 20_000_000_000) / 50_000_000);
        }

        public void SimulateYear()
        {
            SetStateValue(stateValue  + (int)(-Deterioration() + Improvement()));
            SetState();
        }
    }
}
