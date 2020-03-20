using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace integralTest
{
    class Count:Iintegral
    {
        public void Rectangles(double a, double b, double h, double f)
        {
            /* double F(double x)
             {
                 return 31 * x - log(5 * x) + 5;
             }*/


            //double a, b, h;
            a= Convert.ToDouble(textBoxA.Text);
            b= Convert.ToDouble(textBoxB.Text);
            f = Convert.ToDouble(textFunc.Text); 
            h = Convert.ToDouble(textBoxH.Text);


            double s = 0;
            float k = 0.5f;

            int N = (b - a) / h;
            a += h * k;
            for (int i = 0; i < N; i++)
                s += f(a + h * i);

        }

        public void Simpson(double a, double b, double h, double f)
        {
            a = Convert.ToDouble(textBoxA.Text);
            b = Convert.ToDouble(textBoxB.Text);
            f = Convert.ToDouble(textFunc.Text); 
            h = Convert.ToDouble(textBoxH.Text);
        }
    }
}
