using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Circle
{

    public class Triangular : IShape
    {

        private double SideA { get; set; }
        private double SideB { get; set; }
        private double SideC { get; set; }
        private double Height { get; set; }
        //constructor for get set values
        public Triangular( double sideA, double sideB, double sideC)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
            Height = CalculateHeight();
        }
        //empty contructor
        public Triangular()
        {
        }
        // Calculates the area of the triangel using the Heron´s formula
        public double GetArea()
            {
            double s = (SideA + SideB + SideC) / 2;//first step calculating the semi-perimeter
            return Math.Sqrt(s * (s - SideA) * (s - SideB) * (s - SideC));//second step calculating the area
            }
        //Calcualtes the volume of three sided Prism, based om sideC as base.
        public double GetVolume()
        {
            double baseArea = GetArea();
            return Math.Round(baseArea * Height);
        }
        // calcualating the perimeter, the sum of all sides
        public double GetPerimeter()
        {
            return SideA + SideB + SideC;
        }
        //calculating the height based on sideC as the base side
        public double CalculateHeight()
        {
            double area = GetArea();//using the Heron´s fomula
            return (2 * area) / SideC;//height from the base
        }
    }
}
