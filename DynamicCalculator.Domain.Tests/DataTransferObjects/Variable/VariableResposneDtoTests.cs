namespace DynamicCalculator.Domain.Tests.DataTransferObjects.Variable
{
    using FluentAssertions;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Yajat.Digitalizer.DynamicCalculator.Domain.DataTransferObjects.Variable;
    using Yajat.Digitalizer.DynamicCalculator.Domain.Errors;
    using Yajat.Digitalizer.DynamicCalculator.Domain.Interfaces;

    public class VariableResposneDtoTests
    {
        [TestClass]
        public class ConstructorTests
        {
            [TestMethod]
            public void Inheritence()
            {
                var response = new VariableResponseDto();

                response.Should().NotBeNull();
                response.Should().BeAssignableTo<IVariable>();
                response.Should().BeAssignableTo<ErrorDetail>();
                response.Should().BeOfType<VariableResponseDto>();
            }
        }
    }
}
