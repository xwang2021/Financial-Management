using System;

namespace BenefitControl.CostData
{
    [Serializable]
    class Salary : Cost
    {
        public Salary(string name, double amount, Restaurant restaurant, DateTime time)
            : base(name, amount, 1, restaurant, CostType.SALARY, PayMethod.MONTHLY, time)
        {

        }
    }

    [Serializable]
    class Bonus : Cost
    {
        private string description;

        public Bonus(string name, double amount, Restaurant restaurant, string description, PayMethod payMethod, DateTime time)
            : base(name, amount, 1, restaurant, CostType.BONUS, payMethod, time)
        {
            this.description = description;
        }

        public string getDescription()
        {
            return description;
        }
    }

    [Serializable]
    class ExtraCost : Cost
    {
        private string description;

        public ExtraCost(string name, double amount, Restaurant restaurant, string description, PayMethod payMethod, DateTime time)
            : base(name, amount, 1, restaurant, CostType.EXTRA_COST, payMethod, time)
        {
            this.description = description;
        }

        public string getDescription()
        {
            return description;
        }
    }

    [Serializable]
    class MaintenanceCost : Cost
    {
        public MaintenanceCost(double amount, Restaurant restaurant, DateTime time)
            : base("维护", amount, 1, restaurant, CostType.MAINTENANCE, PayMethod.DAILY, time)
        {

        }
    }
}
