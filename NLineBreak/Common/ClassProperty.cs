/******************************************************************************
*
* Name: ClassProperty.cs
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
  public class ClassProperty<T> 
  {
    #region --------------- Fields ---------------

    private T m_class;
    private uint m_startCodePoint;
    private uint m_endCodePoint;

    #endregion ---------------------------------------------

    #region --------------- Constructors ---------------

    /// <summary>
    /// Initializes a new instance of the class <see cref="NLineBreak.ClassProperty"/>.
    /// </summary>
    /// <param name="startCodePoint">Start code point of the range.</param>
    /// <param name="endCodePoint">End code point of the range.</param>
    /// <param name="pClass">Property class.</param>
    public ClassProperty(uint startCodePoint, uint endCodePoint, T pClass)
    {
      m_startCodePoint = startCodePoint;
      m_endCodePoint = endCodePoint;
      m_class = pClass;
    }

    #endregion ---------------------------------------------

    #region --------------- Properties ---------------

    /// <summary>
    /// Gets or sets property class.
    /// </summary>
    public T Class
    {
      get
      {
        return m_class;
      }
      set
      {
        m_class = value;
      }
    }

    /// <summary>
    /// Gets or sets the start code point of the range.
    /// </summary>
    public uint StartCodePoint
    {
      get
      {
        return m_startCodePoint;
      }
      set
      {
        m_startCodePoint = value;
      }
    }

    /// <summary>
    /// Gets or sets the end  code point of the range.
    /// </summary>
    public uint EndCodePoint
    {
      get
      {
        return m_endCodePoint;
      }
      set
      {
        m_endCodePoint = value;
      }
    }

    public static ClassProperty<T> Undefined
    {
      get
      {
        return new ClassProperty<T>(0, 0, UndefinedClass);
      }
    }

    public static T UndefinedClass
    {
      get
      {
        return default(T);
      }
    }

    #endregion ---------------------------------------------

    #region --------------- Methods ---------------

    /// <summary>
    /// Determines whether the <see cref="NLineBreak.LineBreakProperty"/> contains a specific char code.
    /// </summary>
    /// <param name="value">The char code to locate in the <see cref="NLineBreak.LineBreakProperty"/>.</param>
    /// <returns>true if the <see cref="NLineBreak.LineBreakProperty"/> contains an element with the specified char code; otherwise, false.</returns>
    public bool Contains(uint value)
    {
      return m_startCodePoint <= value && value <= m_endCodePoint;
    }

    #region --------------- Methods ---------------

    /// <summary>
    /// Returns a <see cref="System.String"/> that represents the current <see cref="NLineBreak.EastAsianWidthProperty"/>.
    /// </summary>
    /// <returns>A string that represents the instance.</returns>
    public override string ToString()
    {
      return string.Format("0x{0}-0x{1}, {2}", StartCodePoint.ToString("X4"), EndCodePoint.ToString("X4"), Class);
    }

    #endregion ---------------------------------------------
    #endregion ---------------------------------------------
  }
}
