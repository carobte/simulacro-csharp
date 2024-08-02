using simulacro_csharp.Models;

var flag = true;

Admin.DriversAndVehiclesEG();
Admin.CustomersEG();

Admin.ShowCustomer();
Admin.ShowDrivers();


void Menu()
{
    while (flag)
    {

        Console.WriteLine("======================================================================================");
        Console.WriteLine("                                  < TransRiwi Menu >                                  ");
        Console.WriteLine("======================================================================================");
        Console.WriteLine("0. Close");
        Console.WriteLine("1. ");
        Console.WriteLine("2. ");
        Console.WriteLine("3. ");
        Console.WriteLine("4. ");
        Console.WriteLine("5. ");
        Console.WriteLine("6. ");
        Console.WriteLine("6. ");
        Console.WriteLine("======================================================================================");

        Console.Write("Option: ");
        var option = Console.ReadLine();

        switch (option)
        {
            case "0":
            flag = false;
            Console.WriteLine("Goodbye. See you next time!");
            break;

            default:  
            Console.WriteLine("Invalid option. Try again.");
            break;
        }


    }
}

// Menu();