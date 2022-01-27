using System;
using System.Collections.Generic;
using System.Text;

namespace XRE.Common.Models
{
    public class BookingModel
    {
        public Guid xre_bookingid { get; set; }         //Primary Key

        //data against record
        //public Guid xre_contactid { get; set; }       //A lookup to who the booking is for (for context only, this is outside the scope of this test). 
        public DateTime xre_startdate { get; set; }     //The date of the first DayModel against this booking. 
        public DateTime xre_enddate { get; set; }       //The date of the last DayModel against this booking. 
    }
}
