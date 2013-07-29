using System;
using System.IO;

namespace UnicodeDataCodeGenerator
{
  public class UnicodeLineBreakCodeGenerator
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
        sw.WriteLine("\tinternal static class LineBreakData");
        sw.WriteLine("\t{");
        sw.WriteLine("\t\t#region Default list of line break properties");
        sw.WriteLine();
        sw.WriteLine("\t\tprivate static LineBreakProperty[] properties = new LineBreakProperty[]");
        sw.WriteLine("\t\t{");

        string strClassPropertyFormat = "\t\t\tnew LineBreakProperty(0x{0}, 0x{1}, LineBreakClass.{2}),";
        CodeGenerator.ParseClassProperties(inputFilename, strClassPropertyFormat, sw);

        sw.WriteLine("\t\t};");
        sw.WriteLine();
        sw.WriteLine("\t\t#endregion");
        sw.WriteLine();
        sw.WriteLine("\t\tpublic static LineBreakProperty[] GetData()");
        sw.WriteLine("\t\t{");
        sw.WriteLine("\t\t\treturn properties;");
        sw.WriteLine("\t\t}");
        sw.WriteLine("\t}");
        sw.WriteLine("}");
      }
    }
  }
}
