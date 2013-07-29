/******************************************************************************
*
* Name: LineBreakClassResolveEventArgs.cs
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
using System.Globalization;

namespace NLineBreak
{
  /// <summary>
  /// Represents the method that will handle an event that has line break class reoslution data.
  /// </summary>
  /// <param name="sender">The source of the event.</param>
  /// <param name="e">An <see cref="NLineBreak.LineBreakClassResolveEventArgs"/> that contains data for a line break resolution.</param>
  public delegate void LineBreakClassResolveEventHandler(object sender, LineBreakClassResolveEventArgs e);
  
  /// <summary>
  /// Class for containing information about a line break class resolution.
  /// </summary>
  public class LineBreakClassResolveEventArgs
  {
    private LineBreakClass m_lbSource;
    private LineBreakClass m_lbResult;
    private CultureInfo m_cultureInfo;

    /// <summary>
    /// Initializes a new of the class <see cref="NLineBreak.LineBreakClassResolveEventArgs"/>.
    /// </summary>
    /// <param name="lbClass"></param>
    /// <param name="ci"></param>
    public LineBreakClassResolveEventArgs(LineBreakClass lbClass, CultureInfo ci)
    {
      m_lbSource = lbClass;
      m_cultureInfo = ci;
    }

    /// <summary>
    /// Gets information about line break class culture.
    /// </summary>
    public CultureInfo CultureInfo
    {
      get
      {
        return m_cultureInfo;
      }
    }

    /// <summary>
    /// Gets source line break class that must be resolved.
    /// </summary>
    public LineBreakClass Source
    {
      get
      {
        return m_lbSource;
      }
    }

    /// <summary>
    /// Gets or sets line break class after resolution.
    /// </summary>
    public LineBreakClass Result
    {
      get
      {
        return m_lbResult;
      }
      set
      {
        m_lbResult = value;
      }
    }
  }
}
