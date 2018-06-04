using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaOfFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the figure:");
            var figure = Console.ReadLine();
            if (figure == "square")
            {
                Console.WriteLine("Enter 'a' of the square:");
                var a = double.Parse(Console.ReadLine());
                var area = Math.Round((a * a), 3);
                Console.WriteLine("Area of square = " + area);
            }
            if (figure == "rectangle")
            {
                Console.WriteLine("Enter 'a' of the rectangle: ");
                var a = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter 'b' of the rectangle");
                var b = double.Parse(Console.ReadLine());
                var area = Math.Round((a * b), 3);
                Console.WriteLine("Area of rectangle = " + area);
            }
            if (figure == "circle")
            {
                Console.WriteLine("Enter radius of the circle: ");
                var r = double.Parse(Console.ReadLine());
                var area = Math.Round((Math.PI * r * r), 3);
                Console.WriteLine("Area of circle = " + area);
            }
            if (figure == "triangle")
            {
                Console.WriteLine("Enter 'a' of triangle: ");
                var a = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter 'h' of triangle: ");
                var h = double.Parse(Console.ReadLine());
                var area = Math.Round((a * h / 2), 3);
                Console.WriteLine("Area of triangle = " + area);
            }
        }
    }
}
