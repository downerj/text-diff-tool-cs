using DiffMatchPatch;

namespace TextDiffTool
{
  public partial class MainForm : Form
  {
    private readonly diff_match_patch _dmp = new();

    public MainForm()
    {
      InitializeComponent();
    }

    private void RenderDiffs()
    {
      DiffTextBox.Clear();
      string leftText = OriginalTextBox.Text;
      string rightText = ModifiedTextBox.Text;
      if (leftText.Length == 0 || rightText.Length == 0)
      {
        return;
      }
      List<Diff> diffs = _dmp.diff_main(leftText, rightText);
      foreach (Diff diff in diffs)
      {
        DiffTextBox.SelectionStart = DiffTextBox.TextLength;
        DiffTextBox.SelectionLength = 0;
        switch (diff.operation)
        {
          case Operation.EQUAL:
            DiffTextBox.SelectionColor = DiffTextBox.ForeColor;
            DiffTextBox.SelectionBackColor = DiffTextBox.BackColor;
            break;
          case Operation.INSERT:
            DiffTextBox.SelectionColor = Color.Black;
            DiffTextBox.SelectionBackColor = Color.LawnGreen;
            break;
          case Operation.DELETE:
            DiffTextBox.SelectionColor = Color.White;
            DiffTextBox.SelectionBackColor = Color.Red;
            break;
        }
        DiffTextBox.AppendText(diff.text);
      }
    }

    public void CompareButton_Click(object? sender, EventArgs e)
    {
      RenderDiffs();
    }

    public void ClearButton_Click(object? sender, EventArgs e)
    {
      DiffTextBox.Clear();
      OriginalTextBox.Clear();
      ModifiedTextBox.Clear();
    }

    private void MainForm_DpiChanged(object sender, DpiChangedEventArgs e)
    {
      RenderDiffs();
    }
  }
}
