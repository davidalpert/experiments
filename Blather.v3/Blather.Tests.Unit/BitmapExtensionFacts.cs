using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using Xunit;
using Blather.Core;
using Blather.Core.Helpers;

namespace Blather.Tests.Unit
{
    public class BitmapExtensionFacts
    {
        [Fact]
        public void GetPixels_returns_enumerable_of_Pixel()
        {
            var rb = new RandomBitmapFactory().BuildRandomBitmap();
            WriteBitmapSpecsToConsole(rb);

            Assert.IsType<Pixel>(rb.Bitmap.GetPixels().FirstOrDefault());
        }

        [Fact]
        public void GetPixels_returns_all_the_pixels()
        {
            var rb = new RandomBitmapFactory().BuildRandomBitmap();
            WriteBitmapSpecsToConsole(rb);

            var totalNumberOfPixels = rb.Bitmap.Height * rb.Bitmap.Width;

            Assert.Equal(totalNumberOfPixels, rb.Bitmap.GetPixels().Count());
        }

        [Fact]
        public void BuildColorCount_returns_a_ColorCount()
        {
            var rb = new RandomBitmapFactory().BuildRandomBitmap();
            WriteBitmapSpecsToConsole(rb);

            ColorMap map = rb.Bitmap.BuildColorMap();

            Assert.IsAssignableFrom<Dictionary<Color, int>>(map);
            Assert.Equal(rb.Breakdown.Keys.Count, map.Keys.Count);
            rb.Breakdown.ToList().ForEach(kvp => 
            {
                Assert.True(map.Keys.Contains(kvp.Key), String.Format("expected map to contain {0} but it did not.", kvp.Key));
                Assert.Equal(kvp.Value, map[kvp.Key]);
            });
        }

        private static void WriteBitmapSpecsToConsole(RandomBitmapResult rb)
        {
            Console.WriteLine(String.Format("Generated a {0} x {1} bitmap", rb.Bitmap.Width, rb.Bitmap.Height));
            Console.WriteLine(String.Join("; ", rb.Breakdown.Select(kvp => String.Format("{0} x [{1}, {2}, {3}]", kvp.Value, kvp.Key.R, kvp.Key.G, kvp.Key.B)).Take(10).ToArray()) + "; ...");
        }
    }
}
