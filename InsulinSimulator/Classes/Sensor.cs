using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InsulinSimulator.Classes
{
    public class Sensor
    {
        private double currentData = 0;
        private Sensor_Status currentStatus;
        private Insulin insInfo = new Insulin();
        private Random randomGen = new Random();
        private List<DateTime> timeInject = new List<DateTime>();
        private Reading lastReading;
        private Random random = new Random();
        private int errorDuration = 0;

        public Sensor()
        {
            CurrentStatus = Sensor_Status.Ok;
            lastReading = new Reading(0, DateTime.Now);         
        }

        public double readData()
        {
            double newReading;
            double rate = 0;
            
            try
            {
                if (lastReading.Read != 0)
                {
                    if (timeInject.Count != 0)
                    {
                        for(int i=0; i<timeInject.Count ; i++)
                        {
                            DateTime tmp = timeInject[i];
                            long t = (long)(lastReading.TimeStamp - tmp).TotalSeconds;
                            //System.Windows.Forms.MessageBox.Show("Last Reading " + lastReading.TimeStamp.ToString() + " Temp: " + tmp.ToString() + "Sensor t:=" + t.ToString());
                            
                            if (t > (insInfo.TimeOfEffect + insInfo.TimeToEffect))
                            {
                                timeInject.Remove(tmp);
                                i--;
                            }

                            else
                            {
                                if (t >= insInfo.TimeToEffect)
                                {
                                    rate += insInfo.EffectPerUnit * Math.Exp(-0.694 * (t - insInfo.TimeToEffect) / insInfo.HalfLife);
                                }
                            }
                        }

                        rate = Math.Round(rate, 2);
                        newReading = lastReading.Read + Convert.ToDouble(randomGen.Next(1, 10)) - rate;
                        newReading = newReading < 0 ? 0 : newReading;
                    }

                    else
                    {
                        newReading = lastReading.Read + randomGen.Next(1, 10);
                    }
                }

                else
                {
                    newReading = lastReading.Read + 100;
                }

                lastReading.Read = newReading;
                lastReading.TimeStamp = DateTime.Now;

                return newReading;
            }
            catch (Exception e)
            {
                currentStatus = Sensor_Status.Malfunctioning;
                // feedback & reset normal service
            }
            return 0;
        }

        public int runSelfTest()
        {
            bool temp = false;
            temp = (random.NextDouble() < 0.00001) ? true : false;

            if (currentStatus == Sensor_Status.LowBaterry)
            {
                return (int)Sensor_Status.LowBaterry;
            }

            if (currentStatus == Sensor_Status.Malfunctioning && errorDuration < 10)
            {
                errorDuration++;
                return (int)Sensor_Status.Malfunctioning;
            }
            
            if (temp)
            {
                errorDuration = 0;
                currentStatus = Sensor_Status.Malfunctioning;
                return (int)Sensor_Status.Malfunctioning;               
            }

            else
            {
                errorDuration = 0;
                currentStatus = Sensor_Status.Ok;
                return (int)Sensor_Status.Ok;               
            }
        }

        public void resetSensor()
        {
            currentStatus = Sensor_Status.Ok;
        }

        public void addTimeInject(DateTime tmp)
        {
            timeInject.Add(tmp);
        }

        public double CurrentData
        {
            get { return currentData; }
            set { currentData = value; }
        }

        public Sensor_Status CurrentStatus
        {
            get { return currentStatus; }
            set { currentStatus = value; }
        }

        public List<DateTime> TimeInject
        {
            get { return timeInject; }
            set { timeInject = value; }
        }

        public Reading LastReading
        {
            get { return lastReading; }
            set { lastReading = value; }
        }

       

    }
}
