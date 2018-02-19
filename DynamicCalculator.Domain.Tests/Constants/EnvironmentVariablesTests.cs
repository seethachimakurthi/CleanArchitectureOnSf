


namespace DynamicCalculator.Domain.Tests.Constants
{
    using System;
    using FluentAssertions;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Yajat.Digitalizer.DynamicCalculator.Domain.Constants;

    [TestClass]
    public class EnvironmentVariablesTests
    {
        [TestMethod]
        public void ValidValues()
        {
            EnvironmentVariables.InMemoryDb.Should().BeEquivalentTo("InMemoryDb");
            EnvironmentVariables.ASPNETCORE_ENVIRONMENT.Should().BeEquivalentTo("ASPNETCORE_ENVIRONMENT");
        }

        [TestMethod]
        public void GetInMemoryDbValueIsFalse()
        {
            Environment.SetEnvironmentVariable(EnvironmentVariables.InMemoryDb, "false");
            var result = EnvironmentVariables.GetInMemoryDbValue();
            result.Should().BeFalse();
        }

        [TestMethod]
        public void GetInMemoryDbValuesIsTrue()
        {
            Environment.SetEnvironmentVariable(EnvironmentVariables.InMemoryDb, "true");
            var result = EnvironmentVariables.GetInMemoryDbValue();
            result.Should().BeTrue();
        }
    }
}
