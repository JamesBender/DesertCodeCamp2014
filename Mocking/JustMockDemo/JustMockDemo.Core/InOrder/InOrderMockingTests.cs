using NUnit.Framework;
using Telerik.JustMock;
using Telerik.JustMock.Helpers;

namespace JustMockDemo.Core.InOrder
{
    [TestFixture]
    public class InOrderMockingTests
    {
        [Test]
        public void ShouldBeAbleToDefineOrderOfMocks()
        {
            //Arrange
            IInOrderDependency orderedDependencyMock = Mock.Create<IInOrderDependency>();
            orderedDependencyMock.Arrange(x => x.First()).Returns(false).OccursOnce();
            orderedDependencyMock.Arrange(x => x.Second()).Returns("Hi").Occurs(2);
            orderedDependencyMock.Arrange(x => x.Third()).Returns(42).OccursNever();
            var classUnderTest = new ClassUnderTest(orderedDependencyMock);

            //Act 
            var result = classUnderTest.TestMe();

            //Assert
            Assert.IsTrue(result);
            Mock.Assert(orderedDependencyMock);
        }
    }
}