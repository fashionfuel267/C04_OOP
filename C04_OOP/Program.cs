using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C04_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("choose vehicle:");
            Console.WriteLine("Press '4' for car or Press '2' for motorcycle");
            int vehicleType = int.Parse(Console.ReadLine());
            #region Car Calling
            if (vehicleType == (int)VehicleType.FourWheeler)
            {
                Car probox = new Car();
                probox.vehicleTypes = VehicleType.FourWheeler;
                Console.WriteLine("Put Car Model Number:");
                probox.ModelNo = Console.ReadLine();
                Console.WriteLine("Put Car Make Year:");
                probox.YearMake = int.Parse(Console.ReadLine());
                Console.WriteLine("Put Car Engine Capacity CC:");
                probox.EngineCapacityCC = int.Parse(Console.ReadLine());
                Console.WriteLine("Put Car Milage:");
                probox.MilagePowerNM = decimal.Parse(Console.ReadLine());
                Console.WriteLine("Number Of Door:");
                probox.NumberOfDoor = int.Parse(Console.ReadLine());
                Console.WriteLine("Number Of Gear:");
                probox.NumberOfGear = int.Parse(Console.ReadLine());
                IInteriorDesign iInterior = new FourWheeler();
                iInterior.DesignInterior(probox);
            }
            #endregion
            #region Motorcycle Calling
            else if (vehicleType == (int)VehicleType.TwoWheeler)
            {
                Motorcycle oMotorcycle = new Motorcycle();
                oMotorcycle.vehicleTypes = VehicleType.TwoWheeler;
                Console.WriteLine("Put Motorcycle Model Number:");
                oMotorcycle.ModelNo = Console.ReadLine();
                Console.WriteLine("Put Motorcycle Make Year:");
                oMotorcycle.YearMake = int.Parse(Console.ReadLine());
                Console.WriteLine("Put Motorcycle Engine Capacity CC:");
                oMotorcycle.EngineCapacityCC = int.Parse(Console.ReadLine());
                Console.WriteLine("Put Motorcycle  MilagePower NM:");
                oMotorcycle.MilagePowerNM = decimal.Parse(Console.ReadLine());
                Console.WriteLine("Put Motorcycle  Maximum Power in BPH:");
                oMotorcycle.BPH = decimal.Parse(Console.ReadLine());
                Console.WriteLine("Put Motorcycle  Mileage in KMPL:");
                oMotorcycle.KMPL = decimal.Parse(Console.ReadLine());
                Console.WriteLine("Put Number Of  Cooling:");
                oMotorcycle.Cooling = decimal.Parse(Console.ReadLine());
                Console.WriteLine("Put Number Of Gear:");
                oMotorcycle.NumberOfGear = int.Parse(Console.ReadLine());
                Console.WriteLine("Put Number Of Front Break:");
                oMotorcycle.FrontBreak = int.Parse(Console.ReadLine());
                Console.WriteLine("Put Number Of Rear Gear:");
                oMotorcycle.RearBreak = int.Parse(Console.ReadLine());
                IExteriorDesign iExterior = new TwoWheeler();
                iExterior.DesignExterior(oMotorcycle);
            }
            #endregion
            else
            {
                Console.WriteLine("vehicle not found.");
            }

            Console.ReadLine();

        }
    }
}
