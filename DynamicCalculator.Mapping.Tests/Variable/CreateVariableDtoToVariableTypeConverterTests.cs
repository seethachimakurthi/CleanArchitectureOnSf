

namespace Yajat.Digitalizer.DynamicCalculator.Mapping.Tests.Variable
{
    using AutoMapper;
    using FluentAssertions;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Yajat.Digitalizer.DynamicCalculator.Domain.DataTransferObjects.Variable.Input;
    using Yajat.Digitalizer.DynamicCalculator.Domain.Interfaces;
    using Yajat.Digitalizer.DynamicCalculator.Mapping.Variable;
    using Yajat.Digitalizer.DynamicCalculator.Mapping.Variables;

    public class CreateVariableDtoToVariableTypeConverterTests
    {
        [TestClass]
        public class ConstructorTests
        {
            [TestMethod]
            public void Inheritence()
            {
                var converter = new CreateVariableDtoToVariableTypeConverter();
                converter.Should().NotBeNull();
                converter.Should().BeAssignableTo<ITypeConverter<CreateVariableInputDto, Domain.Entities.Variable>>();
                converter.Should().BeOfType<CreateVariableDtoToVariableTypeConverter>();
            }
        }

        [TestClass]
        public class MethodsTests
        {
            private readonly CreateVariableDtoToVariableTypeConverter converter;

            public MethodsTests()
            {
                converter = new CreateVariableDtoToVariableTypeConverter();
            }

            [TestMethod]
            public void ValidConversion()
            {
                var source = new CreateVariableInputDto
                {
                    Name = "Thingy",
                    //Genre = "Some Kind of Genre",
                    //Price = 13.13,
                    //ReleaseDate = DateTime.Now.AddDays(-15)
                };

                var response = converter.Convert(source, default, default);
                response.Should().NotBeNull();
                response.Should().BeAssignableTo<IVariable>();
                response.Should().BeOfType<Domain.Entities.Variable>();

                response.Name.Should().BeEquivalentTo(source.Name);
                //response.Genre.Should().BeEquivalentTo(source.Genre);
                //response.Price.ShouldBeEquivalentTo(source.Price);
                //response.ReleaseDate.ShouldBeEquivalentTo(source.ReleaseDate);
            }
        }
    }
}
