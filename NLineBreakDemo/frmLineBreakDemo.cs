using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

using NLineBreak;

namespace NLineBreakDemo
{
  public partial class frmLineBreakDemo : Form
  {
    /// <summary>
    /// Initializes a new instance of the class <see cref="frmLineBreakDemo"/>
    /// </summary>
    public frmLineBreakDemo()
    {
      InitializeComponent();
    }

    private void mnuOpenFile_Click(object sender, EventArgs e)
    {
      if (dlgOpenFile.ShowDialog() == DialogResult.OK)
      {
        StringBuilder sb = new StringBuilder();

        FileStream fs = File.OpenRead(dlgOpenFile.FileName);
        StreamReader sr = new StreamReader(fs);

        string strLine = string.Empty;

        while (true)
        {
          strLine = sr.ReadLine();
          if (strLine == null)
            break;
          sb.AppendLine(strLine);
        }

        sr.Close();

        txtInput.Text = sb.ToString();
      }
    }

    private void mnuExit_Click(object sender, EventArgs e)
    {
      Close();
    }

    private void btnBreakText_Click(object sender, EventArgs e)
    {
      string strInput = txtInput.Text;
      if (string.IsNullOrEmpty(strInput))
        return;

      txtOutput.Clear();
      
      LineBreak linebreak = new LineBreak();
      LineBreakElement[] lbElements = linebreak.FindLineBreaks(strInput);

      StringBuilder sb = new StringBuilder();

      int lineWidth = 0;
      int maxLineWidth = (int)nudLineWidth.Value;
      int ich = 0;
      foreach (char ch in strInput)
      {
        LineBreakCondition lbCondition = lbElements[ich].Condition;
        ich++;
        string strElem = ch.ToString();
        if (lbCondition == LineBreakCondition.Allowed)
        {
          if (lineWidth >= maxLineWidth)
          {
            sb.AppendLine(string.Empty);
            lineWidth = 0;
          }

          sb.Append(strElem);
        }
        else if (lbCondition == LineBreakCondition.Mandatory)
        {
          sb.AppendLine(string.Empty);
          lineWidth = 0;
          //sb.Append(strElem);
          // sb.AppendLine(strElem);
        }
        else
          sb.Append(strElem);

        lineWidth++;
      }

      txtOutput.Text = sb.ToString();
    }

    private void mnuAbout_Click(object sender, EventArgs e)
    {
      frmAbout frm = new frmAbout();
      frm.ShowDialog();
      frm.Dispose();
    }
  }
}
