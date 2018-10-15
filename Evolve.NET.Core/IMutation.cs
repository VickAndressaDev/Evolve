namespace Evolve.NET.Core
{
    public interface IMutation<T>
    {
        void Mutate(ref IChromosome<T> chromosome, int min, int max);
    }
}
