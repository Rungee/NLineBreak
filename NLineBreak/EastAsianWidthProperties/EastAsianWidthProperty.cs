/******************************************************************************
*
* Name: EastAsianWidthProperty.cs
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

namespace NLineBreak
{
  /// <summary>
  /// Represents struct to store information about East Asian Width class and code point range.
  /// </summary>
  public class EastAsianWidthProperty : ClassProperty<EastAsianWidthClass>
  {
    #region --------------- Constructors ---------------

    /// <summary>
    /// Initializes a new instance of the class <see cref="NLineBreak.EastAsianWidthProperty"/>.
    /// </summary>
    /// <param name="startCodePoint">Start code point of the range.</param>
    /// <param name="endCodePoint">End code point of the range.</param>
    /// <param name="eawClass">East Asian Width class.</param>
    public EastAsianWidthProperty(uint startCodePoint, uint endCodePoint, EastAsianWidthClass eawClass)
      : base(startCodePoint, endCodePoint, eawClass)
    {
    }

    #endregion ---------------------------------------------
  }
}
