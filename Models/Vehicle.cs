using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace simulacro_csharp.Models
{
    public class Vehicle
    {
        public int Id { get; set; }
        public string? Placa { get; set; }
        public string? Tipo { get; set; }
        public string? EngineNumber { get; set; }
        public string? SerialNumber { get; set; }
        public byte PeopleCapacity { get; set; }
        public Driver Owner { get; set; }
       
        public Vehicle(int id, string placa, string tipo, string engineNumber, string serialNumber, byte peopleCapacity, Driver owner)
        {
            Id = id;
            Placa = placa;
            Tipo = tipo;
            EngineNumber = engineNumber;
            SerialNumber = serialNumber;
            PeopleCapacity = peopleCapacity;
            Owner = owner;
        }

        public void DeleteVehicle(int id, List<Vehicle> vehicles)
        {
            var vehicle = vehicles.Find(vehicle => vehicle.Id == id);

            if (vehicle != null)
            {
                Console.WriteLine($"Are you sure you want to delete this vehicle? {vehicle.Id} (yes/no)");
                var confirmation = Console.ReadLine().ToLower();
                if (!string.IsNullOrEmpty(confirmation) && confirmation == "yes")
                {
                    vehicles.Remove(vehicle);
                }
            }
            else
            {
                Console.WriteLine("Sorry. It was not possible to delete the vehicle. Try again");
            }
        }

    }
}