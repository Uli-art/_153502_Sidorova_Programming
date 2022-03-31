using Xunit;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using static Task_1.Program;
namespace Task_1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Assert.Equal(0, CheckAndModify(0));
            Assert.Equal(-4, CheckAndModify(-7));
            Assert.Equal(2147483646, CheckAndModify(2147483643));
            Assert.Equal(500, CheckAndModify(1000));
            Assert.Equal(-3366722, CheckAndModify(-6733444));
        }
    }
}