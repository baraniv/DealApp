using System;
using System.Collections.Generic;

namespace DealApp.API.Models
{
    public class Property
    {
        public int Id { get; set; }
        public string PropertyName { get; set; }
        public int? CategoryId { get; set; }
        public int? PropertyTypeId { get; set; }
        public int? CityId { get; set; }
        public int? QuarterId { get; set; }
        public int? ProjectId { get; set; }
        public int? TowerId { get; set; }
        public int? BlockId { get; set; }
        public int? AreaId { get; set; }
        public int? InterfaceId { get; set; }
        public string PropertyNumber { get; set; }
        public decimal? Price { get; set; }
        public int? RenterId { get; set; }
        public string Note { get; set; }
        public bool? IsAvailable { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDeleted { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string ModifyBy { get; set; }
        public DateTime? ModifyDate { get; set; }
        public bool? IsFocusedOn { get; set; }
        public bool? ItHasAproblem { get; set; }
        public bool? IsFurnished { get; set; }
        public ICollection<Photo> Photos { get; set; }


        public virtual Area Area { get; set; }
        public virtual Block Block { get; set; }
        public virtual Category Category { get; set; }
        public virtual City City { get; set; }
        public virtual Floor Floor { get; set; }
        public virtual Interface Interface { get; set; }
        public virtual Project Project { get; set; }
        public virtual PropertyType PropertyType { get; set; }
        public virtual Tower Tower { get; set; }
        public virtual Quarter Quarter { get; set; }
        public virtual Renter Renter { get; set; }
    }   
}