using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using Xunit;
using Blather.Core;
using Blather.Core.Helpers;

namespace Blather.Tests.Unit
{
    public class RandomHelperFacts
    {
        [Fact]
        private void MethodName()
        {
            var x = RandomHelper.Numbers().Skip(10).Take(20).ToList();
            Assert.Equal(20, x.Count);
        }
    }
}
