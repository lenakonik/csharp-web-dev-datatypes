using System;
using System.Collections.Generic;
using System.Text;

namespace ModularWhileConditionals
{
    internal class Circle
    {
        double radius;  // field - private by default

        public Circle(double r) // constructor
        {
            radius = r; 
        }
        public double Circumference // property
        {
            get { return 2 * Math.PI * radius; }
        }

        public double fuel(double mpg)
        {
            //how many gallons of gas they will use to go around this circle
            double f = Circumference / mpg;
            return f;
        }





    }
}
