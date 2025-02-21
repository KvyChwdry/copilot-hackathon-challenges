using NUnit.Framework;
using Moq;
using System;
using System.Collections.Generic;

namespace ClockSync.Tests
{
    [TestFixture]
    public class ClockSyncServiceTests
    {
        private ClockSyncService _service;

        [SetUp]
        public void SetUp()
        {
            _service = new ClockSyncService();
        }

        [Test]
        public void CalculateTimeDifferences_ShouldReturnCorrectDifferences()
        {
            // Arrange
            TimeSpan grandClockTime = new TimeSpan(15, 0, 0);
            List<TimeSpan> clockTimes = new List<TimeSpan>
            {
                new TimeSpan(14, 45, 0),
                new TimeSpan(15, 5, 0),
                new TimeSpan(15, 0, 0),
                new TimeSpan(14, 40, 0)
            };

            // Act
            List<int> result = _service.CalculateTimeDifferences(grandClockTime, clockTimes);

            // Assert
            List<int> expected = new List<int> { -15, 5, 0, -20 };
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void CalculateTimeDifferences_WithEmptyClockTimes_ShouldReturnEmptyList()
        {
            // Arrange
            TimeSpan grandClockTime = new TimeSpan(15, 0, 0);
            List<TimeSpan> clockTimes = new List<TimeSpan>();

            // Act
            List<int> result = _service.CalculateTimeDifferences(grandClockTime, clockTimes);

            // Assert
            Assert.IsEmpty(result);
        }
    }
}
