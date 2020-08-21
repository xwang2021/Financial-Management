using System;

namespace BenefitControl.IncomeData
{
    [Serializable]
    public class Income
    {
        public static Income EMPTY_INCOME = new Income(null, 0, DateTime.Today);

        private Restaurant restaurant;
        private double amount;
        private DateTime time;

        public Income(Restaurant restaurant, double amount, DateTime time)
        {
            this.restaurant = restaurant;
            this.amount = amount;
            this.time = time;
        }

        public Restaurant getRestaurant()
        {
            return restaurant;
        }

        public double getAmount()
        {
            return amount;
        }

        public DateTime getTime()
        {
            return time;
        }

        public int getYear()
        {
            return time.Year;
        }

        public int getMonth()
        {
            return time.Month;
        }

        public int getDay()
        {
            return time.Day;
        }
    }
}
