using System;

namespace RecordsGenerator.Parameters_of_Generator
{
    public abstract class Rng
    {
        public readonly Random Rand = new Random(DateTime.Now.Millisecond);
    }
}
