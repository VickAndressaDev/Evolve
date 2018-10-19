using Evolve.NET.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evolve.NET.Sample.MusicGenerator
{
    class ConsoleDebug<T> : IDebug<T>
    {
        public void Log(IPopulation<T> population)
        {
            for (int i = 0; i < population.Count; i++)
            {
                Console.Write("Generation {0}\t", population.Generation);
                Log(population[i]);
                Console.WriteLine("\tFitness {0}", population[i].Fitness);
            }

            Console.WriteLine();
        }

        public void Log(IChromosome<T> chromosome)
        {
            Console.Write("{0}", chromosome.ToString());
        }
    }
}
