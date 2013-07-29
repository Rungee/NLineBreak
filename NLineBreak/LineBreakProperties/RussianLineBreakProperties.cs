/******************************************************************************
*
* Name: RussianLineBreakProperties.cs
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
  public class RussianLineBreakProperties : CustomLineBreakProperties
  {
    public static LineBreakProperty[] properties = new LineBreakProperty[] 
    {
      new LineBreakProperty( 0x00AB, 0x00AB, LineBreakClass.OP),	/* Left double angle quotation mark: opening */
	    new LineBreakProperty( 0x00BB, 0x00BB, LineBreakClass.CL ),	/* Right double angle quotation mark: closing */
	    new LineBreakProperty( 0x201C, 0x201C, LineBreakClass.CL ),	/* Left double quotation mark: closing */
	    LineBreakProperty.Undefined
    };

    /// <summary>
    /// Initializes a new instance of the class <see cref="NLineBreak.RussianLineBreakProperties"/>.
    /// </summary>
    public RussianLineBreakProperties()
    {
      SetCustomProperties(properties);
    }
  }
}
