using System;
using System.Collections.Generic;
using System.Text;
using Calculator;
using Xunit;

namespace CalculationsTest
{
    public class CalculationTest
    {
        [Fact]
        public void AddInt_GivenTwoIntValues_ReturnsInt()
        {
          
            var result = Program.addInt(5, 2);
            Assert.Equal(7,result);
        }
    }
}
