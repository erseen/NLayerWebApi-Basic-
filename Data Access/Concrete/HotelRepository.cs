using Data_Access.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access.Concrete
{
    public class HotelRepository : IHotelRepository
    {
        public Hotel CreateHotel(Hotel hotel)
        {
            using (HotelDbContext context = new HotelDbContext())
            {
                context.Hotels.Add(hotel);
                context.SaveChanges();
                return hotel; 
            }
        }

        public void DeleteHotel(int id)
        {
            using (HotelDbContext context= new HotelDbContext())
            {
                var deletedHotel = GetHotelById(id);
                context.Hotels.Remove(deletedHotel);
                context.SaveChanges();

            }
        }

        public List<Hotel> GetAllHotels()
        {
            using (HotelDbContext context = new HotelDbContext())
            {
                return context.Hotels.ToList();

            }
        }

        public Hotel GetHotelById(int id)
        {
            using (HotelDbContext context = new HotelDbContext())
            {
                return context.Hotels.Find(id);

            }
        }

        public Hotel UpdateHotel(Hotel hotel)
        {
            using (HotelDbContext context = new HotelDbContext())
            {
                context.Hotels.Update(hotel); 
                context.SaveChanges();
                return hotel; 

            }
        }
    }
}
