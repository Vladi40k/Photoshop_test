using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyPhotoshop
{
    public abstract class PixelFiter<TParameters> : ParametraizedFilter<TParameters>
        where TParameters : IParameters, new()
    {
        public override Photo Process(Photo original, TParameters parameters)
        {
            var result = new Photo(original.width, original.height);
            for (int x = 0; x < result.width; x++)
                for (int y = 0; y < result.height; y++)
                {
                    result[x, y] = PixelCalc(original[x, y], parameters);
                }
            return result;
        }
        abstract protected Pixel PixelCalc(Pixel original, TParameters parameters);
    }
}
