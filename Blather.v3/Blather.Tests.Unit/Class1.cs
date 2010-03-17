using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;
using System.Drawing;

namespace Blather.Tests.Unit
{
    public class Class1
    {
        [Fact]
        private void MethodName()
        {
            var random = new Random(DateTime.Now.Millisecond);
            var h = random.Next(100);
            var w = random.Next(100);

            Bitmap bitmap = new Bitmap(w, h);

            Dictionary<Color, int> colors;

            for (var x = 0; x < w; x++)
            {

            }
        }
    }
}
