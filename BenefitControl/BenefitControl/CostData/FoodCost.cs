using System;
using System.Collections.Generic;

namespace BenefitControl.CostData
{
    [Serializable]
    public class Food : Cost
    {
        public enum FoodType { MEAT, GRAIN, SEAFOOD, VEGETABLE, FLAVOR }

        public static string getFoodTypeName(FoodType foodType)
        {
            switch (foodType)
            {
                case FoodType.MEAT:
                    return "肉类";
                case FoodType.GRAIN:
                    return "主食";
                case FoodType.SEAFOOD:
                    return "海鲜";
                case FoodType.VEGETABLE:
                    return "蔬菜";
                case FoodType.FLAVOR:
                    return "调味品";
                default:
                    return "";
            }
        }

        public static FoodType getFoodTypeByName(string name)
        {
            Dictionary<string, FoodType> costTypeMap = new Dictionary<string, FoodType>();
            costTypeMap.Add(getFoodTypeName(FoodType.MEAT), FoodType.MEAT);
            costTypeMap.Add(getFoodTypeName(FoodType.GRAIN), FoodType.GRAIN);
            costTypeMap.Add(getFoodTypeName(FoodType.SEAFOOD), FoodType.SEAFOOD);
            costTypeMap.Add(getFoodTypeName(FoodType.VEGETABLE), FoodType.VEGETABLE);
            costTypeMap.Add(getFoodTypeName(FoodType.FLAVOR), FoodType.FLAVOR);
            return costTypeMap[name];
        }

        private FoodType foodType;

        protected Food(string name, double amount, double quantity, Restaurant restaurant,
            FoodType foodType, PayMethod payMethod, DateTime time)
            : base(name, amount, quantity, restaurant, CostType.FOOD, payMethod, time)
        {
            this.foodType = foodType;
        }

        public FoodType getFoodType()
        {
            return foodType;
        }
    }

    [Serializable]
    class Meat : Food
    {
        public Meat(string name, double amount, double quantity, Restaurant restaurant, PayMethod payMethod, DateTime time)
            : base(name, amount, quantity, restaurant, FoodType.MEAT, payMethod, time)
        {

        }

    }

    [Serializable]
    class Vegetable : Food
    {
        public Vegetable(string name, double amount, double quantity, Restaurant restaurant, PayMethod payMethod, DateTime time)
            : base(name, amount, quantity, restaurant, FoodType.VEGETABLE, payMethod, time)
        {

        }

    }

    [Serializable]
    class Seafood : Food
    {
        public Seafood(string name, double amount, double quantity, Restaurant restaurant, PayMethod payMethod, DateTime time)
            : base(name, amount, quantity, restaurant, FoodType.SEAFOOD, payMethod, time)
        {

        }

    }

    [Serializable]
    class Grain : Food
    {
        public Grain(string name, double amount, double quantity, Restaurant restaurant, PayMethod payMethod, DateTime time)
            : base(name, amount, quantity, restaurant, FoodType.GRAIN, payMethod, time)
        {

        }

    }

    [Serializable]
    class Flavor : Food
    {
        public Flavor(string name, double amount, double quantity, Restaurant restaurant, PayMethod payMethod, DateTime time)
            : base(name, amount, quantity, restaurant, FoodType.FLAVOR, payMethod, time)
        {

        }

    }
}
