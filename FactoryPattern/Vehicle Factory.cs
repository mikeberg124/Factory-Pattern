using System;
namespace FactoryPattern
{
	public static class Vehicle_Factory
	{
		public static IVehicle GetVehicle(int wheelCount)
		{
            return wheelCount switch
            {
                2 => new Motorcycle(),
                4 => new Car(),
                0 => new Boat(),
                _ => new Car(),
            };
        }

       
        
    }
}

