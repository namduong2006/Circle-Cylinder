using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle_Cylinder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle("black",5.7);           
            Console.WriteLine(circle.GetArea());            
            Cylinder cylinder = new Cylinder(6.9, "black", 8.9);
            Console.WriteLine(cylinder.CylindricalVolume());
            Console.ReadLine();
        }
    }
}
