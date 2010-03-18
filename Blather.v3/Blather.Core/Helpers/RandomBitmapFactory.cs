using System;
using System.Collections.Generic;
using System.Drawing;

namespace Blather.Core.Helpers
{
    public class RandomBitmapFactory
    {
        Random random;

        /// <summary>
        /// Initializes a new instance of the RandomBitmapFactory class.
        /// </summary>
        /// <param name="random"></param>
        public RandomBitmapFactory()
        {
            this.random = new Random(DateTime.Now.Millisecond);
        }

        public RandomBitmapResult BuildRandomBitmap()
        {
            return BuildRandomBitmap(null, null, null);
        }

        public RandomBitmapResult BuildRandomBitmap(int? width, int? height, int? maxColorValue)
        {
            height = height ?? random.Next(10, 100);
            width = width ?? random.Next(10, 100);
            maxColorValue = maxColorValue ?? random.Next(255);

            Bitmap bitmap = new Bitmap(width.Value, height.Value);

            Dictionary<Color, int> colors = new Dictionary<Color, int>();
            Color c;

            for (var x = 0; x < width.Value; x++)
            {
                for (var y = 0; y < height.Value; y++)
                {
                    // create a random color
                    var r = random.Next(maxColorValue.Value / 10) * 10;
                    var g = random.Next(maxColorValue.Value / 10) * 10;
                    var b = random.Next(maxColorValue.Value / 10) * 10;
                    c = Color.FromArgb(r, g, b);

                    // stash it for reference
                    if (colors.ContainsKey(c))
                    {
                        colors[c]++;
                    }
                    else
                    {
                        colors[c] = 1;
                    }

                    bitmap.SetPixel(x, y, c);
                }
            }

            return new RandomBitmapResult()
            {
                Bitmap = bitmap,
                Breakdown = colors
            };
        }
    }
}
