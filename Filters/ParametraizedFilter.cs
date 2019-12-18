using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyPhotoshop.Filters
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

        public Photo Process(Photo original, double[] parameters)
        {
            throw new NotImplementedException();
        }
        public Photo Process(Photo original, double[] parameters) {
            
        }
    }
}
