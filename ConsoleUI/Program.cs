using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

namespace ConsoleUI
{
    public class Program
    {
        static void Main(string[] args)
        {
            //CarTest();
            CarDetails();

        }

        private static void CarDetails()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.TGetCarsDetails();
            foreach (var car in result.Data)
            {
                Console.WriteLine($"{car.CarName}/{car.BrandName}/{car.ColorName}/{car.DailyPrice}");
            }
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.TGetCarsByBrandId(2);

            foreach (var car in result.Data)
            {
                Console.WriteLine($"Araba modelleri:{car.CarName}");
            }
        }
    }
}
