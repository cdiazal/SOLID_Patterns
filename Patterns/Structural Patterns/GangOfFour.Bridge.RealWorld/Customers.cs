using System;

namespace GangOfFour.Bridge.RealWorld
{
    /// <summary>
    /// The 'RefinedAbstraction' class
    /// </summary>
    class Customers : CustomersBase
    {
        public override void ShowAll()
        {
            // Add separator lines
            Console.WriteLine();
            Console.WriteLine("------------------------");
            base.ShowAll();
            Console.WriteLine("------------------------");
        }
    }
}