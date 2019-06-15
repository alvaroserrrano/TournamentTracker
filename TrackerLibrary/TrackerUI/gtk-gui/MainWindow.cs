
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.VBox vbox1;

	private global::Gtk.HBox hbox4;

	private global::Gtk.Label label6;

	private global::Gtk.Label label8;

	private global::Gtk.HBox hbox5;

	private global::Gtk.Label label10;

	private global::Gtk.ComboBox combobox1;

	private global::Gtk.HBox hbox6;

	private global::Gtk.CheckButton checkbutton1;

	private global::Gtk.HBox hbox7;

	private global::Gtk.ComboBox combobox2;

	private global::Gtk.VBox vbox2;

	private global::Gtk.Label label1;

	private global::Gtk.Label label2;

	private global::Gtk.Button button1;

	private global::Gtk.Label label3;

	private global::Gtk.Label label5;

	private global::Gtk.Label label4;

	protected virtual void Build()
	{
		global::Stetic.Gui.Initialize(this);
		// Widget MainWindow
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString("TournamentViewer");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.vbox1 = new global::Gtk.VBox();
		this.vbox1.Name = "vbox1";
		this.vbox1.Spacing = 6;
		// Container child vbox1.Gtk.Box+BoxChild
		this.hbox4 = new global::Gtk.HBox();
		this.hbox4.Name = "hbox4";
		this.hbox4.Spacing = 6;
		// Container child hbox4.Gtk.Box+BoxChild
		this.label6 = new global::Gtk.Label();
		this.label6.WidthRequest = 354;
		this.label6.HeightRequest = 59;
		this.label6.Name = "label6";
		this.label6.LabelProp = global::Mono.Unix.Catalog.GetString("Tournament: ");
		this.label6.UseMarkup = true;
		this.hbox4.Add(this.label6);
		global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.label6]));
		w1.Position = 0;
		w1.Expand = false;
		w1.Fill = false;
		w1.Padding = ((uint)(5));
		// Container child hbox4.Gtk.Box+BoxChild
		this.label8 = new global::Gtk.Label();
		this.label8.WidthRequest = 398;
		this.label8.Name = "label8";
		this.label8.LabelProp = global::Mono.Unix.Catalog.GetString("<none>");
		this.hbox4.Add(this.label8);
		global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.label8]));
		w2.Position = 1;
		w2.Expand = false;
		w2.Fill = false;
		this.vbox1.Add(this.hbox4);
		global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hbox4]));
		w3.Position = 0;
		w3.Expand = false;
		w3.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.hbox5 = new global::Gtk.HBox();
		this.hbox5.Name = "hbox5";
		this.hbox5.Spacing = 6;
		// Container child hbox5.Gtk.Box+BoxChild
		this.label10 = new global::Gtk.Label();
		this.label10.WidthRequest = 178;
		this.label10.HeightRequest = 4;
		this.label10.Name = "label10";
		this.label10.LabelProp = global::Mono.Unix.Catalog.GetString("Round:");
		this.hbox5.Add(this.label10);
		global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox5[this.label10]));
		w4.Position = 0;
		w4.Expand = false;
		w4.Fill = false;
		// Container child hbox5.Gtk.Box+BoxChild
		this.combobox1 = global::Gtk.ComboBox.NewText();
		this.combobox1.WidthRequest = 130;
		this.combobox1.HeightRequest = 43;
		this.combobox1.Name = "combobox1";
		this.hbox5.Add(this.combobox1);
		global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hbox5[this.combobox1]));
		w5.Position = 1;
		w5.Expand = false;
		w5.Fill = false;
		this.vbox1.Add(this.hbox5);
		global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hbox5]));
		w6.Position = 1;
		w6.Expand = false;
		w6.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.hbox6 = new global::Gtk.HBox();
		this.hbox6.WidthRequest = 0;
		this.hbox6.Name = "hbox6";
		this.hbox6.Spacing = 6;
		// Container child hbox6.Gtk.Box+BoxChild
		this.checkbutton1 = new global::Gtk.CheckButton();
		this.checkbutton1.HeightRequest = 63;
		this.checkbutton1.CanFocus = true;
		this.checkbutton1.Name = "checkbutton1";
		this.checkbutton1.Label = global::Mono.Unix.Catalog.GetString("Unplayed Only");
		this.checkbutton1.DrawIndicator = true;
		this.checkbutton1.UseUnderline = true;
		this.checkbutton1.Relief = ((global::Gtk.ReliefStyle)(2));
		this.hbox6.Add(this.checkbutton1);
		global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.hbox6[this.checkbutton1]));
		w7.Position = 0;
		w7.Padding = ((uint)(189));
		this.vbox1.Add(this.hbox6);
		global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hbox6]));
		w8.Position = 2;
		w8.Expand = false;
		w8.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.hbox7 = new global::Gtk.HBox();
		this.hbox7.Name = "hbox7";
		this.hbox7.Spacing = 6;
		// Container child hbox7.Gtk.Box+BoxChild
		this.combobox2 = global::Gtk.ComboBox.NewText();
		this.combobox2.WidthRequest = 375;
		this.combobox2.HeightRequest = 286;
		this.combobox2.Name = "combobox2";
		this.hbox7.Add(this.combobox2);
		global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.hbox7[this.combobox2]));
		w9.Position = 0;
		w9.Expand = false;
		w9.Fill = false;
		// Container child hbox7.Gtk.Box+BoxChild
		this.vbox2 = new global::Gtk.VBox();
		this.vbox2.WidthRequest = 408;
		this.vbox2.HeightRequest = 0;
		this.vbox2.Name = "vbox2";
		this.vbox2.Homogeneous = true;
		this.vbox2.Spacing = 6;
		// Container child vbox2.Gtk.Box+BoxChild
		this.label1 = new global::Gtk.Label();
		this.label1.Name = "label1";
		this.label1.LabelProp = global::Mono.Unix.Catalog.GetString("Team1 ");
		this.vbox2.Add(this.label1);
		global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.label1]));
		w10.Position = 0;
		w10.Expand = false;
		w10.Fill = false;
		// Container child vbox2.Gtk.Box+BoxChild
		this.label2 = new global::Gtk.Label();
		this.label2.Name = "label2";
		this.label2.LabelProp = global::Mono.Unix.Catalog.GetString("Score");
		this.vbox2.Add(this.label2);
		global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.label2]));
		w11.Position = 1;
		w11.Expand = false;
		w11.Fill = false;
		// Container child vbox2.Gtk.Box+BoxChild
		this.button1 = new global::Gtk.Button();
		this.button1.WidthRequest = 0;
		this.button1.CanFocus = true;
		this.button1.Name = "button1";
		this.button1.UseUnderline = true;
		this.button1.Xalign = 0.93F;
		this.button1.Label = global::Mono.Unix.Catalog.GetString("Score Button");
		this.vbox2.Add(this.button1);
		global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.button1]));
		w12.Position = 2;
		w12.Expand = false;
		w12.Fill = false;
		// Container child vbox2.Gtk.Box+BoxChild
		this.label3 = new global::Gtk.Label();
		this.label3.Name = "label3";
		this.label3.LabelProp = global::Mono.Unix.Catalog.GetString("VS");
		this.vbox2.Add(this.label3);
		global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.label3]));
		w13.Position = 3;
		w13.Expand = false;
		w13.Fill = false;
		// Container child vbox2.Gtk.Box+BoxChild
		this.label5 = new global::Gtk.Label();
		this.label5.Name = "label5";
		this.label5.LabelProp = global::Mono.Unix.Catalog.GetString("Score");
		this.vbox2.Add(this.label5);
		global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.label5]));
		w14.PackType = ((global::Gtk.PackType)(1));
		w14.Position = 4;
		w14.Expand = false;
		w14.Fill = false;
		// Container child vbox2.Gtk.Box+BoxChild
		this.label4 = new global::Gtk.Label();
		this.label4.Name = "label4";
		this.label4.LabelProp = global::Mono.Unix.Catalog.GetString("Team 2");
		this.vbox2.Add(this.label4);
		global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.label4]));
		w15.PackType = ((global::Gtk.PackType)(1));
		w15.Position = 5;
		w15.Expand = false;
		w15.Fill = false;
		this.hbox7.Add(this.vbox2);
		global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.hbox7[this.vbox2]));
		w16.Position = 1;
		w16.Expand = false;
		w16.Fill = false;
		w16.Padding = ((uint)(20));
		this.vbox1.Add(this.hbox7);
		global::Gtk.Box.BoxChild w17 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hbox7]));
		w17.Position = 3;
		w17.Expand = false;
		w17.Fill = false;
		this.Add(this.vbox1);
		if ((this.Child != null))
		{
			this.Child.ShowAll();
		}
		this.DefaultWidth = 829;
		this.DefaultHeight = 579;
		this.Show();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler(this.OnDeleteEvent);
	}
}
