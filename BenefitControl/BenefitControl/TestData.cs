using BenefitControl.CostData;
using BenefitControl.IncomeData;
using System;
using System.Collections.Generic;

namespace BenefitControl
{
    class TestData
    {
        public static DateTime TODAY = new DateTime(2017, 4, 11);

        public CostWrapper getCostData()
        {
            List<Cost> result = new List<Cost>();
            result.AddRange(getFoodCostList());
            result.AddRange(getSalaryList());
            result.AddRange(getBonusList());
            result.AddRange(getExtraCostList());
            result.AddRange(getMaintenanceCostList());

            CostWrapperConverter dataConverter = new CostWrapperConverter();
            CostWrapper costWrapper = dataConverter.convertToCostWrapper(result);
            return costWrapper;
        }

        private List<Cost> getFoodCostList()
        {
            List<Cost> result = new List<Cost>();
            DateTime localDate = new DateTime(2016, 1, 1);
            DateTime today = TODAY;
            while (localDate.CompareTo(today) < 0)
            {
                Meat meat1 = new Meat("猪肉", 200 + localDate.Day, 10, Restaurant.RESTAURANT_1, Cost.PayMethod.DAILY, localDate);
                Meat meat2 = new Meat("牛肉", 300 + localDate.Day, 10, Restaurant.RESTAURANT_1, Cost.PayMethod.DAILY, localDate);
                Meat meat3 = new Meat("猪肉", 400 + localDate.Day, 10, Restaurant.RESTAURANT_2, Cost.PayMethod.DAILY, localDate);
                Meat meat4 = new Meat("牛肉", 100 + localDate.Day, 10, Restaurant.RESTAURANT_2, Cost.PayMethod.DAILY, localDate);

                Vegetable vegetable1 = new Vegetable("白菜", 20 + localDate.Day, 10, Restaurant.RESTAURANT_1, Cost.PayMethod.DAILY, localDate);
                Vegetable vegetable2 = new Vegetable("菠菜", 40 + localDate.Day, 5, Restaurant.RESTAURANT_1, Cost.PayMethod.DAILY, localDate);
                Vegetable vegetable3 = new Vegetable("白菜", 20 + localDate.Day, 10, Restaurant.RESTAURANT_2, Cost.PayMethod.DAILY, localDate);
                Vegetable vegetable4 = new Vegetable("菠菜", 40 + localDate.Day, 10, Restaurant.RESTAURANT_2, Cost.PayMethod.DAILY, localDate);

                Seafood seafood1 = new Seafood("虾", 400 + localDate.Day, 10, Restaurant.RESTAURANT_1, Cost.PayMethod.DAILY, localDate);
                Seafood seafood2 = new Seafood("鱼", 600 + localDate.Day, 10, Restaurant.RESTAURANT_1, Cost.PayMethod.DAILY, localDate);
                Seafood seafood3 = new Seafood("虾", 400 + localDate.Day, 10, Restaurant.RESTAURANT_2, Cost.PayMethod.DAILY, localDate);
                Seafood seafood4 = new Seafood("鱼", 600 + localDate.Day, 10, Restaurant.RESTAURANT_2, Cost.PayMethod.DAILY, localDate);

                Grain grain1 = new Grain("米饭", 100 + localDate.Day, 1, Restaurant.RESTAURANT_1, Cost.PayMethod.DAILY, localDate);
                Grain grain2 = new Grain("米饭", 100 + localDate.Day, 1, Restaurant.RESTAURANT_2, Cost.PayMethod.DAILY, localDate);

                Flavor flavor1 = new Flavor("糖", 10 + localDate.Day, 1, Restaurant.RESTAURANT_1, Cost.PayMethod.DAILY, localDate);
                Flavor flavor2 = new Flavor("盐", 8 + localDate.Day, 1, Restaurant.RESTAURANT_1, Cost.PayMethod.DAILY, localDate);
                Flavor flavor3 = new Flavor("辣椒", 5 + localDate.Day, 1, Restaurant.RESTAURANT_1, Cost.PayMethod.DAILY, localDate);
                Flavor flavor4 = new Flavor("糖", 10 + localDate.Day, 1, Restaurant.RESTAURANT_2, Cost.PayMethod.DAILY, localDate);
                Flavor flavor5 = new Flavor("盐", 8 + localDate.Day, 1, Restaurant.RESTAURANT_2, Cost.PayMethod.DAILY, localDate);
                Flavor flavor6 = new Flavor("辣椒", 5 + localDate.Day, 1, Restaurant.RESTAURANT_2, Cost.PayMethod.DAILY, localDate);

                result.Add(meat1);
                result.Add(meat2);
                result.Add(meat3);
                result.Add(meat4);
                result.Add(vegetable1);
                result.Add(vegetable2);
                result.Add(vegetable3);
                result.Add(vegetable4);
                result.Add(seafood1);
                result.Add(seafood2);
                result.Add(seafood3);
                result.Add(seafood4);
                result.Add(grain1);
                result.Add(grain2);
                result.Add(flavor1);
                result.Add(flavor2);
                result.Add(flavor3);
                result.Add(flavor4);
                result.Add(flavor5);
                result.Add(flavor6);

                localDate = localDate.AddDays(1);
            }
            return result;
        }

