namespace Algorithms
{
    public class Cylinder
    {
        public double Radius { get; }
        public double Height { get; }

        public Cylinder(double radius, double height)
        {
            Radius = radius;
            Height = height;
        }

        public double GetVolume()
        {
            /*
             * SET volume = pie * r^2 * h
             */
            return System.Math.PI * System.Math.Pow(Radius, 2D) * Height;
        }
    }
}