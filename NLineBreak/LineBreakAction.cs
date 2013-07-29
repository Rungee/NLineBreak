/******************************************************************************
*
* Name: LineBreakAction.cs
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
  /// Specifies line break action.
  /// </summary>
  internal enum LineBreakAction
  {
    /// <summary>
    /// A line break opportunity exists between two adjacent characters of the given line breaking classes. 
    /// </summary>
    Direct,
    /// <summary>
    /// A line break opportunity exists between two characters of the given line breaking classes only if they are separated by one or more spaces. 
    /// </summary>
    Indirect,
    CombiningIndirect,
    /// <summary>
    /// No line break opportunity exists between two characters of the given line breaking classes, even if they are separated by one or more space characters. 
    /// </summary>
    Prohibited,
    CombiningProhibited,
    Explicit
  }
}
