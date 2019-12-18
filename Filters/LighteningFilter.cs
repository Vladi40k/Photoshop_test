using System;

namespace MyPhotoshop
{
    public class LighteningFilter : PixelFiter
    {
        override public ParameterInfo[] GetParameters()
        {
            return new[]
            {
                new ParameterInfo { Name="Коэффициент", MaxValue=10, MinValue=0, Increment=0.1, DefaultValue=1 }
            };
        }

        public override string ToString()
        {
            return "Осветление/затемнение";
        }

        override protected Pixel PixelCalc(Pixel original, double[] parameters)
        {
            return original * Pixel.Trim(parameters[0]);
        }
    }
}

