//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.5.3
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from C:\Users\DesanaD\Documents\Visual Studio 2015\Projects\Antlr\Antlr\Base.g4 by ANTLR 4.5.3

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace Antlr.Grammars {
using Antlr4.Runtime.Misc;
using IParseTreeListener = Antlr4.Runtime.Tree.IParseTreeListener;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete listener for a parse tree produced by
/// <see cref="BaseParser"/>.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.5.3")]
[System.CLSCompliant(false)]
public interface IBaseListener : IParseTreeListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="BaseParser.compileUnit"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCompileUnit([NotNull] BaseParser.CompileUnitContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="BaseParser.compileUnit"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCompileUnit([NotNull] BaseParser.CompileUnitContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="BaseParser.input"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterInput([NotNull] BaseParser.InputContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="BaseParser.input"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitInput([NotNull] BaseParser.InputContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="BaseParser.cleanInput"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCleanInput([NotNull] BaseParser.CleanInputContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="BaseParser.cleanInput"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCleanInput([NotNull] BaseParser.CleanInputContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="BaseParser.params"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterParams([NotNull] BaseParser.ParamsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="BaseParser.params"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitParams([NotNull] BaseParser.ParamsContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="BaseParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExpression([NotNull] BaseParser.ExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="BaseParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExpression([NotNull] BaseParser.ExpressionContext context);
}
} // namespace Antlr.Grammars