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
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.6.6")]
[System.CLSCompliant(false)]
public partial class GrammerLexer : Lexer {
	public const int
		T__0=1, T__1=2, T__2=3, T__3=4, T__4=5, T__5=6, T__6=7, T__7=8, T__8=9, 
		T__9=10, T__10=11, T__11=12, T__12=13, T__13=14, T__14=15, T__15=16, T__16=17, 
		T__17=18, T__18=19, T__19=20, T__20=21, T__21=22, T__22=23, T__23=24, 
		T__24=25, T__25=26, T__26=27, T__27=28, T__28=29, T__29=30, T__30=31, 
		T__31=32, T__32=33, WHILE=34, BOOL_OPERATOR=35, INTEGER=36, FLOAT=37, 
		STRING=38, NULL=39, BOOLEAN=40, WS=41, IDENTIFIER=42, IS_ASSIGN=43, Comment=44;
	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"T__0", "T__1", "T__2", "T__3", "T__4", "T__5", "T__6", "T__7", "T__8", 
		"T__9", "T__10", "T__11", "T__12", "T__13", "T__14", "T__15", "T__16", 
		"T__17", "T__18", "T__19", "T__20", "T__21", "T__22", "T__23", "T__24", 
		"T__25", "T__26", "T__27", "T__28", "T__29", "T__30", "T__31", "T__32", 
		"WHILE", "BOOL_OPERATOR", "INTEGER", "FLOAT", "STRING", "NULL", "BOOLEAN", 
		"WS", "IDENTIFIER", "IS_ASSIGN", "Comment"
	};


	public GrammerLexer(ICharStream input)
		: base(input)
	{
		_interp = new LexerATNSimulator(this,_ATN);
	}

	private static readonly string[] _LiteralNames = {
		null, "';'", "'if'", "'else'", "'{'", "'}'", "'='", "'show yourself'", 
		"'('", "')'", "','", "'!'", "'*'", "'/'", "'%'", "'times'", "'divided by'", 
		"'modulus'", "'+'", "'-'", "'plus'", "'minus'", "'=='", "'!='", "'<'", 
		"'<='", "'>'", "'>='", "'is equal to'", "'is not equal to'", "'is less than'", 
		"'is less than or equal to'", "'is greater than'", "'is greater than or equal to'", 
		null, null, null, null, null, "'null'", null, null, null, "'->'", "'//'"
	};
	private static readonly string[] _SymbolicNames = {
		null, null, null, null, null, null, null, null, null, null, null, null, 
		null, null, null, null, null, null, null, null, null, null, null, null, 
		null, null, null, null, null, null, null, null, null, null, "WHILE", "BOOL_OPERATOR", 
		"INTEGER", "FLOAT", "STRING", "NULL", "BOOLEAN", "WS", "IDENTIFIER", "IS_ASSIGN", 
		"Comment"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[System.Obsolete("Use Vocabulary instead.")]
	public static readonly string[] tokenNames = GenerateTokenNames(DefaultVocabulary, _SymbolicNames.Length);

	private static string[] GenerateTokenNames(IVocabulary vocabulary, int length) {
		string[] tokenNames = new string[length];
		for (int i = 0; i < tokenNames.Length; i++) {
			tokenNames[i] = vocabulary.GetLiteralName(i);
			if (tokenNames[i] == null) {
				tokenNames[i] = vocabulary.GetSymbolicName(i);
			}

			if (tokenNames[i] == null) {
				tokenNames[i] = "<INVALID>";
			}
		}

		return tokenNames;
	}

	[System.Obsolete("Use IRecognizer.Vocabulary instead.")]
	public override string[] TokenNames
	{
		get
		{
			return tokenNames;
		}
	}

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "Grammer.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string[] ModeNames { get { return modeNames; } }

	public override string SerializedAtn { get { return _serializedATN; } }

	public static readonly string _serializedATN =
		"\x3\xAF6F\x8320\x479D\xB75C\x4880\x1605\x191C\xAB37\x2.\x186\b\x1\x4\x2"+
		"\t\x2\x4\x3\t\x3\x4\x4\t\x4\x4\x5\t\x5\x4\x6\t\x6\x4\a\t\a\x4\b\t\b\x4"+
		"\t\t\t\x4\n\t\n\x4\v\t\v\x4\f\t\f\x4\r\t\r\x4\xE\t\xE\x4\xF\t\xF\x4\x10"+
		"\t\x10\x4\x11\t\x11\x4\x12\t\x12\x4\x13\t\x13\x4\x14\t\x14\x4\x15\t\x15"+
		"\x4\x16\t\x16\x4\x17\t\x17\x4\x18\t\x18\x4\x19\t\x19\x4\x1A\t\x1A\x4\x1B"+
		"\t\x1B\x4\x1C\t\x1C\x4\x1D\t\x1D\x4\x1E\t\x1E\x4\x1F\t\x1F\x4 \t \x4!"+
		"\t!\x4\"\t\"\x4#\t#\x4$\t$\x4%\t%\x4&\t&\x4\'\t\'\x4(\t(\x4)\t)\x4*\t"+
		"*\x4+\t+\x4,\t,\x4-\t-\x3\x2\x3\x2\x3\x3\x3\x3\x3\x3\x3\x4\x3\x4\x3\x4"+
		"\x3\x4\x3\x4\x3\x5\x3\x5\x3\x6\x3\x6\x3\a\x3\a\x3\b\x3\b\x3\b\x3\b\x3"+
		"\b\x3\b\x3\b\x3\b\x3\b\x3\b\x3\b\x3\b\x3\b\x3\b\x3\t\x3\t\x3\n\x3\n\x3"+
		"\v\x3\v\x3\f\x3\f\x3\r\x3\r\x3\xE\x3\xE\x3\xF\x3\xF\x3\x10\x3\x10\x3\x10"+
		"\x3\x10\x3\x10\x3\x10\x3\x11\x3\x11\x3\x11\x3\x11\x3\x11\x3\x11\x3\x11"+
		"\x3\x11\x3\x11\x3\x11\x3\x11\x3\x12\x3\x12\x3\x12\x3\x12\x3\x12\x3\x12"+
		"\x3\x12\x3\x12\x3\x13\x3\x13\x3\x14\x3\x14\x3\x15\x3\x15\x3\x15\x3\x15"+
		"\x3\x15\x3\x16\x3\x16\x3\x16\x3\x16\x3\x16\x3\x16\x3\x17\x3\x17\x3\x17"+
		"\x3\x18\x3\x18\x3\x18\x3\x19\x3\x19\x3\x1A\x3\x1A\x3\x1A\x3\x1B\x3\x1B"+
		"\x3\x1C\x3\x1C\x3\x1C\x3\x1D\x3\x1D\x3\x1D\x3\x1D\x3\x1D\x3\x1D\x3\x1D"+
		"\x3\x1D\x3\x1D\x3\x1D\x3\x1D\x3\x1D\x3\x1E\x3\x1E\x3\x1E\x3\x1E\x3\x1E"+
		"\x3\x1E\x3\x1E\x3\x1E\x3\x1E\x3\x1E\x3\x1E\x3\x1E\x3\x1E\x3\x1E\x3\x1E"+
		"\x3\x1E\x3\x1F\x3\x1F\x3\x1F\x3\x1F\x3\x1F\x3\x1F\x3\x1F\x3\x1F\x3\x1F"+
		"\x3\x1F\x3\x1F\x3\x1F\x3\x1F\x3 \x3 \x3 \x3 \x3 \x3 \x3 \x3 \x3 \x3 \x3"+
		" \x3 \x3 \x3 \x3 \x3 \x3 \x3 \x3 \x3 \x3 \x3 \x3 \x3 \x3 \x3!\x3!\x3!"+
		"\x3!\x3!\x3!\x3!\x3!\x3!\x3!\x3!\x3!\x3!\x3!\x3!\x3!\x3\"\x3\"\x3\"\x3"+
		"\"\x3\"\x3\"\x3\"\x3\"\x3\"\x3\"\x3\"\x3\"\x3\"\x3\"\x3\"\x3\"\x3\"\x3"+
		"\"\x3\"\x3\"\x3\"\x3\"\x3\"\x3\"\x3\"\x3\"\x3\"\x3\"\x3#\x3#\x3#\x3#\x3"+
		"#\x3#\x3#\x3#\x3#\x3#\x5#\x138\n#\x3$\x3$\x3$\x3$\x3$\x5$\x13F\n$\x3%"+
		"\x6%\x142\n%\r%\xE%\x143\x3&\x6&\x147\n&\r&\xE&\x148\x3&\x3&\x6&\x14D"+
		"\n&\r&\xE&\x14E\x3\'\x3\'\a\'\x153\n\'\f\'\xE\'\x156\v\'\x3\'\x3\'\x3"+
		"\'\a\'\x15B\n\'\f\'\xE\'\x15E\v\'\x3\'\x5\'\x161\n\'\x3(\x3(\x3(\x3(\x3"+
		"(\x3)\x3)\x3)\x3)\x3)\x3)\x3)\x3)\x3)\x5)\x171\n)\x3*\x6*\x174\n*\r*\xE"+
		"*\x175\x3*\x3*\x3+\x3+\a+\x17C\n+\f+\xE+\x17F\v+\x3,\x3,\x3,\x3-\x3-\x3"+
		"-\x2\x2\x2.\x3\x2\x3\x5\x2\x4\a\x2\x5\t\x2\x6\v\x2\a\r\x2\b\xF\x2\t\x11"+
		"\x2\n\x13\x2\v\x15\x2\f\x17\x2\r\x19\x2\xE\x1B\x2\xF\x1D\x2\x10\x1F\x2"+
		"\x11!\x2\x12#\x2\x13%\x2\x14\'\x2\x15)\x2\x16+\x2\x17-\x2\x18/\x2\x19"+
		"\x31\x2\x1A\x33\x2\x1B\x35\x2\x1C\x37\x2\x1D\x39\x2\x1E;\x2\x1F=\x2 ?"+
		"\x2!\x41\x2\"\x43\x2#\x45\x2$G\x2%I\x2&K\x2\'M\x2(O\x2)Q\x2*S\x2+U\x2"+
		",W\x2-Y\x2.\x3\x2\b\x3\x2\x32;\x3\x2$$\x3\x2))\x5\x2\v\f\xF\xF\"\"\x5"+
		"\x2\x43\\\x61\x61\x63|\x6\x2\x32;\x43\\\x61\x61\x63|\x190\x2\x3\x3\x2"+
		"\x2\x2\x2\x5\x3\x2\x2\x2\x2\a\x3\x2\x2\x2\x2\t\x3\x2\x2\x2\x2\v\x3\x2"+
		"\x2\x2\x2\r\x3\x2\x2\x2\x2\xF\x3\x2\x2\x2\x2\x11\x3\x2\x2\x2\x2\x13\x3"+
		"\x2\x2\x2\x2\x15\x3\x2\x2\x2\x2\x17\x3\x2\x2\x2\x2\x19\x3\x2\x2\x2\x2"+
		"\x1B\x3\x2\x2\x2\x2\x1D\x3\x2\x2\x2\x2\x1F\x3\x2\x2\x2\x2!\x3\x2\x2\x2"+
		"\x2#\x3\x2\x2\x2\x2%\x3\x2\x2\x2\x2\'\x3\x2\x2\x2\x2)\x3\x2\x2\x2\x2+"+
		"\x3\x2\x2\x2\x2-\x3\x2\x2\x2\x2/\x3\x2\x2\x2\x2\x31\x3\x2\x2\x2\x2\x33"+
		"\x3\x2\x2\x2\x2\x35\x3\x2\x2\x2\x2\x37\x3\x2\x2\x2\x2\x39\x3\x2\x2\x2"+
		"\x2;\x3\x2\x2\x2\x2=\x3\x2\x2\x2\x2?\x3\x2\x2\x2\x2\x41\x3\x2\x2\x2\x2"+
		"\x43\x3\x2\x2\x2\x2\x45\x3\x2\x2\x2\x2G\x3\x2\x2\x2\x2I\x3\x2\x2\x2\x2"+
		"K\x3\x2\x2\x2\x2M\x3\x2\x2\x2\x2O\x3\x2\x2\x2\x2Q\x3\x2\x2\x2\x2S\x3\x2"+
		"\x2\x2\x2U\x3\x2\x2\x2\x2W\x3\x2\x2\x2\x2Y\x3\x2\x2\x2\x3[\x3\x2\x2\x2"+
		"\x5]\x3\x2\x2\x2\a`\x3\x2\x2\x2\t\x65\x3\x2\x2\x2\vg\x3\x2\x2\x2\ri\x3"+
		"\x2\x2\x2\xFk\x3\x2\x2\x2\x11y\x3\x2\x2\x2\x13{\x3\x2\x2\x2\x15}\x3\x2"+
		"\x2\x2\x17\x7F\x3\x2\x2\x2\x19\x81\x3\x2\x2\x2\x1B\x83\x3\x2\x2\x2\x1D"+
		"\x85\x3\x2\x2\x2\x1F\x87\x3\x2\x2\x2!\x8D\x3\x2\x2\x2#\x98\x3\x2\x2\x2"+
		"%\xA0\x3\x2\x2\x2\'\xA2\x3\x2\x2\x2)\xA4\x3\x2\x2\x2+\xA9\x3\x2\x2\x2"+
		"-\xAF\x3\x2\x2\x2/\xB2\x3\x2\x2\x2\x31\xB5\x3\x2\x2\x2\x33\xB7\x3\x2\x2"+
		"\x2\x35\xBA\x3\x2\x2\x2\x37\xBC\x3\x2\x2\x2\x39\xBF\x3\x2\x2\x2;\xCB\x3"+
		"\x2\x2\x2=\xDB\x3\x2\x2\x2?\xE8\x3\x2\x2\x2\x41\x101\x3\x2\x2\x2\x43\x111"+
		"\x3\x2\x2\x2\x45\x137\x3\x2\x2\x2G\x13E\x3\x2\x2\x2I\x141\x3\x2\x2\x2"+
		"K\x146\x3\x2\x2\x2M\x160\x3\x2\x2\x2O\x162\x3\x2\x2\x2Q\x170\x3\x2\x2"+
		"\x2S\x173\x3\x2\x2\x2U\x179\x3\x2\x2\x2W\x180\x3\x2\x2\x2Y\x183\x3\x2"+
		"\x2\x2[\\\a=\x2\x2\\\x4\x3\x2\x2\x2]^\ak\x2\x2^_\ah\x2\x2_\x6\x3\x2\x2"+
		"\x2`\x61\ag\x2\x2\x61\x62\an\x2\x2\x62\x63\au\x2\x2\x63\x64\ag\x2\x2\x64"+
		"\b\x3\x2\x2\x2\x65\x66\a}\x2\x2\x66\n\x3\x2\x2\x2gh\a\x7F\x2\x2h\f\x3"+
		"\x2\x2\x2ij\a?\x2\x2j\xE\x3\x2\x2\x2kl\au\x2\x2lm\aj\x2\x2mn\aq\x2\x2"+
		"no\ay\x2\x2op\a\"\x2\x2pq\a{\x2\x2qr\aq\x2\x2rs\aw\x2\x2st\at\x2\x2tu"+
		"\au\x2\x2uv\ag\x2\x2vw\an\x2\x2wx\ah\x2\x2x\x10\x3\x2\x2\x2yz\a*\x2\x2"+
		"z\x12\x3\x2\x2\x2{|\a+\x2\x2|\x14\x3\x2\x2\x2}~\a.\x2\x2~\x16\x3\x2\x2"+
		"\x2\x7F\x80\a#\x2\x2\x80\x18\x3\x2\x2\x2\x81\x82\a,\x2\x2\x82\x1A\x3\x2"+
		"\x2\x2\x83\x84\a\x31\x2\x2\x84\x1C\x3\x2\x2\x2\x85\x86\a\'\x2\x2\x86\x1E"+
		"\x3\x2\x2\x2\x87\x88\av\x2\x2\x88\x89\ak\x2\x2\x89\x8A\ao\x2\x2\x8A\x8B"+
		"\ag\x2\x2\x8B\x8C\au\x2\x2\x8C \x3\x2\x2\x2\x8D\x8E\a\x66\x2\x2\x8E\x8F"+
		"\ak\x2\x2\x8F\x90\ax\x2\x2\x90\x91\ak\x2\x2\x91\x92\a\x66\x2\x2\x92\x93"+
		"\ag\x2\x2\x93\x94\a\x66\x2\x2\x94\x95\a\"\x2\x2\x95\x96\a\x64\x2\x2\x96"+
		"\x97\a{\x2\x2\x97\"\x3\x2\x2\x2\x98\x99\ao\x2\x2\x99\x9A\aq\x2\x2\x9A"+
		"\x9B\a\x66\x2\x2\x9B\x9C\aw\x2\x2\x9C\x9D\an\x2\x2\x9D\x9E\aw\x2\x2\x9E"+
		"\x9F\au\x2\x2\x9F$\x3\x2\x2\x2\xA0\xA1\a-\x2\x2\xA1&\x3\x2\x2\x2\xA2\xA3"+
		"\a/\x2\x2\xA3(\x3\x2\x2\x2\xA4\xA5\ar\x2\x2\xA5\xA6\an\x2\x2\xA6\xA7\a"+
		"w\x2\x2\xA7\xA8\au\x2\x2\xA8*\x3\x2\x2\x2\xA9\xAA\ao\x2\x2\xAA\xAB\ak"+
		"\x2\x2\xAB\xAC\ap\x2\x2\xAC\xAD\aw\x2\x2\xAD\xAE\au\x2\x2\xAE,\x3\x2\x2"+
		"\x2\xAF\xB0\a?\x2\x2\xB0\xB1\a?\x2\x2\xB1.\x3\x2\x2\x2\xB2\xB3\a#\x2\x2"+
		"\xB3\xB4\a?\x2\x2\xB4\x30\x3\x2\x2\x2\xB5\xB6\a>\x2\x2\xB6\x32\x3\x2\x2"+
		"\x2\xB7\xB8\a>\x2\x2\xB8\xB9\a?\x2\x2\xB9\x34\x3\x2\x2\x2\xBA\xBB\a@\x2"+
		"\x2\xBB\x36\x3\x2\x2\x2\xBC\xBD\a@\x2\x2\xBD\xBE\a?\x2\x2\xBE\x38\x3\x2"+
		"\x2\x2\xBF\xC0\ak\x2\x2\xC0\xC1\au\x2\x2\xC1\xC2\a\"\x2\x2\xC2\xC3\ag"+
		"\x2\x2\xC3\xC4\as\x2\x2\xC4\xC5\aw\x2\x2\xC5\xC6\a\x63\x2\x2\xC6\xC7\a"+
		"n\x2\x2\xC7\xC8\a\"\x2\x2\xC8\xC9\av\x2\x2\xC9\xCA\aq\x2\x2\xCA:\x3\x2"+
		"\x2\x2\xCB\xCC\ak\x2\x2\xCC\xCD\au\x2\x2\xCD\xCE\a\"\x2\x2\xCE\xCF\ap"+
		"\x2\x2\xCF\xD0\aq\x2\x2\xD0\xD1\av\x2\x2\xD1\xD2\a\"\x2\x2\xD2\xD3\ag"+
		"\x2\x2\xD3\xD4\as\x2\x2\xD4\xD5\aw\x2\x2\xD5\xD6\a\x63\x2\x2\xD6\xD7\a"+
		"n\x2\x2\xD7\xD8\a\"\x2\x2\xD8\xD9\av\x2\x2\xD9\xDA\aq\x2\x2\xDA<\x3\x2"+
		"\x2\x2\xDB\xDC\ak\x2\x2\xDC\xDD\au\x2\x2\xDD\xDE\a\"\x2\x2\xDE\xDF\an"+
		"\x2\x2\xDF\xE0\ag\x2\x2\xE0\xE1\au\x2\x2\xE1\xE2\au\x2\x2\xE2\xE3\a\""+
		"\x2\x2\xE3\xE4\av\x2\x2\xE4\xE5\aj\x2\x2\xE5\xE6\a\x63\x2\x2\xE6\xE7\a"+
		"p\x2\x2\xE7>\x3\x2\x2\x2\xE8\xE9\ak\x2\x2\xE9\xEA\au\x2\x2\xEA\xEB\a\""+
		"\x2\x2\xEB\xEC\an\x2\x2\xEC\xED\ag\x2\x2\xED\xEE\au\x2\x2\xEE\xEF\au\x2"+
		"\x2\xEF\xF0\a\"\x2\x2\xF0\xF1\av\x2\x2\xF1\xF2\aj\x2\x2\xF2\xF3\a\x63"+
		"\x2\x2\xF3\xF4\ap\x2\x2\xF4\xF5\a\"\x2\x2\xF5\xF6\aq\x2\x2\xF6\xF7\at"+
		"\x2\x2\xF7\xF8\a\"\x2\x2\xF8\xF9\ag\x2\x2\xF9\xFA\as\x2\x2\xFA\xFB\aw"+
		"\x2\x2\xFB\xFC\a\x63\x2\x2\xFC\xFD\an\x2\x2\xFD\xFE\a\"\x2\x2\xFE\xFF"+
		"\av\x2\x2\xFF\x100\aq\x2\x2\x100@\x3\x2\x2\x2\x101\x102\ak\x2\x2\x102"+
		"\x103\au\x2\x2\x103\x104\a\"\x2\x2\x104\x105\ai\x2\x2\x105\x106\at\x2"+
		"\x2\x106\x107\ag\x2\x2\x107\x108\a\x63\x2\x2\x108\x109\av\x2\x2\x109\x10A"+
		"\ag\x2\x2\x10A\x10B\at\x2\x2\x10B\x10C\a\"\x2\x2\x10C\x10D\av\x2\x2\x10D"+
		"\x10E\aj\x2\x2\x10E\x10F\a\x63\x2\x2\x10F\x110\ap\x2\x2\x110\x42\x3\x2"+
		"\x2\x2\x111\x112\ak\x2\x2\x112\x113\au\x2\x2\x113\x114\a\"\x2\x2\x114"+
		"\x115\ai\x2\x2\x115\x116\at\x2\x2\x116\x117\ag\x2\x2\x117\x118\a\x63\x2"+
		"\x2\x118\x119\av\x2\x2\x119\x11A\ag\x2\x2\x11A\x11B\at\x2\x2\x11B\x11C"+
		"\a\"\x2\x2\x11C\x11D\av\x2\x2\x11D\x11E\aj\x2\x2\x11E\x11F\a\x63\x2\x2"+
		"\x11F\x120\ap\x2\x2\x120\x121\a\"\x2\x2\x121\x122\aq\x2\x2\x122\x123\a"+
		"t\x2\x2\x123\x124\a\"\x2\x2\x124\x125\ag\x2\x2\x125\x126\as\x2\x2\x126"+
		"\x127\aw\x2\x2\x127\x128\a\x63\x2\x2\x128\x129\an\x2\x2\x129\x12A\a\""+
		"\x2\x2\x12A\x12B\av\x2\x2\x12B\x12C\aq\x2\x2\x12C\x44\x3\x2\x2\x2\x12D"+
		"\x12E\ay\x2\x2\x12E\x12F\aj\x2\x2\x12F\x130\ak\x2\x2\x130\x131\an\x2\x2"+
		"\x131\x138\ag\x2\x2\x132\x133\aw\x2\x2\x133\x134\ap\x2\x2\x134\x135\a"+
		"v\x2\x2\x135\x136\ak\x2\x2\x136\x138\an\x2\x2\x137\x12D\x3\x2\x2\x2\x137"+
		"\x132\x3\x2\x2\x2\x138\x46\x3\x2\x2\x2\x139\x13A\a\x63\x2\x2\x13A\x13B"+
		"\ap\x2\x2\x13B\x13F\a\x66\x2\x2\x13C\x13D\aq\x2\x2\x13D\x13F\at\x2\x2"+
		"\x13E\x139\x3\x2\x2\x2\x13E\x13C\x3\x2\x2\x2\x13FH\x3\x2\x2\x2\x140\x142"+
		"\t\x2\x2\x2\x141\x140\x3\x2\x2\x2\x142\x143\x3\x2\x2\x2\x143\x141\x3\x2"+
		"\x2\x2\x143\x144\x3\x2\x2\x2\x144J\x3\x2\x2\x2\x145\x147\t\x2\x2\x2\x146"+
		"\x145\x3\x2\x2\x2\x147\x148\x3\x2\x2\x2\x148\x146\x3\x2\x2\x2\x148\x149"+
		"\x3\x2\x2\x2\x149\x14A\x3\x2\x2\x2\x14A\x14C\a\x30\x2\x2\x14B\x14D\t\x2"+
		"\x2\x2\x14C\x14B\x3\x2\x2\x2\x14D\x14E\x3\x2\x2\x2\x14E\x14C\x3\x2\x2"+
		"\x2\x14E\x14F\x3\x2\x2\x2\x14FL\x3\x2\x2\x2\x150\x154\a$\x2\x2\x151\x153"+
		"\n\x3\x2\x2\x152\x151\x3\x2\x2\x2\x153\x156\x3\x2\x2\x2\x154\x152\x3\x2"+
		"\x2\x2\x154\x155\x3\x2\x2\x2\x155\x157\x3\x2\x2\x2\x156\x154\x3\x2\x2"+
		"\x2\x157\x161\a$\x2\x2\x158\x15C\a)\x2\x2\x159\x15B\n\x4\x2\x2\x15A\x159"+
		"\x3\x2\x2\x2\x15B\x15E\x3\x2\x2\x2\x15C\x15A\x3\x2\x2\x2\x15C\x15D\x3"+
		"\x2\x2\x2\x15D\x15F\x3\x2\x2\x2\x15E\x15C\x3\x2\x2\x2\x15F\x161\a)\x2"+
		"\x2\x160\x150\x3\x2\x2\x2\x160\x158\x3\x2\x2\x2\x161N\x3\x2\x2\x2\x162"+
		"\x163\ap\x2\x2\x163\x164\aw\x2\x2\x164\x165\an\x2\x2\x165\x166\an\x2\x2"+
		"\x166P\x3\x2\x2\x2\x167\x168\av\x2\x2\x168\x169\at\x2\x2\x169\x16A\aw"+
		"\x2\x2\x16A\x171\ag\x2\x2\x16B\x16C\ah\x2\x2\x16C\x16D\a\x63\x2\x2\x16D"+
		"\x16E\an\x2\x2\x16E\x16F\au\x2\x2\x16F\x171\ag\x2\x2\x170\x167\x3\x2\x2"+
		"\x2\x170\x16B\x3\x2\x2\x2\x171R\x3\x2\x2\x2\x172\x174\t\x5\x2\x2\x173"+
		"\x172\x3\x2\x2\x2\x174\x175\x3\x2\x2\x2\x175\x173\x3\x2\x2\x2\x175\x176"+
		"\x3\x2\x2\x2\x176\x177\x3\x2\x2\x2\x177\x178\b*\x2\x2\x178T\x3\x2\x2\x2"+
		"\x179\x17D\t\x6\x2\x2\x17A\x17C\t\a\x2\x2\x17B\x17A\x3\x2\x2\x2\x17C\x17F"+
		"\x3\x2\x2\x2\x17D\x17B\x3\x2\x2\x2\x17D\x17E\x3\x2\x2\x2\x17EV\x3\x2\x2"+
		"\x2\x17F\x17D\x3\x2\x2\x2\x180\x181\a/\x2\x2\x181\x182\a@\x2\x2\x182X"+
		"\x3\x2\x2\x2\x183\x184\a\x31\x2\x2\x184\x185\a\x31\x2\x2\x185Z\x3\x2\x2"+
		"\x2\xE\x2\x137\x13E\x143\x148\x14E\x154\x15C\x160\x170\x175\x17D\x3\b"+
		"\x2\x2";
	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN.ToCharArray());
}
} // namespace OwnLanguage.Content