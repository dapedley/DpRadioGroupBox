# DpRadioGroupBox.md

## Overview

`DpRadioGroupBox` is a simple extension of `GroupBox`, which adds a property `SelectedTag`. The idea is that the developer adds any number of `RadioButtons` to the `DpRadioGroupBox` and sets the `Tag` property of each to a unique integer string value and the `SelectedTag` to the integer tag value of the initially pressed button. 

From there on, the `SelectedTag` property of the `DpRadioGroupBox` returns the integer `Tag` of the included 'RadioButton' that is checked.

If a `RadioButton` is clicked which does not have a valid tag (may be empty or contains a value that does not resolve to an integer), the button will be selected but no change will be made to `SelectedTag`. An `InvalidDataException` will be thrown, with a message that identifies the name of the offending `RadioButton1.

A utility method `CheckIntegrity` is provided to check that all `RadioButtons` in a `DpRadioGroupBox` have valid tags. It should be called immediately after `InitializeComponent` in the Form's constructor. However, it will not catch a problem where an invalid `RadioButton` is set as checked in the designer. This will cause the `InvalidDataException` to be thrown as `InitializeComponent` tries to set `SelectedTag` with an invalid value.

### Package and Namespace

The package name is DpWinControls
The namespace is **DpWinForms**.

### Using the Control

1. Ensure that the package is loaded into th Form project.
1. Drag a copy of the `DpRadioGroupBox` on to the form's design surface and set the control's `Text` property as required.
2. Drag as many `RadioButtons` as required on to the surface of the group box.
1. For each `RadioButton`, set the `Tag` property of the button to a unique integer value* and the `Text` property as appropriate.
1. Optionally, bind the `SelectedTag` property of the `DpRadioBox` to an integer property of the `BindingSource`.

*OR Set the tag in the form's Load event eg:
```
private void OnForm1Load (object sender, EventArgs e)
{
	radioButton1.Tag = "1";
	radioButton2.Tag = "2";
	radioButton1.Checked = true;
}
```

## Constructor

`public DpRadioGroupBox () : base () { }`

Simply created by `DpRadioGroupBox grpBox = new ();`

## Public Property

### SelectedTag

`public int SelectedTag { get; set; }`

`SelectedTag` gets or sets the radio button on the control that is 'checked'. The integer value corresponds to the value in the `Tag` property of the `RadioButton` concerned. If an invalid (unknown as a `Tag`) integer value is supplied to a `set` operation, no change takes place. 

## Method

### CheckIntegrity

`public List<string> CheckIntegrity ()`

Returns a list of the names of any `RadioButtons` within the `DpRadioGroupBox` which do not have valid Tag properties.

## Event

### SelectedTagChanged

`public event EventHandler<SelectedTagEventArgs> SelectedTagChanged;`

The parent control may subscribe to this event (on the `DpRadioGroupBox`), which fires when there is a change in the selected `RadioButton`. The selection state may be obtained by eg:

	`MyRadioGroup.SelectedTagChanged += MyRadioGroupChanged;`
	`...`
	private void MyRadioGroupChanged (object sender, SelectedTagEventArgs e)
	{ int newlySelectedButtonTag = e.SelectedTag; 	... }

`SelectedTagEventArgs` contains a single member `int SelectedTag`, which is the `Tag` value of the selected `RadioButton`.

Note that the event does not fire until the control has been created. Thus, it will not fire when `Checked` is set to `true` in the designer and the control then initialises. If required at initialisation, either set `Checked` to `true` or set the `SelectedTag` property in the form's `Load` event.