using Xunit;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using static Task_1.Program;
namespace Task_1
{
    public class UnitTest1
    {
        [Fact]
        public void ChechIt()
        {
            Assert.Equal(-1,Check(1, 2, 3));
            Assert.Equal(1, Check(5, 5, 5));
            Assert.Equal(0, Check(5, 7, 8));
            Assert.Equal(-1, Check(0, 0, 0));
            Assert.Equal(1, Check(10, 10, 10));
            Assert.Equal(0, Check(3, 4, 5));
            Assert.Equal(0, Check(17, 8, 15));
        }
    }
}