using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace encaps
{
    internal class Program
    {
        class Reactangle
        {
            public double length=8;
            public double width=5;
            public double getArea()
            {
                return length * width;
            }

        public void Display()
            {
                Console.WriteLine("length: {0}", length);
                Console.WriteLine("width: {0}", width);
                Console.WriteLine("Area of rectangle : {0}", getArea());
            }
            static void Main(string[] args)
            {
                Reactangle r = new Reactangle();
                r.Display();
                Console.ReadLine();
            }
        }
    }
}
