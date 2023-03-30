using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuralNetwork.Libraries.GlobalMethods
{
    public static class MathMethods
    {
        public static double sigmoid(double value)
        {
            /// <summary>
            /// Sigmoid function
            /// </summary>
            /// <param name="double : value">Value to be processed</param>
            /// <returns>float : processed value</returns>

            value = Math.Exp(value);
            return value / (1.0f + value);
        }
    }
}
