/******************************************************************************
*
* Name: EastAsianWidthClass.cs
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

namespace NLineBreak
{
  /// <summary>
  /// Enumeration of East Asian Width Classes listed in Unicode Standard Annex #11.
  /// </summary>
  public enum EastAsianWidthClass : byte
  {
    /// <summary>
    /// Ambiguous
    /// </summary>
    A,
    /// <summary>
    /// Fullwidth
    /// </summary>
    F,
    /// <summary>
    /// Halfwidth
    /// </summary>
    H,
    /// <summary>
    /// Narrow
    /// </summary>
    Na,
    /// <summary>
    /// Wide
    /// </summary>
    W,
    /// <summary>
    /// Neutral
    /// </summary>
    N
  }
}
