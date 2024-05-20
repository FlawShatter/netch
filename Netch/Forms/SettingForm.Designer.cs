using System.ComponentModel;

namespace Netch.Forms
{
    partial class SettingForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new Container();
            TabControl = new TabControl();
            GeneralTabPage = new TabPage();
            PortGroupBox = new GroupBox();
            Socks5PortLabel = new Label();
            Socks5PortTextBox = new TextBox();
            AllowDevicesCheckBox = new CheckBox();
            ServerPingTypeLabel = new Label();
            ICMPingRadioBtn = new RadioButton();
            TCPingRadioBtn = new RadioButton();
            ProfileCountLabel = new Label();
            ProfileCountTextBox = new TextBox();
            DetectionTickLabel = new Label();
            DetectionTickTextBox = new TextBox();
            StartedPingLabel = new Label();
            StartedPingIntervalTextBox = new TextBox();
            STUNServerLabel = new Label();
            STUN_ServerComboBox = new ComboBox();
            LanguageLabel = new Label();
            LanguageComboBox = new ComboBox();
            NFTabPage = new TabPage();
            FilterTCPCheckBox = new CheckBox();
            FilterUDPCheckBox = new CheckBox();
            FilterICMPCheckBox = new CheckBox();
            DNSHijackLabel = new Label();
            ICMPDelayLabel = new Label();
            ICMPDelayTextBox = new TextBox();
            FilterDNSCheckBox = new CheckBox();
            DNSHijackHostTextBox = new TextBox();
            HandleProcDNSCheckBox = new CheckBox();
            DNSProxyCheckBox = new CheckBox();
            ChildProcessHandleCheckBox = new CheckBox();
            WinTUNTabPage = new TabPage();
            WinTUNGroupBox = new GroupBox();
            TUNTAPAddressLabel = new Label();
            TUNTAPAddressTextBox = new TextBox();
            TUNTAPNetmaskLabel = new Label();
            TUNTAPNetmaskTextBox = new TextBox();
            TUNTAPGatewayLabel = new Label();
            TUNTAPGatewayTextBox = new TextBox();
            TUNTAPDNSLabel = new Label();
            TUNTAPDNSTextBox = new TextBox();
            UseCustomDNSCheckBox = new CheckBox();
            ProxyDNSCheckBox = new CheckBox();
            GlobalBypassIPsButton = new Button();
            v2rayTabPage = new TabPage();
            XrayConeCheckBox = new CheckBox();
            TLSAllowInsecureCheckBox = new CheckBox();
            UseMuxCheckBox = new CheckBox();
            TCPFastOpenBox = new CheckBox();
            KCPGroupBox = new GroupBox();
            mtuLabel = new Label();
            mtuTextBox = new TextBox();
            ttiLabel = new Label();
            ttiTextBox = new TextBox();
            uplinkCapacityLabel = new Label();
            uplinkCapacityTextBox = new TextBox();
            downlinkCapacityLabel = new Label();
            downlinkCapacityTextBox = new TextBox();
            readBufferSizeLabel = new Label();
            readBufferSizeTextBox = new TextBox();
            writeBufferSizeLabel = new Label();
            writeBufferSizeTextBox = new TextBox();
            congestionCheckBox = new CheckBox();
            OtherTabPage = new TabPage();
            ExitWhenClosedCheckBox = new CheckBox();
            StopWhenExitedCheckBox = new CheckBox();
            StartWhenOpenedCheckBox = new CheckBox();
            MinimizeWhenStartedCheckBox = new CheckBox();
            RunAtStartupCheckBox = new CheckBox();
            CheckUpdateWhenOpenedCheckBox = new CheckBox();
            NoSupportDialogCheckBox = new CheckBox();
            CheckBetaUpdateCheckBox = new CheckBox();
            UpdateServersWhenOpenedCheckBox = new CheckBox();
            AioDNSTabPage = new TabPage();
            ChinaDNSLabel = new Label();
            ChinaDNSTextBox = new TextBox();
            OtherDNSLabel = new Label();
            OtherDNSTextBox = new TextBox();
            AioDNSListenPortLabel = new Label();
            AioDNSListenPortTextBox = new TextBox();
            CoreTabPage = new TabPage();
            SSRTextBox = new TextBox();
            label16 = new Label();
            SSTextBox = new TextBox();
            label11 = new Label();
            WGComboBox = new ComboBox();
            label15 = new Label();
            SSHComboBox = new ComboBox();
            label14 = new Label();
            SSComboBox = new ComboBox();
            label13 = new Label();
            SSRComboBox = new ComboBox();
            label12 = new Label();
            SOCKSComboBox = new ComboBox();
            label10 = new Label();
            Hysteria2ComboBox = new ComboBox();
            label9 = new Label();
            HysteriaTextBox = new TextBox();
            label8 = new Label();
            TrojanTextBox = new TextBox();
            label7 = new Label();
            TrojanComboBox = new ComboBox();
            label6 = new Label();
            VLESSComboBox = new ComboBox();
            label5 = new Label();
            VMESSComboBox = new ComboBox();
            label4 = new Label();
            XrayTextBox = new TextBox();
            SingBoxTextBox = new TextBox();
            V2rayTextBox = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ControlButton = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            errorProvider = new ErrorProvider(components);
            TabControl.SuspendLayout();
            GeneralTabPage.SuspendLayout();
            PortGroupBox.SuspendLayout();
            NFTabPage.SuspendLayout();
            WinTUNTabPage.SuspendLayout();
            WinTUNGroupBox.SuspendLayout();
            v2rayTabPage.SuspendLayout();
            KCPGroupBox.SuspendLayout();
            OtherTabPage.SuspendLayout();
            AioDNSTabPage.SuspendLayout();
            CoreTabPage.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ((ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // TabControl
            // 
            TabControl.Appearance = TabAppearance.FlatButtons;
            TabControl.Controls.Add(GeneralTabPage);
            TabControl.Controls.Add(NFTabPage);
            TabControl.Controls.Add(WinTUNTabPage);
            TabControl.Controls.Add(v2rayTabPage);
            TabControl.Controls.Add(OtherTabPage);
            TabControl.Controls.Add(AioDNSTabPage);
            TabControl.Controls.Add(CoreTabPage);
            TabControl.Location = new Point(3, 3);
            TabControl.Name = "TabControl";
            TabControl.SelectedIndex = 0;
            TabControl.Size = new Size(469, 354);
            TabControl.TabIndex = 0;
            // 
            // GeneralTabPage
            // 
            GeneralTabPage.BackColor = SystemColors.ButtonFace;
            GeneralTabPage.Controls.Add(PortGroupBox);
            GeneralTabPage.Controls.Add(ServerPingTypeLabel);
            GeneralTabPage.Controls.Add(ICMPingRadioBtn);
            GeneralTabPage.Controls.Add(TCPingRadioBtn);
            GeneralTabPage.Controls.Add(ProfileCountLabel);
            GeneralTabPage.Controls.Add(ProfileCountTextBox);
            GeneralTabPage.Controls.Add(DetectionTickLabel);
            GeneralTabPage.Controls.Add(DetectionTickTextBox);
            GeneralTabPage.Controls.Add(StartedPingLabel);
            GeneralTabPage.Controls.Add(StartedPingIntervalTextBox);
            GeneralTabPage.Controls.Add(STUNServerLabel);
            GeneralTabPage.Controls.Add(STUN_ServerComboBox);
            GeneralTabPage.Controls.Add(LanguageLabel);
            GeneralTabPage.Controls.Add(LanguageComboBox);
            GeneralTabPage.Location = new Point(4, 29);
            GeneralTabPage.Name = "GeneralTabPage";
            GeneralTabPage.Padding = new Padding(3);
            GeneralTabPage.Size = new Size(461, 321);
            GeneralTabPage.TabIndex = 0;
            GeneralTabPage.Text = "General";
            // 
            // PortGroupBox
            // 
            PortGroupBox.Controls.Add(Socks5PortLabel);
            PortGroupBox.Controls.Add(Socks5PortTextBox);
            PortGroupBox.Controls.Add(AllowDevicesCheckBox);
            PortGroupBox.Location = new Point(8, 6);
            PortGroupBox.Name = "PortGroupBox";
            PortGroupBox.Size = new Size(241, 115);
            PortGroupBox.TabIndex = 0;
            PortGroupBox.TabStop = false;
            PortGroupBox.Text = "Local Port";
            // 
            // Socks5PortLabel
            // 
            Socks5PortLabel.AutoSize = true;
            Socks5PortLabel.Location = new Point(9, 25);
            Socks5PortLabel.Name = "Socks5PortLabel";
            Socks5PortLabel.Size = new Size(49, 17);
            Socks5PortLabel.TabIndex = 0;
            Socks5PortLabel.Text = "Socks5";
            // 
            // Socks5PortTextBox
            // 
            Socks5PortTextBox.Location = new Point(120, 22);
            Socks5PortTextBox.Name = "Socks5PortTextBox";
            Socks5PortTextBox.Size = new Size(90, 23);
            Socks5PortTextBox.TabIndex = 1;
            Socks5PortTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // AllowDevicesCheckBox
            // 
            AllowDevicesCheckBox.AutoSize = true;
            AllowDevicesCheckBox.Location = new Point(6, 84);
            AllowDevicesCheckBox.Name = "AllowDevicesCheckBox";
            AllowDevicesCheckBox.Size = new Size(206, 21);
            AllowDevicesCheckBox.TabIndex = 4;
            AllowDevicesCheckBox.Text = "Allow other Devices to connect";
            AllowDevicesCheckBox.TextAlign = ContentAlignment.MiddleRight;
            AllowDevicesCheckBox.UseVisualStyleBackColor = true;
            // 
            // ServerPingTypeLabel
            // 
            ServerPingTypeLabel.AutoSize = true;
            ServerPingTypeLabel.Location = new Point(267, 15);
            ServerPingTypeLabel.Name = "ServerPingTypeLabel";
            ServerPingTypeLabel.Size = new Size(86, 17);
            ServerPingTypeLabel.TabIndex = 2;
            ServerPingTypeLabel.Text = "Ping Protocol";
            // 
            // ICMPingRadioBtn
            // 
            ICMPingRadioBtn.AutoSize = true;
            ICMPingRadioBtn.Checked = true;
            ICMPingRadioBtn.Location = new Point(268, 34);
            ICMPingRadioBtn.Name = "ICMPingRadioBtn";
            ICMPingRadioBtn.Size = new Size(75, 21);
            ICMPingRadioBtn.TabIndex = 3;
            ICMPingRadioBtn.TabStop = true;
            ICMPingRadioBtn.Text = "ICMPing";
            ICMPingRadioBtn.UseVisualStyleBackColor = true;
            // 
            // TCPingRadioBtn
            // 
            TCPingRadioBtn.AutoSize = true;
            TCPingRadioBtn.Location = new Point(366, 35);
            TCPingRadioBtn.Name = "TCPingRadioBtn";
            TCPingRadioBtn.Size = new Size(66, 21);
            TCPingRadioBtn.TabIndex = 4;
            TCPingRadioBtn.Text = "TCPing";
            TCPingRadioBtn.UseVisualStyleBackColor = true;
            // 
            // ProfileCountLabel
            // 
            ProfileCountLabel.AutoSize = true;
            ProfileCountLabel.Location = new Point(15, 140);
            ProfileCountLabel.Name = "ProfileCountLabel";
            ProfileCountLabel.Size = new Size(83, 17);
            ProfileCountLabel.TabIndex = 5;
            ProfileCountLabel.Text = "Profile Count";
            // 
            // ProfileCountTextBox
            // 
            ProfileCountTextBox.Location = new Point(182, 137);
            ProfileCountTextBox.Name = "ProfileCountTextBox";
            ProfileCountTextBox.Size = new Size(70, 23);
            ProfileCountTextBox.TabIndex = 6;
            ProfileCountTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // DetectionTickLabel
            // 
            DetectionTickLabel.AutoSize = true;
            DetectionTickLabel.Location = new Point(15, 170);
            DetectionTickLabel.Name = "DetectionTickLabel";
            DetectionTickLabel.Size = new Size(117, 17);
            DetectionTickLabel.TabIndex = 7;
            DetectionTickLabel.Text = "Detection Tick(sec)";
            // 
            // DetectionTickTextBox
            // 
            DetectionTickTextBox.Location = new Point(182, 167);
            DetectionTickTextBox.Name = "DetectionTickTextBox";
            DetectionTickTextBox.Size = new Size(70, 23);
            DetectionTickTextBox.TabIndex = 8;
            DetectionTickTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // StartedPingLabel
            // 
            StartedPingLabel.AutoSize = true;
            StartedPingLabel.Location = new Point(15, 200);
            StartedPingLabel.Name = "StartedPingLabel";
            StartedPingLabel.Size = new Size(153, 17);
            StartedPingLabel.TabIndex = 9;
            StartedPingLabel.Text = "Delay test after start(sec)";
            // 
            // StartedPingIntervalTextBox
            // 
            StartedPingIntervalTextBox.Location = new Point(182, 197);
            StartedPingIntervalTextBox.Name = "StartedPingIntervalTextBox";
            StartedPingIntervalTextBox.Size = new Size(70, 23);
            StartedPingIntervalTextBox.TabIndex = 10;
            StartedPingIntervalTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // STUNServerLabel
            // 
            STUNServerLabel.AutoSize = true;
            STUNServerLabel.Location = new Point(15, 230);
            STUNServerLabel.Name = "STUNServerLabel";
            STUNServerLabel.Size = new Size(82, 17);
            STUNServerLabel.TabIndex = 11;
            STUNServerLabel.Text = "STUN Server";
            // 
            // STUN_ServerComboBox
            // 
            STUN_ServerComboBox.AutoCompleteMode = AutoCompleteMode.Suggest;
            STUN_ServerComboBox.Location = new Point(182, 227);
            STUN_ServerComboBox.Name = "STUN_ServerComboBox";
            STUN_ServerComboBox.Size = new Size(264, 25);
            STUN_ServerComboBox.TabIndex = 12;
            // 
            // LanguageLabel
            // 
            LanguageLabel.AutoSize = true;
            LanguageLabel.Location = new Point(15, 260);
            LanguageLabel.Name = "LanguageLabel";
            LanguageLabel.Size = new Size(65, 17);
            LanguageLabel.TabIndex = 13;
            LanguageLabel.Text = "Language";
            // 
            // LanguageComboBox
            // 
            LanguageComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            LanguageComboBox.FormattingEnabled = true;
            LanguageComboBox.Location = new Point(182, 257);
            LanguageComboBox.Name = "LanguageComboBox";
            LanguageComboBox.Size = new Size(110, 25);
            LanguageComboBox.TabIndex = 14;
            // 
            // NFTabPage
            // 
            NFTabPage.BackColor = SystemColors.ButtonFace;
            NFTabPage.Controls.Add(FilterTCPCheckBox);
            NFTabPage.Controls.Add(FilterUDPCheckBox);
            NFTabPage.Controls.Add(FilterICMPCheckBox);
            NFTabPage.Controls.Add(DNSHijackLabel);
            NFTabPage.Controls.Add(ICMPDelayLabel);
            NFTabPage.Controls.Add(ICMPDelayTextBox);
            NFTabPage.Controls.Add(FilterDNSCheckBox);
            NFTabPage.Controls.Add(DNSHijackHostTextBox);
            NFTabPage.Controls.Add(HandleProcDNSCheckBox);
            NFTabPage.Controls.Add(DNSProxyCheckBox);
            NFTabPage.Controls.Add(ChildProcessHandleCheckBox);
            NFTabPage.Location = new Point(4, 29);
            NFTabPage.Name = "NFTabPage";
            NFTabPage.Padding = new Padding(3);
            NFTabPage.Size = new Size(461, 321);
            NFTabPage.TabIndex = 1;
            NFTabPage.Text = "Process Mode";
            // 
            // FilterTCPCheckBox
            // 
            FilterTCPCheckBox.AutoSize = true;
            FilterTCPCheckBox.Location = new Point(16, 16);
            FilterTCPCheckBox.Name = "FilterTCPCheckBox";
            FilterTCPCheckBox.Size = new Size(94, 21);
            FilterTCPCheckBox.TabIndex = 1;
            FilterTCPCheckBox.Text = "Handle TCP";
            FilterTCPCheckBox.UseVisualStyleBackColor = true;
            // 
            // FilterUDPCheckBox
            // 
            FilterUDPCheckBox.AutoSize = true;
            FilterUDPCheckBox.Location = new Point(216, 16);
            FilterUDPCheckBox.Name = "FilterUDPCheckBox";
            FilterUDPCheckBox.Size = new Size(97, 21);
            FilterUDPCheckBox.TabIndex = 2;
            FilterUDPCheckBox.Text = "Handle UDP";
            FilterUDPCheckBox.UseVisualStyleBackColor = true;
            // 
            // FilterICMPCheckBox
            // 
            FilterICMPCheckBox.AutoSize = true;
            FilterICMPCheckBox.Location = new Point(16, 48);
            FilterICMPCheckBox.Name = "FilterICMPCheckBox";
            FilterICMPCheckBox.Size = new Size(103, 21);
            FilterICMPCheckBox.TabIndex = 3;
            FilterICMPCheckBox.Text = "Handle ICMP";
            FilterICMPCheckBox.UseVisualStyleBackColor = true;
            // 
            // DNSHijackLabel
            // 
            DNSHijackLabel.AutoSize = true;
            DNSHijackLabel.Location = new Point(48, 144);
            DNSHijackLabel.Name = "DNSHijackLabel";
            DNSHijackLabel.Size = new Size(34, 17);
            DNSHijackLabel.TabIndex = 3;
            DNSHijackLabel.Text = "DNS";
            // 
            // ICMPDelayLabel
            // 
            ICMPDelayLabel.AutoSize = true;
            ICMPDelayLabel.Location = new Point(48, 80);
            ICMPDelayLabel.Name = "ICMPDelayLabel";
            ICMPDelayLabel.Size = new Size(99, 17);
            ICMPDelayLabel.TabIndex = 3;
            ICMPDelayLabel.Text = "ICMP delay(ms)";
            // 
            // ICMPDelayTextBox
            // 
            ICMPDelayTextBox.DataBindings.Add(new Binding("Enabled", FilterICMPCheckBox, "Checked", true));
            ICMPDelayTextBox.Location = new Point(216, 80);
            ICMPDelayTextBox.Name = "ICMPDelayTextBox";
            ICMPDelayTextBox.Size = new Size(98, 23);
            ICMPDelayTextBox.TabIndex = 4;
            ICMPDelayTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // FilterDNSCheckBox
            // 
            FilterDNSCheckBox.AutoSize = true;
            FilterDNSCheckBox.Location = new Point(16, 112);
            FilterDNSCheckBox.Name = "FilterDNSCheckBox";
            FilterDNSCheckBox.Size = new Size(191, 21);
            FilterDNSCheckBox.TabIndex = 5;
            FilterDNSCheckBox.Text = "Handle DNS (DNS hijacking)";
            FilterDNSCheckBox.UseVisualStyleBackColor = true;
            // 
            // DNSHijackHostTextBox
            // 
            DNSHijackHostTextBox.DataBindings.Add(new Binding("Enabled", FilterDNSCheckBox, "Checked", true));
            DNSHijackHostTextBox.Location = new Point(216, 144);
            DNSHijackHostTextBox.Name = "DNSHijackHostTextBox";
            DNSHijackHostTextBox.Size = new Size(191, 23);
            DNSHijackHostTextBox.TabIndex = 6;
            DNSHijackHostTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // HandleProcDNSCheckBox
            // 
            HandleProcDNSCheckBox.AutoSize = true;
            HandleProcDNSCheckBox.DataBindings.Add(new Binding("Enabled", FilterDNSCheckBox, "Checked", true));
            HandleProcDNSCheckBox.Location = new Point(16, 176);
            HandleProcDNSCheckBox.Name = "HandleProcDNSCheckBox";
            HandleProcDNSCheckBox.Size = new Size(208, 21);
            HandleProcDNSCheckBox.TabIndex = 7;
            HandleProcDNSCheckBox.Text = "Handle handled process's DNS";
            HandleProcDNSCheckBox.UseVisualStyleBackColor = true;
            // 
            // DNSProxyCheckBox
            // 
            DNSProxyCheckBox.AutoSize = true;
            DNSProxyCheckBox.DataBindings.Add(new Binding("Enabled", FilterDNSCheckBox, "Checked", true));
            DNSProxyCheckBox.Location = new Point(16, 208);
            DNSProxyCheckBox.Name = "DNSProxyCheckBox";
            DNSProxyCheckBox.Size = new Size(185, 21);
            DNSProxyCheckBox.TabIndex = 8;
            DNSProxyCheckBox.Text = "Handle DNS through proxy";
            DNSProxyCheckBox.UseVisualStyleBackColor = true;
            // 
            // ChildProcessHandleCheckBox
            // 
            ChildProcessHandleCheckBox.AutoSize = true;
            ChildProcessHandleCheckBox.Location = new Point(16, 240);
            ChildProcessHandleCheckBox.Name = "ChildProcessHandleCheckBox";
            ChildProcessHandleCheckBox.Size = new Size(149, 21);
            ChildProcessHandleCheckBox.TabIndex = 9;
            ChildProcessHandleCheckBox.Text = "Handle child process";
            ChildProcessHandleCheckBox.UseVisualStyleBackColor = true;
            // 
            // WinTUNTabPage
            // 
            WinTUNTabPage.BackColor = SystemColors.ButtonFace;
            WinTUNTabPage.Controls.Add(WinTUNGroupBox);
            WinTUNTabPage.Controls.Add(GlobalBypassIPsButton);
            WinTUNTabPage.Location = new Point(4, 29);
            WinTUNTabPage.Name = "WinTUNTabPage";
            WinTUNTabPage.Padding = new Padding(3);
            WinTUNTabPage.Size = new Size(461, 321);
            WinTUNTabPage.TabIndex = 2;
            WinTUNTabPage.Text = "WinTUN";
            // 
            // WinTUNGroupBox
            // 
            WinTUNGroupBox.Controls.Add(TUNTAPAddressLabel);
            WinTUNGroupBox.Controls.Add(TUNTAPAddressTextBox);
            WinTUNGroupBox.Controls.Add(TUNTAPNetmaskLabel);
            WinTUNGroupBox.Controls.Add(TUNTAPNetmaskTextBox);
            WinTUNGroupBox.Controls.Add(TUNTAPGatewayLabel);
            WinTUNGroupBox.Controls.Add(TUNTAPGatewayTextBox);
            WinTUNGroupBox.Controls.Add(TUNTAPDNSLabel);
            WinTUNGroupBox.Controls.Add(TUNTAPDNSTextBox);
            WinTUNGroupBox.Controls.Add(UseCustomDNSCheckBox);
            WinTUNGroupBox.Controls.Add(ProxyDNSCheckBox);
            WinTUNGroupBox.Location = new Point(6, 6);
            WinTUNGroupBox.Name = "WinTUNGroupBox";
            WinTUNGroupBox.Size = new Size(450, 175);
            WinTUNGroupBox.TabIndex = 0;
            WinTUNGroupBox.TabStop = false;
            // 
            // TUNTAPAddressLabel
            // 
            TUNTAPAddressLabel.AutoSize = true;
            TUNTAPAddressLabel.Location = new Point(9, 25);
            TUNTAPAddressLabel.Name = "TUNTAPAddressLabel";
            TUNTAPAddressLabel.Size = new Size(56, 17);
            TUNTAPAddressLabel.TabIndex = 0;
            TUNTAPAddressLabel.Text = "Address";
            // 
            // TUNTAPAddressTextBox
            // 
            TUNTAPAddressTextBox.Location = new Point(120, 22);
            TUNTAPAddressTextBox.Name = "TUNTAPAddressTextBox";
            TUNTAPAddressTextBox.Size = new Size(294, 23);
            TUNTAPAddressTextBox.TabIndex = 1;
            TUNTAPAddressTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // TUNTAPNetmaskLabel
            // 
            TUNTAPNetmaskLabel.AutoSize = true;
            TUNTAPNetmaskLabel.Location = new Point(9, 54);
            TUNTAPNetmaskLabel.Name = "TUNTAPNetmaskLabel";
            TUNTAPNetmaskLabel.Size = new Size(60, 17);
            TUNTAPNetmaskLabel.TabIndex = 2;
            TUNTAPNetmaskLabel.Text = "Netmask";
            // 
            // TUNTAPNetmaskTextBox
            // 
            TUNTAPNetmaskTextBox.Location = new Point(120, 51);
            TUNTAPNetmaskTextBox.Name = "TUNTAPNetmaskTextBox";
            TUNTAPNetmaskTextBox.Size = new Size(294, 23);
            TUNTAPNetmaskTextBox.TabIndex = 3;
            TUNTAPNetmaskTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // TUNTAPGatewayLabel
            // 
            TUNTAPGatewayLabel.AutoSize = true;
            TUNTAPGatewayLabel.Location = new Point(9, 83);
            TUNTAPGatewayLabel.Name = "TUNTAPGatewayLabel";
            TUNTAPGatewayLabel.Size = new Size(57, 17);
            TUNTAPGatewayLabel.TabIndex = 4;
            TUNTAPGatewayLabel.Text = "Gateway";
            // 
            // TUNTAPGatewayTextBox
            // 
            TUNTAPGatewayTextBox.Location = new Point(120, 80);
            TUNTAPGatewayTextBox.Name = "TUNTAPGatewayTextBox";
            TUNTAPGatewayTextBox.Size = new Size(294, 23);
            TUNTAPGatewayTextBox.TabIndex = 5;
            TUNTAPGatewayTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // TUNTAPDNSLabel
            // 
            TUNTAPDNSLabel.AutoSize = true;
            TUNTAPDNSLabel.Location = new Point(9, 112);
            TUNTAPDNSLabel.Name = "TUNTAPDNSLabel";
            TUNTAPDNSLabel.Size = new Size(34, 17);
            TUNTAPDNSLabel.TabIndex = 6;
            TUNTAPDNSLabel.Text = "DNS";
            // 
            // TUNTAPDNSTextBox
            // 
            TUNTAPDNSTextBox.DataBindings.Add(new Binding("Enabled", UseCustomDNSCheckBox, "Checked", true));
            TUNTAPDNSTextBox.Location = new Point(120, 110);
            TUNTAPDNSTextBox.Name = "TUNTAPDNSTextBox";
            TUNTAPDNSTextBox.Size = new Size(294, 23);
            TUNTAPDNSTextBox.TabIndex = 7;
            TUNTAPDNSTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // UseCustomDNSCheckBox
            // 
            UseCustomDNSCheckBox.AutoSize = true;
            UseCustomDNSCheckBox.Location = new Point(10, 139);
            UseCustomDNSCheckBox.Name = "UseCustomDNSCheckBox";
            UseCustomDNSCheckBox.Size = new Size(125, 21);
            UseCustomDNSCheckBox.TabIndex = 8;
            UseCustomDNSCheckBox.Text = "Use custom DNS";
            UseCustomDNSCheckBox.UseVisualStyleBackColor = true;
            UseCustomDNSCheckBox.Click += TUNTAPUseCustomDNSCheckBox_CheckedChanged;
            // 
            // ProxyDNSCheckBox
            // 
            ProxyDNSCheckBox.AutoSize = true;
            ProxyDNSCheckBox.DataBindings.Add(new Binding("Visible", UseCustomDNSCheckBox, "Checked", true));
            ProxyDNSCheckBox.Location = new Point(175, 139);
            ProxyDNSCheckBox.Name = "ProxyDNSCheckBox";
            ProxyDNSCheckBox.Size = new Size(89, 21);
            ProxyDNSCheckBox.TabIndex = 9;
            ProxyDNSCheckBox.Text = "Proxy DNS";
            ProxyDNSCheckBox.UseVisualStyleBackColor = true;
            // 
            // GlobalBypassIPsButton
            // 
            GlobalBypassIPsButton.Location = new Point(6, 199);
            GlobalBypassIPsButton.Name = "GlobalBypassIPsButton";
            GlobalBypassIPsButton.Size = new Size(128, 23);
            GlobalBypassIPsButton.TabIndex = 1;
            GlobalBypassIPsButton.Text = "Global Bypass IPs";
            GlobalBypassIPsButton.UseVisualStyleBackColor = true;
            GlobalBypassIPsButton.Click += GlobalBypassIPsButton_Click;
            // 
            // v2rayTabPage
            // 
            v2rayTabPage.BackColor = SystemColors.ButtonFace;
            v2rayTabPage.Controls.Add(XrayConeCheckBox);
            v2rayTabPage.Controls.Add(TLSAllowInsecureCheckBox);
            v2rayTabPage.Controls.Add(UseMuxCheckBox);
            v2rayTabPage.Controls.Add(TCPFastOpenBox);
            v2rayTabPage.Controls.Add(KCPGroupBox);
            v2rayTabPage.Location = new Point(4, 29);
            v2rayTabPage.Name = "v2rayTabPage";
            v2rayTabPage.Padding = new Padding(3);
            v2rayTabPage.Size = new Size(461, 321);
            v2rayTabPage.TabIndex = 3;
            v2rayTabPage.Text = "V2Ray";
            // 
            // XrayConeCheckBox
            // 
            XrayConeCheckBox.AutoSize = true;
            XrayConeCheckBox.Location = new Point(6, 15);
            XrayConeCheckBox.Name = "XrayConeCheckBox";
            XrayConeCheckBox.Size = new Size(340, 21);
            XrayConeCheckBox.TabIndex = 0;
            XrayConeCheckBox.Text = "FullCone Support (Required Server Xray-core v1.3.0+)";
            XrayConeCheckBox.UseVisualStyleBackColor = true;
            // 
            // TLSAllowInsecureCheckBox
            // 
            TLSAllowInsecureCheckBox.AutoSize = true;
            TLSAllowInsecureCheckBox.Location = new Point(6, 42);
            TLSAllowInsecureCheckBox.Name = "TLSAllowInsecureCheckBox";
            TLSAllowInsecureCheckBox.Size = new Size(131, 21);
            TLSAllowInsecureCheckBox.TabIndex = 1;
            TLSAllowInsecureCheckBox.Text = "TLS AllowInsecure";
            TLSAllowInsecureCheckBox.UseVisualStyleBackColor = true;
            // 
            // UseMuxCheckBox
            // 
            UseMuxCheckBox.AutoSize = true;
            UseMuxCheckBox.Location = new Point(148, 42);
            UseMuxCheckBox.Name = "UseMuxCheckBox";
            UseMuxCheckBox.Size = new Size(78, 21);
            UseMuxCheckBox.TabIndex = 2;
            UseMuxCheckBox.Text = "Use Mux";
            UseMuxCheckBox.UseVisualStyleBackColor = true;
            // 
            // TCPFastOpenBox
            // 
            TCPFastOpenBox.AutoSize = true;
            TCPFastOpenBox.Location = new Point(300, 42);
            TCPFastOpenBox.Name = "TCPFastOpenBox";
            TCPFastOpenBox.Size = new Size(108, 21);
            TCPFastOpenBox.TabIndex = 3;
            TCPFastOpenBox.Text = "TCP FastOpen";
            TCPFastOpenBox.UseVisualStyleBackColor = true;
            // 
            // KCPGroupBox
            // 
            KCPGroupBox.Controls.Add(mtuLabel);
            KCPGroupBox.Controls.Add(mtuTextBox);
            KCPGroupBox.Controls.Add(ttiLabel);
            KCPGroupBox.Controls.Add(ttiTextBox);
            KCPGroupBox.Controls.Add(uplinkCapacityLabel);
            KCPGroupBox.Controls.Add(uplinkCapacityTextBox);
            KCPGroupBox.Controls.Add(downlinkCapacityLabel);
            KCPGroupBox.Controls.Add(downlinkCapacityTextBox);
            KCPGroupBox.Controls.Add(readBufferSizeLabel);
            KCPGroupBox.Controls.Add(readBufferSizeTextBox);
            KCPGroupBox.Controls.Add(writeBufferSizeLabel);
            KCPGroupBox.Controls.Add(writeBufferSizeTextBox);
            KCPGroupBox.Controls.Add(congestionCheckBox);
            KCPGroupBox.Location = new Point(9, 75);
            KCPGroupBox.Name = "KCPGroupBox";
            KCPGroupBox.Size = new Size(447, 204);
            KCPGroupBox.TabIndex = 3;
            KCPGroupBox.TabStop = false;
            KCPGroupBox.Text = "KCP";
            // 
            // mtuLabel
            // 
            mtuLabel.AutoSize = true;
            mtuLabel.Location = new Point(6, 26);
            mtuLabel.Name = "mtuLabel";
            mtuLabel.Size = new Size(30, 17);
            mtuLabel.TabIndex = 0;
            mtuLabel.Text = "mtu";
            // 
            // mtuTextBox
            // 
            mtuTextBox.Location = new Point(103, 17);
            mtuTextBox.Name = "mtuTextBox";
            mtuTextBox.Size = new Size(90, 23);
            mtuTextBox.TabIndex = 1;
            mtuTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // ttiLabel
            // 
            ttiLabel.AutoSize = true;
            ttiLabel.Location = new Point(216, 26);
            ttiLabel.Name = "ttiLabel";
            ttiLabel.Size = new Size(19, 17);
            ttiLabel.TabIndex = 2;
            ttiLabel.Text = "tti";
            // 
            // ttiTextBox
            // 
            ttiTextBox.Location = new Point(331, 17);
            ttiTextBox.Name = "ttiTextBox";
            ttiTextBox.Size = new Size(90, 23);
            ttiTextBox.TabIndex = 3;
            ttiTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // uplinkCapacityLabel
            // 
            uplinkCapacityLabel.AutoSize = true;
            uplinkCapacityLabel.Location = new Point(6, 68);
            uplinkCapacityLabel.Name = "uplinkCapacityLabel";
            uplinkCapacityLabel.Size = new Size(92, 17);
            uplinkCapacityLabel.TabIndex = 4;
            uplinkCapacityLabel.Text = "uplinkCapacity";
            // 
            // uplinkCapacityTextBox
            // 
            uplinkCapacityTextBox.Location = new Point(103, 59);
            uplinkCapacityTextBox.Name = "uplinkCapacityTextBox";
            uplinkCapacityTextBox.Size = new Size(90, 23);
            uplinkCapacityTextBox.TabIndex = 5;
            uplinkCapacityTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // downlinkCapacityLabel
            // 
            downlinkCapacityLabel.AutoSize = true;
            downlinkCapacityLabel.Location = new Point(216, 68);
            downlinkCapacityLabel.Name = "downlinkCapacityLabel";
            downlinkCapacityLabel.Size = new Size(109, 17);
            downlinkCapacityLabel.TabIndex = 6;
            downlinkCapacityLabel.Text = "downlinkCapacity";
            // 
            // downlinkCapacityTextBox
            // 
            downlinkCapacityTextBox.Location = new Point(331, 65);
            downlinkCapacityTextBox.Name = "downlinkCapacityTextBox";
            downlinkCapacityTextBox.Size = new Size(90, 23);
            downlinkCapacityTextBox.TabIndex = 7;
            downlinkCapacityTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // readBufferSizeLabel
            // 
            readBufferSizeLabel.AutoSize = true;
            readBufferSizeLabel.Location = new Point(6, 109);
            readBufferSizeLabel.Name = "readBufferSizeLabel";
            readBufferSizeLabel.Size = new Size(93, 17);
            readBufferSizeLabel.TabIndex = 8;
            readBufferSizeLabel.Text = "readBufferSize";
            // 
            // readBufferSizeTextBox
            // 
            readBufferSizeTextBox.Location = new Point(103, 100);
            readBufferSizeTextBox.Name = "readBufferSizeTextBox";
            readBufferSizeTextBox.Size = new Size(90, 23);
            readBufferSizeTextBox.TabIndex = 9;
            readBufferSizeTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // writeBufferSizeLabel
            // 
            writeBufferSizeLabel.AutoSize = true;
            writeBufferSizeLabel.Location = new Point(216, 109);
            writeBufferSizeLabel.Name = "writeBufferSizeLabel";
            writeBufferSizeLabel.Size = new Size(94, 17);
            writeBufferSizeLabel.TabIndex = 10;
            writeBufferSizeLabel.Text = "writeBufferSize";
            // 
            // writeBufferSizeTextBox
            // 
            writeBufferSizeTextBox.Location = new Point(331, 106);
            writeBufferSizeTextBox.Name = "writeBufferSizeTextBox";
            writeBufferSizeTextBox.Size = new Size(90, 23);
            writeBufferSizeTextBox.TabIndex = 11;
            writeBufferSizeTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // congestionCheckBox
            // 
            congestionCheckBox.AutoSize = true;
            congestionCheckBox.Location = new Point(8, 139);
            congestionCheckBox.Name = "congestionCheckBox";
            congestionCheckBox.Size = new Size(91, 21);
            congestionCheckBox.TabIndex = 12;
            congestionCheckBox.Text = "congestion";
            congestionCheckBox.UseVisualStyleBackColor = true;
            // 
            // OtherTabPage
            // 
            OtherTabPage.BackColor = SystemColors.ButtonFace;
            OtherTabPage.Controls.Add(ExitWhenClosedCheckBox);
            OtherTabPage.Controls.Add(StopWhenExitedCheckBox);
            OtherTabPage.Controls.Add(StartWhenOpenedCheckBox);
            OtherTabPage.Controls.Add(MinimizeWhenStartedCheckBox);
            OtherTabPage.Controls.Add(RunAtStartupCheckBox);
            OtherTabPage.Controls.Add(CheckUpdateWhenOpenedCheckBox);
            OtherTabPage.Controls.Add(NoSupportDialogCheckBox);
            OtherTabPage.Controls.Add(CheckBetaUpdateCheckBox);
            OtherTabPage.Controls.Add(UpdateServersWhenOpenedCheckBox);
            OtherTabPage.Location = new Point(4, 29);
            OtherTabPage.Name = "OtherTabPage";
            OtherTabPage.Padding = new Padding(3);
            OtherTabPage.Size = new Size(461, 321);
            OtherTabPage.TabIndex = 4;
            OtherTabPage.Text = "Others";
            // 
            // ExitWhenClosedCheckBox
            // 
            ExitWhenClosedCheckBox.AutoSize = true;
            ExitWhenClosedCheckBox.Location = new Point(16, 16);
            ExitWhenClosedCheckBox.Name = "ExitWhenClosedCheckBox";
            ExitWhenClosedCheckBox.Size = new Size(123, 21);
            ExitWhenClosedCheckBox.TabIndex = 0;
            ExitWhenClosedCheckBox.Text = "Exit when closed";
            ExitWhenClosedCheckBox.TextAlign = ContentAlignment.MiddleRight;
            ExitWhenClosedCheckBox.UseVisualStyleBackColor = true;
            // 
            // StopWhenExitedCheckBox
            // 
            StopWhenExitedCheckBox.AutoSize = true;
            StopWhenExitedCheckBox.Location = new Point(224, 18);
            StopWhenExitedCheckBox.Name = "StopWhenExitedCheckBox";
            StopWhenExitedCheckBox.Size = new Size(127, 21);
            StopWhenExitedCheckBox.TabIndex = 1;
            StopWhenExitedCheckBox.Text = "Stop when exited";
            StopWhenExitedCheckBox.TextAlign = ContentAlignment.MiddleRight;
            StopWhenExitedCheckBox.UseVisualStyleBackColor = true;
            // 
            // StartWhenOpenedCheckBox
            // 
            StartWhenOpenedCheckBox.AutoSize = true;
            StartWhenOpenedCheckBox.Location = new Point(16, 48);
            StartWhenOpenedCheckBox.Name = "StartWhenOpenedCheckBox";
            StartWhenOpenedCheckBox.Size = new Size(137, 21);
            StartWhenOpenedCheckBox.TabIndex = 2;
            StartWhenOpenedCheckBox.Text = "Start when opened";
            StartWhenOpenedCheckBox.TextAlign = ContentAlignment.MiddleRight;
            StartWhenOpenedCheckBox.UseVisualStyleBackColor = true;
            // 
            // MinimizeWhenStartedCheckBox
            // 
            MinimizeWhenStartedCheckBox.AutoSize = true;
            MinimizeWhenStartedCheckBox.Location = new Point(224, 48);
            MinimizeWhenStartedCheckBox.Name = "MinimizeWhenStartedCheckBox";
            MinimizeWhenStartedCheckBox.Size = new Size(158, 21);
            MinimizeWhenStartedCheckBox.TabIndex = 3;
            MinimizeWhenStartedCheckBox.Text = "Minimize when started";
            MinimizeWhenStartedCheckBox.UseVisualStyleBackColor = true;
            // 
            // RunAtStartupCheckBox
            // 
            RunAtStartupCheckBox.AutoSize = true;
            RunAtStartupCheckBox.Location = new Point(16, 80);
            RunAtStartupCheckBox.Name = "RunAtStartupCheckBox";
            RunAtStartupCheckBox.Size = new Size(109, 21);
            RunAtStartupCheckBox.TabIndex = 4;
            RunAtStartupCheckBox.Text = "Run at startup";
            RunAtStartupCheckBox.UseVisualStyleBackColor = true;
            // 
            // CheckUpdateWhenOpenedCheckBox
            // 
            CheckUpdateWhenOpenedCheckBox.AutoSize = true;
            CheckUpdateWhenOpenedCheckBox.Location = new Point(224, 80);
            CheckUpdateWhenOpenedCheckBox.Name = "CheckUpdateWhenOpenedCheckBox";
            CheckUpdateWhenOpenedCheckBox.Size = new Size(190, 21);
            CheckUpdateWhenOpenedCheckBox.TabIndex = 5;
            CheckUpdateWhenOpenedCheckBox.Text = "Check update when opened";
            CheckUpdateWhenOpenedCheckBox.TextAlign = ContentAlignment.MiddleRight;
            CheckUpdateWhenOpenedCheckBox.UseVisualStyleBackColor = true;
            // 
            // NoSupportDialogCheckBox
            // 
            NoSupportDialogCheckBox.AutoSize = true;
            NoSupportDialogCheckBox.Location = new Point(16, 112);
            NoSupportDialogCheckBox.Name = "NoSupportDialogCheckBox";
            NoSupportDialogCheckBox.Size = new Size(174, 21);
            NoSupportDialogCheckBox.TabIndex = 6;
            NoSupportDialogCheckBox.Text = "Disable Support Warning";
            NoSupportDialogCheckBox.UseVisualStyleBackColor = true;
            // 
            // CheckBetaUpdateCheckBox
            // 
            CheckBetaUpdateCheckBox.AutoSize = true;
            CheckBetaUpdateCheckBox.Location = new Point(224, 112);
            CheckBetaUpdateCheckBox.Name = "CheckBetaUpdateCheckBox";
            CheckBetaUpdateCheckBox.Size = new Size(137, 21);
            CheckBetaUpdateCheckBox.TabIndex = 7;
            CheckBetaUpdateCheckBox.Text = "Check Beta update";
            CheckBetaUpdateCheckBox.TextAlign = ContentAlignment.MiddleRight;
            CheckBetaUpdateCheckBox.UseVisualStyleBackColor = true;
            // 
            // UpdateServersWhenOpenedCheckBox
            // 
            UpdateServersWhenOpenedCheckBox.AutoSize = true;
            UpdateServersWhenOpenedCheckBox.Location = new Point(224, 144);
            UpdateServersWhenOpenedCheckBox.Name = "UpdateServersWhenOpenedCheckBox";
            UpdateServersWhenOpenedCheckBox.Size = new Size(200, 21);
            UpdateServersWhenOpenedCheckBox.TabIndex = 8;
            UpdateServersWhenOpenedCheckBox.Text = "Update Servers when opened";
            UpdateServersWhenOpenedCheckBox.TextAlign = ContentAlignment.MiddleRight;
            UpdateServersWhenOpenedCheckBox.UseVisualStyleBackColor = true;
            // 
            // AioDNSTabPage
            // 
            AioDNSTabPage.Controls.Add(ChinaDNSLabel);
            AioDNSTabPage.Controls.Add(ChinaDNSTextBox);
            AioDNSTabPage.Controls.Add(OtherDNSLabel);
            AioDNSTabPage.Controls.Add(OtherDNSTextBox);
            AioDNSTabPage.Controls.Add(AioDNSListenPortLabel);
            AioDNSTabPage.Controls.Add(AioDNSListenPortTextBox);
            AioDNSTabPage.Location = new Point(4, 29);
            AioDNSTabPage.Name = "AioDNSTabPage";
            AioDNSTabPage.Padding = new Padding(3);
            AioDNSTabPage.Size = new Size(461, 321);
            AioDNSTabPage.TabIndex = 5;
            AioDNSTabPage.Text = "AioDNS";
            AioDNSTabPage.UseVisualStyleBackColor = true;
            // 
            // ChinaDNSLabel
            // 
            ChinaDNSLabel.AutoSize = true;
            ChinaDNSLabel.Location = new Point(15, 23);
            ChinaDNSLabel.Name = "ChinaDNSLabel";
            ChinaDNSLabel.Size = new Size(70, 17);
            ChinaDNSLabel.TabIndex = 0;
            ChinaDNSLabel.Text = "China DNS";
            // 
            // ChinaDNSTextBox
            // 
            ChinaDNSTextBox.Location = new Point(150, 20);
            ChinaDNSTextBox.Name = "ChinaDNSTextBox";
            ChinaDNSTextBox.Size = new Size(201, 23);
            ChinaDNSTextBox.TabIndex = 1;
            ChinaDNSTextBox.TextAlign = HorizontalAlignment.Center;
            ChinaDNSTextBox.TextChanged += ChinaDNSTextBox_TextChanged;
            // 
            // OtherDNSLabel
            // 
            OtherDNSLabel.AutoSize = true;
            OtherDNSLabel.Location = new Point(15, 63);
            OtherDNSLabel.Name = "OtherDNSLabel";
            OtherDNSLabel.Size = new Size(71, 17);
            OtherDNSLabel.TabIndex = 2;
            OtherDNSLabel.Text = "Other DNS";
            // 
            // OtherDNSTextBox
            // 
            OtherDNSTextBox.Location = new Point(150, 60);
            OtherDNSTextBox.Name = "OtherDNSTextBox";
            OtherDNSTextBox.Size = new Size(201, 23);
            OtherDNSTextBox.TabIndex = 3;
            OtherDNSTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // AioDNSListenPortLabel
            // 
            AioDNSListenPortLabel.AutoSize = true;
            AioDNSListenPortLabel.Location = new Point(15, 103);
            AioDNSListenPortLabel.Name = "AioDNSListenPortLabel";
            AioDNSListenPortLabel.Size = new Size(69, 17);
            AioDNSListenPortLabel.TabIndex = 4;
            AioDNSListenPortLabel.Text = "Listen Port";
            AioDNSListenPortLabel.Visible = false;
            // 
            // AioDNSListenPortTextBox
            // 
            AioDNSListenPortTextBox.Location = new Point(150, 100);
            AioDNSListenPortTextBox.Name = "AioDNSListenPortTextBox";
            AioDNSListenPortTextBox.Size = new Size(80, 23);
            AioDNSListenPortTextBox.TabIndex = 5;
            AioDNSListenPortTextBox.TextAlign = HorizontalAlignment.Center;
            AioDNSListenPortTextBox.Visible = false;
            // 
            // CoreTabPage
            // 
            CoreTabPage.Controls.Add(SSRTextBox);
            CoreTabPage.Controls.Add(label16);
            CoreTabPage.Controls.Add(SSTextBox);
            CoreTabPage.Controls.Add(label11);
            CoreTabPage.Controls.Add(WGComboBox);
            CoreTabPage.Controls.Add(label15);
            CoreTabPage.Controls.Add(SSHComboBox);
            CoreTabPage.Controls.Add(label14);
            CoreTabPage.Controls.Add(SSComboBox);
            CoreTabPage.Controls.Add(label13);
            CoreTabPage.Controls.Add(SSRComboBox);
            CoreTabPage.Controls.Add(label12);
            CoreTabPage.Controls.Add(SOCKSComboBox);
            CoreTabPage.Controls.Add(label10);
            CoreTabPage.Controls.Add(Hysteria2ComboBox);
            CoreTabPage.Controls.Add(label9);
            CoreTabPage.Controls.Add(HysteriaTextBox);
            CoreTabPage.Controls.Add(label8);
            CoreTabPage.Controls.Add(TrojanTextBox);
            CoreTabPage.Controls.Add(label7);
            CoreTabPage.Controls.Add(TrojanComboBox);
            CoreTabPage.Controls.Add(label6);
            CoreTabPage.Controls.Add(VLESSComboBox);
            CoreTabPage.Controls.Add(label5);
            CoreTabPage.Controls.Add(VMESSComboBox);
            CoreTabPage.Controls.Add(label4);
            CoreTabPage.Controls.Add(XrayTextBox);
            CoreTabPage.Controls.Add(SingBoxTextBox);
            CoreTabPage.Controls.Add(V2rayTextBox);
            CoreTabPage.Controls.Add(label3);
            CoreTabPage.Controls.Add(label2);
            CoreTabPage.Controls.Add(label1);
            CoreTabPage.Location = new Point(4, 29);
            CoreTabPage.Name = "CoreTabPage";
            CoreTabPage.Padding = new Padding(3);
            CoreTabPage.Size = new Size(461, 321);
            CoreTabPage.TabIndex = 6;
            CoreTabPage.Text = "Core";
            CoreTabPage.UseVisualStyleBackColor = true;
            // 
            // SSRTextBox
            // 
            SSRTextBox.Location = new Point(80, 99);
            SSRTextBox.Name = "SSRTextBox";
            SSRTextBox.Size = new Size(121, 23);
            SSRTextBox.TabIndex = 34;
            SSRTextBox.Text = "ShadowsocksR.exe";
            SSRTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(15, 105);
            label16.Name = "label16";
            label16.Size = new Size(30, 17);
            label16.TabIndex = 33;
            label16.Text = "SSR";
            // 
            // SSTextBox
            // 
            SSTextBox.Location = new Point(319, 68);
            SSTextBox.Name = "SSTextBox";
            SSTextBox.Size = new Size(121, 23);
            SSTextBox.TabIndex = 32;
            SSTextBox.Text = "Shadowsocks.exe";
            SSTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(247, 74);
            label11.Name = "label11";
            label11.Size = new Size(22, 17);
            label11.TabIndex = 31;
            label11.Text = "SS";
            // 
            // WGComboBox
            // 
            WGComboBox.FormattingEnabled = true;
            WGComboBox.Items.AddRange(new object[] { "old", "V2ray", "SingBox" });
            WGComboBox.Location = new Point(319, 283);
            WGComboBox.Name = "WGComboBox";
            WGComboBox.Size = new Size(121, 25);
            WGComboBox.TabIndex = 30;
            WGComboBox.SelectedIndexChanged += WGComboBox_SelectedIndexChanged;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(247, 291);
            label15.Name = "label15";
            label15.Size = new Size(71, 17);
            label15.TabIndex = 29;
            label15.Text = "WireGuard";
            // 
            // SSHComboBox
            // 
            SSHComboBox.FormattingEnabled = true;
            SSHComboBox.Items.AddRange(new object[] { "old", "V2ray", "SingBox" });
            SSHComboBox.Location = new Point(319, 249);
            SSHComboBox.Name = "SSHComboBox";
            SSHComboBox.Size = new Size(121, 25);
            SSHComboBox.TabIndex = 28;
            SSHComboBox.SelectedIndexChanged += SSHComboBox_SelectedIndexChanged;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(247, 257);
            label14.Name = "label14";
            label14.Size = new Size(31, 17);
            label14.TabIndex = 27;
            label14.Text = "SSH";
            // 
            // SSComboBox
            // 
            SSComboBox.FormattingEnabled = true;
            SSComboBox.Items.AddRange(new object[] { "old", "SS", "SingBox", "V2ray" });
            SSComboBox.Location = new Point(80, 249);
            SSComboBox.Name = "SSComboBox";
            SSComboBox.Size = new Size(121, 25);
            SSComboBox.TabIndex = 26;
            SSComboBox.SelectedIndexChanged += SSComboBox_SelectedIndexChanged;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(15, 257);
            label13.Name = "label13";
            label13.Size = new Size(22, 17);
            label13.TabIndex = 25;
            label13.Text = "SS";
            // 
            // SSRComboBox
            // 
            SSRComboBox.FormattingEnabled = true;
            SSRComboBox.Items.AddRange(new object[] { "old", "SSR", "SingBox" });
            SSRComboBox.Location = new Point(80, 283);
            SSRComboBox.Name = "SSRComboBox";
            SSRComboBox.Size = new Size(121, 25);
            SSRComboBox.TabIndex = 24;
            SSRComboBox.SelectedIndexChanged += SSRComboBox_SelectedIndexChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(15, 291);
            label12.Name = "label12";
            label12.Size = new Size(30, 17);
            label12.TabIndex = 23;
            label12.Text = "SSR";
            // 
            // SOCKSComboBox
            // 
            SOCKSComboBox.FormattingEnabled = true;
            SOCKSComboBox.Items.AddRange(new object[] { "old", "V2ray" });
            SOCKSComboBox.Location = new Point(80, 215);
            SOCKSComboBox.Name = "SOCKSComboBox";
            SOCKSComboBox.Size = new Size(121, 25);
            SOCKSComboBox.TabIndex = 20;
            SOCKSComboBox.SelectedIndexChanged += SOCKSComboBox_SelectedIndexChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(15, 223);
            label10.Name = "label10";
            label10.Size = new Size(48, 17);
            label10.TabIndex = 19;
            label10.Text = "SOCKS";
            // 
            // Hysteria2ComboBox
            // 
            Hysteria2ComboBox.FormattingEnabled = true;
            Hysteria2ComboBox.Items.AddRange(new object[] { "old", "Hysteria", "SingBox" });
            Hysteria2ComboBox.Location = new Point(319, 181);
            Hysteria2ComboBox.Name = "Hysteria2ComboBox";
            Hysteria2ComboBox.Size = new Size(121, 25);
            Hysteria2ComboBox.TabIndex = 18;
            Hysteria2ComboBox.SelectedIndexChanged += Hysteria2ComboBox_SelectedIndexChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(247, 189);
            label9.Name = "label9";
            label9.Size = new Size(62, 17);
            label9.TabIndex = 17;
            label9.Text = "Hysteria2";
            // 
            // HysteriaTextBox
            // 
            HysteriaTextBox.Location = new Point(80, 68);
            HysteriaTextBox.Name = "HysteriaTextBox";
            HysteriaTextBox.Size = new Size(121, 23);
            HysteriaTextBox.TabIndex = 16;
            HysteriaTextBox.Text = "hysteria.exe";
            HysteriaTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(15, 74);
            label8.Name = "label8";
            label8.Size = new Size(55, 17);
            label8.TabIndex = 15;
            label8.Text = "Hysteria";
            // 
            // TrojanTextBox
            // 
            TrojanTextBox.Location = new Point(319, 38);
            TrojanTextBox.Name = "TrojanTextBox";
            TrojanTextBox.Size = new Size(121, 23);
            TrojanTextBox.TabIndex = 14;
            TrojanTextBox.Text = "Trojan.exe";
            TrojanTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(247, 44);
            label7.Name = "label7";
            label7.Size = new Size(45, 17);
            label7.TabIndex = 13;
            label7.Text = "Trojan";
            // 
            // TrojanComboBox
            // 
            TrojanComboBox.FormattingEnabled = true;
            TrojanComboBox.Items.AddRange(new object[] { "old", "SingBox", "Trojan", "Xray", "V2ray" });
            TrojanComboBox.Location = new Point(80, 181);
            TrojanComboBox.Name = "TrojanComboBox";
            TrojanComboBox.Size = new Size(121, 25);
            TrojanComboBox.TabIndex = 12;
            TrojanComboBox.SelectedIndexChanged += TrojanComboBox_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(15, 189);
            label6.Name = "label6";
            label6.Size = new Size(45, 17);
            label6.TabIndex = 11;
            label6.Text = "Trojan";
            // 
            // VLESSComboBox
            // 
            VLESSComboBox.FormattingEnabled = true;
            VLESSComboBox.Items.AddRange(new object[] { "old", "Xray", "SingBox" });
            VLESSComboBox.Location = new Point(319, 147);
            VLESSComboBox.Name = "VLESSComboBox";
            VLESSComboBox.Size = new Size(121, 25);
            VLESSComboBox.TabIndex = 10;
            VLESSComboBox.SelectedIndexChanged += VLESSComboBox_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(247, 155);
            label5.Name = "label5";
            label5.Size = new Size(43, 17);
            label5.TabIndex = 9;
            label5.Text = "VLESS";
            // 
            // VMESSComboBox
            // 
            VMESSComboBox.FormattingEnabled = true;
            VMESSComboBox.Items.AddRange(new object[] { "old", "V2ray", "Xray", "SingBox" });
            VMESSComboBox.Location = new Point(80, 147);
            VMESSComboBox.Name = "VMESSComboBox";
            VMESSComboBox.Size = new Size(121, 25);
            VMESSComboBox.TabIndex = 8;
            VMESSComboBox.SelectedIndexChanged += VMESSComboBox_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 155);
            label4.Name = "label4";
            label4.Size = new Size(49, 17);
            label4.TabIndex = 7;
            label4.Text = "VMESS";
            // 
            // XrayTextBox
            // 
            XrayTextBox.Location = new Point(80, 38);
            XrayTextBox.Name = "XrayTextBox";
            XrayTextBox.Size = new Size(121, 23);
            XrayTextBox.TabIndex = 6;
            XrayTextBox.Text = "xray.exe";
            XrayTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // SingBoxTextBox
            // 
            SingBoxTextBox.Location = new Point(319, 7);
            SingBoxTextBox.Name = "SingBoxTextBox";
            SingBoxTextBox.Size = new Size(121, 23);
            SingBoxTextBox.TabIndex = 5;
            SingBoxTextBox.Text = "sing-box.exe";
            SingBoxTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // V2rayTextBox
            // 
            V2rayTextBox.Location = new Point(80, 7);
            V2rayTextBox.Name = "V2rayTextBox";
            V2rayTextBox.Size = new Size(121, 23);
            V2rayTextBox.TabIndex = 4;
            V2rayTextBox.Text = "v2ray-sn.exe";
            V2rayTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 44);
            label3.Name = "label3";
            label3.Size = new Size(34, 17);
            label3.TabIndex = 3;
            label3.Text = "Xray";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(247, 13);
            label2.Name = "label2";
            label2.Size = new Size(55, 17);
            label2.TabIndex = 2;
            label2.Text = "SingBox";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 13);
            label1.Name = "label1";
            label1.Size = new Size(41, 17);
            label1.TabIndex = 1;
            label1.Text = "V2ray";
            // 
            // ControlButton
            // 
            ControlButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ControlButton.Location = new Point(397, 363);
            ControlButton.Name = "ControlButton";
            ControlButton.Size = new Size(75, 23);
            ControlButton.TabIndex = 1;
            ControlButton.Text = "Save";
            ControlButton.UseVisualStyleBackColor = true;
            ControlButton.Click += ControlButton_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel1.Controls.Add(TabControl);
            flowLayoutPanel1.Controls.Add(ControlButton);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(480, 400);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // errorProvider
            // 
            errorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider.ContainerControl = this;
            // 
            // SettingForm
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(480, 400);
            Controls.Add(flowLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "SettingForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Settings";
            Load += SettingForm_Load;
            TabControl.ResumeLayout(false);
            GeneralTabPage.ResumeLayout(false);
            GeneralTabPage.PerformLayout();
            PortGroupBox.ResumeLayout(false);
            PortGroupBox.PerformLayout();
            NFTabPage.ResumeLayout(false);
            NFTabPage.PerformLayout();
            WinTUNTabPage.ResumeLayout(false);
            WinTUNGroupBox.ResumeLayout(false);
            WinTUNGroupBox.PerformLayout();
            v2rayTabPage.ResumeLayout(false);
            v2rayTabPage.PerformLayout();
            KCPGroupBox.ResumeLayout(false);
            KCPGroupBox.PerformLayout();
            OtherTabPage.ResumeLayout(false);
            OtherTabPage.PerformLayout();
            AioDNSTabPage.ResumeLayout(false);
            AioDNSTabPage.PerformLayout();
            CoreTabPage.ResumeLayout(false);
            CoreTabPage.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            ((ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.CheckBox XrayConeCheckBox;
        private System.Windows.Forms.TextBox StartedPingIntervalTextBox;

        #endregion

        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage GeneralTabPage;
        private System.Windows.Forms.TabPage NFTabPage;
        private System.Windows.Forms.TabPage WinTUNTabPage;
        private System.Windows.Forms.TabPage v2rayTabPage;
        private System.Windows.Forms.GroupBox PortGroupBox;
        private System.Windows.Forms.CheckBox AllowDevicesCheckBox;
        private System.Windows.Forms.Label Socks5PortLabel;
        private System.Windows.Forms.TextBox Socks5PortTextBox;
        private System.Windows.Forms.GroupBox WinTUNGroupBox;
        private System.Windows.Forms.CheckBox ProxyDNSCheckBox;
        private System.Windows.Forms.CheckBox UseCustomDNSCheckBox;
        private System.Windows.Forms.Label TUNTAPDNSLabel;
        private System.Windows.Forms.TextBox TUNTAPDNSTextBox;
        private System.Windows.Forms.Label TUNTAPGatewayLabel;
        private System.Windows.Forms.TextBox TUNTAPGatewayTextBox;
        private System.Windows.Forms.Label TUNTAPNetmaskLabel;
        private System.Windows.Forms.TextBox TUNTAPNetmaskTextBox;
        private System.Windows.Forms.Label TUNTAPAddressLabel;
        private System.Windows.Forms.TextBox TUNTAPAddressTextBox;
        private System.Windows.Forms.Button GlobalBypassIPsButton;
        private System.Windows.Forms.CheckBox FilterDNSCheckBox;
        private System.Windows.Forms.Button ControlButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TabPage OtherTabPage;
        private System.Windows.Forms.CheckBox UpdateServersWhenOpenedCheckBox;
        private System.Windows.Forms.CheckBox RunAtStartupCheckBox;
        private System.Windows.Forms.CheckBox MinimizeWhenStartedCheckBox;
        private System.Windows.Forms.CheckBox CheckBetaUpdateCheckBox;
        private System.Windows.Forms.CheckBox CheckUpdateWhenOpenedCheckBox;
        private System.Windows.Forms.CheckBox StartWhenOpenedCheckBox;
        private System.Windows.Forms.CheckBox StopWhenExitedCheckBox;
        private System.Windows.Forms.CheckBox ExitWhenClosedCheckBox;
        private System.Windows.Forms.Label LanguageLabel;
        private System.Windows.Forms.ComboBox LanguageComboBox;
        private System.Windows.Forms.Label DetectionTickLabel;
        private System.Windows.Forms.TextBox DetectionTickTextBox;
        private System.Windows.Forms.Label StartedPingLabel;
        private System.Windows.Forms.Label STUNServerLabel;
        private System.Windows.Forms.ComboBox STUN_ServerComboBox;
        private System.Windows.Forms.Label ProfileCountLabel;
        private System.Windows.Forms.TextBox ProfileCountTextBox;
        private System.Windows.Forms.GroupBox KCPGroupBox;
        private System.Windows.Forms.CheckBox congestionCheckBox;
        private System.Windows.Forms.CheckBox TLSAllowInsecureCheckBox;
        private System.Windows.Forms.CheckBox TCPFastOpenBox;
        private System.Windows.Forms.Label mtuLabel;
        private System.Windows.Forms.TextBox mtuTextBox;
        private System.Windows.Forms.Label writeBufferSizeLabel;
        private System.Windows.Forms.TextBox writeBufferSizeTextBox;
        private System.Windows.Forms.Label readBufferSizeLabel;
        private System.Windows.Forms.TextBox readBufferSizeTextBox;
        private System.Windows.Forms.Label downlinkCapacityLabel;
        private System.Windows.Forms.TextBox downlinkCapacityTextBox;
        private System.Windows.Forms.Label uplinkCapacityLabel;
        private System.Windows.Forms.TextBox uplinkCapacityTextBox;
        private System.Windows.Forms.Label ttiLabel;
        private System.Windows.Forms.TextBox ttiTextBox;
        private System.Windows.Forms.CheckBox UseMuxCheckBox;
        private System.Windows.Forms.TabPage AioDNSTabPage;
        private System.Windows.Forms.Label AioDNSListenPortLabel;
        private System.Windows.Forms.TextBox AioDNSListenPortTextBox;
        private System.Windows.Forms.Label OtherDNSLabel;
        private System.Windows.Forms.Label ChinaDNSLabel;
        private System.Windows.Forms.TextBox OtherDNSTextBox;
        private System.Windows.Forms.TextBox ChinaDNSTextBox;
        private System.Windows.Forms.TextBox DNSHijackHostTextBox;
        private System.Windows.Forms.Label ServerPingTypeLabel;
        private System.Windows.Forms.RadioButton TCPingRadioBtn;
        private System.Windows.Forms.RadioButton ICMPingRadioBtn;
        private System.Windows.Forms.CheckBox FilterICMPCheckBox;
        private System.Windows.Forms.CheckBox ChildProcessHandleCheckBox;
        private System.Windows.Forms.TextBox ICMPDelayTextBox;
        private System.Windows.Forms.Label ICMPDelayLabel;
        private System.Windows.Forms.CheckBox NoSupportDialogCheckBox;
        private System.Windows.Forms.Label DNSHijackLabel;
        private System.Windows.Forms.CheckBox HandleProcDNSCheckBox;
        private System.Windows.Forms.CheckBox FilterTCPCheckBox;
        private System.Windows.Forms.CheckBox FilterUDPCheckBox;
        private System.Windows.Forms.CheckBox DNSProxyCheckBox;
        private ErrorProvider errorProvider;
        private TabPage CoreTabPage;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBox3;
        private TextBox textBox2;
        private Label label4;
        private ComboBox VMESSComboBox;
        private Label label5;
        private Label label6;
        private ComboBox VLESSComboBox;
        private ComboBox TrojanComboBox;
        private TextBox v2rayTextBox;
        private TextBox XrayTextBox;
        private TextBox V2rayTextBox;
        private Label label7;
        private TextBox SingBoxtextBox;
        private TextBox TrojanTextBox;
        private TextBox SingBoxTextBox;
        private TextBox HysteriaTextBox;
        private Label label8;
        private ComboBox HysteriaComboBox;
        private Label label9;
        private ComboBox SSRComboBox;
        private Label label12;
        private ComboBox SOCKSComboBox;
        private Label label10;
        private ComboBox SSComboBox;
        private Label label13;
        private ComboBox WGComboBox;
        private Label label15;
        private ComboBox SSHComboBox;
        private Label label14;
        private TextBox SSTextBox;
        private Label label11;
        private TextBox SSRTextBox;
        private Label label16;
        private ComboBox Hysteria2ComboBox;
    }
}