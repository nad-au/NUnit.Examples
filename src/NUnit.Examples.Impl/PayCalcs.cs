using System;

namespace NUnit.Examples.Impl
{
    public class PayCalcs
    {
        public static int GetFullDaysWorked(
            DaysNightsType daysNightsType,
            DateTime workPeriodStartDate,
            DateTime? workPeriodEndDate,
            DateTime reportStartDate,
            DateTime reportEndDate)
        {
            var startDate = workPeriodStartDate >= reportStartDate
                ? workPeriodStartDate
                : reportStartDate;

            var endDate = workPeriodEndDate ?? reportEndDate;
            endDate = endDate <= reportEndDate ? endDate : reportEndDate;

            if (workPeriodEndDate == null || workPeriodEndDate > reportEndDate)
            {
                return endDate.Subtract(startDate.Date).Days + 1;
            }

            if (workPeriodStartDate == workPeriodEndDate.Value)
                return 1;

            var days = workPeriodEndDate.Value.Subtract(startDate.Date).Days;
            
            return daysNightsType == DaysNightsType.Nights ? days : days + 1;
        }
    }
    
    public enum DaysNightsType
    {
        Days,
        Nights
    }
}