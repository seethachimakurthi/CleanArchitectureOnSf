

namespace DynamicCalculator.Domain.Tests.Configurations
{
    using FluentAssertions;
    using Microsoft.Extensions.Configuration;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Yajat.Digitalizer.DynamicCalculator.Domain.Configurations;
    using Yajat.Digitalizer.DynamicCalculator.Domain.Constants;
    [TestClass]
    public class ConnectionStringsConfigurationTests : ConfigurationTestBase
    {
        [TestMethod]
        public void Valid()
        {
            var connectionStringsConfiguration = Configuration.GetSection(AppSettingsSections.ConnectionStrings).Get<ConnectionStringsConfiguration>();

            connectionStringsConfiguration.Should().NotBeNull();

            connectionStringsConfiguration.VideoGamesConnection.Should().NotBeNullOrWhiteSpace();
            connectionStringsConfiguration.VideoGamesConnection.Should().BeEquivalentTo(Configuration[MockAppSettings.ConnectionStringsKeys.VideoGamesConnection]);
        }
    }
}
