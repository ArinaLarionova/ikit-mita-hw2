using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Drawing;

namespace View
{
    class Program
    {
        static void Main(string[] args)
        {
            var car = new Car("Лада",'D') {Color = Color.MidnightBlue};

            try
            {
                Console.WriteLine($"Owner's name is {car.CarPassport.Owner.Name} for car {car.Model}");
            }
            catch (NullReferenceException exception)
            {
                Console.WriteLine($"Owner of {car.Model} is not exist! Message: {exception.Message}");
            }


            var driver = new Driver(new DateTime(1985, 11, 6), "Вольдемар") {Category = "BC"};

            var carNumber = "о777оо";

            try
            {
                car.ChangeOwner(driver, carNumber);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            driver.Category += car.Category;

            try
            {
                car.ChangeOwner(driver, carNumber);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine(driver.Car.CarNumber);
            Console.WriteLine(driver.Name);
            Console.ReadKey();
        }
    }
}
