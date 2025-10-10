using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Domain_Services
{
    public class TripValidationService
    {
        public bool ValidateTripTimes(DateTime departure, DateTime arrival, out string errorMessage)
        {
            if (departure < DateTime.Now)
            {
                errorMessage = "Departure time cannot be in the past.";
                return false;
            }

            if (arrival <= departure)
            {
                errorMessage = "Arrival time must be after departure time.";
                return false;
            }

            errorMessage = string.Empty;
            return true;
        }

        public bool ValidateBusType(string busType, string busClass, out string errorMessage)
        {
            if (busType == "Mini Bus" && busClass == "Deluxe")
            {
                errorMessage = "There is no Deluxe Mini Bus available. Please select Regular.";
                return false;
            }

            errorMessage = string.Empty;
            return true;
        }
    }
}
