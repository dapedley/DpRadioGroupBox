namespace WinFormsRadioButtonTest2;

public partial class Form1 : Form
{
	TestRec TestData = new TestRec();
	public Form1 ()
	{
		InitializeComponent ();
		AddRadios ();
		testRecBindingSource.DataSource = TestData;
		//		Application.Idle += FormIdle;
	}

	private void FormIdle (object sender, EventArgs e)
	{
	}

	private void OnExitBtn (object sender, EventArgs e)
	{
		Close ();
	}

	private void OnItemChanged (object sender, EventArgs e)
	{
		Application.DoEvents ();
		Rtb.Clear ();
		Rtb.AppendText ($"A: {TestData.RbA1}, {TestData.RbA2}, {TestData.RbA3}\r\n");
		Rtb.AppendText ($"B: {TestData.RbB1}, {TestData.RbB2}, " +
			$"{TestData.RbB3}, {TestData.RbB4}");
	}
}

public class TestRec
{
	public bool RbA1 { get; set; } = false;
	public bool RbA2 { get; set; } = true;
	public bool RbA3 { get; set; } = false;

	public bool RbB1 { get; set; } = false;
	public bool RbB2 { get; set; } = true;
	public bool RbB3 { get; set; } = false;
	public bool RbB4 { get; set; } = false;

}