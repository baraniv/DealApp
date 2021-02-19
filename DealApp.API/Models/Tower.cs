using System;

namespace DealApp.API.Models
{
    public class Tower
    {
       public int Id { get; set; }
        public string Name { get; set; }
        public int? ProjectId { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDeleted { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string ModifyBy { get; set; }
        public DateTime? ModifyDate { get; set; }

        public virtual Project Project { get; set; } 
    }
}