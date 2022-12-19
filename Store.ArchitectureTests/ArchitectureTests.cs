using NetArchTest.Rules;
using Store.Domain.Entities;
using System.Reflection;
using Xunit;

namespace Store.ArchitectureTests
{
    public class ArchitectureTests
    {
        private const string DomainNamespace = "Store.Domain";
        private const string ApplicationNamespace = "Store.Application";
        private const string PersistanceNamespace = "Store.Persistence";
        private const string PresentationNamespace = "Store.Presentation";

        [Fact]
        public void Domain_Should_Not_HaveDependencyOnOtherProjects()
        {
            // Arrange
            var assembly = Assembly.GetAssembly(typeof(Product));

            var otherProjects = new[]
            {
                ApplicationNamespace,
                PersistanceNamespace,
                PresentationNamespace
            };


            // Act
            NetArchTest.Rules.TestResult testResult = Types
                .InAssembly(assembly)
                .ShouldNot()
                .HaveDependencyOnAll(otherProjects)
                .GetResult();

            // Assert
            Assert.True(testResult.IsSuccessful);
        }

        [Fact]
        public void Application_Should_Not_HaveDependencyOnOtherProjects_Except_Domain()
        {
            // Arrange
            var assembly = Assembly.GetAssembly(typeof(Product));

            var otherProjects = new[]
            {
                PersistanceNamespace,
                PresentationNamespace
            };

            // Act
            NetArchTest.Rules.TestResult testResult = Types
                .InAssembly(assembly)
                .ShouldNot()
                .HaveDependencyOnAll(otherProjects)
                .GetResult();

            // Assert
            Assert.True(testResult.IsSuccessful);
        }
    }
}
