/******************************************************************************
*
* Name: LineBreakClass.cs
* Project: NLineBreak - .NET implementation of the Line Breaking Algorithm (http://www.unicode.org/reports/tr14/). 
* Author: Maxim Rylov
*
*********************************************************************************
*
* Copyright (C) 2008-2013, Maxim Rylov
*
* This library is free software; you can redistribute it and/or
* modify it under the terms of the GNU Lesser General Public
* License as published by the Free Software Foundation; either
* version 2.1 of the License, or (at your option) any later version.

* This library is distributed in the hope that it will be useful,
* but WITHOUT ANY WARRANTY; without even the implied warranty of
* MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
* Lesser General Public License for more details.

* You should have received a copy of the GNU Lesser General Public
* License along with this library; if not, write to the Free Software
* Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301  USA
* 
*********************************************************************************/
using System;

namespace NLineBreak
{
  /// <summary>
  /// Enumeration of Line Break Classes listed in Table 1 in Unicode Standard Annex #14 Revision 24.
  /// </summary>
  public enum LineBreakClass
  {
    # region Non-tailorable Line Breaking Classes

    /// <summary>
    /// Mandatory Break. Cause a line break (after).
    /// </summary>
    /// <example>NL, PS</example>
    BK = -1,
    /// <summary>
    /// Carriage Return. Cause a line break (after), except between CR and LF.
    /// </summary>
    /// <example>CR</example>
    CR = -2,
    /// <summary>
    /// Line Feed. Cause a line break (after).
    /// </summary>
    /// <example>LF</example>
    LF = -3,
    /// <summary>
    /// Combining Mark. Prohibit a line break between the character and the preceding character.
    /// </summary>
    /// <example>Combining marks, control codes</example>
    CM = 21,
    /// <summary>
    /// Next Line. Cause a line break (after).
    /// </summary>
    /// <example>NEL</example>
    NL = -4,
    /// <summary>
    /// Surrogate. Do not occur in well-formed text.
    /// </summary>
    /// <example>Surrogates</example>
    SG = -5,
    /// <summary>
    /// Word Joiner. Prohibit line breaks before and after.
    /// </summary>
    /// <example>WJ</example>
    WJ = 22,
    /// <summary>
    /// Zero Width Space. Provide a break opportunity
    /// </summary>
    /// <example>ZWSP</example>
    ZW = 20,
    /// <summary>
    /// Non-breaking (“Glue”). Prohibit line breaks before and after.
    /// </summary>
    /// <example>CGJ, NBSP, ZWNBSP</example>
    GL = 4,
    /// <summary>
    /// Space. Enable indirect line breaks.
    /// </summary>
    /// <example>SPACE</example>
    SP = -6,

    #endregion

    #region Break Opportunities

    /// <summary>
    /// Break Opportunity Before and After. Provide a line break opportunity before and after the character.
    /// </summary>
    /// <example>Em dash</example>
    B2 = 19,
    /// <summary>
    /// Break After. Generally provide a line break opportunity after the character.
    /// </summary>
    /// <example>Spaces, hyphens</example>
    BA = 17,
    /// <summary>
    /// Break Before. Generally provide a line break opportunity before the character.
    /// </summary>
    /// <example>Punctuation used in dictionaries</example>
    BB = 18,
    /// <summary>
    /// Hyphen. Provide a line break opportunity after the character, except in numeric context.
    /// </summary>
    /// <example>HYPHEN-MINUS</example>
    HY = 16,
    /// <summary>
    /// Contingent Break Opportunity. Provide a line break opportunity contingent on additional information.
    /// </summary>
    /// <example>Inline objects</example>
    CB = -7,

    #endregion

    #region Characters Prohibiting Certain Breaks

