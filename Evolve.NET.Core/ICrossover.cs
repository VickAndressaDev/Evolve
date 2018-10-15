namespace Evolve.NET.Core
{
    public interface ICrossover<T>
    {
        void Crossover(IChromosome<T> parent1, IChromosome<T> parent2, out IChromosome<T> offspring1, out IChromosome<T> offspring2);
    }
}
