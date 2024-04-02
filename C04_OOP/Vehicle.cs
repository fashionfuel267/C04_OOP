using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C04_OOP
{
    enum VehicleType
    {
        TwoWheeler = 2,
        ThreeWheeler = 3,
        FourWheeler = 4

    }
    internal abstract class Vehicle
    {
        public VehicleType vehicleTypes { get; set; }
        public string ModelNo { get; set; }
        public int YearMake { get; set; }
        //
        public int NumberOfGear { get; set; }
        public int EngineCapacityCC { get; set; }
        public decimal MilagePowerNM { get; set; }

    }
}
