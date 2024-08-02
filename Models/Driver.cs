using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace simulacro_csharp.Models
{
    public class Driver : User
    {
        public string? LicenseNumber { get; set; }
        public string? LicenseCategory { get; set; }
        public int DrivingExperience { get; set; }
        public Driver(string name, string lastName, string typeDocument, string identificationNumber, DateOnly birthdate, string email, string phoneNumber, string address, string licenseNumber, string licenseCategory, int drivingExperience) : base(name, lastName, typeDocument, identificationNumber, birthdate, email, phoneNumber, address)
        {
            LicenseNumber = licenseNumber;
            LicenseCategory = licenseCategory;
            DrivingExperience = drivingExperience;
        }

        public void UpdateLicenseCategory(string newCategory)
        {
            LicenseCategory = newCategory;
        }

        public void AddExperience(int years)
        {
            DrivingExperience += years;
        }


    }
}