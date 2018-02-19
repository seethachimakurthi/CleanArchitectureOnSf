namespace DynamicCalculator.Domain.Tests.Configurations
{
    using Microsoft.Extensions.Configuration;
    public abstract class ConfigurationTestBase
    {
        protected IConfigurationRoot Configuration;

        protected ConfigurationTestBase()
        {
            var builder = new ConfigurationBuilder();
            builder.AddInMemoryCollection(MockAppSettings.DevConfiguration);
            Configuration = builder.Build();
        }
    }
}
