using System;

using static KSharpParser.KSharpGrammarParser;

using Antlr4.Runtime.Tree;

namespace KSharpParser.Visitors
{
    /// <summary>
    /// Encapsulates <see cref="KSharpVisitor"/> for evaluating macro expressions.
    /// </summary>
    public class MacroExpressionVisitor
    {
        private KSharpGrammarBaseVisitor<object> visitor;

        /// <summary>
        /// Initializes new instance of <see cref="MacroExpressionVisitor"/>.
        /// </summary>
        /// <param name="evaluator">Defines context defining methods for evaluation.</param>
        public MacroExpressionVisitor(INodeEvaluator evaluator)
        {
            visitor = new KSharpVisitor(evaluator);
        }


        /// <summary>
        /// Parses and evaluates the whole macro expression.
        /// </summary>
        /// <param name="tree">Macro expression encapsulated to the parsed tree.</param>
        /// <returns>Evaluated macro expression.</returns>
        public object Visit(IParseTree tree)
        {
            if(tree is Begin_expressionContext)
            {
                return visitor.Visit(tree);
            }

            throw new ArgumentException($"Given parameter {nameof(tree)} must be of type {typeof(Begin_expressionContext).FullName}.");
        }
    }
}