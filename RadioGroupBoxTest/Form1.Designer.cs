namespace RadioGroupBoxTest;

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
	private Button ExitBtn;
	private RichTextBox Rtb;
	private DpRadioGroupBox radioGroupBox1;
	private RadioButton rbA3;
	private RadioButton rbA2;
	private RadioButton rbA1;

	private DpRadioGroupBox radioGroupBox2;
	private RadioButton rbB4;
	private RadioButton rbB3;
	private RadioButton rbB2;
	private RadioButton rbB1;

	private void InitializeComponent ()
	{
		components = new System.ComponentModel.Container ();
		ExitBtn = new Button ();
		Rtb = new RichTextBox ();
		radioGroupBox1 = new DpRadioGroupBox ();
		rbA3 = new RadioButton ();
		rbA2 = new RadioButton ();
		rbA1 = new RadioButton ();
		testRecBindingSource = new BindingSource (components);
		radioGroupBox2 = new DpRadioGroupBox ();
		rbB4 = new RadioButton ();
		rbB3 = new RadioButton ();
		rbB2 = new RadioButton ();
		rbB1 = new RadioButton ();
		tbNewSelection = new TextBox ();
		radioGroupBox1.SuspendLayout ();
		((System.ComponentModel.ISupportInitialize) testRecBindingSource).BeginInit ();
		radioGroupBox2.SuspendLayout ();
		SuspendLayout ();
		// 
		// ExitBtn
		// 
		ExitBtn.Location = new Point (584, 358);
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
		radioGroupBox1.Controls.Add (rbA3);
		radioGroupBox1.Controls.Add (rbA2);
		radioGroupBox1.Controls.Add (rbA1);
		radioGroupBox1.DataBindings.Add (new Binding ("SelectedTag", testRecBindingSource, "Selected1", true, DataSourceUpdateMode.OnPropertyChanged));
		radioGroupBox1.Location = new Point (57, 41);
		radioGroupBox1.Name = "radioGroupBox1";
		radioGroupBox1.SelectedTag = 0;
		radioGroupBox1.Size = new Size (245, 191);
		radioGroupBox1.TabIndex = 4;
		radioGroupBox1.TabStop = false;
		radioGroupBox1.Text = "radioGroupBox1";
		radioGroupBox1.SelectedTagChanged += OnNewSelection;
		// 
		// rbA3
		// 
		rbA3.AutoSize = true;
		rbA3.CausesValidation = false;
		rbA3.Location = new Point (30, 124);
		rbA3.Name = "rbA3";
		rbA3.Size = new Size (50, 19);
		rbA3.TabIndex = 2;
		rbA3.TabStop = true;
		rbA3.Tag = "3";
		rbA3.Text = "rbA3";
		rbA3.UseVisualStyleBackColor = true;
		// 
		// rbA2
		// 
		rbA2.AutoSize = true;
		rbA2.CausesValidation = false;
		rbA2.Location = new Point (30, 70);
		rbA2.Name = "rbA2";
		rbA2.Size = new Size (50, 19);
		rbA2.TabIndex = 2;
		rbA2.TabStop = true;
		rbA2.Tag = "2";
		rbA2.Text = "rbA2";
		rbA2.UseVisualStyleBackColor = true;
		// 
		// rbA1
		// 
		rbA1.AutoSize = true;
		rbA1.CausesValidation = false;
		rbA1.Location = new Point (30, 18);
		rbA1.Name = "rbA1";
		rbA1.Size = new Size (50, 19);
		rbA1.TabIndex = 0;
		rbA1.TabStop = true;
		rbA1.Tag = "1";
		rbA1.Text = "rbA1";
		rbA1.UseVisualStyleBackColor = true;
		// 
		// testRecBindingSource
		// 
		testRecBindingSource.DataSource = typeof (TestRec);
		testRecBindingSource.CurrentItemChanged += OnItemChanged;
		// 
		// radioGroupBox2
		// 
		radioGroupBox2.Controls.Add (rbB4);
		radioGroupBox2.Controls.Add (rbB3);
		radioGroupBox2.Controls.Add (rbB2);
		radioGroupBox2.Controls.Add (rbB1);
		radioGroupBox2.DataBindings.Add (new Binding ("SelectedTag", testRecBindingSource, "Selected2", true, DataSourceUpdateMode.OnPropertyChanged));
		radioGroupBox2.Location = new Point (367, 41);
		radioGroupBox2.Name = "radioGroupBox2";
		radioGroupBox2.SelectedTag = 0;
		radioGroupBox2.Size = new Size (261, 191);
		radioGroupBox2.TabIndex = 5;
		radioGroupBox2.TabStop = false;
		radioGroupBox2.Text = "radioGroupBox2";
		radioGroupBox2.SelectedTagChanged += OnNewSelection;
		// 
		// rbB4
		// 
		rbB4.AutoSize = true;
		rbB4.CausesValidation = false;
		rbB4.Location = new Point (27, 136);
		rbB4.Name = "rbB4";
		rbB4.Size = new Size (49, 19);
		rbB4.TabIndex = 3;
		rbB4.TabStop = true;
		rbB4.Tag = "4";
		rbB4.Text = "rbB4";
		rbB4.UseVisualStyleBackColor = true;
		// 
		// rbB3
		// 
		rbB3.AutoSize = true;
		rbB3.CausesValidation = false;
		rbB3.Location = new Point (27, 98);
		rbB3.Name = "rbB3";
		rbB3.Size = new Size (49, 19);
		rbB3.TabIndex = 2;
		rbB3.TabStop = true;
		rbB3.Tag = "3";
		rbB3.Text = "rbB3";
		rbB3.UseVisualStyleBackColor = true;
		// 
		// rbB2
		// 
		rbB2.AutoSize = true;
		rbB2.CausesValidation = false;
		rbB2.Location = new Point (27, 59);
		rbB2.Name = "rbB2";
		rbB2.Size = new Size (49, 19);
		rbB2.TabIndex = 1;
		rbB2.TabStop = true;
		rbB2.Tag = "2";
		rbB2.Text = "rbB2";
		rbB2.UseVisualStyleBackColor = true;
		// 
		// rbB1
		// 
		rbB1.AutoSize = true;
		rbB1.CausesValidation = false;
		rbB1.Location = new Point (27, 22);
		rbB1.Name = "rbB1";
		rbB1.Size = new Size (49, 19);
		rbB1.TabIndex = 0;
		rbB1.TabStop = true;
		rbB1.Tag = "1";
		rbB1.Text = "rbB1";
		rbB1.UseVisualStyleBackColor = true;
		// 
		// tbNewSelection
		// 
		tbNewSelection.Location = new Point (57, 346);
		tbNewSelection.Name = "tbNewSelection";
		tbNewSelection.Size = new Size (421, 23);
		tbNewSelection.TabIndex = 6;
		// 
		// Form1
		// 
		AutoScaleDimensions = new SizeF (7F, 15F);
		AutoScaleMode = AutoScaleMode.Font;
		ClientSize = new Size (703, 402);
		Controls.Add (tbNewSelection);
		Controls.Add (radioGroupBox2);
		Controls.Add (radioGroupBox1);
		Controls.Add (Rtb);
		Controls.Add (ExitBtn);
		Name = "Form1";
		Text = "Test Form";
		radioGroupBox1.ResumeLayout (false);
		radioGroupBox1.PerformLayout ();
		((System.ComponentModel.ISupportInitialize) testRecBindingSource).EndInit ();
		radioGroupBox2.ResumeLayout (false);
		radioGroupBox2.PerformLayout ();
		ResumeLayout (false);
		PerformLayout ();
	}

	#endregion

	private BindingSource testRecBindingSource;
	private TextBox tbNewSelection;
}