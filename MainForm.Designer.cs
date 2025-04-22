namespace TextDiffTool
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      TopPanel = new TableLayoutPanel();
      DiffsTextGroupBox = new GroupBox();
      DiffTextBox = new RichTextBox();
      InputsPanel = new TableLayoutPanel();
      OriginalTextGroupBox = new GroupBox();
      OriginalTextBox = new TextBox();
      ModifiedTextGroupBox = new GroupBox();
      ModifiedTextBox = new TextBox();
      ButtonPanel = new FlowLayoutPanel();
      CompareButton = new Button();
      ClearButton = new Button();
      TopPanel.SuspendLayout();
      DiffsTextGroupBox.SuspendLayout();
      InputsPanel.SuspendLayout();
      OriginalTextGroupBox.SuspendLayout();
      ModifiedTextGroupBox.SuspendLayout();
      ButtonPanel.SuspendLayout();
      SuspendLayout();
      // 
      // TopPanel
      // 
      TopPanel.ColumnCount = 1;
      TopPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
      TopPanel.Controls.Add(DiffsTextGroupBox, 0, 2);
      TopPanel.Controls.Add(InputsPanel, 0, 0);
      TopPanel.Controls.Add(ButtonPanel, 0, 1);
      TopPanel.Dock = DockStyle.Fill;
      TopPanel.Location = new Point(0, 0);
      TopPanel.Margin = new Padding(0);
      TopPanel.Name = "TopPanel";
      TopPanel.RowCount = 3;
      TopPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
      TopPanel.RowStyles.Add(new RowStyle());
      TopPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
      TopPanel.Size = new Size(560, 270);
      TopPanel.TabIndex = 0;
      // 
      // DiffsTextGroupBox
      // 
      DiffsTextGroupBox.Controls.Add(DiffTextBox);
      DiffsTextGroupBox.Dock = DockStyle.Fill;
      DiffsTextGroupBox.Location = new Point(2, 153);
      DiffsTextGroupBox.Margin = new Padding(2);
      DiffsTextGroupBox.Name = "DiffsTextGroupBox";
      DiffsTextGroupBox.Padding = new Padding(2);
      DiffsTextGroupBox.Size = new Size(556, 115);
      DiffsTextGroupBox.TabIndex = 1;
      DiffsTextGroupBox.TabStop = false;
      DiffsTextGroupBox.Text = "Diffs";
      // 
      // DiffTextBox
      // 
      DiffTextBox.Dock = DockStyle.Fill;
      DiffTextBox.Font = new Font("Consolas", 12F);
      DiffTextBox.Location = new Point(2, 18);
      DiffTextBox.Margin = new Padding(2);
      DiffTextBox.Name = "DiffTextBox";
      DiffTextBox.ReadOnly = true;
      DiffTextBox.Size = new Size(552, 95);
      DiffTextBox.TabIndex = 0;
      DiffTextBox.Text = "";
      // 
      // InputsPanel
      // 
      InputsPanel.ColumnCount = 2;
      InputsPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
      InputsPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
      InputsPanel.Controls.Add(OriginalTextGroupBox, 0, 0);
      InputsPanel.Controls.Add(ModifiedTextGroupBox, 1, 0);
      InputsPanel.Dock = DockStyle.Fill;
      InputsPanel.Location = new Point(2, 2);
      InputsPanel.Margin = new Padding(2);
      InputsPanel.Name = "InputsPanel";
      InputsPanel.RowCount = 1;
      InputsPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
      InputsPanel.Size = new Size(556, 114);
      InputsPanel.TabIndex = 2;
      // 
      // OriginalTextGroupBox
      // 
      OriginalTextGroupBox.Controls.Add(OriginalTextBox);
      OriginalTextGroupBox.Dock = DockStyle.Fill;
      OriginalTextGroupBox.Location = new Point(0, 0);
      OriginalTextGroupBox.Margin = new Padding(0);
      OriginalTextGroupBox.Name = "OriginalTextGroupBox";
      OriginalTextGroupBox.Padding = new Padding(0);
      OriginalTextGroupBox.Size = new Size(278, 114);
      OriginalTextGroupBox.TabIndex = 0;
      OriginalTextGroupBox.TabStop = false;
      OriginalTextGroupBox.Text = "Original Text";
      // 
      // OriginalTextBox
      // 
      OriginalTextBox.Dock = DockStyle.Fill;
      OriginalTextBox.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
      OriginalTextBox.Location = new Point(0, 16);
      OriginalTextBox.Margin = new Padding(2);
      OriginalTextBox.Multiline = true;
      OriginalTextBox.Name = "OriginalTextBox";
      OriginalTextBox.Size = new Size(278, 98);
      OriginalTextBox.TabIndex = 0;
      // 
      // ModifiedTextGroupBox
      // 
      ModifiedTextGroupBox.Controls.Add(ModifiedTextBox);
      ModifiedTextGroupBox.Dock = DockStyle.Fill;
      ModifiedTextGroupBox.Location = new Point(278, 0);
      ModifiedTextGroupBox.Margin = new Padding(0);
      ModifiedTextGroupBox.Name = "ModifiedTextGroupBox";
      ModifiedTextGroupBox.Padding = new Padding(0);
      ModifiedTextGroupBox.Size = new Size(278, 114);
      ModifiedTextGroupBox.TabIndex = 1;
      ModifiedTextGroupBox.TabStop = false;
      ModifiedTextGroupBox.Text = "Modified Text";
      // 
      // ModifiedTextBox
      // 
      ModifiedTextBox.Dock = DockStyle.Fill;
      ModifiedTextBox.Font = new Font("Consolas", 12F);
      ModifiedTextBox.Location = new Point(0, 16);
      ModifiedTextBox.Margin = new Padding(2);
      ModifiedTextBox.Multiline = true;
      ModifiedTextBox.Name = "ModifiedTextBox";
      ModifiedTextBox.Size = new Size(278, 98);
      ModifiedTextBox.TabIndex = 0;
      // 
      // ButtonPanel
      // 
      ButtonPanel.AutoSize = true;
      ButtonPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
      ButtonPanel.Controls.Add(CompareButton);
      ButtonPanel.Controls.Add(ClearButton);
      ButtonPanel.Dock = DockStyle.Fill;
      ButtonPanel.Location = new Point(2, 120);
      ButtonPanel.Margin = new Padding(2);
      ButtonPanel.Name = "ButtonPanel";
      ButtonPanel.Size = new Size(556, 29);
      ButtonPanel.TabIndex = 3;
      // 
      // CompareButton
      // 
      CompareButton.AutoSize = true;
      CompareButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
      CompareButton.Location = new Point(2, 2);
      CompareButton.Margin = new Padding(2);
      CompareButton.Name = "CompareButton";
      CompareButton.Size = new Size(66, 25);
      CompareButton.TabIndex = 0;
      CompareButton.Text = "Compare";
      CompareButton.UseVisualStyleBackColor = true;
      CompareButton.Click += CompareButton_Click;
      // 
      // ClearButton
      // 
      ClearButton.AutoSize = true;
      ClearButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
      ClearButton.Location = new Point(72, 2);
      ClearButton.Margin = new Padding(2);
      ClearButton.Name = "ClearButton";
      ClearButton.Size = new Size(44, 25);
      ClearButton.TabIndex = 1;
      ClearButton.Text = "Clear";
      ClearButton.UseVisualStyleBackColor = true;
      ClearButton.Click += ClearButton_Click;
      // 
      // MainForm
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(560, 270);
      Controls.Add(TopPanel);
      Margin = new Padding(2);
      Name = "MainForm";
      Text = "Text Diff Tool";
      DpiChanged += MainForm_DpiChanged;
      TopPanel.ResumeLayout(false);
      TopPanel.PerformLayout();
      DiffsTextGroupBox.ResumeLayout(false);
      InputsPanel.ResumeLayout(false);
      OriginalTextGroupBox.ResumeLayout(false);
      OriginalTextGroupBox.PerformLayout();
      ModifiedTextGroupBox.ResumeLayout(false);
      ModifiedTextGroupBox.PerformLayout();
      ButtonPanel.ResumeLayout(false);
      ButtonPanel.PerformLayout();
      ResumeLayout(false);
    }

    #endregion

    private TableLayoutPanel TopPanel;
    private GroupBox DiffsTextGroupBox;
    private TableLayoutPanel InputsPanel;
    private GroupBox OriginalTextGroupBox;
    private GroupBox ModifiedTextGroupBox;
    private TextBox OriginalTextBox;
    private TextBox ModifiedTextBox;
    private FlowLayoutPanel ButtonPanel;
    private Button CompareButton;
    private Button ClearButton;
    private RichTextBox DiffTextBox;
  }
}
