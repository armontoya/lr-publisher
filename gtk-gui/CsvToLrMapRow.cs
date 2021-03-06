
// This file has been generated by the GUI designer. Do not modify.

public partial class CsvToLrMapRow
{
	private global::Gtk.HBox RowContainer;
	private global::Gtk.Label lbl_ResourceDataField;
	private global::Gtk.Label lbl_MapsTo;
	private global::Gtk.ComboBox ColumnOptionsComboBox;
	private global::Gtk.Entry CustomValueEntry;
	
	protected virtual void Build ()
	{
		global::Stetic.Gui.Initialize (this);
		// Widget CsvToLrMapRow
		global::Stetic.BinContainer.Attach (this);
		this.Name = "CsvToLrMapRow";
		// Container child CsvToLrMapRow.Gtk.Container+ContainerChild
		this.RowContainer = new global::Gtk.HBox ();
		this.RowContainer.Name = "RowContainer";
		this.RowContainer.Spacing = 6;
		// Container child RowContainer.Gtk.Box+BoxChild
		this.lbl_ResourceDataField = new global::Gtk.Label ();
		this.lbl_ResourceDataField.WidthRequest = 200;
		this.lbl_ResourceDataField.Name = "lbl_ResourceDataField";
		this.lbl_ResourceDataField.Xpad = 5;
		this.lbl_ResourceDataField.Xalign = 0F;
		this.RowContainer.Add (this.lbl_ResourceDataField);
		global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.RowContainer [this.lbl_ResourceDataField]));
		w1.Position = 0;
		w1.Expand = false;
		w1.Fill = false;
		// Container child RowContainer.Gtk.Box+BoxChild
		this.lbl_MapsTo = new global::Gtk.Label ();
		this.lbl_MapsTo.Name = "lbl_MapsTo";
		this.lbl_MapsTo.LabelProp = global::Mono.Unix.Catalog.GetString ("Maps To:");
		this.RowContainer.Add (this.lbl_MapsTo);
		global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.RowContainer [this.lbl_MapsTo]));
		w2.Position = 1;
		w2.Expand = false;
		w2.Fill = false;
		// Container child RowContainer.Gtk.Box+BoxChild
		this.ColumnOptionsComboBox = global::Gtk.ComboBox.NewText ();
		this.ColumnOptionsComboBox.Name = "ColumnOptionsComboBox";
		this.RowContainer.Add (this.ColumnOptionsComboBox);
		global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.RowContainer [this.ColumnOptionsComboBox]));
		w3.Position = 2;
		w3.Expand = false;
		w3.Fill = false;
		// Container child RowContainer.Gtk.Box+BoxChild
		this.CustomValueEntry = new global::Gtk.Entry ();
		this.CustomValueEntry.CanFocus = true;
		this.CustomValueEntry.Name = "CustomValueEntry";
		this.CustomValueEntry.IsEditable = true;
		this.CustomValueEntry.InvisibleChar = '●';
		this.RowContainer.Add (this.CustomValueEntry);
		global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.RowContainer [this.CustomValueEntry]));
		w4.Position = 3;
		w4.Padding = ((uint)(5));
		this.Add (this.RowContainer);
		if ((this.Child != null)) {
			this.Child.ShowAll ();
		}
		this.CustomValueEntry.Hide ();
		this.Hide ();
		this.ColumnOptionsComboBox.Changed += new global::System.EventHandler (this.OnColumnSelectionChanged);
	}
}
