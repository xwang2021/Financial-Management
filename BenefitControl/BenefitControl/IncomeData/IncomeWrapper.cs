using System;
using System.Collections.Generic;

namespace BenefitControl.IncomeData
{
    [Serializable]
    public class IncomeWrapper
    {
        public static IncomeWrapper EMPTY_INCOME_WRAPPER = new IncomeWrapper(new List<RestaurantIncomeWrapper>());

        double totalAmount = 0;
        Dictionary<Restaurant, RestaurantIncomeWrapper> totalIncome = new Dictionary<Restaurant, RestaurantIncomeWrapper>();

        public IncomeWrapper(List<RestaurantIncomeWrapper> incomeList)
        {
            initialize(incomeList);
        }

        public IncomeWrapper(IncomeWrapper oldIncomeWrapper, RestaurantIncomeWrapper income)
        {
            List<RestaurantIncomeWrapper> incomeList = new List<RestaurantIncomeWrapper>();
            oldIncomeWrapper.totalIncome[income.getRestaurant()] = income;
            incomeList.AddRange(oldIncomeWrapper.totalIncome.Values);
            initialize(incomeList);
        }

        private void initialize(List<RestaurantIncomeWrapper> incomeList)
        {
            foreach (RestaurantIncomeWrapper income in incomeList)
            {
                totalAmount += income.getTotalAmount();
                totalIncome.Add(income.getRestaurant(), income);
            }
        }

        public bool isValueExist(Restaurant restaurant, DateTime dateTime)
        {
            if (totalIncome.Count == 0)
            {
                return false;
            }
            if (totalIncome.ContainsKey(restaurant))
            {
                return totalIncome[restaurant].isValueExist(dateTime);
            }
            return false;
        }

        public void updateIncome(RestaurantIncomeWrapper restaurantWrapper)
        {
            RestaurantIncomeWrapper oldWrapper = totalIncome[restaurantWrapper.getRestaurant()];
            totalAmount = totalAmount - oldWrapper.getTotalAmount() + restaurantWrapper.getTotalAmount();
            totalIncome[restaurantWrapper.getRestaurant()] = restaurantWrapper;
        }

        public RestaurantIncomeWrapper getRestaurantIncome(Restaurant restaurant)
        {
            if (totalIncome.ContainsKey(restaurant))
                return totalIncome[restaurant];
            else
                return RestaurantIncomeWrapper.EMPTY_RESTAURANT_INCOME_WRAPPER;
        }
    }

    [Serializable]
    public class RestaurantIncomeWrapper
    {
        public static RestaurantIncomeWrapper EMPTY_RESTAURANT_INCOME_WRAPPER = new RestaurantIncomeWrapper(null, new List<YearIncomeWrapper>());

        Restaurant restaurant;
        double totalAmount = 0;
        Dictionary<int, YearIncomeWrapper> yearIncome = new Dictionary<int, YearIncomeWrapper>();

        public RestaurantIncomeWrapper(Restaurant restaurant, List<YearIncomeWrapper> incomeList)
        {
            initialize(restaurant, incomeList);
        }

        public RestaurantIncomeWrapper(RestaurantIncomeWrapper oldIncomeWrapper, YearIncomeWrapper income)
        {
            List<YearIncomeWrapper> incomeList = new List<YearIncomeWrapper>();
            int year = income.getYear();
            if (oldIncomeWrapper.yearIncome.ContainsKey(year))
            {
                oldIncomeWrapper.yearIncome[year] = income;
                incomeList.AddRange(oldIncomeWrapper.yearIncome.Values);
            }
            else
            {
                oldIncomeWrapper.yearIncome.Add(year, income);
                incomeList.AddRange(oldIncomeWrapper.yearIncome.Values);
            }
            initialize(oldIncomeWrapper.getRestaurant(), incomeList);
        }

