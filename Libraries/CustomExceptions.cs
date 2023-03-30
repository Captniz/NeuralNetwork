using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuralNetwork.Libraries.CustomExceptions
{
    public class LayerLengthMismatch : Exception
    {
        /// <summary>
        /// Exception thrown when the length of two arrays regarding the layers do not match.
        /// </summary>
        public LayerLengthMismatch(string message)
        {
        }
    }
}