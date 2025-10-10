using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Domain_Services
{
    public class FareCalculationService
    {
            public decimal GetBaseFare(string busType, string busClass)
            {
                if (busType == "Mini Bus" && busClass == "Regular") return 150;
                if (busType == "Coach" && busClass == "Regular") return 200;
                if (busType == "Coach" && busClass == "Deluxe") return 300;
                if (busType == "Tour Bus" && busClass == "Regular") return 250;
                if (busType == "Tour Bus" && busClass == "Deluxe") return 350;
                return 0;
            }

            public decimal CalculateTotal(decimal farePerSeat, int regular, int senior, int student, int pwd) =>
                (regular * farePerSeat) +
                (senior * farePerSeat * 0.80m) +
                (student * farePerSeat * 0.80m) +
                (pwd * farePerSeat * 0.80m);

            public decimal CalculateDiscount(decimal farePerSeat, int senior, int student, int pwd) =>
                (senior + student + pwd) * farePerSeat * 0.20m;
        
    }
}
