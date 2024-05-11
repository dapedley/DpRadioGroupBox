namespace RadioGroupBoxTest;

public partial class Form1 : Form
{
	TestRec TestData = new TestRec();

	public Form1 ()
	{
		InitializeComponent ();

		testRecBindingSource.DataSource = TestData;
	}

	private void OnExitBtn (object sender, EventArgs e)
	{
		Close ();
	}

	private void OnItemChanged (object sender, EventArgs e)
	{
		Application.DoEvents ();
		Rtb.Clear ();
		Rtb.AppendText ($"A: {TestData.Selected1}, {TestData.Selected2}");
	}

	private void OnNewSelection (object sender, EventArgs e)
	{
		if (!(sender is DpRadioGroupBox ctrl)) { return; }
		tbNewSelection.Text = $"{ctrl.Name}: Selection Changed to '{ctrl.SelectedTag}'";
	}

	private void OnForm1Load (object sender, EventArgs e)
	{

	}
}


public class TestRec
{
	public int Selected1 { get; set; } = 2;
	public int Selected2 { get; set; } = 3;
}