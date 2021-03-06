
// This file has been generated by the GUI designer. Do not modify.

public partial class CsvToLrWindow
{
	private global::Gtk.VBox RootContainer;
	private global::Gtk.Label lbl_CsvInstructions;
	private global::Gtk.HBox DataContainer;
	private global::Gtk.VBox MapRowsContainer;
	private global::Gtk.VBox PublishInfoContainer;
	private global::NodeInfoWidget ServerInfoWidget;
	private global::SignatureInformationWidget SignatureInformationWidget;
	private global::Gtk.Button CsvPublishButton;
	
	protected virtual void Build ()
	{
		global::Stetic.Gui.Initialize (this);
		// Widget CsvToLrWindow
		this.Name = "CsvToLrWindow";
		this.Title = global::Mono.Unix.Catalog.GetString ("Import From CSV");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		// Container child CsvToLrWindow.Gtk.Container+ContainerChild
		this.RootContainer = new global::Gtk.VBox ();
		this.RootContainer.Name = "RootContainer";
		this.RootContainer.Spacing = 6;
		this.RootContainer.BorderWidth = ((uint)(6));
		// Container child RootContainer.Gtk.Box+BoxChild
		this.lbl_CsvInstructions = new global::Gtk.Label ();
		this.lbl_CsvInstructions.WidthRequest = 500;
		this.lbl_CsvInstructions.Name = "lbl_CsvInstructions";
		this.lbl_CsvInstructions.Xpad = 6;
		this.lbl_CsvInstructions.Ypad = 5;
		this.lbl_CsvInstructions.Xalign = 0F;
		this.lbl_CsvInstructions.LabelProp = global::Mono.Unix.Catalog.GetString ("For each item on the left, choose the approprate column from the csv file that co" +
				"rresponds to the element of the resource description data model on the right:");
		this.lbl_CsvInstructions.Wrap = true;
		this.RootContainer.Add (this.lbl_CsvInstructions);
		global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.RootContainer [this.lbl_CsvInstructions]));
		w1.Position = 0;
		w1.Expand = false;
		w1.Fill = false;
		// Container child RootContainer.Gtk.Box+BoxChild
		this.DataContainer = new global::Gtk.HBox ();
		this.DataContainer.Name = "DataContainer";
		this.DataContainer.Spacing = 6;
		// Container child DataContainer.Gtk.Box+BoxChild
		this.MapRowsContainer = new global::Gtk.VBox ();
		this.MapRowsContainer.Name = "MapRowsContainer";
		this.MapRowsContainer.Spacing = 6;
		this.DataContainer.Add (this.MapRowsContainer);
		global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.DataContainer [this.MapRowsContainer]));
		w2.Position = 0;
		// Container child DataContainer.Gtk.Box+BoxChild
		this.PublishInfoContainer = new global::Gtk.VBox ();
		this.PublishInfoContainer.Name = "PublishInfoContainer";
		this.PublishInfoContainer.Spacing = 6;
		// Container child PublishInfoContainer.Gtk.Box+BoxChild
		this.ServerInfoWidget = new global::NodeInfoWidget ();
		this.ServerInfoWidget.Events = ((global::Gdk.EventMask)(256));
		this.ServerInfoWidget.Name = "ServerInfoWidget";
		this.PublishInfoContainer.Add (this.ServerInfoWidget);
		global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.PublishInfoContainer [this.ServerInfoWidget]));
		w3.Position = 0;
		w3.Expand = false;
		w3.Fill = false;
		// Container child PublishInfoContainer.Gtk.Box+BoxChild
		this.SignatureInformationWidget = new global::SignatureInformationWidget ();
		this.SignatureInformationWidget.Events = ((global::Gdk.EventMask)(256));
		this.SignatureInformationWidget.Name = "SignatureInformationWidget";
		this.PublishInfoContainer.Add (this.SignatureInformationWidget);
		global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.PublishInfoContainer [this.SignatureInformationWidget]));
		w4.Position = 1;
		w4.Expand = false;
		w4.Fill = false;
		// Container child PublishInfoContainer.Gtk.Box+BoxChild
		this.CsvPublishButton = new global::Gtk.Button ();
		this.CsvPublishButton.WidthRequest = 100;
		this.CsvPublishButton.CanFocus = true;
		this.CsvPublishButton.Name = "CsvPublishButton";
		this.CsvPublishButton.UseUnderline = true;
		this.CsvPublishButton.Label = global::Mono.Unix.Catalog.GetString ("Publish Documents");
		this.PublishInfoContainer.Add (this.CsvPublishButton);
		global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.PublishInfoContainer [this.CsvPublishButton]));
		w5.Position = 2;
		w5.Expand = false;
		w5.Fill = false;
		this.DataContainer.Add (this.PublishInfoContainer);
		global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.DataContainer [this.PublishInfoContainer]));
		w6.Position = 1;
		w6.Expand = false;
		w6.Fill = false;
		w6.Padding = ((uint)(11));
		this.RootContainer.Add (this.DataContainer);
		global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.RootContainer [this.DataContainer]));
		w7.Position = 1;
		w7.Expand = false;
		w7.Fill = false;
		this.Add (this.RootContainer);
		if ((this.Child != null)) {
			this.Child.ShowAll ();
		}
		this.DefaultWidth = 749;
		this.DefaultHeight = 532;
		this.Show ();
		this.CsvPublishButton.Clicked += new global::System.EventHandler (this.PublishDocuments);
	}
}
