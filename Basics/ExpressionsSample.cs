using System;
using System.Linq.Expressions;

namespace Basics
{
    public class ExpressionsSample : ISample
    {
        public void Run()
        {
            var blockExpr = Expression.Block(
                Expression.Call(
                    null,
                    typeof(Console).GetMethod("Write", new[] {typeof(string)}),
                    Expression.Constant("Hello ")
                ),
                Expression.Call(
                    null,
                    typeof(Console).GetMethod("WriteLine", new[] {typeof(string)}),
                    Expression.Constant("World!")
                ),
                Expression.Constant(42)
            );

            Console.WriteLine("The result of executing the expression tree:");
            // The following statement first creates an expression tree,
            // then compiles it, and then executes it.
            var expression = Expression.Lambda<Func<int>>(blockExpr);
            var compiledExpression = expression.Compile();
            var result = compiledExpression();
            // Hello World!

            // Print out the expressions from the block expression.
            Console.WriteLine("The expressions from the block expression:");
            foreach (var expr in blockExpr.Expressions)
            {
                Console.WriteLine(expr.ToString());
                // Write("Hello ")
                // WriteLine("World!")
                // 42
            }

            // Print out the result of the tree execution.
            Console.WriteLine("The return value of the block expression:");
            Console.WriteLine(result);
            // 42
        }
    }
}