/******************************************************************************
*
* Name: HashClassProperties.cs
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
  public abstract class HashClassProperties<T> : ClassProperties<T>
  {
    internal struct HashIndex
    {
      public int Index;
      public uint EndCodePoint;
    }

    private const int HASH_TABLE_SIZE = 64;
    private HashIndex[] m_hashtable;
    private Dictionary<uint, T> m_classCache;

    /// <summary>
    /// Initializes a new instance of the class <see cref="NLineBreak.HashClassProperties<T>"/>.
    /// </summary>
    public HashClassProperties()
    {
      m_hashtable = new HashIndex[HASH_TABLE_SIZE];
      m_classCache = new Dictionary<uint, T>();
    }

    protected void UpdateHashTable()
    {
      int step = m_propList.Length / HASH_TABLE_SIZE;
      int index = 0;
      for (int i = 0; i < HASH_TABLE_SIZE; ++i)
      {
        m_hashtable[i].Index = index;
        index += step;
        m_hashtable[i].EndCodePoint = m_propList[index].StartCodePoint - 1;
      }
    }

    public override T GetClass(uint value)
    {
      T result = default(T);
      if (m_classCache.TryGetValue(value, out result))
        return result;

      int i = 0;
      while (value > m_hashtable[i].EndCodePoint)
        i++;

      result = base.GetClass(value, m_hashtable[i].Index);

      m_classCache.Add(value, result);

      return result;
    }
  }
}
