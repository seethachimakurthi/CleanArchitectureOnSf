

namespace DynamicCalculator.Domain.Tests.Constants
{
    using FluentAssertions;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Yajat.Digitalizer.DynamicCalculator.Domain.Constants;

    [TestClass]
    public class AppSettingsSectionsTests
    {
        [TestMethod]
        public void ValidValues()
        {
            AppSettingsSections.ConnectionStrings.Should().BeEquivalentTo("ConnectionStrings");
            AppSettingsSections.Logging.Should().BeEquivalentTo("Logging");
            AppSettingsSections.LogLocations.Should().BeEquivalentTo("LogLocations");
        }
    }
}
