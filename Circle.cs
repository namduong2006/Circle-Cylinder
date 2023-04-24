using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Circle_Cylinder
{
    internal class Circle
    {
        string color="black";
        double radius=1.0;
        public string Color
        {
            get { return color; }
            set { color = value; }
        }
        public double Radius
        {
            get { return radius; }
            set { radius = value; }
        }
        public Circle()
        {           
        }
        public Circle(string color,double radius)
        {
            this.color = color;
            this.radius = radius;
        }

        public double GetArea()
        {
            return radius * radius * Math.PI;
        }
        public double GetPerimeter()
        {
            return 2 * radius * Math.PI;
        }
        public override string ToString()
        {
            return $"A Shape with color of {color}, radius = {radius}";
        }
    }
    class Cylinder : Circle
    {
        double height;
        public double Height { get { return height; } set { height = value; } }
        public Cylinder() 
        {
            height = 1.0;
        }
        public Cylinder(double height,string color,double radius):base(color,radius)
        {
            this.height = height;
        }
        public double CylindricalVolume()
        {
            return height*Radius*Radius*Math.PI;
        }
        public override string ToString()
        {
            return $"A Shape with color of {Color}, radius= {Radius},height= {height} ";
        }
    }    
}
