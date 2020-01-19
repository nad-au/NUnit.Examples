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
            // startDate = Latest of either workPeriodStartDate or reportStartDate
            var startDate = workPeriodStartDate >= reportStartDate
                ? workPeriodStartDate
                : reportStartDate;

            // endDate = workPeriodEndDate unless null, otherwise reportEndDate
            var endDate = workPeriodEndDate ?? reportEndDate;
            // If endDate > reportEndDate then set to reportEndDate
            endDate = endDate <= reportEndDate ? endDate : reportEndDate;

            // if workPeriodEndDate is null or > reportEndDate
            // then return end - start + 1 
            if (workPeriodEndDate == null || workPeriodEndDate > reportEndDate)
            {
                return endDate.Subtract(startDate.Date).Days + 1;
            }

            // If workPeriodStartDate == workPeriodEndDate return 1
            if (workPeriodStartDate == workPeriodEndDate.Value)
                return 1;

            // days = workPeriodEndDate - startDate
            var days = workPeriodEndDate.Value.Subtract(startDate.Date).Days;
            
            // Return days + 1 unless daysNightsType = Nights, then return days
            return daysNightsType == DaysNightsType.Nights ? days : days + 1;
        }
    }
    
    public enum DaysNightsType
    {
        Days,
        Nights
    }
}