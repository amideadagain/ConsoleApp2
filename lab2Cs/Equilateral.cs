using System;

namespace Lab2_CS
{
    public class Equilateral
    {
        public double Area { get; set; }
        public double Perimeter { get; set; }
        public double Line { get; set; }

        public void CalculatePerimeter()
        {
            Perimeter = Line * 3;
        }
        public void CalculateArea()
        {
            Area = Math.Pow(Line,3) ;
        }
        
        public override string ToString()
        {
            return "WARNING!! ALL VALUES ARE ROUNDED!!" + "\nLength of lines = " + Line +
                "\nPerimeter of triangle = " + Math.Round(Perimeter,2) +
                "\nArea of triangle = " + Math.Round(Area,3);
        }
    }
}
