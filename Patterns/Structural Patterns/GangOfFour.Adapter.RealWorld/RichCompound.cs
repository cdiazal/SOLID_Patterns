using System;

namespace GangOfFour.Adapter.RealWorld
{
    /// <summary>
    /// The 'Adapter' class
    /// </summary>
    class RichCompound : Compound
    {
        private string _chemical;
        private ChemicalDatabank _bank;

        // Constructor
        public RichCompound(string chemical)
        {
            _chemical = chemical;
        }

        public override void Display()
        {
            // The Adaptee
            _bank = new ChemicalDatabank();

            _boilingPoint = _bank.GetCriticalPoint(_chemical, "B");
            _meltingPoint = _bank.GetCriticalPoint(_chemical, "M");
            _molecularWeight = _bank.GetMolecularWeight(_chemical);
            _molecularFormula = _bank.GetMolecularStructure(_chemical);

            Console.WriteLine("\nCompound: {0} ------ ", _chemical);
            Console.WriteLine(" Formula: {0}", _molecularFormula);
            Console.WriteLine(" Weight : {0}", _molecularWeight);
            Console.WriteLine(" Melting Pt: {0}", _meltingPoint);
            Console.WriteLine(" Boiling Pt: {0}", _boilingPoint);
        }
    }
}