    /// <summary>
    /// Close Punctuation. Prohibit line breaks before.
    /// </summary>
    /// <example>“}”, “)”, “))” etc.</example>
    CL = 1,
    /// <summary>
    /// Close Parenthesis. Prohibit line breaks before.
    /// </summary>
    /// <example>“)”, “]”</example>
    CP = 2,
    /// <summary>
    /// Exclamation/Interrogation. Prohibit line breaks before.
    /// </summary>
    /// <example>“!”, “?”, etc.</example>
    EX = 6,
    /// <summary>
    /// Inseparable. Allow only indirect line breaks between pairs.
    /// </summary>
    /// <example>Leaders</example>
    IN = 15,
    /// <summary>
    /// Nonstarter. Allow only indirect line breaks before.
    /// </summary>
    /// <example>small kana</example>
    NS = 5,
    /// <summary>
    /// Open Punctuation. Prohibit line breaks after.
    /// </summary>
    /// <example>“(“, “[“, “{“, etc.</example>
    OP = 0,
    /// <summary>
    /// Quotation. Act like they are both opening and closing.
    /// </summary>
    /// <example>Quotation marks</example>
    QU = 3,

    #endregion

    #region Numeric Context

    /// <summary>
    /// Infix Numeric Separator. Prevent breaks after any and before numeric.
    /// </summary>
    /// <example>.</example>
    IS = 8,
    /// <summary>
    /// Numeric. Form numeric expressions for line breaking purposes.
    /// </summary>
    /// <example>Digits</example>
    NU = 11,
    /// <summary>
    /// Postfix Numeric. Do not break following a numeric expression.
    /// </summary>
    /// <example>%, ¢</example>
    PO = 10,
    /// <summary>
    /// Prefix Numeric. Do not break in front of a numeric expression.
    /// </summary>
    /// <example>$, £, ¥, etc.</example>
    PR = 9,
    /// <summary>
    /// Symbols Allowing Break After. Prevent a break before, and allow a break after.
    /// </summary>
    /// <example>/</example>
    SY = 7,

    #endregion

    #region Other Characters

    /// <summary>
    /// Ambiguous (Alphabetic or Ideographic). Act like AL when the resolved EAW is N; otherwise, act as ID.
    /// </summary>
    /// <example>Characters with Ambiguous East Asian Width</example>
    AI = -8,
    /// <summary>
    /// Alphabetic. Are alphabetic characters or symbols that are used with alphabetic characters.
    /// </summary>
    /// <example>Alphabets and regular symbols</example>
    AL = 12,
    /// <summary>
    /// Hebrew letters
    /// </summary>
    HL = 13,
    /// <summary>
    /// Hangul LV Syllable. Form Korean syllable blocks.
    /// </summary>
    /// <example>Hangul</example>
    H2 = 23,
    /// <summary>
    /// Hangul LVT Syllable. Form Korean syllable blocks.
    /// </summary>
    /// <example>Hangul</example>
    H3 = 24,
    /// <summary>
    /// Ideographic. Break before or after, except in some numeric context.
    /// </summary>
    /// <example>Ideographs</example>
    ID = 14,
    /// <summary>
    /// Hangul L Jamo. Form Korean syllable blocks.
    /// </summary>
    /// <example>Conjoining jamo</example>
    JL = 25,
    /// <summary>
    /// Hangul V Jamo. Form Korean syllable blocks.
    /// </summary>
    ///<example>Conjoining jamo</example>
    JV = 26,
    /// <summary>
    /// Hangul T Jamo. Form Korean syllable blocks.
    /// </summary>
    /// <example>Conjoining jamo</example>
    JT = 27,
    /// <summary>
    /// Regional Indicator
    /// </summary>
    RI = 28, 
    /// <summary>
    /// Complex Context Dependent (South East Asian). Provide a line break opportunity contingent on additional, language-specific context analysis.
    /// </summary>
    /// <example>South East Asian: Thai, Lao, Khmer</example>
    SA = -9,
    /// <summary>
    /// Conditional Japanese Starter 	Small kana 	Treat as NS or ID for strict or normal breaking.
    /// </summary>
    CJ =  - 10,
    /// <summary>
    /// Unknown. Have as yet unknown line breaking behavior or unassigned code positions.
    /// </summary>
    /// <example>Most unassigned, private-use</example>
    XX = -11,

    #endregion

    Undefined = -100
  }
}
