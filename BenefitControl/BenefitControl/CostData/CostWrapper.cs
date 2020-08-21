using System;
using System.Collections.Generic;

namespace BenefitControl.CostData
{
    [Serializable]
    public class CostWrapper
    {
        public static CostWrapper EMPTY_COST_WRAPPER = new CostWrapper(new List<RestaurantCostWrapper>());

        double totalAmount = 0;
        Dictionary<Restaurant, RestaurantCostWrapper> totalCost = new Dictionary<Restaurant, RestaurantCostWrapper>();

        public CostWrapper(List<RestaurantCostWrapper> costList)
        {
            initialize(costList);
        }

        public CostWrapper(CostWrapper oldWrapper, RestaurantCostWrapper restaurantWrapper)
        {
            List<RestaurantCostWrapper> restaurantCostList = new List<RestaurantCostWrapper>();
            oldWrapper.totalCost[restaurantWrapper.getRestaurant()] = restaurantWrapper;
            restaurantCostList.AddRange(oldWrapper.totalCost.Values);
            initialize(restaurantCostList);
        }

        public bool isValueExist(Restaurant restaurant, DateTime dateTime)
        {
            if (totalCost.Count == 0)
            {
                return false;
            }
            if (totalCost.ContainsKey(restaurant))
            {
                return totalCost[restaurant].isValueExist(dateTime);
            }
            return false;
        }

        private void initialize(List<RestaurantCostWrapper> costList)
        {
            foreach (RestaurantCostWrapper cost in costList)
            {
                totalAmount += cost.getTotalAmount();
                totalCost.Add(cost.getRestaurant(), cost);
            }
        }

        public RestaurantCostWrapper getRestaurantCost(Restaurant restaurant)
        {
            if (totalCost.ContainsKey(restaurant))
                return totalCost[restaurant];
            else
                return RestaurantCostWrapper.EMPTY_RESTAURANT_COST_WRAPPER;
        }

        public Dictionary<Restaurant, RestaurantCostWrapper> getCostMap()
        {
            return totalCost;
        }
    }

    [Serializable]
    public class RestaurantCostWrapper
    {
        public static RestaurantCostWrapper EMPTY_RESTAURANT_COST_WRAPPER = new RestaurantCostWrapper(null, new List<YearCostWrapper>());

        Restaurant restaurant;
        double amount = 0;
        Dictionary<int, YearCostWrapper> yearCostMap = new Dictionary<int, YearCostWrapper>();
        Dictionary<Cost.CostType, double> costByType = new Dictionary<Cost.CostType, double>();

        public RestaurantCostWrapper(Restaurant restaurant, List<YearCostWrapper> yearCostList)
        {
            initialize(restaurant, yearCostList);
        }

        public RestaurantCostWrapper(RestaurantCostWrapper oldRestaurantCostWrapper, YearCostWrapper yearCostWrapper)
        {
            List<YearCostWrapper> yearCostList = new List<YearCostWrapper>();
            int year = yearCostWrapper.getYear();
            if (oldRestaurantCostWrapper.yearCostMap.ContainsKey(year))
            {
                oldRestaurantCostWrapper.yearCostMap[year] = yearCostWrapper;
                yearCostList.AddRange(oldRestaurantCostWrapper.yearCostMap.Values);
            }
            else
            {
                oldRestaurantCostWrapper.yearCostMap.Add(year, yearCostWrapper);
                yearCostList.AddRange(oldRestaurantCostWrapper.yearCostMap.Values);
            }
            initialize(oldRestaurantCostWrapper.restaurant, yearCostList);
        }

        private void initialize(Restaurant restaurant, List<YearCostWrapper> yearCostList)
        {
            if (restaurant == null)
            {
                return;
            }
            costByType.Add(Cost.CostType.FOOD, 0);
            costByType.Add(Cost.CostType.SALARY, 0);
            costByType.Add(Cost.CostType.BONUS, 0);
            costByType.Add(Cost.CostType.EXTRA_COST, 0);
            costByType.Add(Cost.CostType.MAINTENANCE, 0);

            this.restaurant = restaurant;
            foreach (YearCostWrapper cost in yearCostList)
            {
                amount += cost.getTotalAmount();
                yearCostMap.Add(cost.getYear(), cost);
                foreach (Cost.CostType costType in Enum.GetValues(typeof(Cost.CostType)))
                {
                    costByType[costType] = costByType[costType] + cost.getCostByType(costType);
                }
            }
        }

