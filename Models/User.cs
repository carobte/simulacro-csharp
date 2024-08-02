using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace simulacro_csharp.Models
{
    public class User
    {
        protected Guid Id { get; set; }
        protected string? Name { get; set; }
        protected string? LastName { get; set; }
        protected string? TypeDocument { get; set; }
        protected string? IdentificationNumber { get; set; }
        protected DateOnly Birthdate { get; set; }
        protected string? Email { get; set; }
        protected string? PhoneNumber { get; set; }
        protected string? Address { get; set; }

        protected User(string name, string lastName, string typeDocument, string identificationNumber, DateOnly birthdate, string email, string phoneNumber, string address){

            Id = Guid.NewGuid();
            Name = name;
            LastName = lastName;
            TypeDocument = typeDocument;
            IdentificationNumber = identificationNumber;
            Birthdate = birthdate;
            Email = email;
            PhoneNumber = phoneNumber;
            Address = address;
        }

        protected void ShowDetails(){
            Console.WriteLine($"Fullname: {Name} {LastName}");
            Console.WriteLine($"Type of Document {TypeDocument}");
            Console.WriteLine($"Identification Number: {IdentificationNumber}");
            Console.WriteLine($"Birthdate: {Birthdate}");
            Console.WriteLine($"Email: {Email}");
            Console.WriteLine($"Phone number: {PhoneNumber}");
            Console.WriteLine($"Address: {Address}");
        }

        protected int CalculateAge(){
           return DateTime.Now.Year - Birthdate.Year;
        }

        protected void ShowAge(){
            Console.WriteLine($"{Name} {LastName} is {CalculateAge()} years old");
        }
    }
}