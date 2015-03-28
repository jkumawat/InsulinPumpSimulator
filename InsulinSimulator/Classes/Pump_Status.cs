using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InsulinSimulator.Classes
{
    public enum Pump_Status
    {
        Ok,
        LowBattery,
        NeedleRemoved,
        RepositoryDepleted,
        RepositoryLow,
        Malfunctioning
    };
}
