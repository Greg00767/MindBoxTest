namespace MindBoxFigures
{
    public abstract class Figure
    {
        public string Name { get; set; }

        public abstract double Area();

        public Figure()
        {
            Name = $"Figure {this.GetHashCode()}";
        }
    }
}
