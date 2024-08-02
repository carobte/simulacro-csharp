using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace simulacro_csharp.Models
{
    public class Customer : User
    {
        public string? MembershipLevel { get; set; }
        public string? PreferredPaymentMethod { get; set; }

        public Customer(string name, string lastName, string typeDocument, string identificationNumber, DateOnly birthdate, string email, string phoneNumber, string address, string membershipLevel, string preferredPaymentMethod) : base(name, lastName, typeDocument, identificationNumber, birthdate, email, phoneNumber, address)
        {
            MembershipLevel = membershipLevel;
            PreferredPaymentMethod = preferredPaymentMethod;
        }

        public override void ShowDetailsP()
        {
            base.ShowDetails();
            Console.WriteLine($"Membership Level: {MembershipLevel}");
            Console.WriteLine($"Preferred PaymentMethod: {PreferredPaymentMethod}");
        }

        public void UpdateMembershipLevel(string newMembershipLevel)
        {
            MembershipLevel = newMembershipLevel;
        }

    }
}