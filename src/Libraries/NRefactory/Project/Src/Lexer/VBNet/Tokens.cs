// this file was autogenerated by a tool.
using System;
using System.Collections;

namespace ICSharpCode.NRefactory.Parser.VB
{
	public static class Tokens
	{
		// ----- terminal classes -----
		public const int EOF                  = 0;
		public const int EOL                  = 1;
		public const int Identifier           = 2;
		public const int LiteralString        = 3;
		public const int LiteralCharacter     = 4;
		public const int LiteralInteger       = 5;
		public const int LiteralDouble        = 6;
		public const int LiteralSingle        = 7;
		public const int LiteralDecimal       = 8;
		public const int LiteralDate          = 9;

		// ----- special character -----
		public const int Dot                  = 10;
		public const int Assign               = 11;
		public const int Comma                = 12;
		public const int Colon                = 13;
		public const int Plus                 = 14;
		public const int Minus                = 15;
		public const int Times                = 16;
		public const int Div                  = 17;
		public const int DivInteger           = 18;
		public const int ConcatString         = 19;
		public const int Power                = 20;
		public const int QuestionMark         = 21;
		public const int ExclamationMark      = 22;
		public const int OpenCurlyBrace       = 23;
		public const int CloseCurlyBrace      = 24;
		public const int OpenParenthesis      = 25;
		public const int CloseParenthesis     = 26;
		public const int GreaterThan          = 27;
		public const int LessThan             = 28;
		public const int NotEqual             = 29;
		public const int GreaterEqual         = 30;
		public const int LessEqual            = 31;
		public const int ShiftLeft            = 32;
		public const int ShiftRight           = 33;
		public const int PlusAssign           = 34;
		public const int PowerAssign          = 35;
		public const int MinusAssign          = 36;
		public const int TimesAssign          = 37;
		public const int DivAssign            = 38;
		public const int DivIntegerAssign     = 39;
		public const int ShiftLeftAssign      = 40;
		public const int ShiftRightAssign     = 41;
		public const int ConcatStringAssign   = 42;

