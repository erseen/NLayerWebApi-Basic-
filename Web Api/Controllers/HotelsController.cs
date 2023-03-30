using Business.Abstract;
using Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HotelsController : ControllerBase
    {
        private IHotelService _hotelService;
        public HotelsController(IHotelService hotelService)
        {
            _hotelService= hotelService;
        }

        [HttpGet]
        public List<Hotel> Get()
        {
            return _hotelService.GetAllHotels(); 
        }
        [HttpGet("{id}")]
        public Hotel Get(int id)
        {
            return _hotelService.GetGotelsById(id);
        }

       [HttpPost]
        public Hotel Post([FromBody] Hotel hotel)
        {
            return _hotelService.CreateHotel(hotel); 

        }
        [HttpPut]
        public Hotel Put([FromBody] Hotel hotel)
        {
            return _hotelService.UpdateHotel(hotel);

        }
        [HttpDelete]
        public void Delete(int id ) 
        {
            _hotelService.DeleteHotel(id);
        }

    }
}
