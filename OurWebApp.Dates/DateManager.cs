
namespace OurWebApp.Dates
{
    using System;

    public static class DateManager
    {
        public static DateTime AmericanIndependenceDay = DateTime.Parse("07/04/1776");

        public static DateTime TitanicSank = DateTime.Parse("04/15/1912");

        public static DateTime BattleOfHastings = DateTime.Parse("10/14/1066");

        public static long DaysSince(DateTime sinceDate)
        {
            return DaysSince(sinceDate, DateTime.Today);
        }

        public static long DaysSince(DateTime sinceDate, DateTime currentDate)
        {
            return (currentDate - sinceDate).Days;
        }
    }
}
