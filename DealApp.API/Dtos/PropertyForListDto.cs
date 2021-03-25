using System;
using System.Collections.Generic;
using DealApp.API.Dtos;

namespace DealApp.API.Dtos
{
    public class PropertyForListDto
    {
        public int Id { get; set; }
        public string PropertyName { get; set; }
        public string CityName { get; set; }
        public string QuarterName { get; set; }
        public string TowerName { get; set; }
        public string AreaName { get; set; }
        public string BlockName { get; set; }
        public string CategoryName { get; set; }
        public string FloorName { get; set; }
        public string InterfaceName { get; set; }
        public string ProjectName { get; set; }
        public string PropertyTypeName { get; set; }
        public string RenterName { get; set; }
        public Int64? RenterMobileNo1 { get; set; }
        public Int64? RenterMobileNo2 { get; set; }
        public int? CategoryId { get; set; }
        public int? PropertyTypeId { get; set; }
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