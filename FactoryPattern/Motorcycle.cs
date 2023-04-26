using System;
namespace FactoryPattern
{
	public class Motorcycle : IVehicle
	{
		public Motorcycle()
		{


		}
        public void Drive()
        {

            Console.WriteLine("This can drive, but isn't a car");

        }
    }
}

