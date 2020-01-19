using System;
using NUnit.Examples.Impl;
using NUnit.Framework;

namespace NUnit.Examples.Tests
{
    [TestFixture]
    public class PayCalcsTests
    {
        [Test]
        [TestCase(DaysNightsType.Nights, "28 Sep 2013", "05 Nov 2013", "01 Oct 2013", "31 Oct 2013", ExpectedResult = 31)]
        [TestCase(DaysNightsType.Days, "28 Sep 2013", "05 Nov 2013", "01 Oct 2013", "31 Oct 2013", ExpectedResult = 31)]
        [TestCase(DaysNightsType.Nights, "01 Oct 2013", "05 Nov 2013", "01 Oct 2013", "31 Oct 2013", ExpectedResult = 31)]
        [TestCase(DaysNightsType.Days, "01 Oct 2013", "05 Nov 2013", "01 Oct 2013", "31 Oct 2013", ExpectedResult = 31)]
        [TestCase(DaysNightsType.Nights, "25 Oct 2013", "05 Nov 2013", "01 Oct 2013", "31 Oct 2013", ExpectedResult = 7)]
        [TestCase(DaysNightsType.Days, "25 Oct 2013", "05 Nov 2013", "01 Oct 2013", "31 Oct 2013", ExpectedResult = 7)]
        [TestCase(DaysNightsType.Nights, "31 Oct 2013", "05 Nov 2013", "01 Oct 2013", "31 Oct 2013", ExpectedResult = 1)]
        [TestCase(DaysNightsType.Days, "31 Oct 2013", "05 Nov 2013", "01 Oct 2013", "31 Oct 2013", ExpectedResult = 1)]

        [TestCase(DaysNightsType.Nights, "28 Sep 2013", "06 Oct 2013", "01 Oct 2013", "31 Oct 2013", ExpectedResult = 5)]
        [TestCase(DaysNightsType.Days, "28 Sep 2013", "06 Oct 2013", "01 Oct 2013", "31 Oct 2013", ExpectedResult = 6)]
        [TestCase(DaysNightsType.Nights, "01 Oct 2013", "06 Oct 2013", "01 Oct 2013", "31 Oct 2013", ExpectedResult = 5)]
        [TestCase(DaysNightsType.Days, "01 Oct 2013", "06 Oct 2013", "01 Oct 2013", "31 Oct 2013", ExpectedResult = 6)]
        [TestCase(DaysNightsType.Nights, "04 Oct 2013", "06 Oct 2013", "01 Oct 2013", "31 Oct 2013", ExpectedResult = 2)]
        [TestCase(DaysNightsType.Days, "04 Oct 2013", "06 Oct 2013", "01 Oct 2013", "31 Oct 2013", ExpectedResult = 3)]

        [TestCase(DaysNightsType.Nights, "28 Sep 2013", "31 Oct 2013", "01 Oct 2013", "31 Oct 2013", ExpectedResult = 30)]
        [TestCase(DaysNightsType.Days, "28 Sep 2013", "31 Oct 2013", "01 Oct 2013", "31 Oct 2013", ExpectedResult = 31)]
        [TestCase(DaysNightsType.Nights, "25 Oct 2013", "31 Oct 2013", "01 Oct 2013", "31 Oct 2013", ExpectedResult = 6)]
        [TestCase(DaysNightsType.Days, "25 Oct 2013", "31 Oct 2013", "01 Oct 2013", "31 Oct 2013", ExpectedResult = 7)]
        [TestCase(DaysNightsType.Nights, "31 Oct 2013", "31 Oct 2013", "01 Oct 2013", "31 Oct 2013", ExpectedResult = 1)]
        [TestCase(DaysNightsType.Days, "31 Oct 2013", "31 Oct 2013", "01 Oct 2013", "31 Oct 2013", ExpectedResult = 1)]

        [TestCase(DaysNightsType.Nights, "01 Oct 2013", "01 Oct 2013", "01 Oct 2013", "31 Oct 2013", ExpectedResult = 1)]
        [TestCase(DaysNightsType.Days, "01 Oct 2013", "01 Oct 2013", "01 Oct 2013", "31 Oct 2013", ExpectedResult = 1)]

