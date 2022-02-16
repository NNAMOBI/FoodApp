using odeFood.Data.Model;
using OdeFood.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace odeFood.Data.Services
{
    public class InMemoryRestaurantData : IRestaurantData
    {
        List<Restaurant> restaurants;

        /// <summary>
        /// creating a constructor to initialise a list of restaurants
        /// </summary>
        public InMemoryRestaurantData()
        {
            restaurants = new List<Restaurant>()
            {
                new Restaurant { Id = 1, Name = "Pepe's Pizza", CuisineType = CuisineType.Indian},
                new Restaurant { Id = 2, Name = "Nacos", CuisineType = CuisineType.Italian},
                new Restaurant { Id = 3, Name = "kajie res", CuisineType = CuisineType.French}
            };
           }
        public IEnumerable<Restaurant> GetAll()
        {
            return restaurants.OrderBy(r => r.Name);                  // This is possible because the IRestauranData has a contract for implementation of IEnumberable
        }                                                             // order by name
    }
}
