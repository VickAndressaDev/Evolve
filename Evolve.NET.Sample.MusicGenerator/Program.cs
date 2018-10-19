using Evolve.NET.Core;
using Evolve.NET.Core.CrossoverMethods;
using Evolve.NET.Core.MutationMethods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evolve.NET.Sample.MusicGenerator
{
    class Program
    {
        static void Main(string[] args)
        {

            const int POPULATION_SIZE = 200;
            const int CHROMOSOME_SIZE = 16;
            const int GENE_MIN = 0;
            const int GENE_MAX = 1;
            const int MAX_GENERATIONS = 200;
            const int ELITIMS_NUMBER = 3;
            const int TOURNAMENT_NUMBER = 3;
            const double CROSSOVER_RATE = 0.8;
            const double MUTATION_RATE = 0.02;
            const string FILENAME = "sample_result.xls";

            GeneticAlgorithm<int> simulator = new GeneticAlgorithm<int>
            {
                Selection = new TournamentSelection<int>(TOURNAMENT_NUMBER),
                Crossover = new OnePointCrossoverOperator<int>(CROSSOVER_RATE),
                Mutation = new ResetingRandomMutationOperator<int>(MUTATION_RATE),
                Fitness = new FitnessFunction<int>(),
                Elitism = ELITIMS_NUMBER,
                Filename = FILENAME,
                Debug = new ConsoleDebug<int>(),
            };

            simulator.Simulate(POPULATION_SIZE, CHROMOSOME_SIZE, GENE_MIN, GENE_MAX, MAX_GENERATIONS);

            Console.ReadKey();
        }

    }
    }
}
