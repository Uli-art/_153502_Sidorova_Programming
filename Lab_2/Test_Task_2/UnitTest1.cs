using Xunit;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using static Task_2.Program2;
namespace Task_2
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Assert.Equal(0, Check(0,0));
            Assert.Equal(0, Check(7.071, 7.071));
            Assert.Equal(-1, Check(-5.214, 6.754));
            Assert.Equal(1, Check(-5.234, -4.4237));
            Assert.Equal(0, Check(-10, 0));
            Assert.Equal(-1, Check(0, 2.24));
            Assert.Equal(1, Check(9.726, 0));
        }
    }
}