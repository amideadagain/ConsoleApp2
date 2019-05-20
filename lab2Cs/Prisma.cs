using System;

namespace Lab2_CS
{
    public class Prisma : Equilateral
    {
        public double Volume { get; set; }
        public double Area1 { get; set; }
        public double Height { get; set; }

        public void CalculateArea(double Line, double Area, double Height)
        {
            CalculateArea();
            this.Area1 = 2 * (Area) + 3*Line* Height;
        }

        public void CalcVolume()
        {
            this.Volume = Area1 + Height;
        }
        public string ToString(double Line, double Height, double Perimeter, double Area, double Area1, double Volume)
        {
            return ("All values are rounded" + "\nLength of lines = " + (Line) +
                "\nLength of height = " + (Height) +
                "\nPerimeter of base triangle = " + Math.Round(Perimeter,2) +
                "\nArea of base triangle = " + Math.Round(Area,3) +
                "\nArea of prisma = " + Math.Round(Area1,3) +
                "\nVolume of prisma = " + Math.Round(Volume,3));
        }

    }
}
