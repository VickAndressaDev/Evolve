using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evolve.Net.Sample.LevelGenerator
{
    class PatternFactory
    {
        public static readonly int PATTER_SIZE = 13;

        private static readonly string PATTERN_0 = ".............";
        private static readonly string PATTERN_1 = "............#";
        private static readonly string PATTERN_2 = "........?...#";
        private static readonly string PATTERN_3 = "........@...#";
        private static readonly string PATTERN_4 = "........!...#";
        private static readonly string PATTERN_5 = "....?...@...#";
        private static readonly string PATTERN_6 = "........?....";
        private static readonly string PATTERN_7 = "........@....";
        private static readonly string PATTERN_8 = "........!....";
        private static readonly string PATTERN_9 = "....?...@....";

        private static readonly string[] m_Patterns = {PATTERN_0, PATTERN_1, PATTERN_2, PATTERN_3,
        PATTERN_4, PATTERN_5,PATTERN_6, PATTERN_7, PATTERN_8, PATTERN_9};

        public static char GetPattern(int index, int column) {

            return m_Patterns[index][column];
        }

    }
}
