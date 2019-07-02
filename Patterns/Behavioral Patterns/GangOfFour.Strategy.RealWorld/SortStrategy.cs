using System.Collections.Generic;

namespace GangOfFour.Strategy.RealWorld
{
    /// <summary>
    /// The 'Strategy' abstract class
    /// </summary>
    abstract class SortStrategy
    {
        public abstract void Sort(List<string> list);
    }
}