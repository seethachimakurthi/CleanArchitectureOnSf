namespace DynamicCalculator.Domain.Tests.Constants
{
    using FluentAssertions;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Yajat.Digitalizer.DynamicCalculator.Domain.Constants;

    [TestClass]
    public class EnvironmentTypesTests
    {
        [TestMethod]
        public void ValidValues()
        {
            EnvironmentTypes.Local.Should().BeEquivalentTo("Local");
        }
    }
}
