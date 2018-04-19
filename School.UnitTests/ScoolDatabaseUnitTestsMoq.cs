using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace School.UnitTests
{
    [TestClass]
    public class ScoolDatabaseUnitTestsMoq
    {
        private SchoolDatabase schoolDatabase;

        private Mock<Student> studentMock;

        private Student student;

        [TestInitialize]
        public void Setup()
        {
            schoolDatabase = new SchoolDatabase();

            studentMock = new Mock<Student>();

            student = studentMock.Object;
        }

        [TestMethod]
        public void Register_WhenStudentIsValid_ShouldReturnTrue()
        {
            // Arrange
            studentMock.Setup(s => s.IsSmart()).Returns(true);

            // Act
            var result = schoolDatabase.Register(student);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Register_WhenStudentIsInvalid_ShouldReturnFalse()
        {
            // Arrange
            studentMock.Setup(s => s.IsSmart()).Returns(false);

            // Act
            var result = schoolDatabase.Register(student);

            // Assert
            Assert.IsFalse(result);
        }
    }
}
