namespace DynamicCalculator.Domain.Tests.DataTransferObjects.Variable
{
    using FluentAssertions;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Yajat.Digitalizer.DynamicCalculator.Domain.DataTransferObjects;
    using Yajat.Digitalizer.DynamicCalculator.Domain.DataTransferObjects.Variable;
    using Yajat.Digitalizer.DynamicCalculator.Domain.Errors;

    public class VariableListResponseDtoTests
    {
        [TestClass]
        public class ConstructorTests
        {
            [TestMethod]
            public void Inheritence()
            {
                var response = new VariableListResponseDto();

                response.Should().NotBeNull();
                response.Should().BeAssignableTo<ErrorDetail>();
                response.Should().BeAssignableTo<IListResponseDto>();
                response.Should().BeOfType<VariableListResponseDto>();
            }
        }
    }
}