        public bool isValueExist(DateTime dateTime)
        {
            int year = dateTime.Year;
            if (yearCostMap.ContainsKey(year))
            {
                return yearCostMap[year].isValueExist(dateTime);
            }
            return false;
        }

        public double getTotalAmount()
        {
            return amount;
        }

        public Restaurant getRestaurant()
        {
            return restaurant;
        }

        public YearCostWrapper getYearCost(int year)
        {
            if (yearCostMap.ContainsKey(year))
                return yearCostMap[year];
            else
                return YearCostWrapper.EMPTY_YEAR_COST_WRAPPER;
        }

        public double getCostByType(Cost.CostType costType)
        {
            return costByType[costType];
        }
    }

    [Serializable]
    public class YearCostWrapper
    {
        public static YearCostWrapper EMPTY_YEAR_COST_WRAPPER = new YearCostWrapper(0, new List<MonthCostWrapper>());

        int year = 0;
        double amount = 0;
        Dictionary<int, MonthCostWrapper> monthCostMap = new Dictionary<int, MonthCostWrapper>();
        Dictionary<Cost.CostType, double> costByType = new Dictionary<Cost.CostType, double>();
        private Dictionary<Cost.CostType, Dictionary<string, Tuple<double, List<Cost>>>> costDetailMap
           = new Dictionary<Cost.CostType, Dictionary<string, Tuple<double, List<Cost>>>>();

        public YearCostWrapper(int year, List<MonthCostWrapper> monthCostList)
        {
            initialize(year, monthCostList);
        }

        public YearCostWrapper(YearCostWrapper oldYearCostWrapper, MonthCostWrapper monthCostWrapper)
        {
            List<MonthCostWrapper> monthCostList = new List<MonthCostWrapper>();
            int month = monthCostWrapper.getMonth();
            if (oldYearCostWrapper.monthCostMap.ContainsKey(month))
            {
                oldYearCostWrapper.monthCostMap[month] = monthCostWrapper;
                monthCostList.AddRange(oldYearCostWrapper.monthCostMap.Values);
            }
            else
            {
                oldYearCostWrapper.monthCostMap.Add(month, monthCostWrapper);
                monthCostList.AddRange(oldYearCostWrapper.monthCostMap.Values);
            }
            initialize(oldYearCostWrapper.year, monthCostList);
        }

        private void initialize(int year, List<MonthCostWrapper> monthCostList)
        {
            costByType.Add(Cost.CostType.FOOD, 0);
            costByType.Add(Cost.CostType.SALARY, 0);
            costByType.Add(Cost.CostType.BONUS, 0);
            costByType.Add(Cost.CostType.EXTRA_COST, 0);
            costByType.Add(Cost.CostType.MAINTENANCE, 0);
            costDetailMap.Add(Cost.CostType.FOOD, new Dictionary<string, Tuple<double, List<Cost>>>());
            costDetailMap.Add(Cost.CostType.SALARY, new Dictionary<string, Tuple<double, List<Cost>>>());
            costDetailMap.Add(Cost.CostType.BONUS, new Dictionary<string, Tuple<double, List<Cost>>>());
            costDetailMap.Add(Cost.CostType.EXTRA_COST, new Dictionary<string, Tuple<double, List<Cost>>>());
            costDetailMap.Add(Cost.CostType.MAINTENANCE, new Dictionary<string, Tuple<double, List<Cost>>>());

            this.year = year;
            foreach (MonthCostWrapper cost in monthCostList)
            {
                amount += cost.getTotalAmount();
                monthCostMap.Add(cost.getMonth(), cost);
                foreach (Cost.CostType costType in Enum.GetValues(typeof(Cost.CostType)))
                {
                    costByType[costType] = costByType[costType] + cost.getCostByType(costType);
                    Dictionary<string, Tuple<double, List<Cost>>> singleCostDetailMap = costDetailMap[costType];

                    Dictionary<string, Tuple<double, List<Cost>>> costList = cost.getCostDetailByType(costType);
                    foreach (string name in costList.Keys)
                    {
                        if (singleCostDetailMap.ContainsKey(name))
                        {
                            Tuple<double, List<Cost>> costValue = singleCostDetailMap[name];
                            Tuple<double, List<Cost>> newCostValue = costList[name];
                            List<Cost> specifiedCostList = new List<Cost>();
                            specifiedCostList.AddRange(costValue.Item2);
                            specifiedCostList.AddRange(newCostValue.Item2);
                            singleCostDetailMap[name] = new Tuple<double, List<Cost>>(
                                costValue.Item1 + newCostValue.Item1, specifiedCostList);
                        }
                        else
                        {
                            singleCostDetailMap.Add(name, costList[name]);
                        }
                    }
                }
            }
        }

