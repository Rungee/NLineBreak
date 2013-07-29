using System;
using System.Collections.Generic;
using System.IO;

namespace UnicodeDataCodeGenerator
{
  public class UnicodeEastAsianWidthCodeGenerator
  {
    public static void GenerateCode(string inputFilename, string outputFilename)
    {
      using (StreamWriter sw = File.CreateText(outputFilename))
      {
        CodeGenerator.WriteLicenseTerms(sw);
        sw.WriteLine("");
        CodeGenerator.WriteNotice(sw);

        sw.WriteLine("using System;");
        sw.WriteLine();
        sw.WriteLine("namespace NLineBreak");
        sw.WriteLine("{");
        sw.WriteLine("\tinternal static class EastAsianWidthData");
        sw.WriteLine("\t{");
        sw.WriteLine("\t\t#region Default list of East Asian Width properties");
        sw.WriteLine();
        sw.WriteLine("\t\tprivate static EastAsianWidthProperty[] properties = new EastAsianWidthProperty[]");
        sw.WriteLine("\t\t{");

        string strClassPropertyFormat = "\t\t\tnew EastAsianWidthProperty(0x{0}, 0x{1}, EastAsianWidthClass.{2}),";
        CodeGenerator.ParseClassProperties(inputFilename, strClassPropertyFormat, sw);

        sw.WriteLine("\t\t};");
        sw.WriteLine();
        sw.WriteLine("\t\t#endregion");
        sw.WriteLine();
        sw.WriteLine("\t\tpublic static EastAsianWidthProperty[] GetData()");
        sw.WriteLine("\t\t{");
        sw.WriteLine("\t\t\treturn properties;");
        sw.WriteLine("\t\t}");
        sw.WriteLine("\t}");
        sw.WriteLine("}");
      }
    }
  }
}
