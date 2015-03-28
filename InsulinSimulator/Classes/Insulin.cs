using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InsulinSimulator.Classes
{
    public class Insulin
    {
        private int amount = 0;
        private int totalEffect = 0;
        private int halfLife = 7;
        private int effectPerUnit = 40;
        private int timeToEffect = 14;
        private int timeOfEffect = 60;

        public Insulin()
        {
        }

        public Insulin(int amountIns)
        {
            Amount = amountIns;
        }

        public int Amount
        {
            get { return amount; }
            set { amount = value; }
        }

        public int TotalEffect
        {
            get { return totalEffect; }
            set { totalEffect = value; }
        }

        public int HalfLife
        {
            get { return halfLife; }
        }

        public int EffectPerUnit
        {
            get { return effectPerUnit; }
        }

        public int TimeToEffect
        {
            get { return timeToEffect; }
        }

        public int TimeOfEffect
        {
            get { return timeOfEffect; }
        }
    }
}
