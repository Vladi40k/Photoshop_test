using System;

namespace MyPhotoshop
{
    public class LighteningFilter : PixelFiter<LighteningParameters>
    {
        public override string ToString()
        {
            return "Осветление/затемнение";
        }

        override protected Pixel PixelCalc(Pixel original, LighteningParameters parameters)
        {
            return original * parameters.Coef;
        }
    }
}

