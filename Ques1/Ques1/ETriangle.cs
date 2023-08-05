using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ques1
{
    public class ETriangle : Triangle
    {
        public ETriangle(int edge) : base(edge, edge, edge)
        {
        }

        public override int Perimeter()
        {
            return 3 * edge1;
        }

        public override double Area()
        {
            return edge1 * edge1 * Math.Sqrt(3) / 4;
        }
    }
}
