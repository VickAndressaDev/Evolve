using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evolve.NET.Core
{
    public class BlendCrossoverOperator<T> : ICrossover<T>
    {

        private double m_Alpha;

        public ArithmeticCrossoverOperator(double alpha)
        {

            m_Alpha = alpha;

        }

        public void Crossover(IChromosome<T> parent1, IChromosome<T> parent2, out IChromosome<T> offspring1, out IChromosome<T> offspring2)
        {

            offspring1 = new Chromosome<T>(parent1.Genes);
            offspring2 = new Chromosome<T>(parent2.Genes);

            int length = parent1.Length;
            for (int i = 0; i < length; i++)
            {
                double p1 = (double)(object)parent1[i];
                double p2 = (double)(object)parent2[i];
                double p2lessp1 = (p2 - p1);
                double p1lessp2 = (p1 - p2);
                double blend1 = p1 + m_Alpha * p2lessp1;
                double blend2 = p2 + m_Alpha * p1lessp2;
                offspring1[i] = (T)(object)blend1;
                offspring2[i] = (T)(object)blend2;


            }
        }
    }

}
