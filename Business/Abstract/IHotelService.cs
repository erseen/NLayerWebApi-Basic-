using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IHotelService
    {
        List<Hotel> GetAllHotels();
        Hotel GetGotelsById(int id);
        Hotel CreateHotel(Hotel hotel);
        Hotel UpdateHotel(Hotel hotel); 
        void DeleteHotel(int id);   


    }
}
