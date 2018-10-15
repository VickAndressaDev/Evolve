using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evolve.NET.Core
{
    internal class HeuristicCrossoverOperator<T> : ICrossover<T>
    {
        public void Crossover(IChromosome<T> parent1, IChromosome<T> parent2, out IChromosome<T> offspring1, out IChromosome<T> offspring2)
        {
            offspring1 = new Chromosome<T>(parent1.Genes);
            offspring2 = null;

            int length = parent1.Length;
            for (int i = 0; i < length; i++)
            {
                double p1 = (double)(object)parent1[i];
                double p2 = (double)(object)parent2[i];
                double r = RandomHelper.RandomDouble();
                double result = 0.0;

                if (parent1.Fitness > parent2.Fitness)
                    result = p1 + r * (p1 - p2);

                else
                    result = p2 + r * (p2 - p1);

                offspring1[i] = (T)(object)result;
                             
            }
        }
    }
}
