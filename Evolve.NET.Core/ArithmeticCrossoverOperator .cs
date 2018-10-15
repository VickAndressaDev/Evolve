using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evolve.NET.Core
{
  public class ArithmeticCrossoverOperator<T> : ICrossover<T>
    {

        private double m_Alpha;

        public ArithmeticCrossoverOperator(double alpha) {

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
                    double average1 = m_Alpha * p1 + (1 - m_Alpha) * p2;
                    double average2 = m_Alpha * p2 + (1 - m_Alpha) * p1;
                    
                    offspring1[i] = (T)(object)average1;
                }

                offspring2 = null;
            }
        

        }
    }
}
