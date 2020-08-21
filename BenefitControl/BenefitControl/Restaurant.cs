using System;
using System.Collections.Generic;

namespace BenefitControl
{
    [Serializable]
    public class Restaurant
    {
        public static Restaurant RESTAURANT_1 = new Restaurant("牡丹一号饭店");
        public static Restaurant RESTAURANT_2 = new Restaurant("牡丹二号饭店");

        public string name { get; set; }

        public Restaurant(String name)
        {
            this.name = name;
        }

        public override bool Equals(object obj)
        {
            if (obj == this)
                return true;
            if (!(obj is Restaurant))
                return false;
            var other = (Restaurant)obj;
            return this.name.Equals(other.name);
        }

        public override int GetHashCode()
        {
            return this.name.GetHashCode();
        }
    }

    public class RestaurantWrapper
    {
        private Dictionary<string, Restaurant> restaurantMap = new Dictionary<string, Restaurant>();

        public RestaurantWrapper()
        {
            restaurantMap.Add(Restaurant.RESTAURANT_1.name, Restaurant.RESTAURANT_1);
            restaurantMap.Add(Restaurant.RESTAURANT_2.name, Restaurant.RESTAURANT_2);
        }

        public List<Restaurant> getCurrentRestaurantList()
        {
            return new List<Restaurant>() { Restaurant.RESTAURANT_1, Restaurant.RESTAURANT_2 };
        }

        public Restaurant getRestaurantByName(string name)
        {
            return restaurantMap[name];
        }
    }
}