        public bool isValueExist(DateTime dateTime)
        {
            int month = dateTime.Month;
            if (monthCostMap.ContainsKey(month))
            {
                return monthCostMap[month].isValueExist(dateTime);
            }
            return false;
        }

        public double getTotalAmount()
        {
            return amount;
        }

        public int getYear()
        {
            return year;
        }

        public MonthCostWrapper getMonthCost(int month)
        {
            if (monthCostMap.ContainsKey(month))
                return monthCostMap[month];
            else
                return MonthCostWrapper.EMPTY_MONTH_COST_WRAPPER;
        }

        public double getCostByType(Cost.CostType costType)
        {
            if (costByType.ContainsKey(costType))
                return costByType[costType];
            else
                return 0;
        }

        public Dictionary<string, Tuple<double, List<Cost>>> getCostDetailByType(Cost.CostType costType)
        {
            if (costDetailMap.ContainsKey(costType))
                return costDetailMap[costType];
            else
                return new Dictionary<string, Tuple<double, List<Cost>>>();
        }
    }

    [Serializable]
    public class MonthCostWrapper
    {
        public static MonthCostWrapper EMPTY_MONTH_COST_WRAPPER = new MonthCostWrapper(0, new List<DayCostWrapper>());

        private int month = 0;
        private double amount = 0;
        private Dictionary<int, DayCostWrapper> dayCostMap = new Dictionary<int, DayCostWrapper>();
        private Dictionary<Cost.CostType, double> costByType = new Dictionary<Cost.CostType, double>();
        private Dictionary<Cost.CostType, Dictionary<string, Tuple<double, List<Cost>>>> costDetailMap
            = new Dictionary<Cost.CostType, Dictionary<string, Tuple<double, List<Cost>>>>();

        public MonthCostWrapper(int month, List<DayCostWrapper> dayCostList)
        {
            initialize(month, dayCostList);
        }

        public MonthCostWrapper(MonthCostWrapper oldMonthCostWrapper, DayCostWrapper dayCostWrapper)
        {
            List<DayCostWrapper> dayCostList = new List<DayCostWrapper>();
            int day = dayCostWrapper.getDay();
            if (oldMonthCostWrapper.dayCostMap.ContainsKey(day))
            {
                oldMonthCostWrapper.dayCostMap[day] = dayCostWrapper;
                dayCostList.AddRange(oldMonthCostWrapper.dayCostMap.Values);
            }
            else
            {
                oldMonthCostWrapper.dayCostMap.Add(day, dayCostWrapper);
                dayCostList.AddRange(oldMonthCostWrapper.dayCostMap.Values);
            }
            initialize(oldMonthCostWrapper.month, dayCostList);
        }

        private void initialize(int month, List<DayCostWrapper> dayCostList)
        {
            costByType.Add(Cost.CostType.FOOD, 0);
            costByType.Add(Cost.CostType.SALARY, 0);
            costByType.Add(Cost.CostType.BONUS, 0);
            costByType.Add(Cost.CostType.EXTRA_COST, 0);
            costByType.Add(Cost.CostType.MAINTENANCE, 0);
            costDetailMap.Add(Cost.CostType.FOOD, new Dictionary<string, Tuple<double, List<Cost>>>());
            costDetailMap.Add(Cost.CostType.SALARY, new Dictionary<string, Tuple<double, List<Cost>>>());
            costDetailMap.Add(Cost.CostType.BONUS, new Dictionary<string, Tuple<double, List<Cost>>>());
            costDetailMap.Add(Cost.CostType.EXTRA_COST, new Dictionary<string, Tuple<double, List<Cost>>>());
            costDetailMap.Add(Cost.CostType.MAINTENANCE, new Dictionary<string, Tuple<double, List<Cost>>>());

            this.month = month;
            foreach (DayCostWrapper cost in dayCostList)
            {
                amount += cost.getAmount();
                dayCostMap.Add(cost.getDay(), cost);
                foreach (Cost.CostType costType in Enum.GetValues(typeof(Cost.CostType)))
                {
                    costByType[costType] = costByType[costType] + cost.getCostByType(costType);
                    Dictionary<string, Tuple<double, List<Cost>>> singleCostDetailMap = costDetailMap[costType];

                    List<Cost> costList = cost.getCostList(costType);
                    foreach (Cost detailCost in costList)
                    {
                        if (singleCostDetailMap.ContainsKey(detailCost.getName()))
                        {
                            Tuple<double, List<Cost>> costValue = singleCostDetailMap[detailCost.getName()];
                            List<Cost> specifiedList = new List<Cost>();
                            specifiedList.AddRange(costValue.Item2);
                            specifiedList.Add(detailCost);
                            singleCostDetailMap[detailCost.getName()] = new Tuple<double, List<Cost>>(
                                costValue.Item1 + detailCost.getAmount(), specifiedList);
                        }
                        else
                        {
                            singleCostDetailMap.Add(detailCost.getName(), new Tuple<double, List<Cost>>(
                                detailCost.getAmount(), new List<Cost>() { detailCost }));
                        }
                    }
                }                
            }
        }