		// ----- keywords -----
		public const int AddHandler           = 43;
		public const int AddressOf            = 44;
		public const int Alias                = 45;
		public const int And                  = 46;
		public const int AndAlso              = 47;
		public const int Ansi                 = 48;
		public const int As                   = 49;
		public const int Assembly             = 50;
		public const int Auto                 = 51;
		public const int Binary               = 52;
		public const int Boolean              = 53;
		public const int ByRef                = 54;
		public const int Byte                 = 55;
		public const int ByVal                = 56;
		public const int Call                 = 57;
		public const int Case                 = 58;
		public const int Catch                = 59;
		public const int CBool                = 60;
		public const int CByte                = 61;
		public const int CChar                = 62;
		public const int CDate                = 63;
		public const int CDbl                 = 64;
		public const int CDec                 = 65;
		public const int Char                 = 66;
		public const int CInt                 = 67;
		public const int Class                = 68;
		public const int CLng                 = 69;
		public const int CObj                 = 70;
		public const int Compare              = 71;
		public const int Const                = 72;
		public const int CShort               = 73;
		public const int CSng                 = 74;
		public const int CStr                 = 75;
		public const int CType                = 76;
		public const int Date                 = 77;
		public const int Decimal              = 78;
		public const int Declare              = 79;
		public const int Default              = 80;
		public const int Delegate             = 81;
		public const int Dim                  = 82;
		public const int DirectCast           = 83;
		public const int Do                   = 84;
		public const int Double               = 85;
		public const int Each                 = 86;
		public const int Else                 = 87;
		public const int ElseIf               = 88;
		public const int End                  = 89;
		public const int EndIf                = 90;
		public const int Enum                 = 91;
		public const int Erase                = 92;
		public const int Error                = 93;
		public const int Event                = 94;
		public const int Exit                 = 95;
		public const int Explicit             = 96;
		public const int False                = 97;
		public const int Finally              = 98;
		public const int For                  = 99;
		public const int Friend               = 100;
		public const int Function             = 101;
		public const int Get                  = 102;
		new public const int GetType              = 103;
		public const int GoSub                = 104;
		public const int GoTo                 = 105;
		public const int Handles              = 106;
		public const int If                   = 107;
		public const int Implements           = 108;
		public const int Imports              = 109;
		public const int In                   = 110;
		public const int Inherits             = 111;
		public const int Integer              = 112;
		public const int Interface            = 113;
		public const int Is                   = 114;
		public const int Let                  = 115;
		public const int Lib                  = 116;
		public const int Like                 = 117;
		public const int Long                 = 118;
		public const int Loop                 = 119;
		public const int Me                   = 120;
		public const int Mod                  = 121;
		public const int Module               = 122;
		public const int MustInherit          = 123;
		public const int MustOverride         = 124;
		public const int MyBase               = 125;
		public const int MyClass              = 126;
		public const int Namespace            = 127;
		public const int New                  = 128;
		public const int Next                 = 129;
		public const int Not                  = 130;
		public const int Nothing              = 131;
		public const int NotInheritable       = 132;
		public const int NotOverridable       = 133;
		public const int Object               = 134;
		public const int Off                  = 135;
		public const int On                   = 136;
		public const int Option               = 137;
		public const int Optional             = 138;
		public const int Or                   = 139;
		public const int OrElse               = 140;
		public const int Overloads            = 141;
		public const int Overridable          = 142;
		public const int Overrides            = 143;
		public const int ParamArray           = 144;
		public const int Preserve             = 145;
		public const int Private              = 146;
		public const int Property             = 147;
		public const int Protected            = 148;
		public const int Public               = 149;
		public const int RaiseEvent           = 150;
		public const int ReadOnly             = 151;
		public const int ReDim                = 152;
		public const int RemoveHandler        = 153;
		public const int Resume               = 154;
		public const int Return               = 155;
		public const int Select               = 156;
		public const int Set                  = 157;
		public const int Shadows              = 158;
		public const int Shared               = 159;
		public const int Short                = 160;
		public const int Single               = 161;
		public const int Static               = 162;
		public const int Step                 = 163;
		public const int Stop                 = 164;
		public const int Strict               = 165;
		public const int String               = 166;
		public const int Structure            = 167;
		public const int Sub                  = 168;
		public const int SyncLock             = 169;
		public const int Text                 = 170;
		public const int Then                 = 171;
		public const int Throw                = 172;
		public const int To                   = 173;
		public const int True                 = 174;
		public const int Try                  = 175;
		public const int TypeOf               = 176;
		public const int Unicode              = 177;
		public const int Until                = 178;
		public const int Variant              = 179;
		public const int Wend                 = 180;
		public const int When                 = 181;
		public const int While                = 182;
		public const int With                 = 183;
		public const int WithEvents           = 184;
		public const int WriteOnly            = 185;
		public const int Xor                  = 186;
		public const int Rem                  = 187;
		public const int Continue             = 188;
		public const int Operator             = 189;
		public const int Using                = 190;
		public const int IsNot                = 191;
		public const int SByte                = 192;
		public const int UInteger             = 193;
		public const int ULong                = 194;
		public const int UShort               = 195;
		public const int CSByte               = 196;
		public const int CUShort              = 197;
		public const int CUInt                = 198;
		public const int CULng                = 199;
		public const int Global               = 200;
		public const int TryCast              = 201;
		public const int Of                   = 202;
		public const int Narrowing            = 203;
		public const int Widening             = 204;
		public const int Partial              = 205;
		public const int Custom               = 206;

		public const int MaxToken = 207;
		static BitArray NewSet(params int[] values)
		{
			BitArray bitArray = new BitArray(MaxToken);
			foreach (int val in values) {
			bitArray[val] = true;
			}
			return bitArray;
		}
		public static BitArray Null = NewSet(Nothing);
		public static BitArray BlockSucc = NewSet(Case, Catch, Else, ElseIf, End, Finally, Loop, Next);
		public static BitArray IdentifierTokens = NewSet(Text, Binary, Compare, Assembly, Ansi, Auto, Preserve, Unicode, Until, Explicit, Off);

