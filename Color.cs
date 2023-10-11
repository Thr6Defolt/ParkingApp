using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingApp
{
    /// Color of car in RGB format with opacity.
    public struct Color
    {
        /// Red color.(0-255)
        public int Red { get; }
        /// Green color.(0-255)
        public int Green { get; }
        /// Blue color.(0-255)
        public int Blue { get; }
        /// Opacity.(0-100)
        public int Opacity { get; }

        /// Initializes new instance of the Color struct.
        public Color(int red, int green, int blue, int opacity)
        {
            /// Check valud 0-255 if less the 0 or more the 255 give eror.
            if (red < 0 || red > 255 || green < 0 || green > 255 || blue < 0 || blue > 255 || opacity < 0 || opacity > 100)
            {
                throw new ArgumentOutOfRangeException("Invalid color or opacity values.");
            }

            Red = red;
            Green = green;
            Blue = blue;
            Opacity = opacity;
        }

        /// Initializes new instance of the Color struct with full opacity.
        public Color(int red, int green, int blue) : this(red, green, blue, 100)
        {
        }

        /// Gets a string representation of the color in the format "RGB(Red, Green, Blue), Opacity: Opacity%".
        public override string ToString()
        {
            return $"RGB({Red}, {Green}, {Blue}), Opacity: {Opacity}%";
        }
    }
}
