using simulacro_csharp.Models;

var flag = true;

Admin.DriversAndVehiclesEG();
Admin.CustomersEG();

void Menu()
{
    while (flag)
    {

        Console.WriteLine("======================================================================================");
        Console.WriteLine("                                  < TransRiwi Menu >                                  ");
        Console.WriteLine("======================================================================================");
        Console.WriteLine("0. Close");
        Console.WriteLine("1. Show all customers");
        Console.WriteLine("2. Show all drivers");
        Console.WriteLine("3. Users older than 30 years old");
        Console.WriteLine("4. Drivers ordered by experience years");
        Console.WriteLine("5. Customers with credit card as preferred payment option");
        Console.WriteLine("6. Drivers with License Category 'A2'");
        Console.WriteLine("======================================================================================");

        Console.Write("Option: ");
        var option = Console.ReadLine();

        switch (option)
        {
            case "0":
                flag = false;
                Console.WriteLine("Goodbye. See you next time!");
                break;

            case "1":
                Admin.ShowCustomers(Admin.Customers);
                PauseMenu();
                break;

            case "2":
                Admin.ShowDrivers(Admin.Drivers);
                PauseMenu();
                break;
            
            case "3":
                var driversOlder30 = Admin.Drivers.Where(driver => driver.CalculateAgeP() > 30).ToList();
                Admin.ShowDrivers(driversOlder30);   

                var customersOlder30 = Admin.Customers.Where(customer => customer.CalculateAgeP() > 30).ToList();
                Admin.ShowDrivers(driversOlder30);    

                PauseMenu();
                break;

            case "4":
                var driversOrdered = Admin.Drivers.OrderByDescending(driver => driver.DrivingExperience).ToList();
                Admin.ShowDrivers(driversOrdered);
                PauseMenu();
                break;

            case "5":
                var customersCredit = Admin.Customers.Where(customer => customer.PreferredPaymentMethod.ToLower() == "credit card").ToList();
                Admin.ShowCustomers(customersCredit);
                PauseMenu();
                break;

            case "6":
                var driversA2 = Admin.Drivers.Where(driver => driver.LicenseCategory == "A2").ToList();
                Admin.ShowDrivers(driversA2);
                PauseMenu();
                break;

            default:
                Console.WriteLine("Invalid option. Try again.");
                break;
        }
    }
}

void PauseMenu()
{
    Console.WriteLine($"Press any key to continue");
    Console.ReadLine();
}

Menu();