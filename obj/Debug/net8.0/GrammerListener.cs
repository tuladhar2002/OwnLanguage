﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.6.6
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from /Users/tuladhar2002/ComparitiveLanguageFinal/OwnLanguage/Content/Grammer.g4 by ANTLR 4.6.6

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace OwnLanguage.Content {
using Antlr4.Runtime.Misc;
using IParseTreeListener = Antlr4.Runtime.Tree.IParseTreeListener;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete listener for a parse tree produced by
/// <see cref="GrammerParser"/>.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.6.6")]
[System.CLSCompliant(false)]
public interface IGrammerListener : IParseTreeListener {
	/// <summary>
	/// Enter a parse tree produced by the <c>constantExpression</c>
	/// labeled alternative in <see cref="GrammerParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterConstantExpression([NotNull] GrammerParser.ConstantExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>constantExpression</c>
	/// labeled alternative in <see cref="GrammerParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitConstantExpression([NotNull] GrammerParser.ConstantExpressionContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>identifierExpression</c>
	/// labeled alternative in <see cref="GrammerParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIdentifierExpression([NotNull] GrammerParser.IdentifierExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>identifierExpression</c>
	/// labeled alternative in <see cref="GrammerParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIdentifierExpression([NotNull] GrammerParser.IdentifierExpressionContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>functionCallExpression</c>
	/// labeled alternative in <see cref="GrammerParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFunctionCallExpression([NotNull] GrammerParser.FunctionCallExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>functionCallExpression</c>
	/// labeled alternative in <see cref="GrammerParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFunctionCallExpression([NotNull] GrammerParser.FunctionCallExpressionContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>parenExpression</c>
	/// labeled alternative in <see cref="GrammerParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterParenExpression([NotNull] GrammerParser.ParenExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>parenExpression</c>
	/// labeled alternative in <see cref="GrammerParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitParenExpression([NotNull] GrammerParser.ParenExpressionContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>notExpression</c>
	/// labeled alternative in <see cref="GrammerParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNotExpression([NotNull] GrammerParser.NotExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>notExpression</c>
	/// labeled alternative in <see cref="GrammerParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNotExpression([NotNull] GrammerParser.NotExpressionContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>multExpression</c>
	/// labeled alternative in <see cref="GrammerParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMultExpression([NotNull] GrammerParser.MultExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>multExpression</c>
	/// labeled alternative in <see cref="GrammerParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMultExpression([NotNull] GrammerParser.MultExpressionContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>addExpression</c>
	/// labeled alternative in <see cref="GrammerParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAddExpression([NotNull] GrammerParser.AddExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>addExpression</c>
	/// labeled alternative in <see cref="GrammerParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAddExpression([NotNull] GrammerParser.AddExpressionContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>compExpression</c>
	/// labeled alternative in <see cref="GrammerParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCompExpression([NotNull] GrammerParser.CompExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>compExpression</c>
	/// labeled alternative in <see cref="GrammerParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCompExpression([NotNull] GrammerParser.CompExpressionContext context);

	/// <summary>
	/// Enter a parse tree produced by the <c>boolExpression</c>
	/// labeled alternative in <see cref="GrammerParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBoolExpression([NotNull] GrammerParser.BoolExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by the <c>boolExpression</c>
	/// labeled alternative in <see cref="GrammerParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBoolExpression([NotNull] GrammerParser.BoolExpressionContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="GrammerParser.program"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterProgram([NotNull] GrammerParser.ProgramContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="GrammerParser.program"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitProgram([NotNull] GrammerParser.ProgramContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="GrammerParser.line"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLine([NotNull] GrammerParser.LineContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="GrammerParser.line"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLine([NotNull] GrammerParser.LineContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="GrammerParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStatement([NotNull] GrammerParser.StatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="GrammerParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStatement([NotNull] GrammerParser.StatementContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="GrammerParser.ifBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIfBlock([NotNull] GrammerParser.IfBlockContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="GrammerParser.ifBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIfBlock([NotNull] GrammerParser.IfBlockContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="GrammerParser.elseIfBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterElseIfBlock([NotNull] GrammerParser.ElseIfBlockContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="GrammerParser.elseIfBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitElseIfBlock([NotNull] GrammerParser.ElseIfBlockContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="GrammerParser.block"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBlock([NotNull] GrammerParser.BlockContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="GrammerParser.block"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBlock([NotNull] GrammerParser.BlockContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="GrammerParser.whileBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterWhileBlock([NotNull] GrammerParser.WhileBlockContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="GrammerParser.whileBlock"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitWhileBlock([NotNull] GrammerParser.WhileBlockContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="GrammerParser.assignment"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAssignment([NotNull] GrammerParser.AssignmentContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="GrammerParser.assignment"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAssignment([NotNull] GrammerParser.AssignmentContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="GrammerParser.printStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPrintStatement([NotNull] GrammerParser.PrintStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="GrammerParser.printStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPrintStatement([NotNull] GrammerParser.PrintStatementContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="GrammerParser.functionCall"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFunctionCall([NotNull] GrammerParser.FunctionCallContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="GrammerParser.functionCall"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFunctionCall([NotNull] GrammerParser.FunctionCallContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="GrammerParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExpression([NotNull] GrammerParser.ExpressionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="GrammerParser.expression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExpression([NotNull] GrammerParser.ExpressionContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="GrammerParser.mult_op"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMult_op([NotNull] GrammerParser.Mult_opContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="GrammerParser.mult_op"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMult_op([NotNull] GrammerParser.Mult_opContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="GrammerParser.add_op"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterAdd_op([NotNull] GrammerParser.Add_opContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="GrammerParser.add_op"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitAdd_op([NotNull] GrammerParser.Add_opContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="GrammerParser.comp_op"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterComp_op([NotNull] GrammerParser.Comp_opContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="GrammerParser.comp_op"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitComp_op([NotNull] GrammerParser.Comp_opContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="GrammerParser.bool_op"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterBool_op([NotNull] GrammerParser.Bool_opContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="GrammerParser.bool_op"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitBool_op([NotNull] GrammerParser.Bool_opContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="GrammerParser.constant"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterConstant([NotNull] GrammerParser.ConstantContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="GrammerParser.constant"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitConstant([NotNull] GrammerParser.ConstantContext context);
}
} // namespace OwnLanguage.Content
