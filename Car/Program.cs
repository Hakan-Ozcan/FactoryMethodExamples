using Car;

class Program
{
    static void Main(string[] args)
    {
        CarFactory sedanFactory = new SedanFactory();
        Car.Car sedanAraba = sedanFactory.CreateCar();
        sedanAraba.Drive();

        CarFactory suvFactory = new SUVFactory();
        Car.Car suvAraba = suvFactory.CreateCar();
        suvAraba.Drive();
    }
}
