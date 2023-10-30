using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsRadioButtonTest2
{
	public partial class Form1 : Form
	{
		private RadioGroupBox groupBox1;
		private RadioButton rbA3;
		private RadioButton rbA2;
		private RadioButton rbA1;

		private RadioGroupBox groupBox2;
		private RadioButton rbB4;
		private RadioButton rbB3;
		private RadioButton rbB2;
		private RadioButton rbB1;

		private BindingSource testRecBindingSource;

		private void AddRadios ()
		{
			components = new System.ComponentModel.Container ();
			groupBox2 = new RadioGroupBox ();
			rbA3 = new RadioButton ();
			testRecBindingSource = new BindingSource (components);
			rbA2 = new RadioButton ();
			rbA1 = new RadioButton ();
			groupBox1 = new RadioGroupBox ();
			rbB4 = new RadioButton ();
			rbB3 = new RadioButton ();
			rbB2 = new RadioButton ();
			rbB1 = new RadioButton ();
			groupBox2.SuspendLayout ();
			((System.ComponentModel.ISupportInitialize) testRecBindingSource).BeginInit ();
			groupBox1.SuspendLayout ();
			SuspendLayout ();
			// 
			// groupBox2
			// 
			groupBox2.Controls.Add (rbA3);
			groupBox2.Controls.Add (rbA2);
			groupBox2.Controls.Add (rbA1);
			groupBox2.Location = new Point (428, 58);
			groupBox2.Name = "groupBox2";
			groupBox2.Size = new Size (200, 173);
			groupBox2.TabIndex = 0;
			groupBox2.TabStop = false;
			groupBox2.Text = "groupBox2";
			// 
			// rbA3
			// 
			rbA3.AutoSize = true;
			rbA3.CausesValidation = false;
			rbA3.DataBindings.Add (new Binding ("Checked", testRecBindingSource, "RbA3", true));
			rbA3.Location = new Point (30, 124);
			rbA3.Name = "rbA3";
			rbA3.Size = new Size (50, 19);
			rbA3.TabIndex = 2;
			rbA3.TabStop = true;
			rbA3.Text = "rbA3";
			rbA3.UseVisualStyleBackColor = true;
			// 
			// testRecBindingSource
			// 
			testRecBindingSource.CurrentItemChanged += OnItemChanged;
			// 
			// rbA2
			// 
			rbA2.AutoSize = true;
			rbA2.CausesValidation = false;
			rbA2.DataBindings.Add (new Binding ("Checked", testRecBindingSource, "RbA2", true));
			rbA2.Location = new Point (30, 70);
			rbA2.Name = "rbA2";
			rbA2.Size = new Size (50, 19);
			rbA2.TabIndex = 1;
			rbA2.TabStop = true;
			rbA2.Text = "rbA2";
			rbA2.UseVisualStyleBackColor = true;
			// 
			// rbA1
			// 
			rbA1.AutoSize = true;
			rbA1.CausesValidation = false;
			rbA1.DataBindings.Add (new Binding ("Checked", testRecBindingSource, "RbA1", true));
			rbA1.Location = new Point (30, 18);
			rbA1.Name = "rbA1";
			rbA1.Size = new Size (50, 19);
			rbA1.TabIndex = 0;
			rbA1.TabStop = true;
			rbA1.Text = "rbA1";
			rbA1.UseVisualStyleBackColor = true;
			rbA1.CheckedChanged += OnItemChanged;
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add (rbB4);
			groupBox1.Controls.Add (rbB3);
			groupBox1.Controls.Add (rbB2);
			groupBox1.Controls.Add (rbB1);
			groupBox1.Location = new Point (81, 58);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size (205, 173);
			groupBox1.TabIndex = 1;
			groupBox1.TabStop = false;
			groupBox1.Text = "groupBox1";
			// 
			// rbB4
			// 
			rbB4.AutoSize = true;
			rbB4.CausesValidation = false;
			rbB4.DataBindings.Add (new Binding ("Checked", testRecBindingSource, "RbB4", true));
			rbB4.Location = new Point (27, 136);
			rbB4.Name = "rbB4";
			rbB4.Size = new Size (49, 19);
			rbB4.TabIndex = 3;
			rbB4.TabStop = true;
			rbB4.Text = "rbB4";
			rbB4.UseVisualStyleBackColor = true;
			// 
			// rbB3
			// 
			rbB3.AutoSize = true;
			rbB3.CausesValidation = false;
			rbB3.DataBindings.Add (new Binding ("Checked", testRecBindingSource, "RbB3", true));
			rbB3.Location = new Point (27, 98);
			rbB3.Name = "rbB3";
			rbB3.Size = new Size (49, 19);
			rbB3.TabIndex = 2;
			rbB3.TabStop = true;
			rbB3.Text = "rbB3";
			rbB3.UseVisualStyleBackColor = true;
			// 
			// rbB2
			// 
			rbB2.AutoSize = true;
			rbB2.CausesValidation = false;
			rbB2.DataBindings.Add (new Binding ("Checked", testRecBindingSource, "RbB2", true));
			rbB2.Location = new Point (27, 59);
			rbB2.Name = "rbB2";
			rbB2.Size = new Size (49, 19);
			rbB2.TabIndex = 1;
			rbB2.TabStop = true;
			rbB2.Text = "rbB2";
			rbB2.UseVisualStyleBackColor = true;
			// 
			// rbB1
			// 
			rbB1.AutoSize = true;
			rbB1.CausesValidation = false;
			rbB1.DataBindings.Add (new Binding ("Checked", testRecBindingSource, "RbB1", true));
			rbB1.Location = new Point (27, 22);
			rbB1.Name = "rbB1";
			rbB1.Size = new Size (49, 19);
			rbB1.TabIndex = 0;
			rbB1.TabStop = true;
			rbB1.Text = "rbB1";
			rbB1.UseVisualStyleBackColor = true;
			Controls.Add (groupBox1);
			Controls.Add (groupBox2);
			groupBox2.ResumeLayout (false);
			groupBox2.PerformLayout ();
			((System.ComponentModel.ISupportInitialize) testRecBindingSource).EndInit ();
			groupBox1.ResumeLayout (false);
			groupBox1.PerformLayout ();
			ResumeLayout (false);

		}
	}
}
