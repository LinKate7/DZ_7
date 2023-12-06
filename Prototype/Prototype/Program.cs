using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{

    interface IFigure
    {
        IFigure Clone();
        void GetInfo();
    }
    class Rectangle : IFigure
    {
        int width;
        int height;
        public Rectangle(int w, int h)
        {
            width = w;
            height = h;
        }
        public IFigure Clone()
        {
            return new Rectangle(this.width, this.height);
        }
        public void GetInfo()
        {
            Console.WriteLine("Прямокутник довжиною {0} и шириною {1}", height, width);
        }
    }
    class Circle : IFigure
    {
        int radius;
        public Circle(int r)
        {
            radius = r;
        }
        public IFigure Clone()
        {
            return new Circle(this.radius);
        }
        public void GetInfo()
        {
            Console.WriteLine("Круг радіусом {0}", radius);
        }
    }
    class Triangle : IFigure
    {
        int side_1, side_2, side_3;
        public Triangle(int side_1, int side_2, int side_3)
        {
            this.side_1 = side_1;
            this.side_2 = side_2;
            this.side_3 = side_3;
        }
        public IFigure Clone()
        {
            return new Triangle(side_1, side_2, side_3);
        }
        public void GetInfo()
        {
            Console.WriteLine("Трикутник зі сторонами {0}, {1}, {2}", side_1, side_2, side_3);
        }
    }
}