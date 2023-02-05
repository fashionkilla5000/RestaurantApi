using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RestaurantApi.Entities;

namespace RestaurantApi
{
    public class RestaurantSeeder
    {
        private readonly RestaurantDbContext _dbContext;

        public RestaurantSeeder(RestaurantDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Seed()
        {
            if (!_dbContext.Database.CanConnect())
            {
                if (!_dbContext.Restaurants.Any())
                {
                    var restaurants = GetRestaurants();
                    _dbContext.Restaurants.AddRange(restaurants);
                }

            }

        }

        private IEnumerable<Restaurant> GetRestaurants()
        {
            var restaurants = new List<Restaurant>()
            {
                new Restaurant()
                {
                    Name = "KFC",
                    Category = "Fast Food",
                    Description = "xXD XDDF SDFDSBFgb sfvwebacieac",
                    ContactEmail="con@kfc.pl",
                    HasDelivery = true,
                    Dishes = new List<Dish>()
                    {
                        new Dish()
                        {
                            Name = "New one",
                            Price = 10.3M,
                        },
                        new Dish()
                        {
                            Name ="two",
                            Price = 5.7M,
                        },

                    },
                    Adress = new Adress()
                    {
                        City= "Warsaw",
                        Street = "Warszawska 1",
                        PostalCode= "01-321",
                    }
                },

                 new Restaurant()
                {
                    Name = "McDonald",
                    Category = "Fast Food",
                    Description = "xX22D X3DDF nomSDFDSBFgb sfvwebacieac",
                    ContactEmail="con@mcd.pl",
                    HasDelivery = true,
                    Dishes = new List<Dish>()
                    {
                        new Dish()
                        {
                            Name = "pierww",
                            Price = 7.3M,
                        },
                        new Dish()
                        {
                            Name ="drugie",
                            Price = 7.7M,
                        },

                    },
                    Adress = new Adress()
                    {
                        City= "Warsaw",
                        Street = "Warszawska 2",
                        PostalCode= "01-321",
                    }
                },

            };
            return restaurants;
        }
    }
}
