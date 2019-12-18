using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyPhotoshop
{
    public struct Pixel
    {

        private double r, g, b;

        public Pixel(double r, double g, double b) {
            this.r = r;
            this.g = g;
            this.b = b;
        }

        public static Pixel Trim(Pixel p)
        {

            p.R = Trim(p.R);
            p.G = Trim(p.G);
            p.B = Trim(p.B);

            return p;
        }

        public static double Trim(double val) {
            if (val > 1) return 1;
            else if (val < 0) return 0;
            else return val;
        }
        public double Check(double val) {
            if (val > 1 || val < 0) throw new ArgumentException();
            else return val;
        }

        public double R { get { return r; } set { r = Check(value); } }
        public double G { get { return g; } set { g = Check(value); } }
        public double B { get { return b; } set { b = Check(value); } }

        public static Pixel operator *(Pixel p, double num) {
            Pixel newPixel = new Pixel();
            newPixel.R = p.R * num;
            newPixel.G = p.G * num;
            newPixel.B = p.B * num;
            return newPixel;
        }


    }
}
