using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Most
{
    internal class Rectangle : Figure
    {
        public Rectangle(IColor color, ISize size) : base(color, size)
        {
        }

        public override void GetFigure()
        {
            Console.WriteLine("Прямоугольник");
        }
    }
}
