using Xunit;

namespace Warehouse.test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            int i = 0;
            i++;

            Assert.Equal(1, i);
        }
    }
}