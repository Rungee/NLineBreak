namespace NLineBreakDemo
{
  partial class frmLineBreakDemo
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.mainMenu = new System.Windows.Forms.MenuStrip();
      this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
      this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
      this.mnuOpenFile = new System.Windows.Forms.ToolStripMenuItem();
      this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
      this.mnuAbout = new System.Windows.Forms.ToolStripMenuItem();
      this.panelTop = new System.Windows.Forms.Panel();
      this.txtInput = new System.Windows.Forms.TextBox();
      this.txtOutput = new System.Windows.Forms.TextBox();
      this.panel2 = new System.Windows.Forms.Panel();
      this.btnBreakText = new System.Windows.Forms.Button();
      this.nudLineWidth = new System.Windows.Forms.NumericUpDown();
      this.lblLineWidth = new System.Windows.Forms.Label();
      this.dlgOpenFile = new System.Windows.Forms.OpenFileDialog();
      this.chkUseBidi = new System.Windows.Forms.CheckBox();
      this.mainMenu.SuspendLayout();
      this.panelTop.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.nudLineWidth)).BeginInit();
      this.SuspendLayout();
      // 
      // mainMenu
      // 
      this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuHelp});
      this.mainMenu.Location = new System.Drawing.Point(0, 0);
      this.mainMenu.Name = "mainMenu";
      this.mainMenu.Size = new System.Drawing.Size(814, 24);
      this.mainMenu.TabIndex = 0;
      this.mainMenu.Text = "menuStrip1";
      // 
      // mnuFile
      // 
      this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuOpenFile,
            this.toolStripMenuItem1,
            this.mnuExit});
      this.mnuFile.Name = "mnuFile";
      this.mnuFile.Size = new System.Drawing.Size(35, 20);
      this.mnuFile.Text = "File";
      // 
      // mnuExit
      // 
      this.mnuExit.Name = "mnuExit";
      this.mnuExit.Size = new System.Drawing.Size(152, 22);
      this.mnuExit.Text = "Exit";
      this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
      // 
      // toolStripMenuItem1
      // 
      this.toolStripMenuItem1.Name = "toolStripMenuItem1";
      this.toolStripMenuItem1.Size = new System.Drawing.Size(149, 6);
      // 
      // mnuOpenFile
      // 
      this.mnuOpenFile.Name = "mnuOpenFile";
      this.mnuOpenFile.Size = new System.Drawing.Size(152, 22);
      this.mnuOpenFile.Text = "Open...";
      this.mnuOpenFile.Click += new System.EventHandler(this.mnuOpenFile_Click);
      // 
      // mnuHelp
      // 
      this.mnuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAbout});
      this.mnuHelp.Name = "mnuHelp";
      this.mnuHelp.Size = new System.Drawing.Size(40, 20);
      this.mnuHelp.Text = "Help";
      // 
      // mnuAbout
      // 
      this.mnuAbout.Name = "mnuAbout";
      this.mnuAbout.Size = new System.Drawing.Size(152, 22);
      this.mnuAbout.Text = "About...";
      this.mnuAbout.Click += new System.EventHandler(this.mnuAbout_Click);
      // 
      // panelTop
      // 
      this.panelTop.Controls.Add(this.chkUseBidi);
      this.panelTop.Controls.Add(this.lblLineWidth);
      this.panelTop.Controls.Add(this.nudLineWidth);
      this.panelTop.Controls.Add(this.btnBreakText);
      this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
      this.panelTop.Location = new System.Drawing.Point(0, 24);
      this.panelTop.Name = "panelTop";
      this.panelTop.Size = new System.Drawing.Size(814, 38);
      this.panelTop.TabIndex = 1;
      // 
      // txtInput
      // 
      this.txtInput.Dock = System.Windows.Forms.DockStyle.Left;
      this.txtInput.Font = new System.Drawing.Font("DejaVu Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.txtInput.Location = new System.Drawing.Point(0, 62);
      this.txtInput.Multiline = true;
      this.txtInput.Name = "txtInput";
      this.txtInput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
      this.txtInput.Size = new System.Drawing.Size(406, 523);
      this.txtInput.TabIndex = 2;
      // 
      // txtOutput
      // 
      this.txtOutput.Dock = System.Windows.Forms.DockStyle.Fill;
      this.txtOutput.Font = new System.Drawing.Font("DejaVu Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.txtOutput.Location = new System.Drawing.Point(432, 62);
      this.txtOutput.Multiline = true;
      this.txtOutput.Name = "txtOutput";
      this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
      this.txtOutput.Size = new System.Drawing.Size(382, 523);
      this.txtOutput.TabIndex = 3;
      this.txtOutput.WordWrap = false;
      // 
      // panel2
      // 
      this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
      this.panel2.Location = new System.Drawing.Point(406, 62);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(26, 523);
      this.panel2.TabIndex = 4;
      // 
      // btnBreakText
      // 
      this.btnBreakText.Location = new System.Drawing.Point(246, 9);
      this.btnBreakText.Name = "btnBreakText";
      this.btnBreakText.Size = new System.Drawing.Size(75, 23);
      this.btnBreakText.TabIndex = 0;
      this.btnBreakText.Text = "Break";
      this.btnBreakText.UseVisualStyleBackColor = true;
      this.btnBreakText.Click += new System.EventHandler(this.btnBreakText_Click);
      // 
      // nudLineWidth
      // 
      this.nudLineWidth.Location = new System.Drawing.Point(71, 10);
      this.nudLineWidth.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
      this.nudLineWidth.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
      this.nudLineWidth.Name = "nudLineWidth";
      this.nudLineWidth.Size = new System.Drawing.Size(64, 20);
      this.nudLineWidth.TabIndex = 1;
      this.nudLineWidth.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
      this.nudLineWidth.ValueChanged += new System.EventHandler(this.btnBreakText_Click);
      // 
      // lblLineWidth
      // 
      this.lblLineWidth.AutoSize = true;
      this.lblLineWidth.Location = new System.Drawing.Point(7, 14);
      this.lblLineWidth.Name = "lblLineWidth";
      this.lblLineWidth.Size = new System.Drawing.Size(61, 13);
      this.lblLineWidth.TabIndex = 2;
      this.lblLineWidth.Text = "Line Width:";
      // 
      // dlgOpenFile
      // 
      this.dlgOpenFile.FileName = "openFileDialog1";
      // 
      // chkUseBidi
      // 
      this.chkUseBidi.AutoSize = true;
      this.chkUseBidi.Location = new System.Drawing.Point(154, 12);
      this.chkUseBidi.Name = "chkUseBidi";
      this.chkUseBidi.Size = new System.Drawing.Size(65, 17);
      this.chkUseBidi.TabIndex = 3;
      this.chkUseBidi.Text = "Use Bidi";
      this.chkUseBidi.UseVisualStyleBackColor = true;
      this.chkUseBidi.CheckedChanged += new System.EventHandler(this.btnBreakText_Click);
      // 
      // frmLineBreakDemo
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(814, 585);
      this.Controls.Add(this.txtOutput);
      this.Controls.Add(this.panel2);
      this.Controls.Add(this.txtInput);
      this.Controls.Add(this.panelTop);
      this.Controls.Add(this.mainMenu);
      this.MainMenuStrip = this.mainMenu;
      this.Name = "frmLineBreakDemo";
      this.Text = "LineBreak Algorithm Demo";
      this.mainMenu.ResumeLayout(false);
      this.mainMenu.PerformLayout();
      this.panelTop.ResumeLayout(false);
      this.panelTop.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.nudLineWidth)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MenuStrip mainMenu;
    private System.Windows.Forms.ToolStripMenuItem mnuFile;
    private System.Windows.Forms.ToolStripMenuItem mnuOpenFile;
    private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
    private System.Windows.Forms.ToolStripMenuItem mnuExit;
    private System.Windows.Forms.ToolStripMenuItem mnuHelp;
    private System.Windows.Forms.ToolStripMenuItem mnuAbout;
    private System.Windows.Forms.Panel panelTop;
    private System.Windows.Forms.Label lblLineWidth;
    private System.Windows.Forms.NumericUpDown nudLineWidth;
    private System.Windows.Forms.Button btnBreakText;
    private System.Windows.Forms.TextBox txtInput;
    private System.Windows.Forms.TextBox txtOutput;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.OpenFileDialog dlgOpenFile;
    private System.Windows.Forms.CheckBox chkUseBidi;
  }
}

