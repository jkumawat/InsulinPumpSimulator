using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InsulinSimulator.Classes
{
    public class Reading
    {
        private double read;
        private DateTime timestamp;

        public Reading()
        {
        }

        public Reading(double reading, DateTime tmp)
        {
            Read = reading;
            TimeStamp = tmp;
        }

        public double Read
        {
            get { return read; }
            set { read = value; }
        }

        public DateTime TimeStamp
        {
            get { return timestamp; }
            set { timestamp = value; }
        }
    }
}
