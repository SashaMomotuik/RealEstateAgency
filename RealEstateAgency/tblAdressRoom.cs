//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RealEstateAgency
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblAdressRoom
    {
        public int RoomId { get; set; }
        public int CitiesId { get; set; }
        public int DistrictsId { get; set; }
        public int StreetId { get; set; }
        public int NumberHouse { get; set; }
    
        public virtual tblCities tblCities { get; set; }
        public virtual tblDistricts tblDistricts { get; set; }
        public virtual tblRooms tblRooms { get; set; }
        public virtual tblStreets tblStreets { get; set; }
    }
}
