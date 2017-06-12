using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Driver
    {
        public Driver(DateTime licenseData, string name)
        {
            LicenseData = licenseData;
            Name = name;
        }
        public DateTime LicenseData { get; }
        public string Name { get; }

        public int Experience
        {
            get
            {
                if (DateTime.Now.Month < LicenseData.Month ||
                    DateTime.Now.Month == LicenseData.Month && DateTime.Now.Day < LicenseData.Day)
                    return DateTime.Now.Year - LicenseData.Year - 1;
                else return DateTime.Now.Year - LicenseData.Year;
            }
        }

        public string Category { get; set; }

        public Car Car { get; private set; }

        public void OwnCar(Car car)
        {
            if (Category.Contains(car.Category))
            {
                Car = car;
            }
            else
            {
                throw new Exception($"Driver {Name} have not a necessary category {car.Category} ");
            }
        }
    }
}
