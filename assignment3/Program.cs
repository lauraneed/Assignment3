namespace assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyTruck Fred = new MyTruck("bmw",100,4,5);
           
            Console.WriteLine("Car Brand: " + Fred.GetBrand());
            Console.WriteLine("How fast it drives:" + Fred.GetSpeed());
            Console.WriteLine("Number of wheels the truck has:" + Fred.GetNumberOfWheels());
            Console.WriteLine("Number of doors the truck has:" + Fred.GetNumberOfDoor());
        }
    }
}
