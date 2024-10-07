using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle
{

    public class Circle : IShape
    {
        private double Radius { get; set; }
        //constructor
        public Circle(double radius)
        {
            Radius = radius;
        }
        //empty constructor
        public Circle()
        {
        }
        //Calculating the area
        public double GetArea()
        {
            return Math.Round(Math.PI * Math.Pow(Radius, 2));
        }
        //Calculating the volume
        public double GetVolume()
        {
            return Math.Round(Math.Pow(Radius, 3) * Math.PI * 4) / 3;
        }
        //Calcuating the perimeter
        public double GetPerimeter()
        {
            return Math.Round(Math.PI * 2 * Radius);
        }
    }

}
