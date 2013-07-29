/******************************************************************************
*
* Name: LineBreakElement.cs
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
  /// Represents struct to store information about line break position and condition.
  /// </summary>
  public struct LineBreakElement
  {
    private int m_position;
    private LineBreakCondition m_condition;

    /// <summary>
    /// Initializes a new instance of the class <see cref="NLineBreak.LineBreakElement"/>.
    /// </summary>
    /// <param name="position"></param>
    /// <param name="condition"></param>
    public LineBreakElement(int position, LineBreakCondition condition)
    {
      m_position = position;
      m_condition = condition;
    }

    /// <summary>
    /// Gets or sets line break position.
    /// </summary>
    public int Position
    {
      get
      {
        return m_position;
      }
      set
      {
        m_position = value;
      }
    }

    /// <summary>
    /// Gets or sets line break condition.
    /// </summary>
    public LineBreakCondition Condition
    {
      get
      {
        return m_condition;
      }
      set
      {
        m_condition = value;
      }
    }

    /// <summary>
    /// Returns a <see cref="System.String"/> that represents the current <see cref="NLineBreak.LineBreakElement"/>.
    /// </summary>
    /// <returns>A string that represents the instance.</returns>
    public override string ToString()
    {
      return string.Format("Position={0};Condition={1}", m_position, m_condition);
    }
  }
}
