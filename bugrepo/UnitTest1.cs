using System;
using Xunit;

namespace bugrepo
{
    class Test:Nito.Comparers.EquatableBaseWithOperators<Test>
    {
        static Test()
        {
            DefaultComparer = Nito.Comparers.EqualityComparerBuilder.For<Test>().Default();
        }
    }
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Test a = null;
            Assert.True(a == null);
        }
    }
}
