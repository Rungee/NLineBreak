/******************************************************************************
*
* Name: LineBreakEventArgs.cs
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
  /// Represents the method that will handle an event that has line break data.
  /// </summary>
  /// <param name="sender">The source of the event.</param>
  /// <param name="e">An <see cref="NLineBreak.LineBreakEventArgs"/> that contains data for a line break.</param>
  public delegate void LineBreakEventHandler(object sender, LineBreakEventArgs e);

  /// <summary>
  /// Class for containing information about a line break.
  /// </summary>
  public class LineBreakEventArgs
  {
    private LineBreakCondition m_condition;
    private int m_position;

    /// <summary>
    /// Initializes a new instance of the class <see cref="NLineBreak.LineBreakEventArgs"/>.
    /// </summary>
    /// <param name="condition">A condition of the line break.</param>
    /// <param name="position">A position of the line break.</param>
    public LineBreakEventArgs(LineBreakCondition condition, int position)
    {
      m_position = position;
      m_condition = condition;
    }

    /// <summary>
    /// Gets or sets the line break condition.
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
  }
}