        public bool isValueExist(DateTime dateTime)
        {
            int day = dateTime.Day;
            return dayCostMap.ContainsKey(day);
        }

        public double getTotalAmount()
        {
            return amount;
        }

        public int getMonth()
        {
            return month;
        }

        public DayCostWrapper getDayCost(int day)
        {
            if (dayCostMap.ContainsKey(day))
                return dayCostMap[day];
            else
                return DayCostWrapper.EMPTY_DAY_COST_WRAPPER;
        }

        public double getCostByType(Cost.CostType costType)
        {
            if (costByType.ContainsKey(costType))
                return costByType[costType];
            else
                return 0;
        }

        public Dictionary<string, Tuple<double, List<Cost>>> getCostDetailByType(Cost.CostType costType)
        {
            if (costDetailMap.ContainsKey(costType))
                return costDetailMap[costType];
            else
                return new Dictionary<string, Tuple<double, List<Cost>>>();
        }
    }

    [Serializable]
    public class DayCostWrapper
    {
        public static DayCostWrapper EMPTY_DAY_COST_WRAPPER = new DayCostWrapper(0, new List<Cost>());

        private int day;
        private double amount = 0;

        private Dictionary<Cost.CostType, Tuple<double, List<Cost>>> values
            = new Dictionary<Cost.CostType, Tuple<double, List<Cost>>>();
        private Dictionary<Cost.CostType, Dictionary<string, Tuple<double, List<Cost>>>> costDetailMap
            = new Dictionary<Cost.CostType, Dictionary<string, Tuple<double, List<Cost>>>>();
        private List<Cost> totalCostList = new List<Cost>();

        public DayCostWrapper(int day, List<Cost> costList)
        {
            this.day = day;
            totalCostList.AddRange(costList);
            foreach (Cost cost in costList)
            {
                amount += cost.getAmount();
                Cost.CostType costType = cost.getCostType();

                if (values.ContainsKey(costType))
                {
                    Tuple<double, List<Cost>> costValues = values[costType];
                    double amount = costValues.Item1 + cost.getAmount();
                    List<Cost> costs = costValues.Item2;
                    costs.Add(cost);
                    values[costType] = new Tuple<double, List<Cost>>(amount, costs);
                }
                else
                {
                    List<Cost> costs = new List<Cost>();
                    costs.Add(cost);
                    values.Add(costType, new Tuple<double, List<Cost>>(cost.getAmount(), costs));
                }
                if (costDetailMap.ContainsKey(costType))
                {
                    Dictionary<string, Tuple<double, List<Cost>>> costDetail = costDetailMap[costType];
                    if (costDetail.ContainsKey(cost.getName()))
                    {
                        Tuple<double, List<Cost>> costValue = costDetail[cost.getName()];
                        List<Cost> specifiedCostList = costValue.Item2;
                        specifiedCostList.Add(cost);
                        costDetail[cost.getName()] = new Tuple<double, List<Cost>>(
                            costValue.Item1 + cost.getAmount(), specifiedCostList);
                    }
                    else
                    {
                        costDetail.Add(cost.getName(), new Tuple<double, List<Cost>>(cost.getAmount(), new List<Cost>() { cost }));
                    }
                }
                else
                {
                    Dictionary<string, Tuple<double, List<Cost>>> costDetail = new Dictionary<string, Tuple<double, List<Cost>>>();
                    costDetail.Add(cost.getName(), new Tuple<double, List<Cost>>(cost.getAmount(), new List<Cost>() { cost }));
                    costDetailMap.Add(costType, costDetail);
                }
            }
        }

