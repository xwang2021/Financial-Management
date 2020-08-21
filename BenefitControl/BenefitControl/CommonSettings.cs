using System;
using System.Collections.Generic;

namespace BenefitControl
{
    public class CommonSettings
    {
        public const string DATA_PATH = "C:\\cost\\Mudan";
        public const string INCOME_FILE_PATH = "C:\\cost\\Mudan\\Income.xml";
        public const string COST_FILE_PATH = "C:\\cost\\Mudan\\Cost.xml";

        public static DateTime BASE_DATE = new DateTime(2016, 1, 1);

        public static int PAGE_HEIGHT = 1000;
        public static int PAGE_WIDTH = 1500;

        public static List<String> MONTH_LIST = new List<string>()
        {
            "一月", "二月", "三月", "四月", "五月", "六月",
            "七月", "八月", "九月", "十月", "十一月", "十二月"
        };

        public static List<String> DAY_LIST = new List<string>()
        {
            "一日", "二日", "三日", "四日", "五日",
            "六日", "七日", "八日", "九日", "十日",
            "十一日", "十二日", "十三日", "十四日", "十五日",
            "十六日", "十七日", "十八日", "十九日", "二十日",
            "二十一日", "二十二日", "二十三日", "二十四日", "二十五日",
            "二十六日", "二十七日", "二十八日", "二十九日", "三十日", "三十一日"
        };
    }
}
