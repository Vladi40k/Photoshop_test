using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyPhotoshop
{
    abstract public class PixelFiter : IFilter
    {
        virtual public ParameterInfo[] GetParameters()
        {
            return new ParameterInfo[0];
        }
        virtual public Photo Process(Photo original, double[] parameters)
        {
            var result = new Photo(original.width, original.height);
            for (int x = 0; x < result.width; x++)
                for (int y = 0; y < result.height; y++)
                {
                    result[x, y] = PixelCalc(original[x, y], parameters);
                }
            return result;
        }
        abstract protected Pixel PixelCalc(Pixel original, double[] parameters);
    }
}
