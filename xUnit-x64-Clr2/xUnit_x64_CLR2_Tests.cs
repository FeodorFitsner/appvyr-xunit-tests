using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace xUnit_x64_Clr2
{
    public class xUnit_x64_CLR2_Tests
    {
        [Fact]
        public void TestA()
        {
            Assert.Equal(2, 2);
        }

        [Fact]
        public void TestB()
        {
            Assert.Equal(2, 2);
        }

        [Fact]
        public void TestC()
        {
            Assert.Equal(2, 2);
        }
    }
}