        public int getDay()
        {
            return day;
        }

        public double getAmount()
        {
            return amount;
        }

        public double getCostByType(Cost.CostType costType)
        {
            if (values.ContainsKey(costType))
                return values[costType].Item1;
            else
                return 0;
        }

        public List<Cost> getCostList(Cost.CostType costType)
        {
            if (values.ContainsKey(costType))
                return values[costType].Item2;
            else
                return new List<Cost>();
        }

        public Dictionary<string, Tuple<double, List<Cost>>> getCostDetailByType(Cost.CostType costType)
        {
            if (costDetailMap.ContainsKey(costType))
                return costDetailMap[costType];
            else
                return new Dictionary<string, Tuple<double, List<Cost>>>();
        }

        public List<Cost> getTotalCostList()
        {
            return totalCostList;
        }
    }

    public class CostWrapperConverter
    {
        public CostWrapper convertToCostWrapper(List<Cost> costList)
        {
            Dictionary<Restaurant, Dictionary<int, Dictionary<int, Dictionary<int, List<Cost>>>>> value =
                new Dictionary<Restaurant, Dictionary<int, Dictionary<int, Dictionary<int, List<Cost>>>>>();

            foreach (Cost cost in costList)
            {
                Restaurant restaurant = cost.getRestaurant();
                int year = cost.getYear();
                int month = cost.getMonth();
                int day = cost.getDay();
                string name = cost.getName();
                if (value.ContainsKey(restaurant))
                {
                    Dictionary<int, Dictionary<int, Dictionary<int, List<Cost>>>> totalCost = value[restaurant];
                    if (totalCost.ContainsKey(year))
                    {
                        Dictionary<int, Dictionary<int, List<Cost>>> yearCost = totalCost[year];
                        if (yearCost.ContainsKey(month))
                        {
                            Dictionary<int, List<Cost>> monthCost = yearCost[month];
                            if (monthCost.ContainsKey(day))
                            {
                                List<Cost> dayCostList = monthCost[day];
                                dayCostList.Add(cost);
                                monthCost[day] = dayCostList;
                            }
                            else
                            {
                                List<Cost> dayCostList = new List<Cost>();
                                dayCostList.Add(cost);
                                monthCost.Add(day, dayCostList);
                            }
                        }
                        else
                        {
                            Dictionary<int, List<Cost>> monthCost = new Dictionary<int, List<Cost>>();
                            List<Cost> dayCostList = new List<Cost>();
                            dayCostList.Add(cost);
                            monthCost.Add(day, dayCostList);
                            yearCost.Add(month, monthCost);
                        }
                    }
                    else
                    {
                        Dictionary<int, Dictionary<int, List<Cost>>> yearCost = new Dictionary<int, Dictionary<int, List<Cost>>>();
                        Dictionary<int, List<Cost>> monthCost = new Dictionary<int, List<Cost>>();
                        List<Cost> dayCostList = new List<Cost>();
                        dayCostList.Add(cost);
                        monthCost.Add(day, dayCostList);
                        yearCost.Add(month, monthCost);
                        totalCost.Add(year, yearCost);
                    }
                }
                else
                {
                    Dictionary<int, Dictionary<int, Dictionary<int, List<Cost>>>> totalCost = new Dictionary<int, Dictionary<int, Dictionary<int, List<Cost>>>>();
                    Dictionary<int, Dictionary<int, List<Cost>>> yearCost = new Dictionary<int, Dictionary<int, List<Cost>>>();
                    Dictionary<int, List<Cost>> monthCost = new Dictionary<int, List<Cost>>();
                    List<Cost> dayCostList = new List<Cost>();
                    dayCostList.Add(cost);
                    monthCost.Add(day, dayCostList);
                    yearCost.Add(month, monthCost);
                    totalCost.Add(year, yearCost);
                    value.Add(restaurant, totalCost);
                }
            }

            List<RestaurantCostWrapper> restaurantCosts = new List<RestaurantCostWrapper>();
            foreach (Restaurant restaurant in value.Keys)
            {
                Dictionary<int, Dictionary<int, Dictionary<int, List<Cost>>>> restaurantCost = value[restaurant];
                List<YearCostWrapper> yearCosts = new List<YearCostWrapper>();
                foreach (int year in restaurantCost.Keys)
                {
                    Dictionary<int, Dictionary<int, List<Cost>>> yearCost = restaurantCost[year];
                    List<MonthCostWrapper> monthCosts = new List<MonthCostWrapper>();
                    foreach (int month in yearCost.Keys)
                    {
                        Dictionary<int, List<Cost>> monthCost = yearCost[month];
                        List<DayCostWrapper> dayCosts = new List<DayCostWrapper>();
                        foreach (int day in monthCost.Keys)
                        {
                            List<Cost> dayCost = monthCost[day];
                            dayCosts.Add(new DayCostWrapper(day, dayCost));
                        }
                        monthCosts.Add(new MonthCostWrapper(month, dayCosts));
                    }
                    yearCosts.Add(new YearCostWrapper(year, monthCosts));
                }
                restaurantCosts.Add(new RestaurantCostWrapper(restaurant, yearCosts));
            }

            return new CostWrapper(restaurantCosts);
        }
    }

