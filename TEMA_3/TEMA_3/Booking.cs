//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TEMA_3
{
    using System;
    using System.Collections.Generic;
    
    public partial class Booking
    {
        public int BookingID { get; set; }
        public int CustomerID { get; set; }
        public int RoomID { get; set; }
        public System.DateTime DateFrom { get; set; }
        public System.DateTime DateTo { get; set; }
        public bool Deleted { get; set; }
        public double TotalPrice { get; set; }
    
        public virtual Customer Customer { get; set; }
        public virtual Room Room { get; set; }
    }
}