        private List<Cost> getSalaryList()
        {
            List<string> employees = new List<string>();
            employees.Add("A");
            employees.Add("B");
            employees.Add("C");
            employees.Add("D");
            employees.Add("E");
            employees.Add("F");
            employees.Add("a");
            employees.Add("b");
            employees.Add("c");
            employees.Add("d");
            employees.Add("e");
            employees.Add("f");

            List<Cost> result = new List<Cost>();
            DateTime localDate = new DateTime(2016, 1, 1);
            DateTime today = TODAY;
            while (localDate.CompareTo(today) < 0)
            {
                for (int i = 0; i < 6; i++)
                {
                    string name1 = employees[i];
                    double money1 = 1000 * (i + 1);
                    Salary salary1 = new Salary(name1, money1, Restaurant.RESTAURANT_1, localDate);
                    result.Add(salary1);

                    string name2 = employees[i + 6];
                    double money2 = 1100 * (i + 1);
                    Salary salary2 = new Salary(name2, money2, Restaurant.RESTAURANT_2, localDate);
                    result.Add(salary2);
                }
                localDate = localDate.AddMonths(1);
            }
            return result;
        }

        private List<Cost> getBonusList()
        {
            List<string> employees = new List<string>();
            employees.Add("A");
            employees.Add("B");
            employees.Add("C");
            employees.Add("D");
            employees.Add("E");
            employees.Add("F");
            employees.Add("a");
            employees.Add("b");
            employees.Add("c");
            employees.Add("d");
            employees.Add("e");
            employees.Add("f");

            List<Cost> result = new List<Cost>();
            DateTime localDate = new DateTime(2016, 1, 15);
            DateTime today = TODAY;
            while (localDate.CompareTo(today) < 0)
            {
                for (int i = 0; i < 6; i++)
                {
                    string name1 = employees[i];
                    double money1 = 150 * (i + 1);
                    Bonus bonus1 = new Bonus(name1, money1, Restaurant.RESTAURANT_1, "表现好", Cost.PayMethod.MONTHLY, localDate);
                    result.Add(bonus1);

                    string name2 = employees[i + 6];
                    double money2 = 200 * (i + 1);
                    Bonus bonus2 = new Bonus(name2, money2, Restaurant.RESTAURANT_2, "出勤好", Cost.PayMethod.MONTHLY, localDate);
                    result.Add(bonus2);
                }
                localDate = localDate.AddMonths(1);
            }
            return result;
        }

