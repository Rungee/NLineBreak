/******************************************************************************
*
* Name: EnglishLineBreakProperties.cs
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
  public class EnglishLineBreakProperties : CustomLineBreakProperties
  {
    public static LineBreakProperty[] properties = new LineBreakProperty[] 
    {
      new LineBreakProperty(0x2018, 0x2018, LineBreakClass.OP ),	/* Left single quotation mark: opening */
	    new LineBreakProperty(0x201C, 0x201C, LineBreakClass.OP ),	/* Left double quotation mark: opening */
	    new LineBreakProperty(0x201D, 0x201D, LineBreakClass.CL ),	/* Right double quotation mark: closing */
	    LineBreakProperty.Undefined
    };

    /// <summary>
    /// Initializes a new instance of the class <see cref="NLineBreak.EnglishLineBreakProperties"/>.
    /// </summary>
    public EnglishLineBreakProperties()
    {
      SetCustomProperties(properties);
    }
  }
}
