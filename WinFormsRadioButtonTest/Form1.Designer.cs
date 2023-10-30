namespace WinFormsRadioButtonTest2;

partial class Form1
{
	/// <summary>
	///  Required designer variable.
	/// </summary>
	private System.ComponentModel.IContainer components = null;

	/// <summary>
	///  Clean up any resources being used.
	/// </summary>
	/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	protected override void Dispose (bool disposing)
	{
		if (disposing && (components != null)) {
			components.Dispose ();
		}
		base.Dispose (disposing);
	}

	#region Windows Form Designer generated code

	/// <summary>
	///  Required method for Designer support - do not modify
	///  the contents of this method with the code editor.
	/// </summary>
	private void InitializeComponent ()
	{
		ExitBtn = new Button ();
		Rtb = new RichTextBox ();
		radioGroupBox1 = new RadioGroupBox ();
		radioGroupBox2 = new RadioGroupBox ();
		SuspendLayout ();
		// 
		// ExitBtn
		// 
		ExitBtn.Location = new Point (553, 304);
		ExitBtn.Name = "ExitBtn";
		ExitBtn.Size = new Size (75, 23);
		ExitBtn.TabIndex = 2;
		ExitBtn.Text = "E&xit";
		ExitBtn.UseVisualStyleBackColor = true;
		ExitBtn.Click += OnExitBtn;
		// 
		// Rtb
		// 
		Rtb.Location = new Point (57, 255);
		Rtb.Name = "Rtb";
		Rtb.Size = new Size (421, 72);
		Rtb.TabIndex = 3;
		Rtb.Text = "";
		// 
		// radioGroupBox1
		// 
		radioGroupBox1.Location = new Point (57, 41);
		radioGroupBox1.Name = "radioGroupBox1";
		radioGroupBox1.Selected = 0;
		radioGroupBox1.Size = new Size (200, 100);
		radioGroupBox1.TabIndex = 4;
		radioGroupBox1.TabStop = false;
		radioGroupBox1.Text = "radioGroupBox1";
		// 
		// radioGroupBox2
		// 
		radioGroupBox2.Location = new Point (428, 41);
		radioGroupBox2.Name = "radioGroupBox2";
		radioGroupBox2.Selected = 0;
		radioGroupBox2.Size = new Size (200, 100);
		radioGroupBox2.TabIndex = 5;
		radioGroupBox2.TabStop = false;
		radioGroupBox2.Text = "radioGroupBox2";
		// 
		// Form1
		// 
		AutoScaleDimensions = new SizeF (7F, 15F);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size (703, 364);
		Controls.Add (radioGroupBox2);
		Controls.Add (radioGroupBox1);
		Controls.Add (Rtb);
		Controls.Add (ExitBtn);
		Name = "Form1";
		Text = "Test Form";
		ResumeLayout (false);
	}

	#endregion

	private Button ExitBtn;
	private RichTextBox Rtb;
	private RadioGroupBox radioGroupBox1;
	private RadioGroupBox radioGroupBox2;
}