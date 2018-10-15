namespace Evolve.NET.Core
{
    public interface IPopulation<T>
<<<<<<< HEAD

=======
>>>>>>> bb8e96c35c74b53070ede886fbb96750b33dfd32
    {
        IChromosome<T> this[int index] { get; set; }

        int Generation { get; }

        int Count { get; }

        void AddChromosomeInNewPopulation(IChromosome<T> chromosome);

        bool IsFullNewGeneration { get; }

        void SwapGeneration();

        void Evaluate(IFitness<T> fitnessFunction);

        void Elite(int elitismNumber);

        void Save(string filename, bool append);
    }
}
