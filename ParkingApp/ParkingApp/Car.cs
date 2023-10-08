using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

class Car
{
    public string Makr { get; private set; }
    public string Model { get; private set; }
    public Color CarColor { get; private set; }
    public string Number { get; private set; }
    public DateTime TimeArvid { get; private set; }
    public DateTime? TimeOut { get; set; }

    /// Color of car in RGB format with opacity.
    public struct Color
    {
        public int Red { get; }
        public int Green { get; }
        public int Blue { get; }
        public int Opacity { get; }

        public Color(int red, int green, int blue, int opacity)
        {
            if (red < 0 || red > 255 || green < 0 || green > 255 || blue < 0 || blue > 255 || opacity < 0 || opacity > 100)
            {
                throw new ArgumentOutOfRangeException("Invalid color or opacity values.");
            }

            Red = red;
            Green = green;
            Blue = blue;
            Opacity = opacity;
        }

        public override string ToString()
        {
            return $"RGB({Red}, {Green}, {Blue}), Opacity: {Opacity}%";
        }
    }
    /// Initializes new instance Car.
    public Car(string makr, string model, Color color, string number, DateTime timeArvid)
    {
        Makr = makr;
        Model = model;
        CarColor = color;
        Number = number;
        TimeArvid = timeArvid;
    }
}
