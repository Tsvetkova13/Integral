using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace integralTest
{
    interface Iintegral
    {
        void Rectangles(double a, double b, double h, double f);
        void Simpson(double a, double b, double h, double f);

    }
}