        private void initialize(Restaurant restaurant, List<YearIncomeWrapper> incomeList)
        {
            if (restaurant == null)
            {
                return;
            }
            this.restaurant = restaurant;
            foreach (YearIncomeWrapper income in incomeList)
            {
                totalAmount += income.getTotalAmount();
                yearIncome.Add(income.getYear(), income);
            }
        }

        public bool isValueExist(DateTime dateTime)
        {
            int year = dateTime.Year;
            if (yearIncome.ContainsKey(year))
            {
                return yearIncome[year].isValueExist(dateTime);
            }
            return false;
        }

        public double getTotalAmount()
        {
            return totalAmount;
        }

        public Restaurant getRestaurant()
        {
            return restaurant;
        }

        public YearIncomeWrapper getYearIncome(int year)
        {
            if (yearIncome.ContainsKey(year))
                return yearIncome[year];
            else
                return YearIncomeWrapper.EMPTY_YEAR_INCOME_WRAPPER;
        }
    }

    [Serializable]
    public class YearIncomeWrapper
    {
        public static YearIncomeWrapper EMPTY_YEAR_INCOME_WRAPPER = new YearIncomeWrapper(0, new List<MonthIncomeWrapper>());

        int year;
        double totalAmount = 0;
        Dictionary<int, MonthIncomeWrapper> monthIncome = new Dictionary<int, MonthIncomeWrapper>();

        public YearIncomeWrapper(int year, List<MonthIncomeWrapper> incomeList)
        {
            initialize(year, incomeList);
        }
        
        public YearIncomeWrapper(YearIncomeWrapper oldIncomeWrapper, MonthIncomeWrapper income)
        {
            List<MonthIncomeWrapper> incomeList = new List<MonthIncomeWrapper>();
            int month = income.getMonth();
            if (oldIncomeWrapper.monthIncome.ContainsKey(month))
            {
                oldIncomeWrapper.monthIncome[month] = income;
                incomeList.AddRange(oldIncomeWrapper.monthIncome.Values);
            }
            else
            {
                oldIncomeWrapper.monthIncome.Add(month, income);
                incomeList.AddRange(oldIncomeWrapper.monthIncome.Values);
            }
            initialize(oldIncomeWrapper.getYear(), incomeList);
        }

        private void initialize(int year, List<MonthIncomeWrapper> incomeList)
        {
            this.year = year;
            foreach (MonthIncomeWrapper income in incomeList)
            {
                totalAmount += income.getTotalAmount();
                monthIncome.Add(income.getMonth(), income);
            }
        }

        public bool isValueExist(DateTime dateTime)
        {
            int month = dateTime.Month;
            if (monthIncome.ContainsKey(month))
            {
                return monthIncome[month].isValueExist(dateTime);
            }
            return false;
        }

        public double getTotalAmount()
        {
            return totalAmount;
        }

        public int getYear()
        {
            return year;
        }

        public MonthIncomeWrapper getMonthIncome(int month)
        {
            if (monthIncome.ContainsKey(month))
                return monthIncome[month];
            else
                return MonthIncomeWrapper.EMPTY_MONTH_INCOME_WRAPPER;
        }
    }

    [Serializable]
    public class MonthIncomeWrapper
    {
        public static MonthIncomeWrapper EMPTY_MONTH_INCOME_WRAPPER = new MonthIncomeWrapper(0, new List<Income>());

        int month = 0;
        double totalAmount = 0;
        Dictionary<int, Income> dayIncome = new Dictionary<int, Income>();

        public MonthIncomeWrapper(int month, List<Income> incomeList)
        {
            initialize(month, incomeList);
        }

        public MonthIncomeWrapper(MonthIncomeWrapper oldIncomeWrapper, Income income)
        {
            List<Income> incomeList = new List<Income>();
            int day = income.getDay();
            if (oldIncomeWrapper.dayIncome.ContainsKey(day))
            {
                oldIncomeWrapper.dayIncome[day] = income;
                incomeList.AddRange(oldIncomeWrapper.dayIncome.Values);
            }
            else
            {
                oldIncomeWrapper.dayIncome.Add(day, income);
                incomeList.AddRange(oldIncomeWrapper.dayIncome.Values);
            }
            initialize(oldIncomeWrapper.getMonth(), incomeList);
        }

