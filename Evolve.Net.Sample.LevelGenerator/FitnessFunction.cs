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

        private List<int[]> m_DesiredLevelPatterns = new List<int[]>();
        private List<double> m_DesiredLevelPatternsValues = new List<double>();

        public FitnessFunction() {

            m_DesiredLevelPatterns.Add(new int[] { 2, 3, 4, 5 });
            m_DesiredLevelPatterns.Add(new int[] { 5, 4, 3, 2 });
            m_DesiredLevelPatterns.Add(new int[] { 1, 0, 0, 1 });
            m_DesiredLevelPatterns.Add(new int[] { 13, 9, 14, 9, 13 });
            m_DesiredLevelPatterns.Add(new int[] { 1, 1, 1, 0 });
            m_DesiredLevelPatterns.Add(new int[] { 2, 2, 3 });
            m_DesiredLevelPatterns.Add(new int[] { 3, 0, 3, 0 });
            m_DesiredLevelPatterns.Add(new int[] { 3, 0, 1, 0, 3 });

            m_DesiredLevelPatternsValues.Add(3);
            m_DesiredLevelPatternsValues.Add(3);
            m_DesiredLevelPatternsValues.Add(2);
            m_DesiredLevelPatternsValues.Add(5);
            m_DesiredLevelPatternsValues.Add(1);
            m_DesiredLevelPatternsValues.Add(1);
            m_DesiredLevelPatternsValues.Add(2);
            m_DesiredLevelPatternsValues.Add(2);
        }



        private int FindSequenceCount (IChromosome<T> chromosome, int[] sequence) {

            int count = 0;
            for (int i = 0, j = 0; i < chromosome.Length; i++)
            {
                int gene = (int)(object)chromosome[i];
                if (sequence[j] == gene) {

                    j++;
                    if (sequence.Length == j) {
                        j = 0;
                        count++;

                    }

                }
            }

            return count;
        }

        public double Evaluate(IChromosome<T> chromosome)
        {
            double fitness = 0.0;

            for (int i = 0; i < m_DesiredLevelPatterns.Count; i++)
            {
                int[] sequence = m_DesiredLevelPatterns[i];
                int count = FindSequenceCount(chromosome, sequence);
                fitness += count * m_DesiredLevelPatternsValues[i];
                
            }


            return fitness;
            
            }
        }
    }
}
