using Evolve.NET.Core;
using Evolve.NET.Core.CrossoverMethods;
using Evolve.NET.Core.MutationMethods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evolve.Net.Sample.LevelGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            const int POPULATION_SIZE = 200;
            const int CHROMOSOME_SIZE = 50;
            const int GENE_MIN = 0;
            const int GENE_MAX = 9; //25
            const int MAX_GENERATIONS = 2000;
            const int ELITIMS_NUMBER = 20;
            const int TOURNAMENT_NUMBER = 10;
            const double CROSSOVER_RATE = 1.0;
            const double MUTATION_RATE = 0.02;
            const string FILENAME = "sample_result.xls";

            GeneticAlgorithm<int> simulator = new GeneticAlgorithm<int>();

            simulator.Selection = new TournamentSelection<int>(TOURNAMENT_NUMBER);
            simulator.Crossover = new OnePointCrossoverOperator<int>(CROSSOVER_RATE);
            simulator.Mutation = new ResetingRandomMutationOperator<int>(MUTATION_RATE);
            simulator.Fitness = new FitnessFunction<int>();

            simulator.Elitism = ELITIMS_NUMBER;
            simulator.Filename = FILENAME;

            simulator.Debug = new ConsoleDebug<int>();


            simulator.Simulate(POPULATION_SIZE, CHROMOSOME_SIZE, GENE_MIN, GENE_MAX, MAX_GENERATIONS);

            Console.ReadKey();
        }
    }
}
