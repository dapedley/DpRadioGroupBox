using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DpWinForms;

public class SelectedTagEventArgs : EventArgs
{
	public int SelectedTag { get; set; }

	public SelectedTagEventArgs () : base () { }
	public SelectedTagEventArgs (int selected) : base () { SelectedTag = selected; }
}