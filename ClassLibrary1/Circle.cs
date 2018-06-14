using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindBoxFigures
{
    public class Circle : Figure
    {
        public Dot Center { get; set; }
        float radius;
        public float Radius
        {
            get
            {
                return radius;
            }

            set
            {
                if (value < 0.0f)
                    radius = 0.0f;
                else
                    radius = value;
            }
        }

        public Circle(float _radius)
        {
            Center = new Dot();
            Radius = _radius;
        }

        public Circle(Dot _center, float _radius)
        {
            Center = _center;
            Radius = _radius;
        }

        //Площадь круга по радиусу.
        public override double Area()
        {
            return Math.PI * Math.Pow(Radius, 2.0);
        }
    }
}
