using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Most
{
    abstract class Figure
    {
        protected IColor color;
        public IColor Color
        {
            set { color = value; }
        }

        protected ISize size;
        public ISize Size
        {
            set { size = value; }
        }

        public Figure(IColor color, ISize size)
        {
            this.color = color;
            this.size = size;
        }

        public virtual void GetColor()
        {
            color.GetColor();
        }
        public virtual void GetSize()
        {
            size.GetSize();
        }
        public abstract void GetFigure();

        
    }
}
