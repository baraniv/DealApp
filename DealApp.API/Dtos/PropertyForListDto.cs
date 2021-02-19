using System;

namespace DealApp.API.Dtos
{
    public class PropertyForListDto
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
        public decimal? Price { get; set; }
        public int? RenterId { get; set; }
        public string Note { get; set; }
        public bool? IsAvailable { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsFurnished { get; set; }

        public string PhotoUrl { get; set; }
    }
}