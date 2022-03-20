﻿
namespace ComceptsPOO
{
    public class Date
    {
        private int _year;
        private int _month;
        private int _day;

        public Date(int year, int month, int day)
        {
            _year = year;
            _month = CheckMonth(month);
            _day = Checkday(year, month, day);
        }

        private int Checkday(int year, int month, int day)
        {
            //365.25....
            if(month == 2 && day == 29 && IsleapYear(year))
            {
                return day;
            }

            int[] daysPerMonth = { 0, 31, 28, 30, 31, 30, 31, 31, 31, 30, 31, 30, 31 };
            if (day >= 1 && day <= daysPerMonth[month]) 
            {
                return day;
            }
            throw new DayException("Invalid day");
            
        }

        private bool IsleapYear(int year)
        {
            return year % 400 == 0 || year % 4 == 0 && year % 100 != 0;
            //if (year % 4 == 0) {
            //    if (year % 100 == 0) {
            //        if (year % 400 == 0)
            //        {
            //            return true;
            //        }
            //        else
            //        {
            //            return false;
            //        }
            //    }
            //    else
            //    {
            //        return true;
            //    }
            //else
            //    {
            //        return false;
            //    }
            //}
        }

        private int CheckMonth(int month)
        {
            if(month >= 1 && month <= 12)
            {
                return month;
            }
            throw new MonthException($"Invalid month");
        }

        public override string ToString()
        {
            return $"{_year}/{_month:00}/{_day:00}";
        }
    }
}
