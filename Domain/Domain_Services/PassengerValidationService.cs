using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Domain.Domain_Services
{
    public class PassengerValidationService
    {
        public bool ValidateName(string name, out string errorMessage)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                errorMessage = "Please enter the passenger's name.";
                return false;
            }

            if (!Regex.IsMatch(name, @"^[a-zA-Z\s]+$"))
            {
                errorMessage = "Name can contain letters and spaces only.";
                return false;
            }

            errorMessage = string.Empty;
            return true;
        }

        public bool ValidateAge(int age, out string errorMessage)
        {
            if (age <= 0)
            {
                errorMessage = "Please enter a valid age.";
                return false;
            }

            errorMessage = string.Empty;
            return true;
        }

        public bool ValidateContact(string contact, out string errorMessage)
        {
            if (string.IsNullOrWhiteSpace(contact))
            {
                errorMessage = "Please enter a contact number.";
                return false;
            }

            if (!Regex.IsMatch(contact, @"^\d{11}$"))
            {
                errorMessage = "Contact number must be exactly 11 digits.";
                return false;
            }

            errorMessage = string.Empty;
            return true;
        }

        public bool ValidateEmail(string? email, out string errorMessage)
        {
            if (!string.IsNullOrWhiteSpace(email) &&
                !Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                errorMessage = "Please enter a valid email address.";
                return false;
            }

            errorMessage = string.Empty;
            return true;
        }
    }
}
