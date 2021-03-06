﻿namespace Yajat.Digitalizer.DynamicCalculator.DataAccess.EfCore.Tests.Repository
{
    using System;
    using FakeItEasy;
    using FluentAssertions;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Yajat.Digitalizer.DynamicCalculator.Domain.Repository;
    using Yajat.Digitalizer.DynamicCalculator.DataAccess.EfCore.Repository;

    public class RepositoryTests
    {
        [TestClass]
        public class ConstructorTests
        {
            private DbContext fakeDbContext;
            private Repository<DummyEntity> repository;

            [TestInitialize]
            public void TestInitalize()
            {
                fakeDbContext = A.Fake<DbContext>();
                repository = new Repository<DummyEntity>(fakeDbContext);
            }

            [TestMethod]
            public void ContextIsNull()
            {
                Action ctor = () => new Repository<DummyEntity>(null);

                ctor.Should().Throw<ArgumentNullException>()
                    .WithMessage($"Value cannot be null.{Environment.NewLine}Parameter name: context");
            }

            [TestMethod]
            public void ShouldInheritFromIRepository()
            {
                repository.Should().BeAssignableTo<IRepository<DummyEntity>>();
            }

            [TestMethod]
            public void ShouldBeOfTypeRepository()
            {
                repository.Should().BeOfType<Repository<DummyEntity>>();
            }
        }
    }
}
