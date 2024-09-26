using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using api.Models.Domain;
using api.Data;

namespace api.Controllers
{
    [ApiController]
    //https://localhost:5015/api/regions
    [Route("api/[controller]")]
    public class RegionsController : ControllerBase
    {   
        private readonly NgWalksDBContext dbContext;
        public RegionsController(NgWalksDBContext dbContext)
        {
            this.dbContext = dbContext;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            //Outcoded regions
            // var regions = new List<Region>
            // {
            //     new Region { Id = Guid.NewGuid(), Name = "North America", Code = "NA", RegionImageUrl = "..." },
            //     new Region { Id = Guid.NewGuid(), Name = "South America", Code = "SA", RegionImageUrl = "..." }
            // };
            
            //from the database
            var regions = dbContext.Regions.ToList();
            return Ok(regions);
        }
    }
}