using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;

namespace School.UnitTests
{
    [TestClass]
    public class SchoolDatabaseUnitTestsNS
    {
        private SchoolDatabase schoolDatabase;

        private Student studentMock;

        [TestInitialize]
        public void Setup()
        {
            schoolDatabase = new SchoolDatabase();

            studentMock = Substitute.For<Student>();
        }

        [TestMethod]
        public void Register_WhenStudentIsValid_ShouldReturnTrue()
        {
            // Arrange
            studentMock.IsSmart().Returns(true);

            // Act
            var result = schoolDatabase.Register(studentMock);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Register_WhenStudentIsInvalid_ShouldReturnFalse()
        {
            // Arrange
            studentMock.IsSmart().Returns(false);

            // Act
            var result = schoolDatabase.Register(studentMock);

            // Assert
            Assert.IsFalse(result);
        }
    }
}
