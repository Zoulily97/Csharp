using System;

namespace Csharp.其他
{
    public class Date
    {
        /// <summary>
        ///  //函数GetDate()，能计算一个日期若干（日 / 周 / 月）后的日期
        /// </summary>
        public static DateTime GetDate(string dateString, int amount, TimeEnum unit)
        {
            DateTime basetime = DateTime.ParseExact(dateString, "yyyyMMdd", System.Globalization.CultureInfo.CurrentCulture);

            switch (unit)
            {
                case TimeEnum.day:
                    return basetime.AddDays(amount);
                case TimeEnum.week:
                    return /*Convert.ToDateTime(*/basetime.AddDays(amount * 7);
                case TimeEnum.mouth:
                    return basetime.AddMonths(amount);
                default:
                    break;
            }
            return basetime;
        }
        /// <summary>
        /// 判定是一年的第一周，周一是几号
        /// </summary>
        /// <param name="dateTime">年份</param>   
        public static DateTime GetDate(int year)
        {
            //DateTime year = Convert.ToDateTime(Console.ReadLine());
            //Console.WriteLine(year); 

            //2019
            //2019.1.1 

            DateTime dt = new DateTime(year, 1, 1);
            Console.WriteLine(dt);//20201.1

            while (dt.DayOfWeek != DayOfWeek.Monday)
            {

                dt = dt.AddDays(1);//2020.1.6 周一
            }

            return dt;   //2020/1/6

        }
        /// <summary>
        ///  给定任意一个年份，就能按周排列显示每周的起始日期，如下图所示：
        /// </summary>
        /// <param name="year"></param>
        public static void GetDateWeek(int year)
        {
            GetWeekBody(GetDate(year));//2020/1/6
        }

        /// <summary>
        /// 按周排列显示每周的起始日期
        /// </summary>
        /// <param name="dateTime"></param>
        public static void GetWeekBody(DateTime dateTime)//2020/1/6
        {
            int i = 1;
            int year = dateTime.Year;
            while (dateTime.Year == year)
            {
                Console.WriteLine($"第{i}周：{dateTime.ToString("yyyy年MM月dd日")}-" +
                    $"{dateTime.AddDays(6).ToString("yyyy年MM月dd日")}");
                dateTime = dateTime.AddDays(7);
                i++;
            }
        }
    }
}
