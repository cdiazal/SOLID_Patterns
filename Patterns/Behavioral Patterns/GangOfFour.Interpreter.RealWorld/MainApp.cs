using System;
using System.Collections.Generic;

namespace GangOfFour.Interpreter.RealWorld
{
    /// <summary>
    /// MainApp startup class for Real-World 
    /// Interpreter Design Pattern.
    /// </summary>
    class MainApp
    {
        /// <summary>
        /// Entry point into console application.
        /// </summary>
        static void Main()
        {
            string roman = "MCMXXVIII";
            Context context = new Context(roman);

            // Build the 'parse tree'
            List<Expression> tree = new List<Expression>();
            tree.Add(new ThousandExpression());
            tree.Add(new HundredExpression());
            tree.Add(new TenExpression());
            tree.Add(new OneExpression());

            // Interpret
            foreach (Expression exp in tree)
            {
                exp.Interpret(context);
            }

            Console.WriteLine("{0} = {1}",
                roman, context.Output);

            // Wait for user
            Console.ReadKey();
        }
    }
}
