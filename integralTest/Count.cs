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
            double F(double x)
             {
				return 31 * x - Math.Log(5 * x) + 5;
			}

            a= Convert.ToDouble(textBoxA.Text);
            b= Convert.ToDouble(textBoxB.Text);
            f = Convert.ToDouble(textFunc.Text); 
            h = Convert.ToDouble(textBoxH.Text);


            double s = 0;
            float k = 0.5f;
			
			double  N = (b - a) / h;
			a += h * k;
			for (int i = 0; i < N; i++)
			{
				double x = a + h * i;
				s += F(x);
			}

			textBoxRec.Text = s.ToString();

		}

        public void Simpson(double a, double b, double h, double f)
        {
			
			a = Convert.ToDouble(textBoxA.Text);
			b = Convert.ToDouble(textBoxB.Text);
			f = Convert.ToDouble(textFunc.Text);
			h = Convert.ToDouble(textBoxH.Text);

			double N = (b - a) / h;

				double F(double x)
				{
					return 31 * x - Math.Log(5 * x) + 5;
				}

				double k1 = 0, k2 = 0;
				for (int i = 1; i < N; i += 2)
				{
					k1 += F(a + i * h);
					k2 += F(a + (i + 1) * h);
				}
				double s1=h / 3 * (F(a) + 4 * k1 + 2 * k2);

			textBoxSim.Text = s1.ToString();

		}
    }
}
