/******************************************************************************
*
* Name: ClassProperties.cs
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

//
// Unicode Data Copyright:
// Copyright © 1991-2006 Unicode, Inc. All rights reserved. Distributed under the Terms of Use in http://www.unicode.org/copyright.html.

using System;
using System.Collections.Generic;

namespace NLineBreak
{
  public abstract class ClassProperties<T> : IClassProperties<T>
  {
    protected ClassProperty<T>[] m_propList = null;

    public virtual T GetClass(uint value)
    {
      return GetClass(value, m_propList, 0);
    }

    protected T GetClass(uint value, int index)
    {
      return GetClass(value, m_propList, index);
    }

    protected T GetClass(uint value, ClassProperty<T>[] clProps, int index)
    {
      int nLength = clProps.Length;

      if (index > nLength)
        return (T)ClassProperty<T>.UndefinedClass;

      for (int i = index; i < nLength; i++)
      {
        ClassProperty<T> lbp = clProps[i];
        if (lbp.Contains(value))
        {
          return lbp.Class;
        }
      }

      return (T)ClassProperty<T>.UndefinedClass;
    }

    protected void SetProperties(ClassProperty<T>[] propList)
    {
      if (propList == null)
        throw new ArgumentNullException("propList");

      m_propList = propList;
    }
  }
}
