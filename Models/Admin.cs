using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace simulacro_csharp.Models
{
    public static class Admin
    {
        public static List<Driver> Drivers = new List<Driver>();
        public static List<Customer> Customers = new List<Customer>();
        public static List<Vehicle> Vehicles = new List<Vehicle>();

        public static void Show(Object user)
        {

            if (user is Driver)
            {
                foreach (var driver in Drivers)
                {
                    driver.ShowDetails();
                }
            }
            else if (user is Customer)
            {
                foreach (var customer in Customers)
                {
                    customer.ShowDetails();
                }
            }
        }


    }
}