    public class CostUpdater
    {
        public static CostWrapper updateCost(CostWrapper costWrapper, DayCostWrapper dayCost, Restaurant restaurant, int year, int month, int day)
        {
            if (costWrapper.Equals(CostWrapper.EMPTY_COST_WRAPPER))
            {
                MonthCostWrapper monthCostWrapper = new MonthCostWrapper(month, new List<DayCostWrapper>() { dayCost });
                YearCostWrapper yearCostWrapper = new YearCostWrapper(year, new List<MonthCostWrapper>() { monthCostWrapper });
                RestaurantCostWrapper newRestaurantWrapper = new RestaurantCostWrapper(restaurant, new List<YearCostWrapper>() { yearCostWrapper });
                return new CostWrapper(new List<RestaurantCostWrapper>() { newRestaurantWrapper });
            }
            RestaurantCostWrapper restaurantWrapper = costWrapper.getRestaurantCost(restaurant);
            if (restaurantWrapper.getRestaurant() == null)
            {
                MonthCostWrapper monthCostWrapper = new MonthCostWrapper(month, new List<DayCostWrapper>() { dayCost });
                YearCostWrapper yearCostWrapper = new YearCostWrapper(year, new List<MonthCostWrapper>() { monthCostWrapper });
                RestaurantCostWrapper newRestaurantWrapper = new RestaurantCostWrapper(restaurant, new List<YearCostWrapper>() { yearCostWrapper });
                return new CostWrapper(costWrapper, newRestaurantWrapper);
            }
            if (restaurantWrapper.getYearCost(year).getYear() == 0)
            {
                MonthCostWrapper monthCostWrapper = new MonthCostWrapper(month, new List<DayCostWrapper>() { dayCost });
                YearCostWrapper yearCostWrapper = new YearCostWrapper(year, new List<MonthCostWrapper>() { monthCostWrapper });
                restaurantWrapper = new RestaurantCostWrapper(restaurantWrapper, yearCostWrapper);
                return new CostWrapper(costWrapper, restaurantWrapper);
            }
            else
            {
                YearCostWrapper yearCostWrapper = restaurantWrapper.getYearCost(year);
                if (yearCostWrapper.getMonthCost(month).getMonth() == 0)
                {
                    MonthCostWrapper monthCostWrapper = new MonthCostWrapper(month, new List<DayCostWrapper>() { dayCost });
                    yearCostWrapper = new YearCostWrapper(yearCostWrapper, monthCostWrapper);
                    restaurantWrapper = new RestaurantCostWrapper(restaurantWrapper, yearCostWrapper);
                    return new CostWrapper(costWrapper, restaurantWrapper);
                }
                else
                {
                    MonthCostWrapper monthCostWrapper = new MonthCostWrapper(yearCostWrapper.getMonthCost(month), dayCost);
                    yearCostWrapper = new YearCostWrapper(yearCostWrapper, monthCostWrapper);
                    restaurantWrapper = new RestaurantCostWrapper(restaurantWrapper, yearCostWrapper);
                    return new CostWrapper(costWrapper, restaurantWrapper);
                }
            }
        }
    }
}
