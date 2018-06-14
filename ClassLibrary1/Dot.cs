using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindBoxFigures
{
    public class Dot : Element
    {
        public string Name { get; }
        public float X { get; set; }
        public float Y { get; set; }

        public Dot()
        {
            Name = $"dot {this.GetHashCode()}";
            X = 0.0f;
            Y = 0.0f;
        }

        public Dot(float X, float Y)
        {
            Name = $"dot {this.GetHashCode()}";
            this.X = X;
            this.Y = Y;
        }
    }
}