        [TestCase(DaysNightsType.Nights, "05 Oct 2013", "05 Oct 2013", "01 Oct 2013", "31 Oct 2013", ExpectedResult = 1)]
        [TestCase(DaysNightsType.Days, "05 Oct 2013", "05 Oct 2013", "01 Oct 2013", "31 Oct 2013", ExpectedResult = 1)]

        [TestCase(DaysNightsType.Nights, "28 Sep 2013", null, "01 Oct 2013", "31 Oct 2013", ExpectedResult = 31)]
        [TestCase(DaysNightsType.Days, "28 Sep 2013", null, "01 Oct 2013", "31 Oct 2013", ExpectedResult = 31)]
        [TestCase(DaysNightsType.Nights, "01 Oct 2013", null, "01 Oct 2013", "31 Oct 2013", ExpectedResult = 31)]
        [TestCase(DaysNightsType.Days, "01 Oct 2013", null, "01 Oct 2013", "31 Oct 2013", ExpectedResult = 31)]
        [TestCase(DaysNightsType.Nights, "25 Oct 2013", null, "01 Oct 2013", "31 Oct 2013", ExpectedResult = 7)]
        [TestCase(DaysNightsType.Days, "25 Oct 2013", null, "01 Oct 2013", "31 Oct 2013", ExpectedResult = 7)]
        [TestCase(DaysNightsType.Nights, "31 Oct 2013", null, "01 Oct 2013", "31 Oct 2013", ExpectedResult = 1)]
        [TestCase(DaysNightsType.Days, "31 Oct 2013", null, "01 Oct 2013", "31 Oct 2013", ExpectedResult = 1)]

        [TestCase(DaysNightsType.Nights, "30 Sep 2013", "01 Oct 2013", "01 Oct 2013", "31 Oct 2013", ExpectedResult = 0)]
        [TestCase(DaysNightsType.Days, "30 Sep 2013", "01 Oct 2013", "01 Oct 2013", "31 Oct 2013", ExpectedResult = 1)]

        [TestCase(DaysNightsType.Nights, "30 Sep 2013", "01 Oct 2013", "01 Sep 2013", "30 Sep 2013", ExpectedResult = 1)]
        [TestCase(DaysNightsType.Days, "30 Sep 2013", "01 Oct 2013", "01 Sep 2013", "30 Sep 2013", ExpectedResult = 1)]

        [TestCase(DaysNightsType.Nights, "31 Oct 2013", "01 Nov 2013", "01 Nov 2013", "30 Nov 2013", ExpectedResult = 0)]
        [TestCase(DaysNightsType.Days, "31 Oct 2013", "01 Nov 2013", "01 Nov 2013", "30 Nov 2013", ExpectedResult = 1)]

        [TestCase(DaysNightsType.Nights, "01 Oct 2013", "31 Oct 2013", "01 Oct 2013", "31 Oct 2013", ExpectedResult = 30)]
        [TestCase(DaysNightsType.Days, "01 Oct 2013", "31 Oct 2013", "01 Oct 2013", "31 Oct 2013", ExpectedResult = 31)]

        [TestCase(DaysNightsType.Nights, "1 May 2013", null, "1 May 2013", "31 May 2013", ExpectedResult = 31)]
        [TestCase(DaysNightsType.Nights, "1 May 2013", "31 May 2013", "1 May 2013", "31 May 2013", ExpectedResult = 30)]
        [TestCase(DaysNightsType.Nights, "2 May 2013", null, "1 May 2013", "31 May 2013", ExpectedResult = 30)]
        [TestCase(DaysNightsType.Nights, "2 May 2013", "31 May 2013", "1 May 2013", "31 May 2013", ExpectedResult = 29)]
        public int CalculateFullDaysWorked(
            DaysNightsType daysOrNights,
            string placementStartDate,
            string placementEndDate,
            string reportStartDate,
            string reportEndDate)
        {
            return PayCalcs.GetFullDaysWorked(
                daysOrNights,
                DateTime.Parse(placementStartDate),
                placementEndDate != null ? DateTime.Parse(placementEndDate) : (DateTime?) null,
                DateTime.Parse(reportStartDate), DateTime.Parse(reportEndDate));
        }
    }
}