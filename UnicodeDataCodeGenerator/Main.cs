using System;
using System.IO;
using System.Text;

namespace UnicodeDataCodeGenerator
{
  /// <summary>
  /// Description of Main.
  /// </summary>
  public class CodeGenerator
  {
    public static void Main()
    {
      Directory.CreateDirectory("Output");

      string strInputDataDir = Path.Combine("Data", "6.2.0");
      string strOutputDir = @"Output\";
      string strInputFilename = Path.Combine(strInputDataDir, "LineBreak.txt");
      string strOutputFilename = Path.Combine(strOutputDir, "LineBreakData.generated.cs");
      UnicodeLineBreakCodeGenerator.GenerateCode(strInputFilename, strOutputFilename);

      strInputFilename = Path.Combine(strInputDataDir, "EastAsianWidth.txt");
      strOutputFilename = Path.Combine(strOutputDir, "EastAsianWidthData.generated.cs");
      UnicodeEastAsianWidthCodeGenerator.GenerateCode(strInputFilename, strOutputFilename);
    }

    /// <summary>
    /// Parse unicode data file and writes class properties data to <see cref="System.IO.StreamWriter"/>.
    /// </summary>
    /// <param name="filename">Input filename</param>
    /// <param name="lineFormat"></param>
    /// <param name="sw"></param>
    public static void ParseClassProperties(string filename, string lineFormat, StreamWriter sw)
    {
      string strClassPropertyFormat = lineFormat;

      using (StreamReader sr = File.OpenText(filename))
      {
        string strGroupClass = string.Empty;
        string strClass = string.Empty;
        string strStartCodePoint = string.Empty;
        string strPrevCodePoint = string.Empty;
        string strCodePoint = string.Empty;
        string strLine = string.Empty;
        string strLineValue = string.Empty;
        bool bRangeValue = false;

        while (true)
        {
          strLine = sr.ReadLine();
          if (strLine == null) break;

          if (strLine.StartsWith("#"))
            continue;

          if (strLine.Trim() != string.Empty)
          {
            int p1 = strLine.IndexOf(";");
            int p2 = strLine.IndexOf(" #");
            strLineValue = strLine.Substring(0, p2);
            strCodePoint = strLineValue.Substring(0, p1);
            strClass = strLineValue.Substring(p1 + 1, strLineValue.Length - p1 - 1);
            bRangeValue = strLineValue.Contains("..");

            if (!bRangeValue)
            {
              if (strGroupClass == string.Empty)
              {
                strStartCodePoint = strCodePoint;
                strGroupClass = strClass;
                continue;
              }

              if (strGroupClass != strClass)
              {
                sw.WriteLine(string.Format(strClassPropertyFormat, strStartCodePoint, strPrevCodePoint, strGroupClass));

                strGroupClass = strClass;
                strStartCodePoint = strCodePoint;
              }
            }
            else
            {
              if (strStartCodePoint != string.Empty && strPrevCodePoint != string.Empty)
                sw.WriteLine(string.Format(strClassPropertyFormat, strStartCodePoint, strPrevCodePoint, strGroupClass));

              //ADDD..ADF7,H3
              string[] ss = strCodePoint.Split(new string[] { ".." }, 2, StringSplitOptions.RemoveEmptyEntries);
              string str1 = ss[0];
              string str2 = ss[1];

              sw.WriteLine(string.Format(strClassPropertyFormat, str1, str2, strClass));

              strStartCodePoint = string.Empty;
              strGroupClass = string.Empty;
            }

            if (!bRangeValue)
              strPrevCodePoint = strCodePoint;
          }
        }
      }
    }

    internal static void WriteLicenseTerms(StreamWriter sw)
    {
      sw.WriteLine("// NLineBreak - a .NET implementation of the Line Breaking Algorithm (http://www.unicode.org/reports/tr14/).");
      sw.WriteLine("// Copyright (C) 2009-2013 Maxim Rylov");
      sw.WriteLine("// ");
      sw.WriteLine("// This library is free software; you can redistribute it and/or");
      sw.WriteLine("// modify it under the terms of the GNU Lesser General Public");
      sw.WriteLine("// License as published by the Free Software Foundation; either");
      sw.WriteLine("// version 2.1 of the License, or (at your option) any later version.");
      sw.WriteLine("// ");
      sw.WriteLine("// This library is distributed in the hope that it will be useful,");
      sw.WriteLine("// but WITHOUT ANY WARRANTY; without even the implied warranty of");
      sw.WriteLine("// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU");
      sw.WriteLine("// Lesser General Public License for more details.");
      sw.WriteLine("// ");
      sw.WriteLine("// You should have received a copy of the GNU Lesser General Public");
      sw.WriteLine("// License along with this library; if not, write to the Free Software");
      sw.WriteLine("// Foundation, Inc., 59 Temple Place, Suite 330, Boston, MA  02111-1307  USA");
      sw.WriteLine("//");
      sw.WriteLine("// ---");
      sw.WriteLine("//");
      sw.WriteLine("// Unicode Data Copyright:");
      sw.WriteLine("// Copyright © 1998-2013 Unicode, Inc. All Rights Reserved. Distributed under the Terms of Use in http://www.unicode.org/copyright.html.");
      sw.WriteLine();
    }

    internal static void WriteNotice(StreamWriter sw)
    {
      sw.WriteLine("//------------------------------------------------------------------------------");
      sw.WriteLine("// <auto-generated>");
      sw.WriteLine("//     This code was generated by a tool.");
      sw.WriteLine("//     Runtime Version:" + Environment.Version);
      sw.WriteLine("//");
      sw.WriteLine("//     Changes to this file may cause incorrect behavior and will be lost if");
      sw.WriteLine("//     the code is regenerated.");
      sw.WriteLine("// </auto-generated>");
      sw.WriteLine("//------------------------------------------------------------------------------");
    }
  }
}
