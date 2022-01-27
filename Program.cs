using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XRE.Common.Models;
using XRE.Common.Functions;
using XRE.Common.Functions.CRUD;

namespace XRE_Grad_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            List<BookingModel> Bookings = CRUD_Functions.SetupBookings();
            List<DayModel> Days = CRUD_Functions.SetupDays(Bookings);
            List<ActivityProviderModel> ActivityProviders = CRUD_Functions.SetupProviders();
            //List of activities here
        }
    }
}
