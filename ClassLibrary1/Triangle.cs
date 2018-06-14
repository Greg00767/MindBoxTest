using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindBoxFigures
{
    public class Triangle : Figure
    {
        public Dot DotA { get; set; }
        public Dot DotB { get; set; }
        public Dot DotC { get; set; }

        public Line EdgeAB { get; set; }
        public Line EdgeBC { get; set; }
        public Line EdgeCA { get; set; }

        public double CornerA { get; }
        public double CornerB { get; }
        public double CornerC { get; }

        public double CosA { get; }
        public double CosB { get; }
        public double CosC { get; }

        public Triangle(Dot _dotA, Dot _dotB, Dot _dotC)
        {
            DotA = _dotA;
            DotB = _dotB;
            DotC = _dotC;

            EdgeAB = new Line(DotA, DotB);
            EdgeBC = new Line(DotB, DotC);
            EdgeCA = new Line(DotC, DotA);

            CosA = (Math.Pow(EdgeCA.Length(), 2.0) + Math.Pow(EdgeAB.Length(), 2.0) - Math.Pow(EdgeBC.Length(), 2.0)) / (2 * EdgeCA.Length() * EdgeAB.Length());
            CornerA = Math.Acos(CosA);

            CosB = (Math.Pow(EdgeAB.Length(), 2.0) + Math.Pow(EdgeBC.Length(), 2.0) - Math.Pow(EdgeCA.Length(), 2.0)) / (2 * EdgeBC.Length() * EdgeAB.Length());
            CornerB = Math.Acos(CosB);

            CosC = (Math.Pow(EdgeCA.Length(), 2.0) + Math.Pow(EdgeBC.Length(), 2.0) - Math.Pow(EdgeAB.Length(), 2.0)) / (2 * EdgeCA.Length() * EdgeBC.Length());
            CornerC = Math.Acos(CosC);
        }

        //Площадь треугольника по трем сторонам
        public override double Area()
        {
            double semiPerimeter = (EdgeAB.Length() + EdgeBC.Length() + EdgeCA.Length()) / 2.0;
            return Math.Sqrt(semiPerimeter * (semiPerimeter - EdgeAB.Length()) * (semiPerimeter - EdgeBC.Length()) * (semiPerimeter - EdgeCA.Length()));
        }

        public bool IsRightTriangle()
        {
            bool result = true;

            if (Math.Pow(EdgeAB.Length(), 2.0) + Math.Pow(EdgeBC.Length(), 2.0) != Math.Pow(EdgeCA.Length(), 2.0))
                if (Math.Pow(EdgeBC.Length(), 2.0) + Math.Pow(EdgeCA.Length(), 2.0) != Math.Pow(EdgeAB.Length(), 2.0))
                    if (Math.Pow(EdgeCA.Length(), 2.0) + Math.Pow(EdgeAB.Length(), 2.0) != Math.Pow(EdgeBC.Length(), 2.0))
                        result = false;

            return result;
        }
    }
}
