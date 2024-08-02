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
       

        public Vehicle(int id, string placa, string tipo, string engineNumber, string serialNumber, byte peopleCapacity)
        {
            Id = id;
            Placa = placa;
            Tipo = tipo;
            EngineNumber = engineNumber;
            SerialNumber = serialNumber;
            PeopleCapacity = peopleCapacity;
        }

        // Delete vehicles is on Driver class because it has the list of vehicles and has more sense to go there.
    }
}