

namespace DynamicCalculator.Domain.Tests.Entitites
{
    using FluentAssertions;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Yajat.Digitalizer.DynamicCalculator.Domain.Entities;

    public class GameTests
    {

        [TestClass]
        public class ConstructorTests
        {
            private Variable entity;

            [TestInitialize]
            public void TestInitialize()
            {
                entity = new Variable();
            }

            [TestMethod]
            public void ShouldInheritFromVideoGameEntity()
            {
                entity.Should().BeAssignableTo<BaseEntity>();
            }

            [TestMethod]
            public void ShouldBeOfTypeGame()
            {
                entity.Should().BeOfType<Variable>();
            }
        }
    }
}
