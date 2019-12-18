using System;

namespace MyPhotoshop
{
    public class LighteningFilter : PixelFiter
    {
        public LighteningFilter() : base(new LighteningParameters()) { }
        public override string ToString()
        {
            return "Осветление/затемнение";
        }

        override protected Pixel PixelCalc(Pixel original, IParameters parameters)
        {
            return original * (parameters as LighteningParameters).Coef;
        }
    }
}

