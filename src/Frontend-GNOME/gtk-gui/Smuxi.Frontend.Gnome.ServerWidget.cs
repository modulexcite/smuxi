
// This file has been generated by the GUI designer. Do not modify.
namespace Smuxi.Frontend.Gnome
{
	public partial class ServerWidget
	{
		private global::Gtk.VBox vbox16;
		private global::Gtk.Table table2;
		private global::Gtk.Label f_HostnameLabel;
		private global::Gtk.ComboBoxEntry f_NetworkComboBoxEntry;
		private global::Gtk.Label f_NetworkLabel;
		private global::Gtk.Label f_PasswordLabel;
		private global::Gtk.ComboBox f_ProtocolComboBox;
		private global::Gtk.Entry f_UsernameEntry;
		private global::Gtk.HBox hbox10;
		private global::Gtk.Entry f_HostnameEntry;
		private global::Gtk.HBox hbox11;
		private global::Gtk.Label f_PortLabel;
		private global::Gtk.SpinButton f_PortSpinButton;
		private global::Gtk.HBox hbox2;
		private global::Gtk.Entry f_PasswordEntry;
		private global::Gtk.CheckButton f_ShowPasswordCheckButton;
		private global::Gtk.Label label21;
		private global::Gtk.Label label5;
		private global::Gtk.CheckButton f_OnStartupConnectCheckButton;
		private global::Gtk.CheckButton f_UseEncryptionCheckButton;
		private global::Gtk.CheckButton f_ValidateServerCertificateCheckButton;
		private global::Gtk.VBox vbox2;
		private global::Gtk.HBox hbox3;
		private global::Gtk.Label label37;
		private global::Gtk.CheckButton f_IgnoreOnConnectCommandsCheckButton;
		private global::Gtk.ScrolledWindow scrolledwindow1;
		private global::Gtk.TextView f_OnConnectCommandsTextView;
        
		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget Smuxi.Frontend.Gnome.ServerWidget
			global::Stetic.BinContainer.Attach (this);
			this.Name = "Smuxi.Frontend.Gnome.ServerWidget";
			// Container child Smuxi.Frontend.Gnome.ServerWidget.Gtk.Container+ContainerChild
			this.vbox16 = new global::Gtk.VBox ();
			this.vbox16.Name = "vbox16";
			this.vbox16.Spacing = 5;
			// Container child vbox16.Gtk.Box+BoxChild
			this.table2 = new global::Gtk.Table (((uint)(5)), ((uint)(2)), false);
			this.table2.Name = "table2";
			this.table2.RowSpacing = ((uint)(5));
			this.table2.ColumnSpacing = ((uint)(5));
			// Container child table2.Gtk.Table+TableChild
			this.f_HostnameLabel = new global::Gtk.Label ();
			this.f_HostnameLabel.Name = "f_HostnameLabel";
			this.f_HostnameLabel.Xalign = 0F;
			this.f_HostnameLabel.LabelProp = global::Mono.Unix.Catalog.GetString ("_Hostname:");
			this.f_HostnameLabel.UseUnderline = true;
			this.table2.Add (this.f_HostnameLabel);
			global::Gtk.Table.TableChild w1 = ((global::Gtk.Table.TableChild)(this.table2 [this.f_HostnameLabel]));
			w1.TopAttach = ((uint)(1));
			w1.BottomAttach = ((uint)(2));
			// Container child table2.Gtk.Table+TableChild
			this.f_NetworkComboBoxEntry = global::Gtk.ComboBoxEntry.NewText ();
			this.f_NetworkComboBoxEntry.Name = "f_NetworkComboBoxEntry";
			this.table2.Add (this.f_NetworkComboBoxEntry);
			global::Gtk.Table.TableChild w2 = ((global::Gtk.Table.TableChild)(this.table2 [this.f_NetworkComboBoxEntry]));
			w2.TopAttach = ((uint)(2));
			w2.BottomAttach = ((uint)(3));
			w2.LeftAttach = ((uint)(1));
			w2.RightAttach = ((uint)(2));
			w2.XOptions = ((global::Gtk.AttachOptions)(4));
			w2.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.f_NetworkLabel = new global::Gtk.Label ();
			this.f_NetworkLabel.Name = "f_NetworkLabel";
			this.f_NetworkLabel.Xalign = 0F;
			this.f_NetworkLabel.LabelProp = global::Mono.Unix.Catalog.GetString ("_Network:");
			this.f_NetworkLabel.UseUnderline = true;
			this.table2.Add (this.f_NetworkLabel);
			global::Gtk.Table.TableChild w3 = ((global::Gtk.Table.TableChild)(this.table2 [this.f_NetworkLabel]));
			w3.TopAttach = ((uint)(2));
			w3.BottomAttach = ((uint)(3));
			w3.XOptions = ((global::Gtk.AttachOptions)(4));
			w3.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.f_PasswordLabel = new global::Gtk.Label ();
			this.f_PasswordLabel.Name = "f_PasswordLabel";
			this.f_PasswordLabel.Xalign = 0F;
			this.f_PasswordLabel.LabelProp = global::Mono.Unix.Catalog.GetString ("_Password:");
			this.f_PasswordLabel.UseUnderline = true;
			this.table2.Add (this.f_PasswordLabel);
			global::Gtk.Table.TableChild w4 = ((global::Gtk.Table.TableChild)(this.table2 [this.f_PasswordLabel]));
			w4.TopAttach = ((uint)(4));
			w4.BottomAttach = ((uint)(5));
			// Container child table2.Gtk.Table+TableChild
			this.f_ProtocolComboBox = new global::Gtk.ComboBox ();
			this.f_ProtocolComboBox.Name = "f_ProtocolComboBox";
			this.table2.Add (this.f_ProtocolComboBox);
			global::Gtk.Table.TableChild w5 = ((global::Gtk.Table.TableChild)(this.table2 [this.f_ProtocolComboBox]));
			w5.LeftAttach = ((uint)(1));
			w5.RightAttach = ((uint)(2));
			// Container child table2.Gtk.Table+TableChild
			this.f_UsernameEntry = new global::Gtk.Entry ();
			this.f_UsernameEntry.Name = "f_UsernameEntry";
			this.f_UsernameEntry.IsEditable = true;
			this.f_UsernameEntry.InvisibleChar = '●';
			this.table2.Add (this.f_UsernameEntry);
			global::Gtk.Table.TableChild w6 = ((global::Gtk.Table.TableChild)(this.table2 [this.f_UsernameEntry]));
			w6.TopAttach = ((uint)(3));
			w6.BottomAttach = ((uint)(4));
			w6.LeftAttach = ((uint)(1));
			w6.RightAttach = ((uint)(2));
			// Container child table2.Gtk.Table+TableChild
			this.hbox10 = new global::Gtk.HBox ();
			this.hbox10.Name = "hbox10";
			// Container child hbox10.Gtk.Box+BoxChild
			this.f_HostnameEntry = new global::Gtk.Entry ();
			this.f_HostnameEntry.Name = "f_HostnameEntry";
			this.f_HostnameEntry.IsEditable = true;
			this.f_HostnameEntry.InvisibleChar = '●';
			this.hbox10.Add (this.f_HostnameEntry);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.hbox10 [this.f_HostnameEntry]));
			w7.Position = 0;
			// Container child hbox10.Gtk.Box+BoxChild
			this.hbox11 = new global::Gtk.HBox ();
			this.hbox11.Name = "hbox11";
			this.hbox11.Spacing = 5;
			// Container child hbox11.Gtk.Box+BoxChild
			this.f_PortLabel = new global::Gtk.Label ();
			this.f_PortLabel.Name = "f_PortLabel";
			this.f_PortLabel.LabelProp = global::Mono.Unix.Catalog.GetString ("_Port:");
			this.f_PortLabel.UseUnderline = true;
			this.hbox11.Add (this.f_PortLabel);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.hbox11 [this.f_PortLabel]));
			w8.Position = 0;
			// Container child hbox11.Gtk.Box+BoxChild
			this.f_PortSpinButton = new global::Gtk.SpinButton (0, 65535, 1);
			this.f_PortSpinButton.Name = "f_PortSpinButton";
			this.f_PortSpinButton.Adjustment.PageIncrement = 10;
			this.f_PortSpinButton.Adjustment.PageSize = 10;
			this.f_PortSpinButton.ClimbRate = 1;
			this.f_PortSpinButton.Numeric = true;
			this.hbox11.Add (this.f_PortSpinButton);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.hbox11 [this.f_PortSpinButton]));
			w9.Position = 1;
			this.hbox10.Add (this.hbox11);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.hbox10 [this.hbox11]));
			w10.Position = 1;
			this.table2.Add (this.hbox10);
			global::Gtk.Table.TableChild w11 = ((global::Gtk.Table.TableChild)(this.table2 [this.hbox10]));
			w11.TopAttach = ((uint)(1));
			w11.BottomAttach = ((uint)(2));
			w11.LeftAttach = ((uint)(1));
			w11.RightAttach = ((uint)(2));
			// Container child table2.Gtk.Table+TableChild
			this.hbox2 = new global::Gtk.HBox ();
			this.hbox2.Name = "hbox2";
			this.hbox2.Spacing = 6;
			// Container child hbox2.Gtk.Box+BoxChild
			this.f_PasswordEntry = new global::Gtk.Entry ();
			this.f_PasswordEntry.Name = "f_PasswordEntry";
			this.f_PasswordEntry.IsEditable = true;
			this.f_PasswordEntry.Visibility = false;
			this.f_PasswordEntry.InvisibleChar = '●';
			this.hbox2.Add (this.f_PasswordEntry);
			global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.f_PasswordEntry]));
			w12.Position = 0;
			// Container child hbox2.Gtk.Box+BoxChild
			this.f_ShowPasswordCheckButton = new global::Gtk.CheckButton ();
			this.f_ShowPasswordCheckButton.CanFocus = true;
			this.f_ShowPasswordCheckButton.Name = "f_ShowPasswordCheckButton";
			this.f_ShowPasswordCheckButton.Label = global::Mono.Unix.Catalog.GetString ("Show Password");
			this.f_ShowPasswordCheckButton.DrawIndicator = true;
			this.f_ShowPasswordCheckButton.UseUnderline = true;
			this.hbox2.Add (this.f_ShowPasswordCheckButton);
			global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.hbox2 [this.f_ShowPasswordCheckButton]));
			w13.Position = 1;
			this.table2.Add (this.hbox2);
			global::Gtk.Table.TableChild w14 = ((global::Gtk.Table.TableChild)(this.table2 [this.hbox2]));
			w14.TopAttach = ((uint)(4));
			w14.BottomAttach = ((uint)(5));
			w14.LeftAttach = ((uint)(1));
			w14.RightAttach = ((uint)(2));
			w14.XOptions = ((global::Gtk.AttachOptions)(4));
			w14.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.label21 = new global::Gtk.Label ();
			this.label21.Name = "label21";
			this.label21.Xalign = 0F;
			this.label21.LabelProp = global::Mono.Unix.Catalog.GetString ("_Username:");
			this.label21.UseUnderline = true;
			this.table2.Add (this.label21);
			global::Gtk.Table.TableChild w15 = ((global::Gtk.Table.TableChild)(this.table2 [this.label21]));
			w15.TopAttach = ((uint)(3));
			w15.BottomAttach = ((uint)(4));
			// Container child table2.Gtk.Table+TableChild
			this.label5 = new global::Gtk.Label ();
			this.label5.Name = "label5";
			this.label5.Xalign = 0F;
			this.label5.LabelProp = global::Mono.Unix.Catalog.GetString ("_Protocol:");
			this.label5.UseUnderline = true;
			this.table2.Add (this.label5);
			this.vbox16.Add (this.table2);
			global::Gtk.Box.BoxChild w17 = ((global::Gtk.Box.BoxChild)(this.vbox16 [this.table2]));
			w17.Position = 0;
			w17.Expand = false;
			// Container child vbox16.Gtk.Box+BoxChild
			this.f_OnStartupConnectCheckButton = new global::Gtk.CheckButton ();
			this.f_OnStartupConnectCheckButton.CanFocus = true;
			this.f_OnStartupConnectCheckButton.Name = "f_OnStartupConnectCheckButton";
			this.f_OnStartupConnectCheckButton.Label = global::Mono.Unix.Catalog.GetString ("Automatically connect to server at startup");
			this.f_OnStartupConnectCheckButton.DrawIndicator = true;
			this.f_OnStartupConnectCheckButton.UseUnderline = true;
			this.f_OnStartupConnectCheckButton.Xalign = 0F;
			this.vbox16.Add (this.f_OnStartupConnectCheckButton);
			global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(this.vbox16 [this.f_OnStartupConnectCheckButton]));
			w18.Position = 1;
			w18.Expand = false;
			w18.Fill = false;
			// Container child vbox16.Gtk.Box+BoxChild
			this.f_UseEncryptionCheckButton = new global::Gtk.CheckButton ();
			this.f_UseEncryptionCheckButton.CanFocus = true;
			this.f_UseEncryptionCheckButton.Name = "f_UseEncryptionCheckButton";
			this.f_UseEncryptionCheckButton.Label = global::Mono.Unix.Catalog.GetString ("Use Encryption");
			this.f_UseEncryptionCheckButton.DrawIndicator = true;
			this.f_UseEncryptionCheckButton.UseUnderline = true;
			this.vbox16.Add (this.f_UseEncryptionCheckButton);
			global::Gtk.Box.BoxChild w19 = ((global::Gtk.Box.BoxChild)(this.vbox16 [this.f_UseEncryptionCheckButton]));
			w19.Position = 2;
			w19.Expand = false;
			w19.Fill = false;
			// Container child vbox16.Gtk.Box+BoxChild
			this.f_ValidateServerCertificateCheckButton = new global::Gtk.CheckButton ();
			this.f_ValidateServerCertificateCheckButton.CanFocus = true;
			this.f_ValidateServerCertificateCheckButton.Name = "f_ValidateServerCertificateCheckButton";
			this.f_ValidateServerCertificateCheckButton.Label = global::Mono.Unix.Catalog.GetString ("Validate Server Certificate");
			this.f_ValidateServerCertificateCheckButton.DrawIndicator = true;
			this.f_ValidateServerCertificateCheckButton.UseUnderline = true;
			this.vbox16.Add (this.f_ValidateServerCertificateCheckButton);
			global::Gtk.Box.BoxChild w20 = ((global::Gtk.Box.BoxChild)(this.vbox16 [this.f_ValidateServerCertificateCheckButton]));
			w20.Position = 3;
			w20.Expand = false;
			w20.Fill = false;
			// Container child vbox16.Gtk.Box+BoxChild
			this.vbox2 = new global::Gtk.VBox ();
			this.vbox2.Name = "vbox2";
			this.vbox2.Spacing = 5;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hbox3 = new global::Gtk.HBox ();
			this.hbox3.Name = "hbox3";
			this.hbox3.Spacing = 6;
			// Container child hbox3.Gtk.Box+BoxChild
			this.label37 = new global::Gtk.Label ();
			this.label37.Name = "label37";
			this.label37.Xalign = 0F;
			this.label37.LabelProp = global::Mono.Unix.Catalog.GetString ("_On Connect Commands:");
			this.label37.UseUnderline = true;
			this.hbox3.Add (this.label37);
			global::Gtk.Box.BoxChild w21 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.label37]));
			w21.Position = 0;
			w21.Expand = false;
			w21.Fill = false;
			// Container child hbox3.Gtk.Box+BoxChild
			this.f_IgnoreOnConnectCommandsCheckButton = new global::Gtk.CheckButton ();
			this.f_IgnoreOnConnectCommandsCheckButton.CanFocus = true;
			this.f_IgnoreOnConnectCommandsCheckButton.Name = "f_IgnoreOnConnectCommandsCheckButton";
			this.f_IgnoreOnConnectCommandsCheckButton.Label = global::Mono.Unix.Catalog.GetString ("_Ignore Commands");
			this.f_IgnoreOnConnectCommandsCheckButton.DrawIndicator = true;
			this.f_IgnoreOnConnectCommandsCheckButton.UseUnderline = true;
			this.hbox3.Add (this.f_IgnoreOnConnectCommandsCheckButton);
			global::Gtk.Box.BoxChild w22 = ((global::Gtk.Box.BoxChild)(this.hbox3 [this.f_IgnoreOnConnectCommandsCheckButton]));
			w22.Position = 1;
			this.vbox2.Add (this.hbox3);
			global::Gtk.Box.BoxChild w23 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.hbox3]));
			w23.Position = 0;
			w23.Expand = false;
			w23.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.scrolledwindow1 = new global::Gtk.ScrolledWindow ();
			this.scrolledwindow1.WidthRequest = 350;
			this.scrolledwindow1.HeightRequest = 100;
			this.scrolledwindow1.Name = "scrolledwindow1";
			this.scrolledwindow1.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child scrolledwindow1.Gtk.Container+ContainerChild
			this.f_OnConnectCommandsTextView = new global::Gtk.TextView ();
			this.f_OnConnectCommandsTextView.WidthRequest = 152;
			this.f_OnConnectCommandsTextView.HeightRequest = 168;
			this.f_OnConnectCommandsTextView.Name = "f_OnConnectCommandsTextView";
			this.f_OnConnectCommandsTextView.WrapMode = ((global::Gtk.WrapMode)(2));
			this.scrolledwindow1.Add (this.f_OnConnectCommandsTextView);
			this.vbox2.Add (this.scrolledwindow1);
			global::Gtk.Box.BoxChild w25 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.scrolledwindow1]));
			w25.Position = 1;
			this.vbox16.Add (this.vbox2);
			global::Gtk.Box.BoxChild w26 = ((global::Gtk.Box.BoxChild)(this.vbox16 [this.vbox2]));
			w26.Position = 4;
			this.Add (this.vbox16);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.f_HostnameLabel.MnemonicWidget = this.f_HostnameEntry;
			this.f_NetworkLabel.MnemonicWidget = this.f_NetworkComboBoxEntry;
			this.f_PasswordLabel.MnemonicWidget = this.f_PasswordEntry;
			this.f_PortLabel.MnemonicWidget = this.f_PortSpinButton;
			this.label21.MnemonicWidget = this.f_UsernameEntry;
			this.label5.MnemonicWidget = this.f_ProtocolComboBox;
			this.label37.MnemonicWidget = this.f_OnConnectCommandsTextView;
			this.Hide ();
		}
	}
}