

namespace Yajat.Digitalizer.DynamicCalculator.Mapping.Tests.Variable
{
    using AutoMapper;
    using FluentAssertions;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;
    using Yajat.Digitalizer.DynamicCalculator.Domain.DataTransferObjects.Variable;
    using Yajat.Digitalizer.DynamicCalculator.Domain.Interfaces;
    using Yajat.Digitalizer.DynamicCalculator.Mapping.Variable;

    public class VariableToVariableeResponseDtoTypeConverterTests
    {
        [TestClass]
        public class ConstructorTests
        {
            [TestMethod]
            public void Inheritence()
            {
                var converter = new VariableToVariableResponseDtoTypeConverter();
                converter.Should().NotBeNull();
                converter.Should().BeAssignableTo<ITypeConverter<Domain.Entities.Variable, VariableResponseDto>>();
                converter.Should().BeOfType<VariableToVariableResponseDtoTypeConverter>();
            }
        }

        [TestClass]
        public class MethodsTests
        {
            private readonly VariableToVariableResponseDtoTypeConverter converter;

            public MethodsTests()
            {
                converter = new VariableToVariableResponseDtoTypeConverter();
            }

            [TestMethod]
            public void ValidConversion()
            {
                var source = new Domain.Entities.Variable
                {
                    //Id = 1,
                    Name = "SomeName",
                    //Price = 69.69,
                    //Genre = "Awesauce",
                    //ReleaseDate = DateTime.Now.AddYears(-12)
                };

                var response = converter.Convert(source, default(VariableResponseDto), default(ResolutionContext));
                response.Should().NotBeNull();
                response.Should().BeAssignableTo<IVariable>();
                response.Should().BeOfType<VariableResponseDto>();

                response.Id.Should().Be(source.Id);
                response.Name.Should().BeEquivalentTo(source.Name);
                //response.Genre.Should().BeEquivalentTo(source.Genre);
                //response.Price.ShouldBeEquivalentTo(source.Price);
                //response.ReleaseDate.ShouldBeEquivalentTo(source.ReleaseDate);
            }
        }
    }
}
