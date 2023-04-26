using System;
namespace FactoryPattern
{
	public class Boat : IVehicle
	{
		public Boat()
		{
		}
        public void Drive()
        {

            Console.WriteLine("This can't drive");

        }
    }
}


