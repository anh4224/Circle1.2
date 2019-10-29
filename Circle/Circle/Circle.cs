using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle
{
    public class Circle
    {
        private double Radius = 1.0;

        public Circle()
        {

        }
        public Circle(double Radius)
        {
            this.Radius = Radius;
        }
        public void setRadius(double Radius)
        {
            this.Radius = Radius;

        }
        public double getArea()
        {
            return Radius * Radius * Math.PI;
        }
        public double getCircumference()
        {
            return Radius;
        }
        public double getRadius()
        {
            return this.Radius;
        }
        public override string ToString()
        {
            return String.Format("Circle [ Radius = {0}}", Radius);
        }
    }
}