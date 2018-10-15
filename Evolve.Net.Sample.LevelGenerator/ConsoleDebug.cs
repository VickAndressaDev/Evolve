using Evolve.NET.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evolve.Net.Sample.LevelGenerator
{
    class ConsoleDebug<T> : IDebug<T>
    {

        private readonly char EMPTY = '.';
        private readonly char GROUND = '#';
        private readonly char BLOCK_ITEM = '?'; 
        private readonly char BLOCK_COIN = '!';
        private readonly char BLOCK = '@';

        private IDictionary<char, ConsoleColor> m_Colors;

        public ConsoleDebug() {

            m_Colors = new Dictionary<char, ConsoleColor>();
            m_Colors.Add(EMPTY, System.ConsoleColor.Blue);
            m_Colors.Add(GROUND, System.ConsoleColor.Green);
            m_Colors.Add(BLOCK_ITEM, System.ConsoleColor.DarkYellow);
            m_Colors.Add(BLOCK_COIN, System.ConsoleColor.Yellow);
            m_Colors.Add(BLOCK, System.ConsoleColor.DarkRed);
        }

        public void Log(IChromosome<T> chromosome) 
        {
            for (int i = 0; i < PatternFactory.PATTER_SIZE; i++)
            {
                for (int j = 0; j < chromosome.Length; j++)
                {
                    int pattern = (int)(object)chromosome[j];
                    char tile = PatternFactory.GetPattern(pattern, i);
                    // Console.Write(tile);
                    Console.BackgroundColor = m_Colors[tile];
                    Console.Write(" ");

                }
                Console.BackgroundColor = ConsoleColor.Black;
                Console.WriteLine();
            }
            Console.WriteLine(); 
        }

        public void Log(IPopulation<T> population)
        {
            int generation = population.Generation;
            for (int i = 0; i < population.Count; i++)
            {
                IChromosome<T> chromosome = population[i];
                Console.WriteLine("Generation {0} - Fitness {1}", generation, chromosome.Fitness);
                Log(chromosome);
            }
           
        }
    }
}
