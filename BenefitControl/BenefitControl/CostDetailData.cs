using BenefitControl.CostData;
using System;
using System.Collections.Generic;

namespace BenefitControl
{
    public enum DetailType
    {
        Year, Month, Day
    }

    public abstract class CostDetailData
    {
        private Restaurant restaurant;
        private DetailType detailType;

        public CostDetailData(Restaurant restaurant, DetailType detailType)
        {
            this.restaurant = restaurant;
            this.detailType = detailType;
        }
        public Restaurant getRestaurant()
        {
            return restaurant;
        }

        public DetailType getDetailType()
        {
            return detailType;
        }

        public abstract Dictionary<string, Tuple<double, List<Cost>>> getCostDetailMap(Cost.CostType costType);

        public abstract string getTitle();

        public abstract string getTime();
    }

    public class YearCostDetailData : CostDetailData
    {
        private int year;
        private YearCostWrapper currentYearCostWrapper;

        public YearCostDetailData(Restaurant restaurant, int year, YearCostWrapper yearCostWrapper)
            : base(restaurant, DetailType.Year)
        {
            this.year = year;
            this.currentYearCostWrapper = yearCostWrapper;
        }

        public int getYear()
        {
            return year;
        }

        public override Dictionary<string, Tuple<double, List<Cost>>> getCostDetailMap(Cost.CostType costType)
        {
            return currentYearCostWrapper.getCostDetailByType(costType);
        }

        public override string getTitle()
        {
            return base.getRestaurant().name + year + "年支出细节";
        }

        public override string getTime()
        {
            return year + "年";
        }
    }

    public class MonthCostDetailData : CostDetailData
    {
        private int year;
        private int month;
        private MonthCostWrapper currentMonthCostWrapper;

        public MonthCostDetailData(Restaurant restaurant, int year, int month, MonthCostWrapper monthCostWrapper)
            : base(restaurant, DetailType.Month)
        {
            this.year = year;
            this.month = month;
            this.currentMonthCostWrapper = monthCostWrapper;
        }

        public int getYear()
        {
            return year;
        }

        public int getMonth()
        {
            return month;
        }

        public override Dictionary<string, Tuple<double, List<Cost>>> getCostDetailMap(Cost.CostType costType)
        {
            return currentMonthCostWrapper.getCostDetailByType(costType);
        }

        public override string getTitle()
        {
            return base.getRestaurant().name + year + "年" + month + "月支出细节";
        }

        public override string getTime()
        {
            return year + "年" + month + "月";
        }
    }

    public class DayCostDetailData : CostDetailData
    {
        private int year;
        private int month;
        private int day;
        private DayCostWrapper currentDayCostWrapper;

        public DayCostDetailData(Restaurant restaurant, int year, int month, int day, DayCostWrapper dayCostWrapper)
            : base(restaurant, DetailType.Day)
        {
            this.year = year;
            this.month = month;
            this.day = day;
            this.currentDayCostWrapper = dayCostWrapper;
        }

        public int getDay()
        {
            return day;
        }

        public override Dictionary<string, Tuple<double, List<Cost>>> getCostDetailMap(Cost.CostType costType)
        {
            return currentDayCostWrapper.getCostDetailByType(costType);
        }

        public override string getTitle()
        {
            return base.getRestaurant().name + year + "年" + month + "月" + day + "日支出细节";
        }

        public override string getTime()
        {
            return year + "年" + month + "月" + day + "日";
        }
    }
}
