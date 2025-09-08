namespace WH.Api.Common
{
    public static class DateHelper
    {
        public static (DateTime, DateTime) GetPeriodBy(int year, int month)
        {
            var begin = new DateTime(year, month, 1);
            var end = begin.AddMonths(1);
            return (begin, end);
        }

        public static (DateTime, DateTime) GetPeriodBy(int lastDays)
        {
            var begin = DateTime.Today.AddDays(-lastDays);
            var end = DateTime.Today;
            return (begin, end);
        }

        public static (DateTime, DateTime) GetCurrentMonth()
        {
            var today = DateTime.Today;
            var begin = new DateTime(today.Year, today.Month, 1);
            var end = today;
            return (begin, end);
        }

        public static (DateTime, DateTime) GetPreviousMonth()
        {
            var previous = DateTime.Today.AddMonths(-1);
            var begin = new DateTime(previous.Year, previous.Month, 1);
            var end = begin.AddMonths(1);
            return (begin, end);
        }

        public static (DateTime, DateTime) GetPrePreviousMonth()
        {
            var preprevious = DateTime.Today.AddMonths(-2);
            var begin = new DateTime(preprevious.Year, preprevious.Month, 1);
            var end = begin.AddMonths(1);
            return (begin, end);
        }

        public static (DateTime, DateTime) GetLastTripleMonth()
        {
            var begin = new DateTime(DateTime.Today.AddMonths(-2).Year, DateTime.Today.AddMonths(-2).Month, 1);
            var end = DateTime.Today;
            return (begin, end);
        }
    }
}
