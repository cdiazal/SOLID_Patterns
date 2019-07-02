using System;

namespace GangOfFour.Bridge.RealWorld
{
    /// <summary>
    /// MainApp startup class for Real-World 
    /// Bridge Design Pattern.
    /// </summary>
    class MainApp
    {
        /// <summary>
        /// Entry point into console application.
        /// </summary>
        static void Main()
        {
            // Create RefinedAbstraction
            var customers = new Customers();

            // Set ConcreteImplementor
            customers.Data = new CustomersData("Chicago");

            // Exercise the bridge
            customers.Show();
            customers.Next();
            customers.Show();
            customers.Next();
            customers.Show();
            customers.Add("Henry Velasquez");

            customers.ShowAll();

            // Wait for user
            Console.ReadKey();
        }
    }
}