        private void initialize(int month, List<Income> incomeList)
        {
            this.month = month;
            foreach (Income income in incomeList)
            {
                totalAmount += income.getAmount();
                dayIncome.Add(income.getDay(), income);
            }
        }

        public bool isValueExist(DateTime dateTime)
        {
            return dayIncome.ContainsKey(dateTime.Day);
        }

        public double getTotalAmount()
        {
            return totalAmount;
        }

        public int getMonth()
        {
            return month;
        }

        public Income getDayIncome(int day)
        {
            if (dayIncome.ContainsKey(day))
                return dayIncome[day];
            else
                return Income.EMPTY_INCOME;
        }
    }

    [Serializable]
    public class IncomeWrapperConverter
    {
        public IncomeWrapper convertToIncomeWrapper(List<Income> incomeList)
        {
            Dictionary<Restaurant, Dictionary<int, Dictionary<int, Dictionary<int, Income>>>> value =
                new Dictionary<Restaurant, Dictionary<int, Dictionary<int, Dictionary<int, Income>>>>();

            foreach (Income income in incomeList)
            {
                Restaurant restaurant = income.getRestaurant();
                int year = income.getYear();
                int month = income.getMonth();
                int day = income.getDay();
                if (value.ContainsKey(restaurant))
                {
                    Dictionary<int, Dictionary<int, Dictionary<int, Income>>> totalIncome = value[restaurant];
                    if (totalIncome.ContainsKey(year))
                    {
                        Dictionary<int, Dictionary<int, Income>> yearIncome = totalIncome[year];
                        if (yearIncome.ContainsKey(month))
                        {
                            Dictionary<int, Income> monthIncome = yearIncome[month];
                            monthIncome.Add(day, income);
                        }
                        else
                        {
                            Dictionary<int, Income> monthIncome = new Dictionary<int, Income>();
                            monthIncome.Add(day, income);
                            yearIncome.Add(month, monthIncome);
                        }
                    }
                    else
                    {
                        Dictionary<int, Dictionary<int, Income>> yearIncome = new Dictionary<int, Dictionary<int, Income>>();
                        Dictionary<int, Income> monthIncome = new Dictionary<int, Income>();
                        monthIncome.Add(day, income);
                        yearIncome.Add(month, monthIncome);
                        totalIncome.Add(year, yearIncome);
                    }
                }
                else
                {
                    Dictionary<int, Dictionary<int, Dictionary<int, Income>>> totalIncome = new Dictionary<int, Dictionary<int, Dictionary<int, Income>>>();
                    Dictionary<int, Dictionary<int, Income>> yearIncome = new Dictionary<int, Dictionary<int, Income>>();
                    Dictionary<int, Income> monthIncome = new Dictionary<int, Income>();
                    monthIncome.Add(day, income);
                    yearIncome.Add(month, monthIncome);
                    totalIncome.Add(year, yearIncome);
                    value.Add(restaurant, totalIncome);
                }
            }

            List<RestaurantIncomeWrapper> restaurantIncomes = new List<RestaurantIncomeWrapper>();
            foreach (Restaurant restaurant in value.Keys)
            {
                Dictionary<int, Dictionary<int, Dictionary<int, Income>>> restaurantIncome = value[restaurant];
                List<YearIncomeWrapper> yearIncomes = new List<YearIncomeWrapper>();
                foreach (int year in restaurantIncome.Keys)
                {
                    Dictionary<int, Dictionary<int, Income>> yearIncome = restaurantIncome[year];
                    List<MonthIncomeWrapper> monthIncomes = new List<MonthIncomeWrapper>();
                    foreach (int month in yearIncome.Keys)
                    {
                        Dictionary<int, Income> monthIncome = yearIncome[month];
                        List<Income> incomes = new List<Income>();
                        incomes.AddRange(monthIncome.Values);
                        monthIncomes.Add(new MonthIncomeWrapper(month, incomes));
                    }
                    yearIncomes.Add(new YearIncomeWrapper(year, monthIncomes));
                }
                restaurantIncomes.Add(new RestaurantIncomeWrapper(restaurant, yearIncomes));
            }

            return new IncomeWrapper(restaurantIncomes);
        }
    }

