using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InsulinSimulator.Classes
{
    public class Pump
    {
        private int currentReserve;
        private Pump_Status currentStatus;
        private Random random = new Random();
        private int errorDuration = 0;

        public Pump()
        {
            CurrentReserve = 20;
            currentStatus = Pump_Status.Ok;
        }

        public int PumpInsulin()
        {                        
             currentReserve -= 5;           
             return (int)Pump_Status.Ok;                          
        }

        public int PumpInsulin(Insulin dose)
        {
            bool temp = false;
            temp = (random.NextDouble() > 0.0001) ? true : false;

            if (temp && currentStatus == Pump_Status.Ok)
            {
                currentReserve -= dose.Amount;
                return (int)Pump_Status.Ok;
            }

            else
            {
                return (int)Pump_Status.Malfunctioning;
            }
        }

        public int runSelfTest()
        {
            if (currentStatus == Pump_Status.Malfunctioning && errorDuration < 10)
            {
                    errorDuration++;
                    return (int) Pump_Status.Malfunctioning;
            }

            if (currentReserve < 5)
            {
                currentStatus = Pump_Status.RepositoryDepleted;
                return (int)Pump_Status.RepositoryDepleted;
            }

            bool temp = false;
            temp = (random.NextDouble() < 0.00001) ? true : false;

            if (temp)
            {
                errorDuration = 0;
                currentStatus = Pump_Status.Malfunctioning;
                return (int) Pump_Status.Malfunctioning;
            }

            else
            {                           
                errorDuration = 0;
                currentStatus = Pump_Status.Ok;
                return (int) Pump_Status.Ok;       
            }
        }

        public void resetPump()
        {
            CurrentReserve = 20;
            currentStatus = Pump_Status.Ok;
        }

        public int ReplaceRepository()
        {
            currentReserve = 20;
            return (int)currentStatus;
        }

        public int CurrentReserve
        {
            get { return currentReserve; }
            set { currentReserve = value; }
        }

        public Pump_Status CurrentStatus
        {
            get { return currentStatus; }
            set { currentStatus = value; }
        }

        public int ErrorDuration
        {
            get { return errorDuration; }
            set { errorDuration = value; }
        }
    }
}
