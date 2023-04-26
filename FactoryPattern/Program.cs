namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            int numOfWheels;
            bool response = false;
            do
            {
                Console.WriteLine("Enter amount of tires for new vehicle");
                response = int.TryParse(Console.ReadLine(), out numOfWheels);

            } while (response == false);

            var vehcile = Vehicle_Factory.GetVehicle(numOfWheels);
            vehcile.Drive();
        }
    }
}



