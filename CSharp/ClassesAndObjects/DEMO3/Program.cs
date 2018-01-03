using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO3
{
    class Rectangle
    {
        public int Top { get; set; }
        public int Left { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        public int Area
        {
        get { return Width * Height; }                    //пропърти
        }


      //public int CalcArea()                             //метод
      //{
      //    return Width * Height;
      //}
    }

    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle { Top = 10, Left = 7, Width = 42, Height = 11 };

            //int area = r.CalcArea();
            //Console.WriteLine(area);

            Console.WriteLine(r.Area);
        }
    }
}

