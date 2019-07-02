using System;

namespace GangOfFour.Adapter.RealWorld
{
    /// <summary>
    /// The 'Target' class
    /// </summary>
    class Compound
    {
        protected float _boilingPoint;
        protected float _meltingPoint;
        protected double _molecularWeight;
        protected string _molecularFormula;

        public virtual void Display()
        {
            Console.WriteLine("\nCompound: Unknown ------ ");
        }
    }
}