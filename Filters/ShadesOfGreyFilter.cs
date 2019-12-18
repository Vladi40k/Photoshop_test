using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyPhotoshop
{
    class ShadesOfGreyFilter : PixelFiter
    {
        override public ParameterInfo[] GetParameters()
        {
            return new ParameterInfo[0];
        }
        override public string ToString()
        {
            return "ShadesOfGreyFilter";
        }
        override protected Pixel PixelCalc(Pixel original, double[] parameters) {
            var light = original.R + original.G + original.B;
            light /= 3.0;
            return new Pixel(light, light, light);
        }

    }
}
