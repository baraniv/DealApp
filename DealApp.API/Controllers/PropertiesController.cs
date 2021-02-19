using System.Threading.Tasks;
using DealApp.API.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using AutoMapper;
using DealApp.API.Dtos;

namespace DealApp.API.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class PropertiesController : ControllerBase
    {
        private readonly IDealRepository _repo;
        private readonly IMapper _mapper;
        public PropertiesController(IDealRepository repo, IMapper mapper)
        
        {
            _mapper = mapper;
            _repo = repo;

        }

    [HttpGet]
    public async Task<IActionResult> GetProperties()
    {
        var properties = await _repo.GetProperties();
        var propertiesToReturn = _mapper.Map<IEnumerable<PropertyForListDto>>(properties);
        return Ok(propertiesToReturn);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetProperty(int id)
    {
        var property = await _repo.GetProperty(id);
        var propertyToReturn = _mapper.Map<PropertyForDetailedDto>(property);
        return Ok(propertyToReturn);
    }
}
}