		static string[] tokenList = new string[] {
			// ----- terminal classes -----
			"<EOF>",
			"<EOL>",
			"<Identifier>",
			"<LiteralString>",
			"<LiteralCharacter>",
			"<LiteralInteger>",
			"<LiteralDouble>",
			"<LiteralSingle>",
			"<LiteralDecimal>",
			"<LiteralDate>",
			// ----- special character -----
			".",
			"=",
			",",
			":",
			"+",
			"-",
			"*",
			"/",
			"\\",
			"&",
			"^",
			"?",
			"!",
			"{",
			"}",
			"(",
			")",
			">",
			"<",
			"<>",
			">=",
			"<=",
			"<<",
			">>",
			"+=",
			"^=",
			"-=",
			"*=",
			"/=",
			"\\=",
			"<<=",
			">>=",
			"&=",
			// ----- keywords -----
			"AddHandler",
			"AddressOf",
			"Alias",
			"And",
			"AndAlso",
			"Ansi",
			"As",
			"Assembly",
			"Auto",
			"Binary",
			"Boolean",
			"ByRef",
			"Byte",
			"ByVal",
			"Call",
			"Case",
			"Catch",
			"CBool",
			"CByte",
			"CChar",
			"CDate",
			"CDbl",
			"CDec",
			"Char",
			"CInt",
			"Class",
			"CLng",
			"CObj",
			"Compare",
			"Const",
			"CShort",
			"CSng",
			"CStr",
			"CType",
			"Date",
			"Decimal",
			"Declare",
			"Default",
			"Delegate",
			"Dim",
			"DirectCast",
			"Do",
			"Double",
			"Each",
			"Else",
			"ElseIf",
			"End",
			"EndIf",
			"Enum",
			"Erase",
			"Error",
			"Event",
			"Exit",
			"Explicit",
			"False",
			"Finally",
			"For",
			"Friend",
			"Function",
			"Get",
			"GetType",
			"GoSub",
			"GoTo",
			"Handles",
			"If",
			"Implements",
			"Imports",
			"In",
			"Inherits",
			"Integer",
			"Interface",
			"Is",
			"Let",
			"Lib",
			"Like",
			"Long",
			"Loop",
			"Me",
			"Mod",
			"Module",
			"MustInherit",
			"MustOverride",
			"MyBase",
			"MyClass",
			"Namespace",
			"New",
			"Next",
			"Not",
			"Nothing",
			"NotInheritable",
			"NotOverridable",
			"Object",
			"Off",
			"On",
			"Option",
			"Optional",
			"Or",
			"OrElse",
			"Overloads",
			"Overridable",
			"Overrides",
			"ParamArray",
			"Preserve",
			"Private",
			"Property",
			"Protected",
			"Public",
			"RaiseEvent",
			"ReadOnly",
			"ReDim",
			"RemoveHandler",
			"Resume",
			"Return",
			"Select",
			"Set",
			"Shadows",
			"Shared",
			"Short",
			"Single",
			"Static",
			"Step",
			"Stop",
			"Strict",
			"String",
			"Structure",
			"Sub",
			"SyncLock",
			"Text",
			"Then",
			"Throw",
			"To",
			"True",
			"Try",
			"TypeOf",
			"Unicode",
			"Until",
			"Variant",
			"Wend",
			"When",
			"While",
			"With",
			"WithEvents",
			"WriteOnly",
			"Xor",
			"Rem",
			"Continue",
			"Operator",
			"Using",
			"IsNot",
			"SByte",
			"UInteger",
			"ULong",
			"UShort",
			"CSByte",
			"CUShort",
			"CUInt",
			"CULng",
			"Global",
			"TryCast",
			"Of",
			"Narrowing",
			"Widening",
			"Partial",
			"Custom",
		};
		public static string GetTokenString(int token)
		{
			if (token >= 0 && token < tokenList.Length) {
				return tokenList[token];
			}
			throw new System.NotSupportedException("Unknown token:" + token);
		}
	}
}
