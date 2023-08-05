using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ques1
{
    public class Triangle
    {
        protected int edge1;
        protected int edge2;
        protected int edge3;

        public Triangle(int edge1, int edge2, int edge3)
        {
            this.edge1 = edge1;
            this.edge2 = edge2;
            this.edge3 = edge3;
        }

        public virtual int Perimeter()
        {
            return edge1 + edge2 + edge3;
        }

        public virtual double Area()
        {
            double s = (edge1 + edge2 + edge3) / 2;
            return Math.Sqrt(s * (s - edge1) * (s - edge2) * (s - edge3));
        }
    }
}
