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

        public static void ShowDrivers(List<Driver> drivers)
        {
            foreach (var driver in drivers)
            {
                driver.ShowDetailsP();
            }
        }

        public static void ShowCustomers(List<Customer> customers)
        {
            foreach (var customer in customers)
            {
                customer.ShowDetailsP();
            }
        }

        public static void DriversAndVehiclesEG()
        {
            var driver = new Driver("Caro", "Bte", "Cédula", "123456", new DateOnly(1997, 07, 21), "caro@example.com", "3124567890", "av 68 #34", "123456", "B2", 2);
            var vehicle = new Vehicle(1, "DGH674", "truck", "52wc10338", "52wc103", 6, driver);

            Admin.Vehicles.Add(vehicle);
            Admin.Drivers.Add(driver);

            var driver2 = new Driver("Juli", "Bte", "Cédula", "456789", new DateOnly(1990, 08, 07), "juli@example.com", "3124567891", "av 68 #50", "456789", "A2", 1);
            var vehicle2 = new Vehicle(1, "DGH674", "motorbike", "50wc10338", "50wc103", 6, driver2);

            Admin.Vehicles.Add(vehicle2);
            Admin.Drivers.Add(driver2);

            var driver3 = new Driver("Meli", "Bte", "Cédula", "987654", new DateOnly(1995, 12, 28), "meli@example.com", "3124567892", "av 68 #10", "987654", "B2", 0);
            var vehicle3 = new Vehicle(1, "DGH674", "bus", "51wc10338", "51wc103", 6, driver3);

            Admin.Vehicles.Add(vehicle3);
            Admin.Drivers.Add(driver3);

            var driver4 = new Driver("Dario", "Bte", "Cédula", "654321", new DateOnly(1997, 02, 07), "dario@example.com", "3124567893", "street 16 #34", "654321", "B2", 2);
            var vehicle4 = new Vehicle(1, "DGH674", "truck", "53wc10338", "53wc103", 6, driver4);

            Admin.Vehicles.Add(vehicle4);
            Admin.Drivers.Add(driver4);
        }


        public static void CustomersEG()
        {
            var customer = new Customer("Santi", "Pineda", "Cédula", "012345", new DateOnly(1997, 09, 09), "santi@example.com", "3124567894", "av 56 #10", "Basic", "Credit card");
            var customer2 = new Customer("Kari", "Pineda", "Cédula", "987650", new DateOnly(1996, 02, 02), "kari@example.com", "3124567895", "av 33 #10", "Premium", "Credit card");
            var customer3 = new Customer("Manu", "Montoya", "Cédula", "543216", new DateOnly(1996, 05, 02), "manu@example.com", "3124567896", "av 52 #10", "Premium", "Cash");

            Customers.Add(customer);
            Customers.Add(customer2);
            Customers.Add(customer3);
        }
    }
}



