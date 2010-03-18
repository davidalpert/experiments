using System;
using System.Drawing;

namespace Blather.Core
{
    public class Pixel
    {
        /// <summary>
        /// Initializes a new instance of the Pixel class.
        /// </summary>
        public Pixel(int x, int y, Color color)
        {
            X = x;
            Y = y;
            Color = color;
        }

        public int X { get; private set; }

        public int Y { get; private set; }

        public Color Color { get; private set; }
    }
}
