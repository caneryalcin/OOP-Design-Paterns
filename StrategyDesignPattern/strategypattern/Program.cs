using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strategypattern
{
    class Program
    {
        static void Main(string[] args)
        {

            Cargo cargo = new Cargo(new ShipCargo());
            cargo.CargoVehicleInfo();
            cargo = new Cargo(new TruckCargo());
            cargo.CargoVehicleInfo();
            cargo = new Cargo(new PlaneCargo());
            cargo.CargoVehicleInfo();

           
            Console.ReadKey();

        }
    }
}
