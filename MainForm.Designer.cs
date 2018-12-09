namespace DZEThaitro
{
    // Token: 0x02000002 RID: 2
    public partial class MainForm : global::System.Windows.Forms.Form
    {
        // Token: 0x06000018 RID: 24 RVA: 0x00003338 File Offset: 0x00001538
        protected override void Dispose(bool disposing)
        {
            bool flag = disposing && this.components != null;
            if (flag)
            {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }

        // Token: 0x06000019 RID: 25 RVA: 0x00003370 File Offset: 0x00001570
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusValueLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.SpringLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.MacroSKILLTimer = new System.Windows.Forms.Timer(this.components);
            this.SpamSKILL1CheckBox = new System.Windows.Forms.CheckBox();
            this.SpamSKILL2CheckBox = new System.Windows.Forms.CheckBox();
            this.FunctionsTab = new System.Windows.Forms.TabPage();
            this.SettingsGroup = new System.Windows.Forms.GroupBox();
            this.TabControlBody = new System.Windows.Forms.TabControl();
            this.AutopotTab = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.StatusPlayerHotkeyComboBox = new System.Windows.Forms.ComboBox();
            this.HPHotkeyComboBox = new System.Windows.Forms.ComboBox();
            this.StatusPlayerCheckBox = new System.Windows.Forms.CheckBox();
            this.PerSPNumeric = new System.Windows.Forms.NumericUpDown();
            this.SPHotkeyComboBox = new System.Windows.Forms.ComboBox();
            this.PerHPNumeric = new System.Windows.Forms.NumericUpDown();
            this.HPCheckBox = new System.Windows.Forms.CheckBox();
            this.SPCheckBox = new System.Windows.Forms.CheckBox();
            this.MacroTab = new System.Windows.Forms.TabPage();
            this.SpamSKILL1ComboBox = new System.Windows.Forms.ComboBox();
            this.SpamSKILL2ComboBox = new System.Windows.Forms.ComboBox();
            this.DisplayGroup = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.StatusPlayerValueLabel = new System.Windows.Forms.Label();
            this.StatusPlayerLabel = new System.Windows.Forms.Label();
            this.HPStatsLabel = new System.Windows.Forms.Label();
            this.HPStatsProgressBar = new System.Windows.Forms.ProgressBar();
            this.SPStatsProgressBar = new System.Windows.Forms.ProgressBar();
            this.SPStatsLabel = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.AutopotTimer = new System.Windows.Forms.Timer(this.components);
            this.IAutopotTimer = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1.SuspendLayout();
            this.FunctionsTab.SuspendLayout();
            this.SettingsGroup.SuspendLayout();
            this.TabControlBody.SuspendLayout();
            this.AutopotTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PerSPNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PerHPNumeric)).BeginInit();
            this.MacroTab.SuspendLayout();
            this.DisplayGroup.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabel,
            this.StatusValueLabel,
            this.SpringLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 334);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(334, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // StatusLabel
            // 
            this.StatusLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(48, 17);
            this.StatusLabel.Text = "Status :";
            // 
            // StatusValueLabel
            // 
            this.StatusValueLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusValueLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.StatusValueLabel.Name = "StatusValueLabel";
            this.StatusValueLabel.Size = new System.Drawing.Size(77, 17);
            this.StatusValueLabel.Text = "Disconneted";
            // 
            // SpringLabel
            // 
            this.SpringLabel.Name = "SpringLabel";
            this.SpringLabel.Size = new System.Drawing.Size(194, 17);
            this.SpringLabel.Spring = true;
            // 
            // MacroSKILLTimer
            // 
            this.MacroSKILLTimer.Interval = 1;
            this.MacroSKILLTimer.Tick += new System.EventHandler(this.MacroSKILLTimer_Tick);
            // 
            // SpamSKILL1CheckBox
            // 
            this.SpamSKILL1CheckBox.AutoSize = true;
            this.SpamSKILL1CheckBox.Location = new System.Drawing.Point(94, 12);
            this.SpamSKILL1CheckBox.Name = "SpamSKILL1CheckBox";
            this.SpamSKILL1CheckBox.Size = new System.Drawing.Size(74, 17);
            this.SpamSKILL1CheckBox.TabIndex = 3;
            this.SpamSKILL1CheckBox.Text = "Spam Key";
            this.SpamSKILL1CheckBox.UseVisualStyleBackColor = true;
            this.SpamSKILL1CheckBox.CheckedChanged += new System.EventHandler(this.SpamSKILL1CheckBox_CheckedChanged);
            // 
            // SpamSKILL2CheckBox
            // 
            this.SpamSKILL2CheckBox.AutoSize = true;
            this.SpamSKILL2CheckBox.Location = new System.Drawing.Point(94, 37);
            this.SpamSKILL2CheckBox.Name = "SpamSKILL2CheckBox";
            this.SpamSKILL2CheckBox.Size = new System.Drawing.Size(74, 17);
            this.SpamSKILL2CheckBox.TabIndex = 4;
            this.SpamSKILL2CheckBox.Text = "Spam Key";
            this.SpamSKILL2CheckBox.UseVisualStyleBackColor = true;
            // 
            // FunctionsTab
            // 
            this.FunctionsTab.Controls.Add(this.SettingsGroup);
            this.FunctionsTab.Controls.Add(this.DisplayGroup);
            this.FunctionsTab.Location = new System.Drawing.Point(4, 22);
            this.FunctionsTab.Name = "FunctionsTab";
            this.FunctionsTab.Padding = new System.Windows.Forms.Padding(3);
            this.FunctionsTab.Size = new System.Drawing.Size(326, 308);
            this.FunctionsTab.TabIndex = 3;
            this.FunctionsTab.Text = "What do u mean ?";
            this.FunctionsTab.UseVisualStyleBackColor = true;
            this.FunctionsTab.Click += new System.EventHandler(this.FunctionsTab_Click);
            // 
            // SettingsGroup
            // 
            this.SettingsGroup.Controls.Add(this.TabControlBody);
            this.SettingsGroup.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.SettingsGroup.Location = new System.Drawing.Point(3, 147);
            this.SettingsGroup.Name = "SettingsGroup";
            this.SettingsGroup.Size = new System.Drawing.Size(320, 146);
            this.SettingsGroup.TabIndex = 11;
            this.SettingsGroup.TabStop = false;
            this.SettingsGroup.Text = "Settings";
            // 
            // TabControlBody
            // 
            this.TabControlBody.Controls.Add(this.AutopotTab);
            this.TabControlBody.Controls.Add(this.MacroTab);
            this.TabControlBody.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabControlBody.Location = new System.Drawing.Point(6, 19);
            this.TabControlBody.Name = "TabControlBody";
            this.TabControlBody.SelectedIndex = 0;
            this.TabControlBody.Size = new System.Drawing.Size(308, 119);
            this.TabControlBody.TabIndex = 8;
            // 
            // AutopotTab
            // 
            this.AutopotTab.Controls.Add(this.label3);
            this.AutopotTab.Controls.Add(this.label2);
            this.AutopotTab.Controls.Add(this.label1);
            this.AutopotTab.Controls.Add(this.StatusPlayerHotkeyComboBox);
            this.AutopotTab.Controls.Add(this.HPHotkeyComboBox);
            this.AutopotTab.Controls.Add(this.StatusPlayerCheckBox);
            this.AutopotTab.Controls.Add(this.PerSPNumeric);
            this.AutopotTab.Controls.Add(this.SPHotkeyComboBox);
            this.AutopotTab.Controls.Add(this.PerHPNumeric);
            this.AutopotTab.Controls.Add(this.HPCheckBox);
            this.AutopotTab.Controls.Add(this.SPCheckBox);
            this.AutopotTab.Location = new System.Drawing.Point(4, 22);
            this.AutopotTab.Name = "AutopotTab";
            this.AutopotTab.Padding = new System.Windows.Forms.Padding(3);
            this.AutopotTab.Size = new System.Drawing.Size(300, 93);
            this.AutopotTab.TabIndex = 0;
            this.AutopotTab.Text = "Autopots";
            this.AutopotTab.UseVisualStyleBackColor = true;
            this.AutopotTab.Click += new System.EventHandler(this.AutopotTab_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Status: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "SP:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "HP: ";
            // 
            // StatusPlayerHotkeyComboBox
            // 
            this.StatusPlayerHotkeyComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StatusPlayerHotkeyComboBox.FormattingEnabled = true;
            this.StatusPlayerHotkeyComboBox.Location = new System.Drawing.Point(55, 59);
            this.StatusPlayerHotkeyComboBox.Name = "StatusPlayerHotkeyComboBox";
            this.StatusPlayerHotkeyComboBox.Size = new System.Drawing.Size(81, 21);
            this.StatusPlayerHotkeyComboBox.TabIndex = 7;
            this.StatusPlayerHotkeyComboBox.SelectedIndexChanged += new System.EventHandler(this.StatusPlayerHotkeyComboBox_SelectedIndexChanged);
            // 
            // HPHotkeyComboBox
            // 
            this.HPHotkeyComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.HPHotkeyComboBox.FormattingEnabled = true;
            this.HPHotkeyComboBox.Location = new System.Drawing.Point(55, 6);
            this.HPHotkeyComboBox.Name = "HPHotkeyComboBox";
            this.HPHotkeyComboBox.Size = new System.Drawing.Size(81, 21);
            this.HPHotkeyComboBox.TabIndex = 1;
            this.HPHotkeyComboBox.SelectedIndexChanged += new System.EventHandler(this.HPHotkeyComboBox_SelectedIndexChanged);
            // 
            // StatusPlayerCheckBox
            // 
            this.StatusPlayerCheckBox.AutoSize = true;
            this.StatusPlayerCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.StatusPlayerCheckBox.Location = new System.Drawing.Point(154, 62);
            this.StatusPlayerCheckBox.Name = "StatusPlayerCheckBox";
            this.StatusPlayerCheckBox.Size = new System.Drawing.Size(15, 14);
            this.StatusPlayerCheckBox.TabIndex = 6;
            this.StatusPlayerCheckBox.UseVisualStyleBackColor = true;
            this.StatusPlayerCheckBox.CheckedChanged += new System.EventHandler(this.AutopotCheckedChanged);
            // 
            // PerSPNumeric
            // 
            this.PerSPNumeric.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PerSPNumeric.Location = new System.Drawing.Point(175, 32);
            this.PerSPNumeric.Name = "PerSPNumeric";
            this.PerSPNumeric.Size = new System.Drawing.Size(50, 20);
            this.PerSPNumeric.TabIndex = 5;
            this.PerSPNumeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PerSPNumeric.ValueChanged += new System.EventHandler(this.PercenValueChanged);
            // 
            // SPHotkeyComboBox
            // 
            this.SPHotkeyComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SPHotkeyComboBox.FormattingEnabled = true;
            this.SPHotkeyComboBox.Location = new System.Drawing.Point(55, 32);
            this.SPHotkeyComboBox.Name = "SPHotkeyComboBox";
            this.SPHotkeyComboBox.Size = new System.Drawing.Size(81, 21);
            this.SPHotkeyComboBox.TabIndex = 4;
            this.SPHotkeyComboBox.SelectedIndexChanged += new System.EventHandler(this.SPHotkeyComboBox_SelectedIndexChanged);
            // 
            // PerHPNumeric
            // 
            this.PerHPNumeric.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PerHPNumeric.Location = new System.Drawing.Point(175, 6);
            this.PerHPNumeric.Name = "PerHPNumeric";
            this.PerHPNumeric.Size = new System.Drawing.Size(50, 20);
            this.PerHPNumeric.TabIndex = 2;
            this.PerHPNumeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PerHPNumeric.ValueChanged += new System.EventHandler(this.PercenValueChanged);
            // 
            // HPCheckBox
            // 
            this.HPCheckBox.AutoSize = true;
            this.HPCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.HPCheckBox.Location = new System.Drawing.Point(154, 6);
            this.HPCheckBox.Name = "HPCheckBox";
            this.HPCheckBox.Size = new System.Drawing.Size(15, 14);
            this.HPCheckBox.TabIndex = 0;
            this.HPCheckBox.UseVisualStyleBackColor = true;
            this.HPCheckBox.CheckedChanged += new System.EventHandler(this.AutopotCheckedChanged);
            // 
            // SPCheckBox
            // 
            this.SPCheckBox.AutoSize = true;
            this.SPCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SPCheckBox.Location = new System.Drawing.Point(154, 34);
            this.SPCheckBox.Name = "SPCheckBox";
            this.SPCheckBox.Size = new System.Drawing.Size(15, 14);
            this.SPCheckBox.TabIndex = 3;
            this.SPCheckBox.UseVisualStyleBackColor = true;
            this.SPCheckBox.CheckedChanged += new System.EventHandler(this.AutopotCheckedChanged);
            // 
            // MacroTab
            // 
            this.MacroTab.Controls.Add(this.SpamSKILL1ComboBox);
            this.MacroTab.Controls.Add(this.SpamSKILL2CheckBox);
            this.MacroTab.Controls.Add(this.SpamSKILL2ComboBox);
            this.MacroTab.Controls.Add(this.SpamSKILL1CheckBox);
            this.MacroTab.Location = new System.Drawing.Point(4, 22);
            this.MacroTab.Name = "MacroTab";
            this.MacroTab.Padding = new System.Windows.Forms.Padding(3);
            this.MacroTab.Size = new System.Drawing.Size(300, 93);
            this.MacroTab.TabIndex = 1;
            this.MacroTab.Text = "Macros";
            this.MacroTab.UseVisualStyleBackColor = true;
            // 
            // SpamSKILL1ComboBox
            // 
            this.SpamSKILL1ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SpamSKILL1ComboBox.FormattingEnabled = true;
            this.SpamSKILL1ComboBox.Items.AddRange(new object[] {
            "--",
            "F1",
            "F2",
            "F3",
            "F4",
            "F5",
            "F6",
            "F7",
            "F8",
            "F9"});
            this.SpamSKILL1ComboBox.Location = new System.Drawing.Point(13, 8);
            this.SpamSKILL1ComboBox.Name = "SpamSKILL1ComboBox";
            this.SpamSKILL1ComboBox.Size = new System.Drawing.Size(75, 21);
            this.SpamSKILL1ComboBox.TabIndex = 1;
            this.SpamSKILL1ComboBox.SelectedIndexChanged += new System.EventHandler(this.SpamSKILL1ComboBox_SelectedIndexChanged);
            // 
            // SpamSKILL2ComboBox
            // 
            this.SpamSKILL2ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SpamSKILL2ComboBox.FormattingEnabled = true;
            this.SpamSKILL2ComboBox.Items.AddRange(new object[] {
            "--",
            "F1",
            "F2",
            "F3",
            "F4",
            "F5",
            "F6",
            "F7",
            "F8",
            "F9"});
            this.SpamSKILL2ComboBox.Location = new System.Drawing.Point(13, 35);
            this.SpamSKILL2ComboBox.Name = "SpamSKILL2ComboBox";
            this.SpamSKILL2ComboBox.Size = new System.Drawing.Size(75, 21);
            this.SpamSKILL2ComboBox.TabIndex = 2;
            // 
            // DisplayGroup
            // 
            this.DisplayGroup.Controls.Add(this.label4);
            this.DisplayGroup.Controls.Add(this.button1);
            this.DisplayGroup.Controls.Add(this.StatusPlayerValueLabel);
            this.DisplayGroup.Controls.Add(this.StatusPlayerLabel);
            this.DisplayGroup.Controls.Add(this.HPStatsLabel);
            this.DisplayGroup.Controls.Add(this.HPStatsProgressBar);
            this.DisplayGroup.Controls.Add(this.SPStatsProgressBar);
            this.DisplayGroup.Controls.Add(this.SPStatsLabel);
            this.DisplayGroup.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.DisplayGroup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DisplayGroup.Location = new System.Drawing.Point(3, 6);
            this.DisplayGroup.Name = "DisplayGroup";
            this.DisplayGroup.Size = new System.Drawing.Size(320, 135);
            this.DisplayGroup.TabIndex = 10;
            this.DisplayGroup.TabStop = false;
            this.DisplayGroup.Text = "Information";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(195, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "label4";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(214, 108);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // StatusPlayerValueLabel
            // 
            this.StatusPlayerValueLabel.AutoSize = true;
            this.StatusPlayerValueLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusPlayerValueLabel.ForeColor = System.Drawing.Color.DarkViolet;
            this.StatusPlayerValueLabel.Location = new System.Drawing.Point(97, 112);
            this.StatusPlayerValueLabel.Name = "StatusPlayerValueLabel";
            this.StatusPlayerValueLabel.Size = new System.Drawing.Size(12, 15);
            this.StatusPlayerValueLabel.TabIndex = 6;
            this.StatusPlayerValueLabel.Text = "-";
            // 
            // StatusPlayerLabel
            // 
            this.StatusPlayerLabel.AutoSize = true;
            this.StatusPlayerLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.StatusPlayerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.StatusPlayerLabel.Location = new System.Drawing.Point(13, 112);
            this.StatusPlayerLabel.Name = "StatusPlayerLabel";
            this.StatusPlayerLabel.Size = new System.Drawing.Size(85, 15);
            this.StatusPlayerLabel.TabIndex = 5;
            this.StatusPlayerLabel.Text = "Status Player :";
            // 
            // HPStatsLabel
            // 
            this.HPStatsLabel.AutoSize = true;
            this.HPStatsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.HPStatsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.HPStatsLabel.Location = new System.Drawing.Point(15, 20);
            this.HPStatsLabel.Name = "HPStatsLabel";
            this.HPStatsLabel.Size = new System.Drawing.Size(35, 13);
            this.HPStatsLabel.TabIndex = 3;
            this.HPStatsLabel.Text = "0 / 0";
            // 
            // HPStatsProgressBar
            // 
            this.HPStatsProgressBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.HPStatsProgressBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.HPStatsProgressBar.Location = new System.Drawing.Point(16, 36);
            this.HPStatsProgressBar.Name = "HPStatsProgressBar";
            this.HPStatsProgressBar.Size = new System.Drawing.Size(286, 20);
            this.HPStatsProgressBar.TabIndex = 1;
            // 
            // SPStatsProgressBar
            // 
            this.SPStatsProgressBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.SPStatsProgressBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.SPStatsProgressBar.Location = new System.Drawing.Point(16, 80);
            this.SPStatsProgressBar.Name = "SPStatsProgressBar";
            this.SPStatsProgressBar.Size = new System.Drawing.Size(286, 20);
            this.SPStatsProgressBar.TabIndex = 2;
            // 
            // SPStatsLabel
            // 
            this.SPStatsLabel.AutoSize = true;
            this.SPStatsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.SPStatsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.SPStatsLabel.Location = new System.Drawing.Point(15, 64);
            this.SPStatsLabel.Name = "SPStatsLabel";
            this.SPStatsLabel.Size = new System.Drawing.Size(35, 13);
            this.SPStatsLabel.TabIndex = 4;
            this.SPStatsLabel.Text = "0 / 0";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.FunctionsTab);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(334, 334);
            this.tabControl.TabIndex = 5;
            // 
            // AutopotTimer
            // 
            this.AutopotTimer.Interval = 65;
            this.AutopotTimer.Tick += new System.EventHandler(this.AutopotTimer_Tick);
            // 
            // IAutopotTimer
            // 
            this.IAutopotTimer.Tick += new System.EventHandler(this.IAutopotTimer_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 356);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.statusStrip1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(350, 395);
            this.MinimumSize = new System.Drawing.Size(350, 395);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DZEThaitro";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.FunctionsTab.ResumeLayout(false);
            this.SettingsGroup.ResumeLayout(false);
            this.TabControlBody.ResumeLayout(false);
            this.AutopotTab.ResumeLayout(false);
            this.AutopotTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PerSPNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PerHPNumeric)).EndInit();
            this.MacroTab.ResumeLayout(false);
            this.MacroTab.PerformLayout();
            this.DisplayGroup.ResumeLayout(false);
            this.DisplayGroup.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        // Token: 0x0400001E RID: 30
        private global::System.ComponentModel.IContainer components = null;

        // Token: 0x0400001F RID: 31
        private global::System.Windows.Forms.StatusStrip statusStrip1;

        // Token: 0x04000020 RID: 32
        private global::System.Windows.Forms.ToolStripStatusLabel StatusLabel;

        // Token: 0x04000021 RID: 33
        private global::System.Windows.Forms.ToolStripStatusLabel StatusValueLabel;

        // Token: 0x04000022 RID: 34
        private global::System.Windows.Forms.Timer MacroSKILLTimer;

        // Token: 0x04000023 RID: 35
        private global::System.Windows.Forms.ToolStripStatusLabel SpringLabel;

        // Token: 0x04000024 RID: 36

        // Token: 0x04000025 RID: 37

        // Token: 0x04000026 RID: 38
        private global::System.Windows.Forms.CheckBox SpamSKILL1CheckBox;

        // Token: 0x04000027 RID: 39
        private global::System.Windows.Forms.CheckBox SpamSKILL2CheckBox;

        // Token: 0x04000028 RID: 40
        private global::System.Windows.Forms.TabPage FunctionsTab;

        // Token: 0x04000029 RID: 41
        private global::System.Windows.Forms.NumericUpDown PerSPNumeric;

        // Token: 0x0400002A RID: 42
        private global::System.Windows.Forms.ComboBox SPHotkeyComboBox;

        // Token: 0x0400002B RID: 43
        private global::System.Windows.Forms.CheckBox SPCheckBox;

        // Token: 0x0400002C RID: 44
        private global::System.Windows.Forms.ComboBox SpamSKILL2ComboBox;

        // Token: 0x0400002D RID: 45
        private global::System.Windows.Forms.NumericUpDown PerHPNumeric;

        // Token: 0x0400002E RID: 46
        private global::System.Windows.Forms.ComboBox SpamSKILL1ComboBox;

        // Token: 0x0400002F RID: 47
        private global::System.Windows.Forms.ComboBox HPHotkeyComboBox;

        // Token: 0x04000030 RID: 48
        private global::System.Windows.Forms.Label SPStatsLabel;

        // Token: 0x04000031 RID: 49
        private global::System.Windows.Forms.Label HPStatsLabel;

        // Token: 0x04000032 RID: 50
        private global::System.Windows.Forms.ProgressBar SPStatsProgressBar;

        // Token: 0x04000033 RID: 51
        private global::System.Windows.Forms.ProgressBar HPStatsProgressBar;

        // Token: 0x04000034 RID: 52
        private global::System.Windows.Forms.CheckBox HPCheckBox;

        // Token: 0x04000035 RID: 53
        private global::System.Windows.Forms.TabControl tabControl;

        // Token: 0x04000036 RID: 54
        private global::System.Windows.Forms.GroupBox DisplayGroup;

        // Token: 0x04000037 RID: 55
        private global::System.Windows.Forms.Label StatusPlayerLabel;

        // Token: 0x04000038 RID: 56
        private global::System.Windows.Forms.Label StatusPlayerValueLabel;

        // Token: 0x04000039 RID: 57
        private global::System.Windows.Forms.GroupBox SettingsGroup;

        // Token: 0x0400003A RID: 58
        private global::System.Windows.Forms.ComboBox StatusPlayerHotkeyComboBox;

        // Token: 0x0400003B RID: 59
        private global::System.Windows.Forms.CheckBox StatusPlayerCheckBox;

        // Token: 0x0400003C RID: 60
        private global::System.Windows.Forms.TabControl TabControlBody;

        // Token: 0x0400003D RID: 61
        private global::System.Windows.Forms.TabPage AutopotTab;

        // Token: 0x0400003E RID: 62
        private global::System.Windows.Forms.TabPage MacroTab;

        // Token: 0x0400003F RID: 63
        private global::System.Windows.Forms.Timer AutopotTimer;

        // Token: 0x04000040 RID: 64
        private global::System.Windows.Forms.Timer IAutopotTimer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
    }
}
