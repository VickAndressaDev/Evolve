using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evolve.NET.Core
{
    public class AvaregeCrossoverOperator<T> : ICrossover<T> {


        public void Crossover(IChromosome<T> parent1, IChromosome<T> parent2, out IChromosome<T> offspring1) {

            Crossover(parent1, parent2, out offspring1, out IChromosome<T> offspring2);

        }

        public void Crossover(IChromosome<T> parent1, IChromosome<T> parent2, out IChromosome<T> offspring1, out IChromosome<T> offspring2) {

            offspring1 = new Chromosome<T>(parent1.Genes);

            int length = parent1.Length;
            for (int i = 0; i < length; i++)
            {
                double data1 = (double)(object)parent1[i];
                double data2 = (double)(object)parent2[i];
                double average = ((data1 + data2) * 0.5);
                offspring1[i] = (T)(object)average;
            }

            offspring2 = null; 
        }




    }


}

