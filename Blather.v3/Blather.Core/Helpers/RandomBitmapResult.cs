using System;
using System.Collections.Generic;
using System.Drawing;

namespace Blather.Core.Helpers
{
    public class RandomBitmapResult
    {
        public Bitmap Bitmap { get; set; }
        public Dictionary<Color, int> Breakdown { get; set; }
    }
}
