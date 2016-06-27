using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C4
{
    class Treugоl
    {
        private double a, b, c, d, e, f;
        public Treugоl()
        { 
            a = 3;b = 4;c = 5;
        }
         
        public double rez_a()
        {
            return a;
        }
        public double rez_b()
        {
            return b;
        }
        public double rez_c()
        {
            return c;
        }
        public double rez_d(int x1,int y1,int x2,int y2,int x3,int y3)
        {
            d = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            return d;
        }
        public double rez_e(int x1, int y1, int x2, int y2, int x3, int y3)
        {
            e = Math.Sqrt((x2 - x3) * (x2 - x3) + (y2 - y3) * (y2 - y3));
            return e;
        }
        public double rez_f(int x1, int y1, int x2, int y2, int x3, int y3)
        {
            f = Math.Sqrt((x1 - x3) * (x1 - x3) + (y1 - y3) * (y1 - y3));
            return f;
        }
        public double ger(double a_g,double b_g,double c_g)
        {
            double S, p;
            p = (a_g + b_g + c_g) / 2;
            S = Math.Sqrt(p * (p - a_g) * (p - b_g) * (p - c_g));
            return S;
        }
        public double perim(double a_p,double b_p,double c_p)
        {
            double P;
            P = a_p + b_p + c_p;
            return P;
        }

    }
    }

       


