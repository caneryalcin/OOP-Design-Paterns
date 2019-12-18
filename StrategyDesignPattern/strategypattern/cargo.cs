using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strategypattern
{
    interface ICargoStrategy
    {
        void loadCargo();
    }

    //ConcreteStrategy1
    class ShipCargo : ICargoStrategy
    {
        public void loadCargo()
        {
            Console.WriteLine("Cargo vehicle is a ship");
        }
    }
    //ConcreteStrategy2
    class TruckCargo : ICargoStrategy
    {
        public void loadCargo()
        {
            Console.WriteLine("Cargo vehicle is a truck");
        }
    }
    //ConcreteStrategy3
    class PlaneCargo : ICargoStrategy
    {
        public void loadCargo()
        {
            Console.WriteLine("Cargo vehicle is a plane");
        }
    }
    //Context yapısı
    class Cargo
    {
        ICargoStrategy cargostrategy;
        public Cargo(ICargoStrategy cargostrategy)
        {
            this.cargostrategy = cargostrategy;
        }
        public void CargoVehicleInfo()
        {
            cargostrategy.loadCargo();
        }
    }

}
