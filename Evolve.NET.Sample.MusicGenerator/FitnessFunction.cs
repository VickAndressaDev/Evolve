using Evolve.NET.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evolve.NET.Sample.MusicGenerator
{
    public class FitnessFunction<T> : IFitness<T>
    {
        public double Evaluate(IChromosome<T> chromosome)
        {
            return 1;
        }
    }
}