        private List<Cost> getExtraCostList()
        {
            List<string> services = new List<string>();
            services.Add("网费");
            services.Add("水费");
            services.Add("电费");
            services.Add("房租");
            services.Add("煤气费");


            List<Cost> result = new List<Cost>();
            DateTime localDate = new DateTime(2016, 1, 8);
            DateTime today = TODAY;
            while (localDate.CompareTo(today) < 0)
            {
                for (int i = 0; i < 5; i++)
                {
                    string name1 = services[i];
                    double money1 = 100 * (i + 1) + localDate.Month * 5;
                    ExtraCost extraCost1 = new ExtraCost(name1, money1, Restaurant.RESTAURANT_1, "Res 1", Cost.PayMethod.MONTHLY, localDate);
                    result.Add(extraCost1);

                    string name2 = services[i];
                    double money2 = 50 * (i + 1) + localDate.Month * 6;
                    ExtraCost extraCost2 = new ExtraCost(name2, money2, Restaurant.RESTAURANT_2, "Res 2", Cost.PayMethod.MONTHLY, localDate);
                    result.Add(extraCost2);
                }
                localDate = localDate.AddMonths(1);
            }
            return result;
        }

        private List<Cost> getMaintenanceCostList()
        {
            List<Cost> result = new List<Cost>();
            DateTime localDate = new DateTime(2016, 1, 1);
            DateTime today = TODAY;
            while (localDate.CompareTo(today) < 0)
            {
                int day = localDate.Day;
                if (day % 7 == 1)
                {
                    double money1 = 360;
                    MaintenanceCost maintenanceCost1 = new MaintenanceCost(money1, Restaurant.RESTAURANT_1, localDate);
                    double money2 = 280;
                    MaintenanceCost maintenanceCost2 = new MaintenanceCost(money2, Restaurant.RESTAURANT_2, localDate);
                    result.Add(maintenanceCost1);
                    result.Add(maintenanceCost2);
                }
                else if (day % 7 == 2)
                {
                    double money1 = 80;
                    MaintenanceCost maintenanceCost1 = new MaintenanceCost(money1, Restaurant.RESTAURANT_1, localDate);
                    double money2 = 100;
                    MaintenanceCost maintenanceCost2 = new MaintenanceCost(money2, Restaurant.RESTAURANT_2, localDate);
                    result.Add(maintenanceCost1);
                    result.Add(maintenanceCost2);
                }
                else if (day % 7 == 3)
                {
                    double money1 = 110;
                    MaintenanceCost maintenanceCost1 = new MaintenanceCost(money1, Restaurant.RESTAURANT_1, localDate);
                    double money2 = 90;
                    MaintenanceCost maintenanceCost2 = new MaintenanceCost(money2, Restaurant.RESTAURANT_2, localDate);
                    result.Add(maintenanceCost1);
                    result.Add(maintenanceCost2);
                }
                else if (day % 7 == 4)
                {
                    double money2 = 180;
                    MaintenanceCost maintenanceCost2 = new MaintenanceCost(money2, Restaurant.RESTAURANT_2, localDate);
                    result.Add(maintenanceCost2);
                }
                else if (day % 7 == 5)
                {
                    double money1 = 200;
                    MaintenanceCost maintenanceCost1 = new MaintenanceCost(money1, Restaurant.RESTAURANT_1, localDate);
                    result.Add(maintenanceCost1);
                }
                localDate = localDate.AddDays(1);
            }
            return result;
        }

        public IncomeWrapper getIncomeValue()
        {
            List<Income> result = new List<Income>();
            DateTime localDate = new DateTime(2016, 1, 1);
            DateTime today = TODAY;
            while (localDate.CompareTo(today) < 0)
            {
                Income income1 = new Income(Restaurant.RESTAURANT_1, 1500 * localDate.Month, localDate);
                Income income2 = new Income(Restaurant.RESTAURANT_2, 2000 * localDate.Month, localDate);
                result.Add(income1);
                result.Add(income2);
                localDate = localDate.AddDays(1);
            }
            IncomeWrapperConverter dataConverter = new IncomeWrapperConverter();
            IncomeWrapper incomeWrapper = dataConverter.convertToIncomeWrapper(result);
            return incomeWrapper;
        }
    }
}
