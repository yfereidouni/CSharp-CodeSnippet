using iAttributes.Domain;
using Xunit;

namespace iAttributes.DomainTests
{
    public class InternalPrinterTest
    {
        [Fact]
        public void PrintTest()
        {
            //Arrange
            InternalPrinter internalPrinter = new InternalPrinter();

            //Act
            var expectedResult = "Hello Internal";
            var result =internalPrinter.Print();


            //Assert
            Assert.Equal(expectedResult, result);
        }
    }
}