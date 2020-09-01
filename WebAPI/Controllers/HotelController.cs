using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using HotelBrowser.BusinessLogic.Interfaces;
using HotelBrowser.BusinessLogic.Models;

namespace HotelBrowser.WebAPI.Controllers
{
    //[Route("api/[controller]")]
    [Route("[controller]")]
    [ApiController]
    public class HotelController : ControllerBase
    {
        public IHotelService _hotelService;

        public HotelController(IHotelService hotelService) 
        {
            _hotelService = hotelService;
        }

        // GET: api/Hotel
        [HttpGet]
        public IEnumerable<HotelDTO> Get()
        {
            var lstHotels = _hotelService.Get();
            return lstHotels;
        }

        // GET: api/Hotel/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Hotel
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Hotel/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
