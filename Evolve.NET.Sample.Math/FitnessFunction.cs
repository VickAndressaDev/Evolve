using Evolve.NET.Core;
using System;

namespace Evolve.NET.Sample
{
    public class FitnessFunction<T> : IFitness<T>
    {
        public double Evaluate(IChromosome<T> chromosome)
        {
            return Math.Pow(ConvertArrayToDecimal(chromosome.Genes), 2);
        }

        private long ConvertArrayToDecimal(T[] genes)
        {
            long value = 0;

            for (int i = 0; i < genes.Length; i++)
            {
                long exp = genes.Length - i - 1;
                value += (long)Math.Pow(2, exp) * (int)(object)genes[i];
            }

            return value;
        }
    }
}
