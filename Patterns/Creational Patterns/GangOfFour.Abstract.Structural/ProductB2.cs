using System;

namespace GangOfFour.Abstract.Structural
{
    /// <summary>
    /// The 'ProductB2' class
    /// </summary>
    class ProductB2 : AbstractProductB
    {
        public override void Interact(AbstractProductA a)
        {
            Console.WriteLine(this.GetType().Name +
                              " interacts with " + a.GetType().Name);
        }
    }
}