    public class IncomeUpdater
    {
        public static IncomeWrapper updateIncome(IncomeWrapper incomeWrapper, Income income, Restaurant restaurant, int year, int month, int day)
        {
            if (incomeWrapper == IncomeWrapper.EMPTY_INCOME_WRAPPER)
            {
                MonthIncomeWrapper monthIncomeWrapper = new MonthIncomeWrapper(month, new List<Income>() { income });
                YearIncomeWrapper yearIncomeWrapper = new YearIncomeWrapper(year, new List<MonthIncomeWrapper>() { monthIncomeWrapper });
                RestaurantIncomeWrapper newRestaurantWrapper = new RestaurantIncomeWrapper(restaurant, new List<YearIncomeWrapper>() { yearIncomeWrapper });
                return new IncomeWrapper(new List<RestaurantIncomeWrapper>() { newRestaurantWrapper });
            }
            RestaurantIncomeWrapper restaurantWrapper = incomeWrapper.getRestaurantIncome(restaurant);
            if (restaurantWrapper.getRestaurant() == null)
            {
                MonthIncomeWrapper monthIncomeWrapper = new MonthIncomeWrapper(month, new List<Income>() { income });
                YearIncomeWrapper yearIncomeWrapper = new YearIncomeWrapper(year, new List<MonthIncomeWrapper>() { monthIncomeWrapper });
                RestaurantIncomeWrapper newRestaurantWrapper = new RestaurantIncomeWrapper(restaurant, new List<YearIncomeWrapper>() { yearIncomeWrapper });
                return new IncomeWrapper(incomeWrapper, newRestaurantWrapper);
            }
            if (restaurantWrapper.getYearIncome(year).getYear() == 0)
            {
                MonthIncomeWrapper monthIncomeWrapper = new MonthIncomeWrapper(month, new List<Income>() { income });
                YearIncomeWrapper yearIncomeWrapper = new YearIncomeWrapper(year, new List<MonthIncomeWrapper>() { monthIncomeWrapper });
                restaurantWrapper = new RestaurantIncomeWrapper(restaurantWrapper, yearIncomeWrapper);
                return new IncomeWrapper(incomeWrapper, restaurantWrapper);
            }
            else
            {
                YearIncomeWrapper yearIncomeWrapper = restaurantWrapper.getYearIncome(year);
                if (yearIncomeWrapper.getMonthIncome(month).getMonth() == 0)
                {
                    MonthIncomeWrapper monthIncomeWrapper = new MonthIncomeWrapper(month, new List<Income>() { income });
                    yearIncomeWrapper = new YearIncomeWrapper(yearIncomeWrapper, monthIncomeWrapper);
                    restaurantWrapper = new RestaurantIncomeWrapper(restaurantWrapper, yearIncomeWrapper);
                    return new IncomeWrapper(incomeWrapper, restaurantWrapper);
                }
                else
                {
                    MonthIncomeWrapper monthIncomeWrapper = new MonthIncomeWrapper(yearIncomeWrapper.getMonthIncome(month), income);
                    yearIncomeWrapper = new YearIncomeWrapper(yearIncomeWrapper, monthIncomeWrapper);
                    restaurantWrapper = new RestaurantIncomeWrapper(restaurantWrapper, yearIncomeWrapper);
                    return new IncomeWrapper(incomeWrapper, restaurantWrapper);
                }
            }
        }
    }
}
