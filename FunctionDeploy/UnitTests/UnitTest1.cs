using System;
using Xunit;
using FunctionDeploy;

namespace UnitTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(10,10,20)]
        [InlineData(15, 15, 30)]
        public void Test1(decimal value1, decimal value2, decimal result)
        {
            var service = new Operations();

            var res = service.Sum(value1, value4);

            Assert.True(res == result);
        }
    }
}
