//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.9.2
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from c:\Users\axelg\Desktop\RecetarioGrupo1\Recetario.g4 by ANTLR 4.9.2

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

using System;
using System.IO;
using System.Text;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.9.2")]
[System.CLSCompliant(false)]
public partial class RecetarioLexer : Lexer {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		GUION=1, RECETA=2, PORCIONES=3, PREPARACION=4, COCCION=5, CALORIAS=6, 
		INGREDIENTES=7, ELABORACION=8, CUCHARADITA=9, CUCHARADA=10, TAZA=11, SEP=12, 
		SP=13, NUMBER=14, TEXT=15, WORD=16, ING_ITEM=17, PASOS=18, WS=19;
	public static string[] channelNames = {
		"DEFAULT_TOKEN_CHANNEL", "HIDDEN"
	};

	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"GUION", "RECETA", "PORCIONES", "PREPARACION", "COCCION", "CALORIAS", 
		"INGREDIENTES", "ELABORACION", "CUCHARADITA", "CUCHARADA", "TAZA", "SEP", 
		"SP", "NUMBER", "TEXT", "WORD", "ING_ITEM_SP", "PASOS_SP", "WS"
	};

	public RecetarioLexer(ICharStream input)
	: this(input, Console.Out, Console.Error) { }

	public RecetarioLexer(ICharStream input, TextWriter output, TextWriter errorOutput)
	: base(input, output, errorOutput)
	{
		Interpreter = new LexerATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	private static readonly string[] _LiteralNames = {
		null, "'- '", "'RECETA'", "'PORCIONES'", "'TIEMPO PREPARACION'", "'TIEMPO COCCION'", 
		"'CALORIAS'", "'INGREDIENTES'", "'ELABORACION'", null, null, null, null, 
		null, null, null, null, "','", "')'"
	};
	private static readonly string[] _SymbolicNames = {
		null, "GUION", "RECETA", "PORCIONES", "PREPARACION", "COCCION", "CALORIAS", 
		"INGREDIENTES", "ELABORACION", "CUCHARADITA", "CUCHARADA", "TAZA", "SEP", 
		"SP", "NUMBER", "TEXT", "WORD", "ING_ITEM_SP", "PASOS_SP", "WS"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "Recetario.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string[] ChannelNames { get { return channelNames; } }

	public override string[] ModeNames { get { return modeNames; } }

	public override string SerializedAtn { get { return new string(_serializedATN); } }

	static RecetarioLexer() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}
	private static char[] _serializedATN = {
		'\x3', '\x608B', '\xA72A', '\x8133', '\xB9ED', '\x417C', '\x3BE7', '\x7786', 
		'\x5964', '\x2', '\x15', '\x114', '\b', '\x1', '\x4', '\x2', '\t', '\x2', 
		'\x4', '\x3', '\t', '\x3', '\x4', '\x4', '\t', '\x4', '\x4', '\x5', '\t', 
		'\x5', '\x4', '\x6', '\t', '\x6', '\x4', '\a', '\t', '\a', '\x4', '\b', 
		'\t', '\b', '\x4', '\t', '\t', '\t', '\x4', '\n', '\t', '\n', '\x4', '\v', 
		'\t', '\v', '\x4', '\f', '\t', '\f', '\x4', '\r', '\t', '\r', '\x4', '\xE', 
		'\t', '\xE', '\x4', '\xF', '\t', '\xF', '\x4', '\x10', '\t', '\x10', '\x4', 
		'\x11', '\t', '\x11', '\x4', '\x12', '\t', '\x12', '\x4', '\x13', '\t', 
		'\x13', '\x4', '\x14', '\t', '\x14', '\x3', '\x2', '\x3', '\x2', '\x3', 
		'\x2', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', 
		'\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x4', '\x3', '\x4', '\x3', 
		'\x4', '\x3', '\x4', '\x3', '\x4', '\x3', '\x4', '\x3', '\x4', '\x3', 
		'\x4', '\x3', '\x4', '\x3', '\x4', '\x3', '\x5', '\x3', '\x5', '\x3', 
		'\x5', '\x3', '\x5', '\x3', '\x5', '\x3', '\x5', '\x3', '\x5', '\x3', 
		'\x5', '\x3', '\x5', '\x3', '\x5', '\x3', '\x5', '\x3', '\x5', '\x3', 
		'\x5', '\x3', '\x5', '\x3', '\x5', '\x3', '\x5', '\x3', '\x5', '\x3', 
		'\x5', '\x3', '\x5', '\x3', '\x6', '\x3', '\x6', '\x3', '\x6', '\x3', 
		'\x6', '\x3', '\x6', '\x3', '\x6', '\x3', '\x6', '\x3', '\x6', '\x3', 
		'\x6', '\x3', '\x6', '\x3', '\x6', '\x3', '\x6', '\x3', '\x6', '\x3', 
		'\x6', '\x3', '\x6', '\x3', '\a', '\x3', '\a', '\x3', '\a', '\x3', '\a', 
		'\x3', '\a', '\x3', '\a', '\x3', '\a', '\x3', '\a', '\x3', '\a', '\x3', 
		'\b', '\x3', '\b', '\x3', '\b', '\x3', '\b', '\x3', '\b', '\x3', '\b', 
		'\x3', '\b', '\x3', '\b', '\x3', '\b', '\x3', '\b', '\x3', '\b', '\x3', 
		'\b', '\x3', '\b', '\x3', '\t', '\x3', '\t', '\x3', '\t', '\x3', '\t', 
		'\x3', '\t', '\x3', '\t', '\x3', '\t', '\x3', '\t', '\x3', '\t', '\x3', 
		'\t', '\x3', '\t', '\x3', '\t', '\x3', '\n', '\x5', '\n', '\x83', '\n', 
		'\n', '\x3', '\n', '\x3', '\n', '\x3', '\n', '\x3', '\n', '\x3', '\n', 
		'\x3', '\n', '\x3', '\n', '\x3', '\n', '\x3', '\n', '\x3', '\n', '\x3', 
		'\n', '\x3', '\n', '\x3', '\n', '\x5', '\n', '\x92', '\n', '\n', '\x3', 
		'\n', '\x5', '\n', '\x95', '\n', '\n', '\x3', '\n', '\x3', '\n', '\x3', 
		'\n', '\x3', '\n', '\x3', '\n', '\x3', '\n', '\x3', '\n', '\x3', '\n', 
		'\x3', '\n', '\x3', '\n', '\x3', '\n', '\x3', '\n', '\x3', '\n', '\x3', 
		'\n', '\x5', '\n', '\xA5', '\n', '\n', '\x5', '\n', '\xA7', '\n', '\n', 
		'\x3', '\v', '\x5', '\v', '\xAA', '\n', '\v', '\x3', '\v', '\x3', '\v', 
		'\x3', '\v', '\x3', '\v', '\x3', '\v', '\x3', '\v', '\x3', '\v', '\x3', 
		'\v', '\x3', '\v', '\x3', '\v', '\x3', '\v', '\x5', '\v', '\xB7', '\n', 
		'\v', '\x3', '\v', '\x5', '\v', '\xBA', '\n', '\v', '\x3', '\v', '\x3', 
		'\v', '\x3', '\v', '\x3', '\v', '\x3', '\v', '\x3', '\v', '\x3', '\v', 
		'\x3', '\v', '\x3', '\v', '\x3', '\v', '\x3', '\v', '\x3', '\v', '\x5', 
		'\v', '\xC8', '\n', '\v', '\x5', '\v', '\xCA', '\n', '\v', '\x3', '\f', 
		'\x5', '\f', '\xCD', '\n', '\f', '\x3', '\f', '\x3', '\f', '\x3', '\f', 
		'\x3', '\f', '\x3', '\f', '\x3', '\f', '\x5', '\f', '\xD5', '\n', '\f', 
		'\x3', '\f', '\x5', '\f', '\xD8', '\n', '\f', '\x3', '\f', '\x3', '\f', 
		'\x3', '\f', '\x3', '\f', '\x3', '\f', '\x3', '\f', '\x3', '\f', '\x5', 
		'\f', '\xE1', '\n', '\f', '\x5', '\f', '\xE3', '\n', '\f', '\x3', '\r', 
		'\x5', '\r', '\xE6', '\n', '\r', '\x3', '\r', '\x3', '\r', '\x5', '\r', 
		'\xEA', '\n', '\r', '\x3', '\xE', '\x6', '\xE', '\xED', '\n', '\xE', '\r', 
		'\xE', '\xE', '\xE', '\xEE', '\x3', '\xF', '\x6', '\xF', '\xF2', '\n', 
		'\xF', '\r', '\xF', '\xE', '\xF', '\xF3', '\x3', '\xF', '\x5', '\xF', 
		'\xF7', '\n', '\xF', '\x3', '\xF', '\a', '\xF', '\xFA', '\n', '\xF', '\f', 
		'\xF', '\xE', '\xF', '\xFD', '\v', '\xF', '\x3', '\x10', '\x3', '\x10', 
		'\x3', '\x10', '\x3', '\x10', '\a', '\x10', '\x103', '\n', '\x10', '\f', 
		'\x10', '\xE', '\x10', '\x106', '\v', '\x10', '\x3', '\x11', '\x6', '\x11', 
		'\x109', '\n', '\x11', '\r', '\x11', '\xE', '\x11', '\x10A', '\x3', '\x12', 
		'\x3', '\x12', '\x3', '\x13', '\x3', '\x13', '\x3', '\x14', '\x3', '\x14', 
		'\x3', '\x14', '\x3', '\x14', '\x2', '\x2', '\x15', '\x3', '\x3', '\x5', 
		'\x4', '\a', '\x5', '\t', '\x6', '\v', '\a', '\r', '\b', '\xF', '\t', 
		'\x11', '\n', '\x13', '\v', '\x15', '\f', '\x17', '\r', '\x19', '\xE', 
		'\x1B', '\xF', '\x1D', '\x10', '\x1F', '\x11', '!', '\x12', '#', '\x13', 
		'%', '\x14', '\'', '\x15', '\x3', '\x2', '\x5', '\x3', '\x2', '\x32', 
		';', '\x5', '\x2', '\x43', '\\', '\x61', '\x61', '\x63', '|', '\x4', '\x2', 
		'\v', '\f', '\xF', '\xF', '\x2', '\x12A', '\x2', '\x3', '\x3', '\x2', 
		'\x2', '\x2', '\x2', '\x5', '\x3', '\x2', '\x2', '\x2', '\x2', '\a', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '\t', '\x3', '\x2', '\x2', '\x2', '\x2', '\v', 
		'\x3', '\x2', '\x2', '\x2', '\x2', '\r', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'\xF', '\x3', '\x2', '\x2', '\x2', '\x2', '\x11', '\x3', '\x2', '\x2', 
		'\x2', '\x2', '\x13', '\x3', '\x2', '\x2', '\x2', '\x2', '\x15', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '\x17', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'\x19', '\x3', '\x2', '\x2', '\x2', '\x2', '\x1B', '\x3', '\x2', '\x2', 
		'\x2', '\x2', '\x1D', '\x3', '\x2', '\x2', '\x2', '\x2', '\x1F', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '!', '\x3', '\x2', '\x2', '\x2', '\x2', '#', 
		'\x3', '\x2', '\x2', '\x2', '\x2', '%', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'\'', '\x3', '\x2', '\x2', '\x2', '\x3', ')', '\x3', '\x2', '\x2', '\x2', 
		'\x5', ',', '\x3', '\x2', '\x2', '\x2', '\a', '\x33', '\x3', '\x2', '\x2', 
		'\x2', '\t', '=', '\x3', '\x2', '\x2', '\x2', '\v', 'P', '\x3', '\x2', 
		'\x2', '\x2', '\r', '_', '\x3', '\x2', '\x2', '\x2', '\xF', 'h', '\x3', 
		'\x2', '\x2', '\x2', '\x11', 'u', '\x3', '\x2', '\x2', '\x2', '\x13', 
		'\xA6', '\x3', '\x2', '\x2', '\x2', '\x15', '\xC9', '\x3', '\x2', '\x2', 
		'\x2', '\x17', '\xE2', '\x3', '\x2', '\x2', '\x2', '\x19', '\xE5', '\x3', 
		'\x2', '\x2', '\x2', '\x1B', '\xEC', '\x3', '\x2', '\x2', '\x2', '\x1D', 
		'\xF1', '\x3', '\x2', '\x2', '\x2', '\x1F', '\xFE', '\x3', '\x2', '\x2', 
		'\x2', '!', '\x108', '\x3', '\x2', '\x2', '\x2', '#', '\x10C', '\x3', 
		'\x2', '\x2', '\x2', '%', '\x10E', '\x3', '\x2', '\x2', '\x2', '\'', '\x110', 
		'\x3', '\x2', '\x2', '\x2', ')', '*', '\a', '/', '\x2', '\x2', '*', '+', 
		'\a', '\"', '\x2', '\x2', '+', '\x4', '\x3', '\x2', '\x2', '\x2', ',', 
		'-', '\a', 'T', '\x2', '\x2', '-', '.', '\a', 'G', '\x2', '\x2', '.', 
		'/', '\a', '\x45', '\x2', '\x2', '/', '\x30', '\a', 'G', '\x2', '\x2', 
		'\x30', '\x31', '\a', 'V', '\x2', '\x2', '\x31', '\x32', '\a', '\x43', 
		'\x2', '\x2', '\x32', '\x6', '\x3', '\x2', '\x2', '\x2', '\x33', '\x34', 
		'\a', 'R', '\x2', '\x2', '\x34', '\x35', '\a', 'Q', '\x2', '\x2', '\x35', 
		'\x36', '\a', 'T', '\x2', '\x2', '\x36', '\x37', '\a', '\x45', '\x2', 
		'\x2', '\x37', '\x38', '\a', 'K', '\x2', '\x2', '\x38', '\x39', '\a', 
		'Q', '\x2', '\x2', '\x39', ':', '\a', 'P', '\x2', '\x2', ':', ';', '\a', 
		'G', '\x2', '\x2', ';', '<', '\a', 'U', '\x2', '\x2', '<', '\b', '\x3', 
		'\x2', '\x2', '\x2', '=', '>', '\a', 'V', '\x2', '\x2', '>', '?', '\a', 
		'K', '\x2', '\x2', '?', '@', '\a', 'G', '\x2', '\x2', '@', '\x41', '\a', 
		'O', '\x2', '\x2', '\x41', '\x42', '\a', 'R', '\x2', '\x2', '\x42', '\x43', 
		'\a', 'Q', '\x2', '\x2', '\x43', '\x44', '\a', '\"', '\x2', '\x2', '\x44', 
		'\x45', '\a', 'R', '\x2', '\x2', '\x45', '\x46', '\a', 'T', '\x2', '\x2', 
		'\x46', 'G', '\a', 'G', '\x2', '\x2', 'G', 'H', '\a', 'R', '\x2', '\x2', 
		'H', 'I', '\a', '\x43', '\x2', '\x2', 'I', 'J', '\a', 'T', '\x2', '\x2', 
		'J', 'K', '\a', '\x43', '\x2', '\x2', 'K', 'L', '\a', '\x45', '\x2', '\x2', 
		'L', 'M', '\a', 'K', '\x2', '\x2', 'M', 'N', '\a', 'Q', '\x2', '\x2', 
		'N', 'O', '\a', 'P', '\x2', '\x2', 'O', '\n', '\x3', '\x2', '\x2', '\x2', 
		'P', 'Q', '\a', 'V', '\x2', '\x2', 'Q', 'R', '\a', 'K', '\x2', '\x2', 
		'R', 'S', '\a', 'G', '\x2', '\x2', 'S', 'T', '\a', 'O', '\x2', '\x2', 
		'T', 'U', '\a', 'R', '\x2', '\x2', 'U', 'V', '\a', 'Q', '\x2', '\x2', 
		'V', 'W', '\a', '\"', '\x2', '\x2', 'W', 'X', '\a', '\x45', '\x2', '\x2', 
		'X', 'Y', '\a', 'Q', '\x2', '\x2', 'Y', 'Z', '\a', '\x45', '\x2', '\x2', 
		'Z', '[', '\a', '\x45', '\x2', '\x2', '[', '\\', '\a', 'K', '\x2', '\x2', 
		'\\', ']', '\a', 'Q', '\x2', '\x2', ']', '^', '\a', 'P', '\x2', '\x2', 
		'^', '\f', '\x3', '\x2', '\x2', '\x2', '_', '`', '\a', '\x45', '\x2', 
		'\x2', '`', '\x61', '\a', '\x43', '\x2', '\x2', '\x61', '\x62', '\a', 
		'N', '\x2', '\x2', '\x62', '\x63', '\a', 'Q', '\x2', '\x2', '\x63', '\x64', 
		'\a', 'T', '\x2', '\x2', '\x64', '\x65', '\a', 'K', '\x2', '\x2', '\x65', 
		'\x66', '\a', '\x43', '\x2', '\x2', '\x66', 'g', '\a', 'U', '\x2', '\x2', 
		'g', '\xE', '\x3', '\x2', '\x2', '\x2', 'h', 'i', '\a', 'K', '\x2', '\x2', 
		'i', 'j', '\a', 'P', '\x2', '\x2', 'j', 'k', '\a', 'I', '\x2', '\x2', 
		'k', 'l', '\a', 'T', '\x2', '\x2', 'l', 'm', '\a', 'G', '\x2', '\x2', 
		'm', 'n', '\a', '\x46', '\x2', '\x2', 'n', 'o', '\a', 'K', '\x2', '\x2', 
		'o', 'p', '\a', 'G', '\x2', '\x2', 'p', 'q', '\a', 'P', '\x2', '\x2', 
		'q', 'r', '\a', 'V', '\x2', '\x2', 'r', 's', '\a', 'G', '\x2', '\x2', 
		's', 't', '\a', 'U', '\x2', '\x2', 't', '\x10', '\x3', '\x2', '\x2', '\x2', 
		'u', 'v', '\a', 'G', '\x2', '\x2', 'v', 'w', '\a', 'N', '\x2', '\x2', 
		'w', 'x', '\a', '\x43', '\x2', '\x2', 'x', 'y', '\a', '\x44', '\x2', '\x2', 
		'y', 'z', '\a', 'Q', '\x2', '\x2', 'z', '{', '\a', 'T', '\x2', '\x2', 
		'{', '|', '\a', '\x43', '\x2', '\x2', '|', '}', '\a', '\x45', '\x2', '\x2', 
		'}', '~', '\a', 'K', '\x2', '\x2', '~', '\x7F', '\a', 'Q', '\x2', '\x2', 
		'\x7F', '\x80', '\a', 'P', '\x2', '\x2', '\x80', '\x12', '\x3', '\x2', 
		'\x2', '\x2', '\x81', '\x83', '\x5', '\x1B', '\xE', '\x2', '\x82', '\x81', 
		'\x3', '\x2', '\x2', '\x2', '\x82', '\x83', '\x3', '\x2', '\x2', '\x2', 
		'\x83', '\x84', '\x3', '\x2', '\x2', '\x2', '\x84', '\x85', '\a', '\x65', 
		'\x2', '\x2', '\x85', '\x86', '\a', 'w', '\x2', '\x2', '\x86', '\x87', 
		'\a', '\x65', '\x2', '\x2', '\x87', '\x88', '\a', 'j', '\x2', '\x2', '\x88', 
		'\x89', '\a', '\x63', '\x2', '\x2', '\x89', '\x8A', '\a', 't', '\x2', 
		'\x2', '\x8A', '\x8B', '\a', '\x63', '\x2', '\x2', '\x8B', '\x8C', '\a', 
		'\x66', '\x2', '\x2', '\x8C', '\x8D', '\a', 'k', '\x2', '\x2', '\x8D', 
		'\x8E', '\a', 'v', '\x2', '\x2', '\x8E', '\x8F', '\a', '\x63', '\x2', 
		'\x2', '\x8F', '\x91', '\x3', '\x2', '\x2', '\x2', '\x90', '\x92', '\x5', 
		'\x1B', '\xE', '\x2', '\x91', '\x90', '\x3', '\x2', '\x2', '\x2', '\x91', 
		'\x92', '\x3', '\x2', '\x2', '\x2', '\x92', '\xA7', '\x3', '\x2', '\x2', 
		'\x2', '\x93', '\x95', '\x5', '\x1B', '\xE', '\x2', '\x94', '\x93', '\x3', 
		'\x2', '\x2', '\x2', '\x94', '\x95', '\x3', '\x2', '\x2', '\x2', '\x95', 
		'\x96', '\x3', '\x2', '\x2', '\x2', '\x96', '\x97', '\a', '\x65', '\x2', 
		'\x2', '\x97', '\x98', '\a', 'w', '\x2', '\x2', '\x98', '\x99', '\a', 
		'\x65', '\x2', '\x2', '\x99', '\x9A', '\a', 'j', '\x2', '\x2', '\x9A', 
		'\x9B', '\a', '\x63', '\x2', '\x2', '\x9B', '\x9C', '\a', 't', '\x2', 
		'\x2', '\x9C', '\x9D', '\a', '\x63', '\x2', '\x2', '\x9D', '\x9E', '\a', 
		'\x66', '\x2', '\x2', '\x9E', '\x9F', '\a', 'k', '\x2', '\x2', '\x9F', 
		'\xA0', '\a', 'v', '\x2', '\x2', '\xA0', '\xA1', '\a', '\x63', '\x2', 
		'\x2', '\xA1', '\xA2', '\a', 'u', '\x2', '\x2', '\xA2', '\xA4', '\x3', 
		'\x2', '\x2', '\x2', '\xA3', '\xA5', '\x5', '\x1B', '\xE', '\x2', '\xA4', 
		'\xA3', '\x3', '\x2', '\x2', '\x2', '\xA4', '\xA5', '\x3', '\x2', '\x2', 
		'\x2', '\xA5', '\xA7', '\x3', '\x2', '\x2', '\x2', '\xA6', '\x82', '\x3', 
		'\x2', '\x2', '\x2', '\xA6', '\x94', '\x3', '\x2', '\x2', '\x2', '\xA7', 
		'\x14', '\x3', '\x2', '\x2', '\x2', '\xA8', '\xAA', '\x5', '\x1B', '\xE', 
		'\x2', '\xA9', '\xA8', '\x3', '\x2', '\x2', '\x2', '\xA9', '\xAA', '\x3', 
		'\x2', '\x2', '\x2', '\xAA', '\xAB', '\x3', '\x2', '\x2', '\x2', '\xAB', 
		'\xAC', '\a', '\x65', '\x2', '\x2', '\xAC', '\xAD', '\a', 'w', '\x2', 
		'\x2', '\xAD', '\xAE', '\a', '\x65', '\x2', '\x2', '\xAE', '\xAF', '\a', 
		'j', '\x2', '\x2', '\xAF', '\xB0', '\a', '\x63', '\x2', '\x2', '\xB0', 
		'\xB1', '\a', 't', '\x2', '\x2', '\xB1', '\xB2', '\a', '\x63', '\x2', 
		'\x2', '\xB2', '\xB3', '\a', '\x66', '\x2', '\x2', '\xB3', '\xB4', '\a', 
		'\x63', '\x2', '\x2', '\xB4', '\xB6', '\x3', '\x2', '\x2', '\x2', '\xB5', 
		'\xB7', '\x5', '\x1B', '\xE', '\x2', '\xB6', '\xB5', '\x3', '\x2', '\x2', 
		'\x2', '\xB6', '\xB7', '\x3', '\x2', '\x2', '\x2', '\xB7', '\xCA', '\x3', 
		'\x2', '\x2', '\x2', '\xB8', '\xBA', '\x5', '\x1B', '\xE', '\x2', '\xB9', 
		'\xB8', '\x3', '\x2', '\x2', '\x2', '\xB9', '\xBA', '\x3', '\x2', '\x2', 
		'\x2', '\xBA', '\xBB', '\x3', '\x2', '\x2', '\x2', '\xBB', '\xBC', '\a', 
		'\x65', '\x2', '\x2', '\xBC', '\xBD', '\a', 'w', '\x2', '\x2', '\xBD', 
		'\xBE', '\a', '\x65', '\x2', '\x2', '\xBE', '\xBF', '\a', 'j', '\x2', 
		'\x2', '\xBF', '\xC0', '\a', '\x63', '\x2', '\x2', '\xC0', '\xC1', '\a', 
		't', '\x2', '\x2', '\xC1', '\xC2', '\a', '\x63', '\x2', '\x2', '\xC2', 
		'\xC3', '\a', '\x66', '\x2', '\x2', '\xC3', '\xC4', '\a', '\x63', '\x2', 
		'\x2', '\xC4', '\xC5', '\a', 'u', '\x2', '\x2', '\xC5', '\xC7', '\x3', 
		'\x2', '\x2', '\x2', '\xC6', '\xC8', '\x5', '\x1B', '\xE', '\x2', '\xC7', 
		'\xC6', '\x3', '\x2', '\x2', '\x2', '\xC7', '\xC8', '\x3', '\x2', '\x2', 
		'\x2', '\xC8', '\xCA', '\x3', '\x2', '\x2', '\x2', '\xC9', '\xA9', '\x3', 
		'\x2', '\x2', '\x2', '\xC9', '\xB9', '\x3', '\x2', '\x2', '\x2', '\xCA', 
		'\x16', '\x3', '\x2', '\x2', '\x2', '\xCB', '\xCD', '\x5', '\x1B', '\xE', 
		'\x2', '\xCC', '\xCB', '\x3', '\x2', '\x2', '\x2', '\xCC', '\xCD', '\x3', 
		'\x2', '\x2', '\x2', '\xCD', '\xCE', '\x3', '\x2', '\x2', '\x2', '\xCE', 
		'\xCF', '\a', 'v', '\x2', '\x2', '\xCF', '\xD0', '\a', '\x63', '\x2', 
		'\x2', '\xD0', '\xD1', '\a', '|', '\x2', '\x2', '\xD1', '\xD2', '\a', 
		'\x63', '\x2', '\x2', '\xD2', '\xD4', '\x3', '\x2', '\x2', '\x2', '\xD3', 
		'\xD5', '\x5', '\x1B', '\xE', '\x2', '\xD4', '\xD3', '\x3', '\x2', '\x2', 
		'\x2', '\xD4', '\xD5', '\x3', '\x2', '\x2', '\x2', '\xD5', '\xE3', '\x3', 
		'\x2', '\x2', '\x2', '\xD6', '\xD8', '\x5', '\x1B', '\xE', '\x2', '\xD7', 
		'\xD6', '\x3', '\x2', '\x2', '\x2', '\xD7', '\xD8', '\x3', '\x2', '\x2', 
		'\x2', '\xD8', '\xD9', '\x3', '\x2', '\x2', '\x2', '\xD9', '\xDA', '\a', 
		'v', '\x2', '\x2', '\xDA', '\xDB', '\a', '\x63', '\x2', '\x2', '\xDB', 
		'\xDC', '\a', '|', '\x2', '\x2', '\xDC', '\xDD', '\a', '\x63', '\x2', 
		'\x2', '\xDD', '\xDE', '\a', 'u', '\x2', '\x2', '\xDE', '\xE0', '\x3', 
		'\x2', '\x2', '\x2', '\xDF', '\xE1', '\x5', '\x1B', '\xE', '\x2', '\xE0', 
		'\xDF', '\x3', '\x2', '\x2', '\x2', '\xE0', '\xE1', '\x3', '\x2', '\x2', 
		'\x2', '\xE1', '\xE3', '\x3', '\x2', '\x2', '\x2', '\xE2', '\xCC', '\x3', 
		'\x2', '\x2', '\x2', '\xE2', '\xD7', '\x3', '\x2', '\x2', '\x2', '\xE3', 
		'\x18', '\x3', '\x2', '\x2', '\x2', '\xE4', '\xE6', '\x5', '\x1B', '\xE', 
		'\x2', '\xE5', '\xE4', '\x3', '\x2', '\x2', '\x2', '\xE5', '\xE6', '\x3', 
		'\x2', '\x2', '\x2', '\xE6', '\xE7', '\x3', '\x2', '\x2', '\x2', '\xE7', 
		'\xE9', '\a', '<', '\x2', '\x2', '\xE8', '\xEA', '\x5', '\x1B', '\xE', 
		'\x2', '\xE9', '\xE8', '\x3', '\x2', '\x2', '\x2', '\xE9', '\xEA', '\x3', 
		'\x2', '\x2', '\x2', '\xEA', '\x1A', '\x3', '\x2', '\x2', '\x2', '\xEB', 
		'\xED', '\a', '\"', '\x2', '\x2', '\xEC', '\xEB', '\x3', '\x2', '\x2', 
		'\x2', '\xED', '\xEE', '\x3', '\x2', '\x2', '\x2', '\xEE', '\xEC', '\x3', 
		'\x2', '\x2', '\x2', '\xEE', '\xEF', '\x3', '\x2', '\x2', '\x2', '\xEF', 
		'\x1C', '\x3', '\x2', '\x2', '\x2', '\xF0', '\xF2', '\t', '\x2', '\x2', 
		'\x2', '\xF1', '\xF0', '\x3', '\x2', '\x2', '\x2', '\xF2', '\xF3', '\x3', 
		'\x2', '\x2', '\x2', '\xF3', '\xF1', '\x3', '\x2', '\x2', '\x2', '\xF3', 
		'\xF4', '\x3', '\x2', '\x2', '\x2', '\xF4', '\xF6', '\x3', '\x2', '\x2', 
		'\x2', '\xF5', '\xF7', '\a', '\x30', '\x2', '\x2', '\xF6', '\xF5', '\x3', 
		'\x2', '\x2', '\x2', '\xF6', '\xF7', '\x3', '\x2', '\x2', '\x2', '\xF7', 
		'\xFB', '\x3', '\x2', '\x2', '\x2', '\xF8', '\xFA', '\t', '\x2', '\x2', 
		'\x2', '\xF9', '\xF8', '\x3', '\x2', '\x2', '\x2', '\xFA', '\xFD', '\x3', 
		'\x2', '\x2', '\x2', '\xFB', '\xF9', '\x3', '\x2', '\x2', '\x2', '\xFB', 
		'\xFC', '\x3', '\x2', '\x2', '\x2', '\xFC', '\x1E', '\x3', '\x2', '\x2', 
		'\x2', '\xFD', '\xFB', '\x3', '\x2', '\x2', '\x2', '\xFE', '\x104', '\x5', 
		'!', '\x11', '\x2', '\xFF', '\x100', '\x5', '\x1B', '\xE', '\x2', '\x100', 
		'\x101', '\x5', '!', '\x11', '\x2', '\x101', '\x103', '\x3', '\x2', '\x2', 
		'\x2', '\x102', '\xFF', '\x3', '\x2', '\x2', '\x2', '\x103', '\x106', 
		'\x3', '\x2', '\x2', '\x2', '\x104', '\x102', '\x3', '\x2', '\x2', '\x2', 
		'\x104', '\x105', '\x3', '\x2', '\x2', '\x2', '\x105', ' ', '\x3', '\x2', 
		'\x2', '\x2', '\x106', '\x104', '\x3', '\x2', '\x2', '\x2', '\x107', '\x109', 
		'\t', '\x3', '\x2', '\x2', '\x108', '\x107', '\x3', '\x2', '\x2', '\x2', 
		'\x109', '\x10A', '\x3', '\x2', '\x2', '\x2', '\x10A', '\x108', '\x3', 
		'\x2', '\x2', '\x2', '\x10A', '\x10B', '\x3', '\x2', '\x2', '\x2', '\x10B', 
		'\"', '\x3', '\x2', '\x2', '\x2', '\x10C', '\x10D', '\a', '.', '\x2', 
		'\x2', '\x10D', '$', '\x3', '\x2', '\x2', '\x2', '\x10E', '\x10F', '\a', 
		'+', '\x2', '\x2', '\x10F', '&', '\x3', '\x2', '\x2', '\x2', '\x110', 
		'\x111', '\t', '\x4', '\x2', '\x2', '\x111', '\x112', '\x3', '\x2', '\x2', 
		'\x2', '\x112', '\x113', '\b', '\x14', '\x2', '\x2', '\x113', '(', '\x3', 
		'\x2', '\x2', '\x2', '\x1A', '\x2', '\x82', '\x91', '\x94', '\xA4', '\xA6', 
		'\xA9', '\xB6', '\xB9', '\xC7', '\xC9', '\xCC', '\xD4', '\xD7', '\xE0', 
		'\xE2', '\xE5', '\xE9', '\xEE', '\xF3', '\xF6', '\xFB', '\x104', '\x10A', 
		'\x3', '\b', '\x2', '\x2',
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);

}
