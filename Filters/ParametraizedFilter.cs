﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyPhotoshop
{
    public abstract class ParametraizedFilter : IFilter
    {
        IParameters parameters;

        public ParametraizedFilter(IParameters parameters) {
            this.parameters = parameters;
        }

        public ParameterInfo[] GetParameters()
        {
            return parameters.GetDescription();
        }

        public Photo Process(Photo original, double[] values)
        {
            this.parameters.SetValues(values);
            return Process(original, this.parameters);
        }
        public abstract Photo Process(Photo original, IParameters parameters);
    }
}
