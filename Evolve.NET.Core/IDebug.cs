using System;

namespace Evolve.NET.Core
{
    public interface IDebug<T>
    {
        void Log(IPopulation<T> population);
<<<<<<< HEAD

        void Log(IChromosome<T> chromosome);
=======

        void Log(IChromosome<T> chromosome);
    }

    [Flags]
    public enum DebugMask
    {
        None = 0,
        First = 1 << 0,
        Step = 1 << 1,
        Last = 1 << 2
>>>>>>> bb8e96c35c74b53070ede886fbb96750b33dfd32
    }
}
