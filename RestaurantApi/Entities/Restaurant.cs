﻿using System.Collections.Generic;

namespace RestaurantApi.Entities
{
    public class Restaurant
    {
        public int Id { get; set; }
        public int Name { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public bool HasDelivery { get; set; }
        public string ContactEmail { get; set; }
        public string ContactNumber { get; set; }
        public int AdressId { get; set; }
        public virtual Adress Adress { get; set; }

        public virtual List<Dish> Dishes { get; set; }
    }
}
