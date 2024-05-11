/************************************************************************************
 * DpRadioGroupBox.cs - Winforms control to manage a collection of RadioButtons
 ************************************************************************************/
using System.ComponentModel;

//using RadioGroupBox;

namespace DpWinForms;

/************************************************************************************
 * Class DpRadioGroupBox
 ************************************************************************************/
[DefaultBindingProperty("Selected")]
[DefaultEvent("SelectedChanged")]
[Browsable (true)] 
public class DpRadioGroupBox : GroupBox, INotifyPropertyChanged
{
	//*** Event that may be handled by a user process
	[Browsable (true)] 
	public event EventHandler<SelectedTagEventArgs> SelectedTagChanged = null;

	//*** Event for INotifyPropertyChanged
	public event PropertyChangedEventHandler PropertyChanged;

	private int _selectedTag;

	//--------------------------------------------------------------------------------
	// Constructor
	//--------------------------------------------------------------------------------
	public DpRadioGroupBox () : base () { }

	//--------------------------------------------------------------------------------
	// Property 'SelectedTag'
	//--------------------------------------------------------------------------------
	[Browsable (true)] 
	public int SelectedTag {
		//*** Getter
		get {	return _selectedTag; }

		//*** Setter
		set {
			int val = 0;
			//*** Search the list of controls for a RadioButton with the corresponding Tag
			var radioButton = this.Controls.OfType<RadioButton>()
							.FirstOrDefault(radio =>
									radio.Tag != null
								 && int.TryParse(radio.Tag.ToString(), out val) && val == value);
			//*** Set the button as 'Checked' (which automagically unchecks all others)
			if (radioButton != null) {
				radioButton.Checked = true;
				_selectedTag = val;
			}
		}
	}

	//--------------------------------------------------------------------------------
	// OnControlAdded Event - Adds a CheckedChanged event handler to the control
	//--------------------------------------------------------------------------------
	protected override void OnControlAdded (ControlEventArgs e)
	{
		base.OnControlAdded (e);

		if (e.Control is RadioButton radioButton) 
			{ radioButton.CheckedChanged += OnRadioButtonChanged; }
	}

	//--------------------------------------------------------------------------------
	// RadioButton's CheckedChanged event handler.
	//--------------------------------------------------------------------------------
	void OnRadioButtonChanged (object sender, EventArgs e)
	{
		if (sender is not RadioButton radioButton) { return; }

		//*** If the RadioButton is checked and has a valid Tag, show it as selected ...
		if (radioButton.Checked) {
			if (radioButton.Tag != null
				 && int.TryParse (radioButton.Tag.ToString (), out int val)) {
				_selectedTag = val;
				DataBindings [nameof (SelectedTag)]?.WriteValue ();

				//*** ..and create the PropertyChanged event, as required by INotifyPropertyChanged
				PropertyChanged?.Invoke (this,
					 new PropertyChangedEventArgs (nameof (SelectedTag)));

				//*** .. and creates a user event, if specified
				SelectedTagChanged?.Invoke (this, new SelectedTagEventArgs (SelectedTag));
			}
			else { 
				if (radioButton.Created) { throw new InvalidDataException
							($"RadioButton {radioButton.Name} " +
											$"does not have a valid Tag property set"); 
				}
			}
		}
	}

	//--------------------------------------------------------------------------------
	// CheckIntegrity
	//--------------------------------------------------------------------------------
	public List<string> CheckIntegrity ()
	{
		string tag;
		List<string> list = new();
		List<RadioButton> buttons = this.Controls.OfType<RadioButton>().ToList ();
		foreach (RadioButton btn in buttons) {
			if (btn.Tag == null || (tag = btn.Tag.ToString ().Trim ()).Length <= 0 ||
					!int.TryParse (tag, out int val) || val < 0) { list.Add (btn.Name); }
		}
		return list;
	}
}