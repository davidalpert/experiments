using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace Blather.Core
{
    public static class BitmapExtensions
    {
        public static IEnumerable<Pixel> GetPixels(this Bitmap source)
        { 
            for(var x = 0; x < source.Width; x++) 
            {
                for (var y = 0; y < source.Height; y++) 
                {
                    yield return new Pixel(x, y, source.GetPixel(x, y));
                }
            }
        }

        public static ColorMap BuildColorMap(this Bitmap source)
        {
            var map = new ColorMap();

            source.GetPixels().Select(p => 
            { 
                if (map.ContainsKey(p.Color)) {
                    map[p.Color]++;
                } else {
                    map.Add(p.Color, 1);
                }

                return p;
            }).ToList();

            return map;
        }
    }
}
