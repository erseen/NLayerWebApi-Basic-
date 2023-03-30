using Business.Abstract;
using Data_Access.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class HotelManager : IHotelService
    {
        private IHotelRepository _hotelRepository;

        public HotelManager(IHotelRepository hotelRepository)
        {
            _hotelRepository = hotelRepository; 
        }

        public Hotel CreateHotel(Hotel hotel)
        {
           return  _hotelRepository.CreateHotel(hotel);    
        }

        public void DeleteHotel(int id)
        {
            _hotelRepository.DeleteHotel(id);
        }

        public List<Hotel> GetAllHotels()
        {
            return _hotelRepository.GetAllHotels();
        }

        public Hotel GetGotelsById(int id)
        {
            if (id>0 )
            {
                return _hotelRepository.GetHotelById(id);
            }
            throw new Exception("HM  ID yanlış parametre alıyor ");

            
        }

     

        public Hotel UpdateHotel(Hotel hotel)
        {
            return _hotelRepository.UpdateHotel(hotel); 
        }
    }
}
