using System;

namespace DealApp.API.Models
{
    public class Renter
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Int64 MobileNo1 { get; set; }
        public Int64 MobileNo2 { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDeleted { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string ModifyBy { get; set; }
        public DateTime? ModifyDate { get; set; }
    }
}