using Evolve.NET.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evolve.Net.Sample.LevelGenerator
{
    class FitnessFunction<T> : IFitness<T>
    {
        public double Evaluate(IChromosome<T> chromosome)
        {
            double fitness = 0.0;
            for (int i = 0; i < chromosome.Length; i++) { 

                int pattern = (int)(object)chromosome[i];
                if (pattern >= 6) 
                        fitness += 1;
                    else if (pattern >= 2)
                        fitness += 2;
                    else
                        fitness += 3;
                
            }


            return 0;
        }
    }
}
