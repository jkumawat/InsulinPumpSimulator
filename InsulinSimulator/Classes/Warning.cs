using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InsulinSimulator.Classes
{
    public enum Warning
    {
        Ok,
        BloodSugarHigh,
        BloodSugarStable,
        BloodSugarLow,
        PumpFailure,
        SensorFailure,
        BatteryLow,
        DeliveryFailure,
        NeedleRemoved,
        RepositoryRemoved,
        RepositoryLow,
    };
}
