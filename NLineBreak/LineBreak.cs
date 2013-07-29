/******************************************************************************
*
* Name: LineBreak.cs
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
using System.Collections.Generic;
using System.Globalization;

namespace NLineBreak
{
  public class LineBreak
  {
    #region --------------- Fields ---------------

    private static Dictionary<string, LineBreakProperties> m_cultureLBProps;
    private static LineBreakAction[,] BREAK_PAIR_TABLE;

    private ClassProperties<LineBreakClass> m_defaultLineBreakProps;

    [ThreadStatic]
    private static LineBreak m_default;

    #endregion ---------------------------------------------

    #region --------------- Events ---------------

    /// <summary>
    /// Occurs when line break class need to be resolved.
    /// </summary>
    public event LineBreakClassResolveEventHandler LineBreakClassResolve;
    /// <summary>
    /// Occurs when line break opportunity was found.
    /// </summary>
    public event LineBreakEventHandler LineBreakFound;

    #endregion ---------------------------------------------

    #region --------------- Constructors ---------------

    static LineBreak()
    {
      m_cultureLBProps = new Dictionary<string, LineBreakProperties>();

      int OP = (int)LineBreakClass.OP;
      int CL = (int)LineBreakClass.CL;
      int CP = (int)LineBreakClass.CP;
      int QU = (int)LineBreakClass.QU;
      int GL = (int)LineBreakClass.GL;
      int NS = (int)LineBreakClass.NS;
      int EX = (int)LineBreakClass.EX;
      int SY = (int)LineBreakClass.SY;
      int IS = (int)LineBreakClass.IS;
      int PR = (int)LineBreakClass.PR;
      int PO = (int)LineBreakClass.PO;
      int NU = (int)LineBreakClass.NU;
      int AL = (int)LineBreakClass.AL;
      int HL = (int)LineBreakClass.HL;
      int ID = (int)LineBreakClass.ID;
      int IN = (int)LineBreakClass.IN;
      int HY = (int)LineBreakClass.HY;
      int BA = (int)LineBreakClass.BA;
      int BB = (int)LineBreakClass.BB;
      int B2 = (int)LineBreakClass.B2;
      int ZW = (int)LineBreakClass.ZW;
      int CM = (int)LineBreakClass.CM;
      int WJ = (int)LineBreakClass.WJ;
      int H2 = (int)LineBreakClass.H2;
      int H3 = (int)LineBreakClass.H3;
      int JL = (int)LineBreakClass.JL;
      int JV = (int)LineBreakClass.JV;
      int JT = (int)LineBreakClass.JT;
      int RI = (int)LineBreakClass.RI;


      BREAK_PAIR_TABLE = new LineBreakAction[29, 29];
      // OP
      BREAK_PAIR_TABLE[OP, OP] = LineBreakAction.Prohibited;
      BREAK_PAIR_TABLE[OP, CL] = LineBreakAction.Prohibited;
      BREAK_PAIR_TABLE[OP, CP] = LineBreakAction.Prohibited;
      BREAK_PAIR_TABLE[OP, QU] = LineBreakAction.Prohibited;
      BREAK_PAIR_TABLE[OP, GL] = LineBreakAction.Prohibited;
      BREAK_PAIR_TABLE[OP, NS] = LineBreakAction.Prohibited;
      BREAK_PAIR_TABLE[OP, EX] = LineBreakAction.Prohibited;
      BREAK_PAIR_TABLE[OP, SY] = LineBreakAction.Prohibited;
      BREAK_PAIR_TABLE[OP, IS] = LineBreakAction.Prohibited;
      BREAK_PAIR_TABLE[OP, PR] = LineBreakAction.Prohibited;
      BREAK_PAIR_TABLE[OP, PO] = LineBreakAction.Prohibited;
      BREAK_PAIR_TABLE[OP, NU] = LineBreakAction.Prohibited;
      BREAK_PAIR_TABLE[OP, AL] = LineBreakAction.Prohibited;
      BREAK_PAIR_TABLE[OP, HL] = LineBreakAction.Prohibited;
      BREAK_PAIR_TABLE[OP, ID] = LineBreakAction.Prohibited;
      BREAK_PAIR_TABLE[OP, IN] = LineBreakAction.Prohibited;
      BREAK_PAIR_TABLE[OP, HY] = LineBreakAction.Prohibited;
      BREAK_PAIR_TABLE[OP, BA] = LineBreakAction.Prohibited;
      BREAK_PAIR_TABLE[OP, BB] = LineBreakAction.Prohibited;
      BREAK_PAIR_TABLE[OP, B2] = LineBreakAction.Prohibited;
      BREAK_PAIR_TABLE[OP, ZW] = LineBreakAction.CombiningProhibited;
      BREAK_PAIR_TABLE[OP, CM] = LineBreakAction.Prohibited;
      BREAK_PAIR_TABLE[OP, WJ] = LineBreakAction.Prohibited;
      BREAK_PAIR_TABLE[OP, H2] = LineBreakAction.Prohibited;
      BREAK_PAIR_TABLE[OP, H3] = LineBreakAction.Prohibited;
      BREAK_PAIR_TABLE[OP, JL] = LineBreakAction.Prohibited;
      BREAK_PAIR_TABLE[OP, JV] = LineBreakAction.Prohibited;
      BREAK_PAIR_TABLE[OP, JT] = LineBreakAction.Prohibited;
      BREAK_PAIR_TABLE[OP, RI] = LineBreakAction.Prohibited;
      // CL
      BREAK_PAIR_TABLE[CL, CL] = LineBreakAction.Prohibited;
      BREAK_PAIR_TABLE[CL, CP] = LineBreakAction.Prohibited;
      BREAK_PAIR_TABLE[CL, QU] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[CL, GL] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[CL, NS] = LineBreakAction.Prohibited;
      BREAK_PAIR_TABLE[CL, EX] = LineBreakAction.Prohibited;
      BREAK_PAIR_TABLE[CL, SY] = LineBreakAction.Prohibited;
      BREAK_PAIR_TABLE[CL, IS] = LineBreakAction.Prohibited;
      BREAK_PAIR_TABLE[CL, PR] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[CL, PO] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[CL, HY] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[CL, BA] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[CL, ZW] = LineBreakAction.Prohibited;
      BREAK_PAIR_TABLE[CL, CM] = LineBreakAction.CombiningIndirect;
      BREAK_PAIR_TABLE[CL, WJ] = LineBreakAction.Prohibited;
      // CP
      BREAK_PAIR_TABLE[CP, CL] = LineBreakAction.Prohibited;
      BREAK_PAIR_TABLE[CP, CP] = LineBreakAction.Prohibited;
      BREAK_PAIR_TABLE[CP, QU] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[CP, GL] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[CP, NS] = LineBreakAction.Prohibited;
      BREAK_PAIR_TABLE[CP, EX] = LineBreakAction.Prohibited;
      BREAK_PAIR_TABLE[CP, SY] = LineBreakAction.Prohibited;
      BREAK_PAIR_TABLE[CP, IS] = LineBreakAction.Prohibited;
      BREAK_PAIR_TABLE[CP, PR] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[CP, PO] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[CP, NU] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[CP, AL] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[CP, HL] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[CP, HY] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[CP, BA] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[CP, ZW] = LineBreakAction.Prohibited;
      BREAK_PAIR_TABLE[CP, CM] = LineBreakAction.CombiningIndirect;
      BREAK_PAIR_TABLE[CP, WJ] = LineBreakAction.Prohibited;
      // QU
      BREAK_PAIR_TABLE[QU, OP] = LineBreakAction.Prohibited;
      BREAK_PAIR_TABLE[QU, CL] = LineBreakAction.Prohibited;
      BREAK_PAIR_TABLE[QU, CP] = LineBreakAction.Prohibited;
      BREAK_PAIR_TABLE[QU, QU] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[QU, GL] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[QU, NS] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[QU, EX] = LineBreakAction.Prohibited;
      BREAK_PAIR_TABLE[QU, SY] = LineBreakAction.Prohibited;
      BREAK_PAIR_TABLE[QU, IS] = LineBreakAction.Prohibited;
      BREAK_PAIR_TABLE[QU, PR] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[QU, PO] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[QU, NU] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[QU, AL] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[QU, HL] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[QU, ID] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[QU, IN] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[QU, HY] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[QU, BA] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[QU, BB] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[QU, B2] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[QU, ZW] = LineBreakAction.Prohibited;
      BREAK_PAIR_TABLE[QU, CM] = LineBreakAction.CombiningIndirect;
      BREAK_PAIR_TABLE[QU, WJ] = LineBreakAction.Prohibited;
      BREAK_PAIR_TABLE[QU, H2] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[QU, H3] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[QU, JL] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[QU, JV] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[QU, JT] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[QU, RI] = LineBreakAction.Indirect;
      // GL
      BREAK_PAIR_TABLE[GL, OP] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[GL, CL] = LineBreakAction.Prohibited;
      BREAK_PAIR_TABLE[GL, CP] = LineBreakAction.Prohibited;
      BREAK_PAIR_TABLE[GL, QU] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[GL, GL] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[GL, NS] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[GL, EX] = LineBreakAction.Prohibited;
      BREAK_PAIR_TABLE[GL, SY] = LineBreakAction.Prohibited;
      BREAK_PAIR_TABLE[GL, IS] = LineBreakAction.Prohibited;
      BREAK_PAIR_TABLE[GL, PR] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[GL, PO] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[GL, NU] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[GL, AL] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[GL, HL] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[GL, ID] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[GL, IN] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[GL, HY] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[GL, BA] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[GL, BB] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[GL, B2] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[GL, ZW] = LineBreakAction.Prohibited;
      BREAK_PAIR_TABLE[GL, CM] = LineBreakAction.CombiningIndirect;
      BREAK_PAIR_TABLE[GL, WJ] = LineBreakAction.Prohibited;
      BREAK_PAIR_TABLE[GL, H2] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[GL, H3] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[GL, JL] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[GL, JV] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[GL, JT] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[GL, RI] = LineBreakAction.Indirect;
      // NS 
      BREAK_PAIR_TABLE[NS, CL] = LineBreakAction.Prohibited;
      BREAK_PAIR_TABLE[NS, CP] = LineBreakAction.Prohibited;
      BREAK_PAIR_TABLE[NS, QU] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[NS, GL] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[NS, NS] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[NS, EX] = LineBreakAction.Prohibited;
      BREAK_PAIR_TABLE[NS, SY] = LineBreakAction.Prohibited;
      BREAK_PAIR_TABLE[NS, IS] = LineBreakAction.Prohibited;
      BREAK_PAIR_TABLE[NS, HY] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[NS, BA] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[NS, ZW] = LineBreakAction.Prohibited;
      BREAK_PAIR_TABLE[NS, CM] = LineBreakAction.CombiningIndirect;
      BREAK_PAIR_TABLE[NS, WJ] = LineBreakAction.Prohibited;
      // EX
      BREAK_PAIR_TABLE[EX, CL] = LineBreakAction.Prohibited;
      BREAK_PAIR_TABLE[EX, CP] = LineBreakAction.Prohibited;
      BREAK_PAIR_TABLE[EX, QU] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[EX, GL] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[EX, NS] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[EX, EX] = LineBreakAction.Prohibited;
      BREAK_PAIR_TABLE[EX, SY] = LineBreakAction.Prohibited;
      BREAK_PAIR_TABLE[EX, IS] = LineBreakAction.Prohibited;
      BREAK_PAIR_TABLE[EX, HY] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[EX, BA] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[EX, ZW] = LineBreakAction.Prohibited;
      BREAK_PAIR_TABLE[EX, CM] = LineBreakAction.CombiningIndirect;
      BREAK_PAIR_TABLE[EX, WJ] = LineBreakAction.Prohibited;
      // SY
      BREAK_PAIR_TABLE[SY, CL] = LineBreakAction.Prohibited;
      BREAK_PAIR_TABLE[SY, CP] = LineBreakAction.Prohibited;
      BREAK_PAIR_TABLE[SY, QU] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[SY, GL] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[SY, NS] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[SY, EX] = LineBreakAction.Prohibited;
      BREAK_PAIR_TABLE[SY, SY] = LineBreakAction.Prohibited;
      BREAK_PAIR_TABLE[SY, IS] = LineBreakAction.Prohibited;
      BREAK_PAIR_TABLE[SY, NU] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[SY, HY] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[SY, BA] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[SY, ZW] = LineBreakAction.Prohibited;
      BREAK_PAIR_TABLE[SY, CM] = LineBreakAction.CombiningIndirect;
      BREAK_PAIR_TABLE[SY, WJ] = LineBreakAction.Prohibited;
      // IS
      BREAK_PAIR_TABLE[IS, CL] = LineBreakAction.Prohibited;
      BREAK_PAIR_TABLE[IS, CP] = LineBreakAction.Prohibited;
      BREAK_PAIR_TABLE[IS, QU] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[IS, GL] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[IS, NS] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[IS, EX] = LineBreakAction.Prohibited;
      BREAK_PAIR_TABLE[IS, SY] = LineBreakAction.Prohibited;
      BREAK_PAIR_TABLE[IS, IS] = LineBreakAction.Prohibited;
      BREAK_PAIR_TABLE[IS, NU] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[IS, AL] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[IS, HL] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[IS, HY] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[IS, BA] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[IS, ZW] = LineBreakAction.Prohibited;
      BREAK_PAIR_TABLE[IS, CM] = LineBreakAction.CombiningIndirect;
      BREAK_PAIR_TABLE[IS, WJ] = LineBreakAction.Prohibited;
      // PR
      BREAK_PAIR_TABLE[PR, OP] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[PR, CL] = LineBreakAction.Prohibited;
      BREAK_PAIR_TABLE[PR, CP] = LineBreakAction.Prohibited;
      BREAK_PAIR_TABLE[PR, QU] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[PR, GL] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[PR, NS] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[PR, EX] = LineBreakAction.Prohibited;
      BREAK_PAIR_TABLE[PR, SY] = LineBreakAction.Prohibited;
      BREAK_PAIR_TABLE[PR, IS] = LineBreakAction.Prohibited;
      BREAK_PAIR_TABLE[PR, NU] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[PR, AL] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[PR, HL] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[PR, ID] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[PR, HY] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[PR, BA] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[PR, ZW] = LineBreakAction.Prohibited;
      BREAK_PAIR_TABLE[PR, CM] = LineBreakAction.CombiningIndirect;
      BREAK_PAIR_TABLE[PR, WJ] = LineBreakAction.Prohibited;
      BREAK_PAIR_TABLE[PR, H2] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[PR, H3] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[PR, JL] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[PR, JV] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[PR, JT] = LineBreakAction.Indirect;
      // PO
      BREAK_PAIR_TABLE[PO, OP] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[PO, CL] = LineBreakAction.Prohibited;
      BREAK_PAIR_TABLE[PO, CP] = LineBreakAction.Prohibited;
      BREAK_PAIR_TABLE[PO, QU] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[PO, GL] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[PO, NS] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[PO, EX] = LineBreakAction.Prohibited;
      BREAK_PAIR_TABLE[PO, SY] = LineBreakAction.Prohibited;
      BREAK_PAIR_TABLE[PO, IS] = LineBreakAction.Prohibited;
      BREAK_PAIR_TABLE[PO, NU] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[PO, AL] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[PO, HL] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[PO, HY] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[PO, BA] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[PO, ZW] = LineBreakAction.Prohibited;
      BREAK_PAIR_TABLE[PO, CM] = LineBreakAction.CombiningIndirect;
      BREAK_PAIR_TABLE[PO, WJ] = LineBreakAction.Prohibited;
      // NU
      BREAK_PAIR_TABLE[NU, OP] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[NU, CL] = LineBreakAction.Prohibited;
      BREAK_PAIR_TABLE[NU, CP] = LineBreakAction.Prohibited;
      BREAK_PAIR_TABLE[NU, QU] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[NU, GL] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[NU, NS] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[NU, EX] = LineBreakAction.Prohibited;
      BREAK_PAIR_TABLE[NU, SY] = LineBreakAction.Prohibited;
      BREAK_PAIR_TABLE[NU, IS] = LineBreakAction.Prohibited;
      BREAK_PAIR_TABLE[NU, PR] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[NU, PO] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[NU, NU] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[NU, AL] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[NU, HL] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[NU, IN] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[NU, HY] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[NU, BA] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[NU, ZW] = LineBreakAction.Prohibited;
      BREAK_PAIR_TABLE[NU, CM] = LineBreakAction.CombiningIndirect;
      BREAK_PAIR_TABLE[NU, WJ] = LineBreakAction.Prohibited;
      // AL
      BREAK_PAIR_TABLE[AL, OP] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[AL, CL] = LineBreakAction.Prohibited;
      BREAK_PAIR_TABLE[AL, CP] = LineBreakAction.Prohibited;
      BREAK_PAIR_TABLE[AL, QU] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[AL, GL] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[AL, NS] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[AL, EX] = LineBreakAction.Prohibited;
      BREAK_PAIR_TABLE[AL, SY] = LineBreakAction.Prohibited;
      BREAK_PAIR_TABLE[AL, IS] = LineBreakAction.Prohibited;
      BREAK_PAIR_TABLE[AL, NU] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[AL, AL] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[AL, HL] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[AL, IN] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[AL, HY] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[AL, BA] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[AL, ZW] = LineBreakAction.Prohibited;
      BREAK_PAIR_TABLE[AL, CM] = LineBreakAction.CombiningIndirect;
      BREAK_PAIR_TABLE[AL, WJ] = LineBreakAction.Prohibited;
      // HL
      BREAK_PAIR_TABLE[HL, OP] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[HL, CL] = LineBreakAction.Prohibited;
      BREAK_PAIR_TABLE[HL, CP] = LineBreakAction.Prohibited;
      BREAK_PAIR_TABLE[HL, QU] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[HL, GL] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[HL, NS] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[HL, EX] = LineBreakAction.Prohibited;
      BREAK_PAIR_TABLE[HL, SY] = LineBreakAction.Prohibited;
      BREAK_PAIR_TABLE[HL, IS] = LineBreakAction.Prohibited;
      BREAK_PAIR_TABLE[HL, NU] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[HL, AL] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[HL, HL] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[HL, IN] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[HL, HY] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[HL, BA] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[HL, ZW] = LineBreakAction.Prohibited;
      BREAK_PAIR_TABLE[HL, CM] = LineBreakAction.CombiningIndirect;
      BREAK_PAIR_TABLE[HL, WJ] = LineBreakAction.Prohibited;
      // ID
      BREAK_PAIR_TABLE[ID, CL] = LineBreakAction.Prohibited;
      BREAK_PAIR_TABLE[ID, CP] = LineBreakAction.Prohibited;
      BREAK_PAIR_TABLE[ID, QU] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[ID, GL] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[ID, NS] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[ID, EX] = LineBreakAction.Prohibited;
      BREAK_PAIR_TABLE[ID, SY] = LineBreakAction.Prohibited;
      BREAK_PAIR_TABLE[ID, IS] = LineBreakAction.Prohibited;
      BREAK_PAIR_TABLE[ID, PO] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[ID, IN] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[ID, HY] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[ID, BA] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[ID, ZW] = LineBreakAction.Prohibited;
      BREAK_PAIR_TABLE[ID, CM] = LineBreakAction.CombiningIndirect;
      BREAK_PAIR_TABLE[ID, WJ] = LineBreakAction.Prohibited;
      // IN
      BREAK_PAIR_TABLE[IN, CL] = LineBreakAction.Prohibited;
      BREAK_PAIR_TABLE[IN, CP] = LineBreakAction.Prohibited;
      BREAK_PAIR_TABLE[IN, QU] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[IN, GL] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[IN, NS] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[IN, EX] = LineBreakAction.Prohibited;
      BREAK_PAIR_TABLE[IN, SY] = LineBreakAction.Prohibited;
      BREAK_PAIR_TABLE[IN, IS] = LineBreakAction.Prohibited;
      BREAK_PAIR_TABLE[IN, IN] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[IN, HY] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[IN, BA] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[IN, ZW] = LineBreakAction.Prohibited;
      BREAK_PAIR_TABLE[IN, CM] = LineBreakAction.CombiningIndirect;
      BREAK_PAIR_TABLE[IN, WJ] = LineBreakAction.Prohibited;
      // HY
      BREAK_PAIR_TABLE[HY, CL] = LineBreakAction.Prohibited;
      BREAK_PAIR_TABLE[HY, CP] = LineBreakAction.Prohibited;
      BREAK_PAIR_TABLE[HY, QU] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[HY, NS] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[HY, EX] = LineBreakAction.Prohibited;
      BREAK_PAIR_TABLE[HY, SY] = LineBreakAction.Prohibited;
      BREAK_PAIR_TABLE[HY, IS] = LineBreakAction.Prohibited;
      BREAK_PAIR_TABLE[HY, NU] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[HY, HY] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[HY, BA] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[HY, ZW] = LineBreakAction.Prohibited;
      BREAK_PAIR_TABLE[HY, CM] = LineBreakAction.CombiningIndirect;
      BREAK_PAIR_TABLE[HY, WJ] = LineBreakAction.Prohibited;
      // BA
      BREAK_PAIR_TABLE[BA, CL] = LineBreakAction.Prohibited;
      BREAK_PAIR_TABLE[BA, CP] = LineBreakAction.Prohibited;
      BREAK_PAIR_TABLE[BA, QU] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[BA, NS] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[BA, EX] = LineBreakAction.Prohibited;
      BREAK_PAIR_TABLE[BA, SY] = LineBreakAction.Prohibited;
      BREAK_PAIR_TABLE[BA, IS] = LineBreakAction.Prohibited;
      BREAK_PAIR_TABLE[BA, HY] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[BA, BA] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[BA, ZW] = LineBreakAction.Prohibited;
      BREAK_PAIR_TABLE[BA, CM] = LineBreakAction.CombiningIndirect;
      BREAK_PAIR_TABLE[BA, WJ] = LineBreakAction.Prohibited;
      // BB
      BREAK_PAIR_TABLE[BB, OP] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[BB, CL] = LineBreakAction.Prohibited;
      BREAK_PAIR_TABLE[BB, CP] = LineBreakAction.Prohibited;
      BREAK_PAIR_TABLE[BB, QU] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[BB, GL] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[BB, NS] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[BB, EX] = LineBreakAction.Prohibited;
      BREAK_PAIR_TABLE[BB, SY] = LineBreakAction.Prohibited;
      BREAK_PAIR_TABLE[BB, IS] = LineBreakAction.Prohibited;
      BREAK_PAIR_TABLE[BB, PR] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[BB, PO] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[BB, NU] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[BB, AL] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[BB, HL] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[BB, ID] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[BB, IN] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[BB, HY] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[BB, BA] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[BB, BB] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[BB, B2] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[BB, ZW] = LineBreakAction.Prohibited;
      BREAK_PAIR_TABLE[BB, CM] = LineBreakAction.CombiningIndirect;
      BREAK_PAIR_TABLE[BB, WJ] = LineBreakAction.Prohibited;
      BREAK_PAIR_TABLE[BB, H2] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[BB, H3] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[BB, JL] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[BB, JV] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[BB, JT] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[BB, RI] = LineBreakAction.Indirect;
      // B2
      BREAK_PAIR_TABLE[B2, CL] = LineBreakAction.Prohibited;
      BREAK_PAIR_TABLE[B2, CP] = LineBreakAction.Prohibited;
      BREAK_PAIR_TABLE[B2, QU] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[B2, GL] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[B2, NS] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[B2, EX] = LineBreakAction.Prohibited;
      BREAK_PAIR_TABLE[B2, SY] = LineBreakAction.Prohibited;
      BREAK_PAIR_TABLE[B2, IS] = LineBreakAction.Prohibited;
      BREAK_PAIR_TABLE[B2, HY] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[B2, BA] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[B2, B2] = LineBreakAction.Prohibited;
      BREAK_PAIR_TABLE[B2, ZW] = LineBreakAction.Prohibited;
      BREAK_PAIR_TABLE[B2, CM] = LineBreakAction.CombiningIndirect;
      BREAK_PAIR_TABLE[B2, WJ] = LineBreakAction.Prohibited;
      // ZW
      BREAK_PAIR_TABLE[ZW, ZW] = LineBreakAction.Prohibited;
      // CM
      BREAK_PAIR_TABLE[CM, OP] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[CM, CL] = LineBreakAction.Prohibited;
      BREAK_PAIR_TABLE[CM, CP] = LineBreakAction.Prohibited;
      BREAK_PAIR_TABLE[CM, QU] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[CM, GL] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[CM, NS] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[CM, EX] = LineBreakAction.Prohibited;
      BREAK_PAIR_TABLE[CM, SY] = LineBreakAction.Prohibited;
      BREAK_PAIR_TABLE[CM, IS] = LineBreakAction.Prohibited;
      BREAK_PAIR_TABLE[CM, NU] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[CM, AL] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[CM, HL] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[CM, IN] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[CM, HY] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[CM, BA] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[CM, ZW] = LineBreakAction.Prohibited;
      BREAK_PAIR_TABLE[CM, CM] = LineBreakAction.CombiningIndirect;
      BREAK_PAIR_TABLE[CM, WJ] = LineBreakAction.Prohibited;
      // WJ
      BREAK_PAIR_TABLE[WJ, OP] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[WJ, CL] = LineBreakAction.Prohibited;
      BREAK_PAIR_TABLE[WJ, CP] = LineBreakAction.Prohibited;
      BREAK_PAIR_TABLE[WJ, QU] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[WJ, GL] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[WJ, NS] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[WJ, EX] = LineBreakAction.Prohibited;
      BREAK_PAIR_TABLE[WJ, SY] = LineBreakAction.Prohibited;
      BREAK_PAIR_TABLE[WJ, IS] = LineBreakAction.Prohibited;
      BREAK_PAIR_TABLE[WJ, PR] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[WJ, PO] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[WJ, NU] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[WJ, AL] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[WJ, HL] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[WJ, ID] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[WJ, IN] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[WJ, HY] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[WJ, BA] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[WJ, BB] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[WJ, B2] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[WJ, ZW] = LineBreakAction.Prohibited;
      BREAK_PAIR_TABLE[WJ, CM] = LineBreakAction.CombiningIndirect;
      BREAK_PAIR_TABLE[WJ, WJ] = LineBreakAction.Prohibited;
      BREAK_PAIR_TABLE[WJ, H2] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[WJ, H3] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[WJ, JL] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[WJ, JV] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[WJ, JT] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[WJ, RI] = LineBreakAction.Indirect;
      // H2
      BREAK_PAIR_TABLE[H2, CL] = LineBreakAction.Prohibited;
      BREAK_PAIR_TABLE[H2, CP] = LineBreakAction.Prohibited;
      BREAK_PAIR_TABLE[H2, QU] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[H2, GL] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[H2, NS] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[H2, EX] = LineBreakAction.Prohibited;
      BREAK_PAIR_TABLE[H2, SY] = LineBreakAction.Prohibited;
      BREAK_PAIR_TABLE[H2, IS] = LineBreakAction.Prohibited;
      BREAK_PAIR_TABLE[H2, PO] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[H2, IN] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[H2, HY] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[H2, BA] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[H2, ZW] = LineBreakAction.Prohibited;
      BREAK_PAIR_TABLE[H2, CM] = LineBreakAction.CombiningIndirect;
      BREAK_PAIR_TABLE[H2, WJ] = LineBreakAction.Prohibited;
      BREAK_PAIR_TABLE[H2, JV] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[H2, JT] = LineBreakAction.Indirect;
      // H3
      BREAK_PAIR_TABLE[H3, CL] = LineBreakAction.Prohibited;
      BREAK_PAIR_TABLE[H3, CP] = LineBreakAction.Prohibited;
      BREAK_PAIR_TABLE[H3, QU] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[H3, GL] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[H3, NS] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[H3, EX] = LineBreakAction.Prohibited;
      BREAK_PAIR_TABLE[H3, SY] = LineBreakAction.Prohibited;
      BREAK_PAIR_TABLE[H3, IS] = LineBreakAction.Prohibited;
      BREAK_PAIR_TABLE[H3, PO] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[H3, IN] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[H3, HY] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[H3, BA] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[H3, ZW] = LineBreakAction.Prohibited;
      BREAK_PAIR_TABLE[H3, CM] = LineBreakAction.CombiningIndirect;
      BREAK_PAIR_TABLE[H3, WJ] = LineBreakAction.Prohibited;
      BREAK_PAIR_TABLE[H3, JT] = LineBreakAction.Indirect;
      // JL
      BREAK_PAIR_TABLE[JL, CL] = LineBreakAction.Prohibited;
      BREAK_PAIR_TABLE[JL, CP] = LineBreakAction.Prohibited;
      BREAK_PAIR_TABLE[JL, QU] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[JL, GL] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[JL, NS] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[JL, EX] = LineBreakAction.Prohibited;
      BREAK_PAIR_TABLE[JL, SY] = LineBreakAction.Prohibited;
      BREAK_PAIR_TABLE[JL, IS] = LineBreakAction.Prohibited;
      BREAK_PAIR_TABLE[JL, PO] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[JL, IN] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[JL, HY] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[JL, BA] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[JL, ZW] = LineBreakAction.Prohibited;
      BREAK_PAIR_TABLE[JL, CM] = LineBreakAction.CombiningIndirect;
      BREAK_PAIR_TABLE[JL, WJ] = LineBreakAction.Prohibited;
      BREAK_PAIR_TABLE[JL, JV] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[JL, JT] = LineBreakAction.Indirect;
      // JV
      BREAK_PAIR_TABLE[JV, CL] = LineBreakAction.Prohibited;
      BREAK_PAIR_TABLE[JV, CP] = LineBreakAction.Prohibited;
      BREAK_PAIR_TABLE[JV, QU] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[JV, GL] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[JV, NS] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[JV, EX] = LineBreakAction.Prohibited;
      BREAK_PAIR_TABLE[JV, SY] = LineBreakAction.Prohibited;
      BREAK_PAIR_TABLE[JV, IS] = LineBreakAction.Prohibited;
      BREAK_PAIR_TABLE[JV, PO] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[JV, IN] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[JV, HY] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[JV, BA] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[JV, ZW] = LineBreakAction.Prohibited;
      BREAK_PAIR_TABLE[JV, CM] = LineBreakAction.CombiningIndirect;
      BREAK_PAIR_TABLE[JV, WJ] = LineBreakAction.Prohibited;
      BREAK_PAIR_TABLE[JV, JV] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[JV, JT] = LineBreakAction.Indirect;
      // JT
      BREAK_PAIR_TABLE[JT, CL] = LineBreakAction.Prohibited;
      BREAK_PAIR_TABLE[JT, CP] = LineBreakAction.Prohibited;
      BREAK_PAIR_TABLE[JT, QU] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[JT, GL] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[JT, NS] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[JT, EX] = LineBreakAction.Prohibited;
      BREAK_PAIR_TABLE[JT, SY] = LineBreakAction.Prohibited;
      BREAK_PAIR_TABLE[JT, IS] = LineBreakAction.Prohibited;
      BREAK_PAIR_TABLE[JT, PO] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[JT, IN] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[JT, HY] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[JT, BA] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[JT, ZW] = LineBreakAction.Prohibited;
      BREAK_PAIR_TABLE[JT, CM] = LineBreakAction.CombiningIndirect;
      BREAK_PAIR_TABLE[JT, WJ] = LineBreakAction.Prohibited;
      BREAK_PAIR_TABLE[JT, JT] = LineBreakAction.Indirect;
      // RI
      BREAK_PAIR_TABLE[RI, CL] = LineBreakAction.Prohibited;
      BREAK_PAIR_TABLE[RI, CP] = LineBreakAction.Prohibited;
      BREAK_PAIR_TABLE[RI, QU] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[RI, GL] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[RI, NS] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[RI, EX] = LineBreakAction.Prohibited;
      BREAK_PAIR_TABLE[RI, SY] = LineBreakAction.Prohibited;
      BREAK_PAIR_TABLE[RI, IS] = LineBreakAction.Prohibited;
      BREAK_PAIR_TABLE[RI, HY] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[RI, BA] = LineBreakAction.Indirect;
      BREAK_PAIR_TABLE[RI, ZW] = LineBreakAction.Prohibited;
      BREAK_PAIR_TABLE[RI, CM] = LineBreakAction.CombiningIndirect;
      BREAK_PAIR_TABLE[RI, WJ] = LineBreakAction.Prohibited;
      BREAK_PAIR_TABLE[RI, RI] = LineBreakAction.Indirect;
    }

    public LineBreak()
    {
      m_defaultLineBreakProps = new DefaultLineBreakProperties();
    }

    #endregion ---------------------------------------------

    #region --------------- Properties ---------------

    public static LineBreak Default
    {
      get
      {
        LineBreak instance = m_default;

        if (instance == null)
        {
          instance = new LineBreak();
          m_default = instance;
        }

        return instance;
      }
    }

    #endregion ---------------------------------------------

    #region --------------- Methods ---------------

    /// <summary>
    /// Registers line break property for given language specified by <see>System.Globalization.CultureInfo</see> object.
    /// </summary>
    /// <param name="ci">The <see>System.Globalization.CultureInfo</see> object that stores information about language.</param>
    /// <param name="lbProps">The line break properties object.</param>
    public static void RegisterLanguageProperties(CultureInfo ci, LineBreakProperties lbProps)
    {
      if (ci == null)
        throw new ArgumentNullException("ci");
      if (lbProps == null)
        throw new ArgumentNullException("lbProps");

      if (m_cultureLBProps.ContainsKey(ci.TwoLetterISOLanguageName))
        m_cultureLBProps[ci.TwoLetterISOLanguageName] = lbProps;
      else
        m_cultureLBProps.Add(ci.TwoLetterISOLanguageName, lbProps);
    }

    /// <summary>
    /// Unregisters line break property for specified language.
    /// </summary>
    /// <param name="ci">An <see>System.Globalization.CultureInfo</see> object that stores information about language.</param>
    public static void UnregisterLanguageProperties(CultureInfo ci)
    {
      if (ci == null)
        throw new ArgumentNullException("ci");
      m_cultureLBProps.Remove(ci.TwoLetterISOLanguageName);
    }

    /// <summary>
    /// Unregisters line break properties for all languages.
    /// </summary>
    public static void UnregisterAllLanguageProperties()
    {
      m_cultureLBProps.Clear();
    }

    /// <summary>
    /// LB1  Assign a line breaking class to each code point of the input. 
    /// Resolve AI, CB, SA, SG, and XX into other line breaking classes depending on criteria outside the scope of this algorithm.
    /// In the absence of such criteria, it is recommended that classes AI, SA, SG, and XX be resolved to AL, 
    /// except that characters of class SA that have General_Category Mn or Mc be resolved to CM (see SA). Unresolved class CB is handled in rule LB20.
    /// </summary>
    /// <param name="lbClass">Informatin about line break class culture.</param>
    /// <param name="ci">The <see>System.Globalization.CultureInfo</see> object.</param>
    private LineBreakClass ResolveLineBreakClass(LineBreakClass lbClass, CultureInfo ci)
    {
      LineBreakClass result = LineBreakClass.Undefined;

      switch (lbClass)
      {
        case LineBreakClass.AI:
          result = LineBreakClass.AL;

          if (ci != null)
          {
            if (ci.TwoLetterISOLanguageName == "ko" ||
               ci.TwoLetterISOLanguageName == "ja" ||
               ci.TwoLetterISOLanguageName == "zh")
            {
              result = LineBreakClass.ID;
            }
          }
          break;
        case LineBreakClass.CB:
          result = LineBreakClass.CB;
          break;
        case LineBreakClass.SA:
        case LineBreakClass.SG:
        case LineBreakClass.XX:
          result = LineBreakClass.AL;
          break;
        default:
          result = lbClass;
          break;
      }

      if (result != LineBreakClass.Undefined)
      {
        if (LineBreakClassResolve != null)
        {
          LineBreakClassResolveEventArgs e = new LineBreakClassResolveEventArgs(lbClass, ci);
          LineBreakClassResolve(this, e);
          return e.Result;
        }
      }

      return result;
    }

    /// <summary>
    /// Gets the line break properties for given culture.
    /// </summary>
    /// <param name="ci">The <see>System.Globalization.CultureInfo</see> for which to get line break properties.</param>
    /// <returns></returns>
    public ClassProperties<LineBreakClass> GetLineBreakProperties(CultureInfo ci)
    {
      if (ci != null)
      {
        if (m_cultureLBProps.ContainsKey(ci.TwoLetterISOLanguageName))
          return m_cultureLBProps[ci.TwoLetterISOLanguageName];
      }

      return m_defaultLineBreakProps;
    }

    /// <summary>
    /// Returns array of <see cref="NLineBreak.LineBreakElement"/> objects.
    /// </summary>
    /// <param name="text"></param>
    /// <param name="breakStrings"></param>
    /// <returns></returns>
    public LineBreakElement[] FindLineBreaks(string text, string[] breakStrings, byte[] wrapCodes = null)
    {
      return FindLineBreaks(text, text.Length, breakStrings, wrapCodes);
    }

    public LineBreakElement[] FindLineBreaks(string text, int length, string[] breakStrings, byte[] wrapCodes = null)
    {
       LineBreakElement[] lbElements = null;

       if (text != null)
       {
         if (length < 0 || length > text.Length)
           throw new ArgumentOutOfRangeException("length");

         List<LineBreakElement> elements = new List<LineBreakElement>();

         for (int i = 0; i < length; i++)
         {
           LineBreakElement lbElem = new LineBreakElement(i, LineBreakCondition.Prohibited);
           elements.Add(lbElem);
         }

         if (breakStrings != null && breakStrings.Length > 0)
         {
           bool bWrap = (wrapCodes != null);

           for (int i = 0; i < breakStrings.Length; i++)
           {
             string strBreak = breakStrings[i];
             if (strBreak == null)
               continue;

             int breakLength = strBreak.Length;
             int posBreak = 0;

             while (posBreak >= 0 && posBreak < length)
             {
               int pos = text.IndexOf(strBreak, posBreak);
               if (pos >= 0 && pos <= length)
               {
                 int idx = 0;
                 if (bWrap)
                 {
                   if (wrapCodes[i] == 1)
                     idx = pos + breakLength - 1;
                   else
                     idx = pos - 1;
                 }
                 else
                 {
                   idx = pos + breakLength - 1;
                 }

                 if (idx >= 0 && idx < length)
                 {
                   LineBreakElement lbElem = elements[idx];
                   lbElem.Condition = LineBreakCondition.Allowed;
                   elements[idx] = lbElem;
                 }
               }
               else
                 break;

               posBreak = pos + breakLength;
             }
           }
         }

         LineBreakElement lbe = elements[elements.Count - 1];
         lbe.Condition = LineBreakCondition.Mandatory;
         elements[elements.Count - 1] = lbe;

         lbElements = new LineBreakElement[elements.Count];
         elements.CopyTo(lbElements, 0);
       }

      return lbElements;
    }

    public LineBreakElement[] FindLineBreaks(string text)
    {
      return FindLineBreaks(text, (CultureInfo)null);
    }

    public LineBreakElement[] FindLineBreaks(string text, int length)
    {
      return FindLineBreaks(text, length, (CultureInfo)null);
    }

    public LineBreakElement[] FindLineBreaks(string text, CultureInfo ci)
    {
      return FindLineBreaks(text, text.Length, ci);
    }

    public LineBreakElement[] FindLineBreaks(string text, int length, CultureInfo ci)
    {
      LineBreakElement[] lbElements = null;
      if (text != null)
      {
        List<LineBreakElement> elements = new List<LineBreakElement>();

        LineBreakEventHandler LineBreakFoundInternal = (object sender, LineBreakEventArgs e) =>
        {
          elements.Add(new LineBreakElement(e.Position, e.Condition));
        };

        LineBreakFound += LineBreakFoundInternal;

        FindLineBreaksInternal(text, length, ci);

        LineBreakFound = null;

        lbElements = new LineBreakElement[elements.Count];
        elements.CopyTo(lbElements, 0);
      }

      return lbElements;
    }

    private void FindLineBreaksInternal(string text, int length, CultureInfo ci)
    {
      if (text == null)
        throw new ArgumentNullException("text");

      if (length <= 0)
        throw new ArgumentException("length");

      if (text == string.Empty)
        return;

      int nLength = text.Length;
      if (length < 0 || length > nLength)
        throw new ArgumentOutOfRangeException("length");

      ClassProperties<LineBreakClass> lbProps = GetLineBreakProperties(ci);
      LineBreakClass lbcCurrent = ResolveLineBreakClass(lbProps.GetClass(text[0]), ci);
      LineBreakClass lbcPrev = LineBreakClass.Undefined;
      LineBreakClass lbcNext = LineBreakClass.Undefined;

      for (int ich = 1; ich < nLength; ich++)
      {
        char ch = text[ich];

        switch (lbcCurrent)
        {
          case LineBreakClass.NL:
          case LineBreakClass.LF:
            lbcCurrent = LineBreakClass.BK;
            break;
          case LineBreakClass.SP:
            lbcCurrent = LineBreakClass.WJ;
            break;
          default:
            break;
        }

        lbcPrev = lbcNext;
        lbcNext = lbProps.GetClass(ch);

        if (lbcCurrent == LineBreakClass.BK || (lbcCurrent == LineBreakClass.CR && lbcNext != LineBreakClass.LF))
        {
          OnLineBreakFound(ich, LineBreakCondition.Mandatory);
          lbcCurrent = lbProps.GetClass(ch);
          continue;
        }

        LineBreakCondition lbCondition = LineBreakCondition.Prohibited;
        bool bContinue = false;

        switch (lbcNext)
        {
          // Handle spaces explicitly
          case LineBreakClass.SP:
            lbCondition = LineBreakCondition.Prohibited;
            bContinue = true;
            break;
          case LineBreakClass.CJ:
            // TODO
            //bContinue = true;
            break;
          // Handle complex scripts in a separate function
          case LineBreakClass.SA:
            // Not implemented yet
              //ich += findComplexBreak(cls, &pcls[ich - 1], &pbrk[ich - 1],
              //           cch - (ich - 1));
              //if (ich < cch)
              //  cls = pcls[ich];
            //bContinue = true;
            break;
          // Handle BK, NL and LF explicitly
          case LineBreakClass.BK:
          case LineBreakClass.NL:
          case LineBreakClass.LF:
            lbCondition = LineBreakCondition.Prohibited;
            lbcCurrent = LineBreakClass.BK;
            bContinue = true;
            break;
          // Handle CR explicitly
          case LineBreakClass.CR:
            lbCondition = LineBreakCondition.Prohibited;
            lbcCurrent = LineBreakClass.CR;
            bContinue = true;
            break;
          case LineBreakClass.CB:
            lbCondition = LineBreakCondition.Allowed;
            lbcCurrent = LineBreakClass.BA;
            bContinue = true;
            break;
          default:
            break;
        }

        if (!bContinue)
        {
          lbcNext = ResolveLineBreakClass(lbcNext, ci);

          // Lookup pair table information in BREAK_PAIR_TABLE[before, after];
          LineBreakAction brkAction = BREAK_PAIR_TABLE[(int)lbcCurrent, (int)lbcNext];

          switch (brkAction)
          {
            case LineBreakAction.Direct:
              lbCondition = LineBreakCondition.Allowed;
              break;
            case LineBreakAction.Indirect:
            case LineBreakAction.CombiningIndirect:
              lbCondition = (lbcPrev == LineBreakClass.SP) ? LineBreakCondition.Allowed : LineBreakCondition.Prohibited;
              break;
            case LineBreakAction.CombiningProhibited:
            case LineBreakAction.Prohibited:
              lbCondition = LineBreakCondition.Prohibited;
              break;
            case LineBreakAction.Explicit:
              // 
              break;
          }
        }

        lbcCurrent = lbcNext;

        OnLineBreakFound(ich - 1, lbCondition);
      }

      OnLineBreakFound(text.Length, LineBreakCondition.Mandatory);
    }

    /// <summary>
    /// Raises the LineBreakFound event. 
    /// </summary>
    /// <param name="position">Line break opportunity position.</param>
    /// <param name="condition">Line break opportunity condition.</param>
    private void OnLineBreakFound(int position, LineBreakCondition condition)
    {
      if (LineBreakFound != null)
      {
        LineBreakFound(this, new LineBreakEventArgs(condition, position));
      }
    }

    #endregion ---------------------------------------------
  }
}
