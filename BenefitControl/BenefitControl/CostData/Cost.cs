using System;
using System.Collections.Generic;

namespace BenefitControl.CostData
{
    [Serializable]
    public class Cost
    {
        public static Cost EMPTY_COST = new Cost("", 0, 0, new Restaurant(""), CostType.FOOD, PayMethod.YEARLY, DateTime.Now);

        public enum PayMethod
        {
            MONTHLY, DAILY, YEARLY,
        }

        public enum CostType
        {
            FOOD, SALARY, BONUS, EXTRA_COST, MAINTENANCE,
        }

        public static string getCostTypeName(CostType costType)
        {
            switch (costType)
            {
                case CostType.FOOD:
                    return "食物";
                case CostType.SALARY:
                    return "工资";
                case CostType.BONUS:
                    return "奖金";
                case CostType.EXTRA_COST:
                    return "额外支出";
                case CostType.MAINTENANCE:
                    return "维护";
                default:
                    return "";
            }
        }

        public static CostType getCostTypeByName(string name)
        {
            Dictionary<string, CostType> costTypeMap = new Dictionary<string, CostType>();
            costTypeMap.Add(getCostTypeName(CostType.FOOD), CostType.FOOD);
            costTypeMap.Add(getCostTypeName(CostType.SALARY), CostType.SALARY);
            costTypeMap.Add(getCostTypeName(CostType.BONUS), CostType.BONUS);
            costTypeMap.Add(getCostTypeName(CostType.EXTRA_COST), CostType.EXTRA_COST);
            costTypeMap.Add(getCostTypeName(CostType.MAINTENANCE), CostType.MAINTENANCE);
            return costTypeMap[name];
        }

        private string name;
        private double amount;
        private double quantity;
        private Restaurant restaurant;
        private CostType costType;
        private PayMethod payMethod;
        private DateTime time;

        protected Cost(string name, double amount, double quantity, Restaurant restaurant, CostType costType, PayMethod payMethod, DateTime time)
        {
            this.name = name;
            this.amount = amount;
            this.quantity = quantity;
            this.restaurant = restaurant;
            this.costType = costType;
            this.payMethod = payMethod;
            this.time = time;
        }

        public PayMethod getPayMethod()
        {
            return payMethod;
        }

        public CostType getCostType()
        {
            return costType;
        }

        public string getName()
        {
            return name;
        }

        public double getAmount()
        {
            return amount;
        }

        public double getQuantity()
        {
            return quantity;
        }

        public double getUnitPrice()
        {
            return amount / quantity;
        }

        public Restaurant getRestaurant()
        {
            return restaurant;
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
