﻿namespace TowerUniteMidiDotNet.Windows
{
	partial class MainWindow
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
                playbackTimer?.Dispose();
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.TabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.OctaveTranspositionSlider = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.StopListeningButton = new System.Windows.Forms.Button();
            this.StartListeningButton = new System.Windows.Forms.Button();
            this.InputDeviceScanButton = new System.Windows.Forms.Button();
            this.DeviceComboBox = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MIDIPlaybackTransposeSlider = new System.Windows.Forms.TrackBar();
            this.MIDIPlaybackSpeedSlider = new System.Windows.Forms.TrackBar();
            this.MIDIStopButton = new System.Windows.Forms.Button();
            this.MIDIPlayButton = new System.Windows.Forms.Button();
            this.MIDIBrowseButton = new System.Windows.Forms.Button();
            this.EventListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FPSAdjustToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoTransposeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DetailedLoggingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creditsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolTipController = new System.Windows.Forms.ToolTip(this.components);
            this.checkboxDrums = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OctaveTranspositionSlider)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MIDIPlaybackTransposeSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MIDIPlaybackSpeedSlider)).BeginInit();
            this.MenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.tabPage1);
            this.TabControl.Controls.Add(this.tabPage2);
            this.TabControl.Location = new System.Drawing.Point(18, 40);
            this.TabControl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(465, 391);
            this.TabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.OctaveTranspositionSlider);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.StopListeningButton);
            this.tabPage1.Controls.Add(this.StartListeningButton);
            this.tabPage1.Controls.Add(this.InputDeviceScanButton);
            this.tabPage1.Controls.Add(this.DeviceComboBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Size = new System.Drawing.Size(457, 358);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "MIDI Device Setup";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(147, 234);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Octave Transposition";
            // 
            // OctaveTranspositionSlider
            // 
            this.OctaveTranspositionSlider.LargeChange = 1;
            this.OctaveTranspositionSlider.Location = new System.Drawing.Point(9, 259);
            this.OctaveTranspositionSlider.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.OctaveTranspositionSlider.Maximum = 3;
            this.OctaveTranspositionSlider.Minimum = -3;
            this.OctaveTranspositionSlider.Name = "OctaveTranspositionSlider";
            this.OctaveTranspositionSlider.Size = new System.Drawing.Size(435, 69);
            this.OctaveTranspositionSlider.TabIndex = 5;
            this.ToolTipController.SetToolTip(this.OctaveTranspositionSlider, "Use this if your MIDI device doesn\'t support transposition.");
            this.OctaveTranspositionSlider.ValueChanged += new System.EventHandler(this.OctaveTranspositionSlider_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 29);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Input Devices";
            // 
            // StopListeningButton
            // 
            this.StopListeningButton.Enabled = false;
            this.StopListeningButton.Location = new System.Drawing.Point(9, 171);
            this.StopListeningButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.StopListeningButton.Name = "StopListeningButton";
            this.StopListeningButton.Size = new System.Drawing.Size(435, 49);
            this.StopListeningButton.TabIndex = 3;
            this.StopListeningButton.Text = "Stop Listening (F2)";
            this.ToolTipController.SetToolTip(this.StopListeningButton, "Stop listening to the selected MIDI device");
            this.StopListeningButton.UseVisualStyleBackColor = true;
            this.StopListeningButton.Click += new System.EventHandler(this.StopListeningButton_Click);
            // 
            // StartListeningButton
            // 
            this.StartListeningButton.Enabled = false;
            this.StartListeningButton.Location = new System.Drawing.Point(9, 99);
            this.StartListeningButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.StartListeningButton.Name = "StartListeningButton";
            this.StartListeningButton.Size = new System.Drawing.Size(435, 49);
            this.StartListeningButton.TabIndex = 2;
            this.StartListeningButton.Text = "Start Listening (F1)";
            this.ToolTipController.SetToolTip(this.StartListeningButton, "Start listening for events on the selected MIDI device");
            this.StartListeningButton.UseVisualStyleBackColor = true;
            this.StartListeningButton.Click += new System.EventHandler(this.StartListeningButton_Click);
            // 
            // InputDeviceScanButton
            // 
            this.InputDeviceScanButton.Location = new System.Drawing.Point(228, 54);
            this.InputDeviceScanButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.InputDeviceScanButton.Name = "InputDeviceScanButton";
            this.InputDeviceScanButton.Size = new System.Drawing.Size(216, 35);
            this.InputDeviceScanButton.TabIndex = 1;
            this.InputDeviceScanButton.Text = "Scan for devices";
            this.ToolTipController.SetToolTip(this.InputDeviceScanButton, "Scan for MIDI devices");
            this.InputDeviceScanButton.UseVisualStyleBackColor = true;
            this.InputDeviceScanButton.Click += new System.EventHandler(this.InputDeviceScanButton_Click);
            // 
            // DeviceComboBox
            // 
            this.DeviceComboBox.FormattingEnabled = true;
            this.DeviceComboBox.Location = new System.Drawing.Point(9, 54);
            this.DeviceComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DeviceComboBox.Name = "DeviceComboBox";
            this.DeviceComboBox.Size = new System.Drawing.Size(208, 28);
            this.DeviceComboBox.TabIndex = 0;
            this.ToolTipController.SetToolTip(this.DeviceComboBox, "Input devices");
            this.DeviceComboBox.SelectedIndexChanged += new System.EventHandler(this.DeviceComboBox_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.progressBar1);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.MIDIPlaybackTransposeSlider);
            this.tabPage2.Controls.Add(this.MIDIPlaybackSpeedSlider);
            this.tabPage2.Controls.Add(this.MIDIStopButton);
            this.tabPage2.Controls.Add(this.MIDIPlayButton);
            this.tabPage2.Controls.Add(this.MIDIBrowseButton);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Size = new System.Drawing.Size(457, 358);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "MIDI Playback";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(175, 94);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "MIDI Duration";
            // 
            // progressBar1
            // 
            this.progressBar1.Cursor = System.Windows.Forms.Cursors.No;
            this.progressBar1.Location = new System.Drawing.Point(9, 117);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(435, 28);
            this.progressBar1.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(130, 254);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(190, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "MIDI Playback Transpose";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(145, 155);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "MIDI Playback Speed";
            // 
            // MIDIPlaybackTransposeSlider
            // 
            this.MIDIPlaybackTransposeSlider.LargeChange = 1;
            this.MIDIPlaybackTransposeSlider.Location = new System.Drawing.Point(9, 279);
            this.MIDIPlaybackTransposeSlider.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MIDIPlaybackTransposeSlider.Maximum = 12;
            this.MIDIPlaybackTransposeSlider.Minimum = -12;
            this.MIDIPlaybackTransposeSlider.Name = "MIDIPlaybackTransposeSlider";
            this.MIDIPlaybackTransposeSlider.Size = new System.Drawing.Size(435, 69);
            this.MIDIPlaybackTransposeSlider.TabIndex = 4;
            this.MIDIPlaybackTransposeSlider.Value = 1;
            this.MIDIPlaybackTransposeSlider.ValueChanged += new System.EventHandler(this.MIDIPlaybackTransposeSlider_ValueChanged);
            // 
            // MIDIPlaybackSpeedSlider
            // 
            this.MIDIPlaybackSpeedSlider.LargeChange = 1;
            this.MIDIPlaybackSpeedSlider.Location = new System.Drawing.Point(9, 180);
            this.MIDIPlaybackSpeedSlider.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MIDIPlaybackSpeedSlider.Maximum = 20;
            this.MIDIPlaybackSpeedSlider.Name = "MIDIPlaybackSpeedSlider";
            this.MIDIPlaybackSpeedSlider.Size = new System.Drawing.Size(435, 69);
            this.MIDIPlaybackSpeedSlider.TabIndex = 3;
            this.MIDIPlaybackSpeedSlider.Value = 1;
            this.MIDIPlaybackSpeedSlider.ValueChanged += new System.EventHandler(this.MIDIPlaybackSpeedSlider_ValueChanged);
            // 
            // MIDIStopButton
            // 
            this.MIDIStopButton.Enabled = false;
            this.MIDIStopButton.Location = new System.Drawing.Point(234, 54);
            this.MIDIStopButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MIDIStopButton.Name = "MIDIStopButton";
            this.MIDIStopButton.Size = new System.Drawing.Size(210, 35);
            this.MIDIStopButton.TabIndex = 2;
            this.MIDIStopButton.Text = "Stop (F2)";
            this.ToolTipController.SetToolTip(this.MIDIStopButton, "Stop currently playing MIDI");
            this.MIDIStopButton.UseVisualStyleBackColor = true;
            this.MIDIStopButton.Click += new System.EventHandler(this.MIDIStopButton_Click);
            // 
            // MIDIPlayButton
            // 
            this.MIDIPlayButton.Enabled = false;
            this.MIDIPlayButton.Location = new System.Drawing.Point(9, 54);
            this.MIDIPlayButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MIDIPlayButton.Name = "MIDIPlayButton";
            this.MIDIPlayButton.Size = new System.Drawing.Size(210, 35);
            this.MIDIPlayButton.TabIndex = 1;
            this.MIDIPlayButton.Text = "Play (F1)";
            this.ToolTipController.SetToolTip(this.MIDIPlayButton, "Play selected MIDI");
            this.MIDIPlayButton.UseVisualStyleBackColor = true;
            this.MIDIPlayButton.Click += new System.EventHandler(this.MIDIPlayButton_Click);
            // 
            // MIDIBrowseButton
            // 
            this.MIDIBrowseButton.Location = new System.Drawing.Point(9, 9);
            this.MIDIBrowseButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MIDIBrowseButton.Name = "MIDIBrowseButton";
            this.MIDIBrowseButton.Size = new System.Drawing.Size(435, 35);
            this.MIDIBrowseButton.TabIndex = 0;
            this.MIDIBrowseButton.Text = "Browse";
            this.ToolTipController.SetToolTip(this.MIDIBrowseButton, "Browse for a MIDI file");
            this.MIDIBrowseButton.UseVisualStyleBackColor = true;
            this.MIDIBrowseButton.Click += new System.EventHandler(this.MIDIBrowseButton_Click);
            // 
            // EventListView
            // 
            this.EventListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.EventListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.EventListView.HideSelection = false;
            this.EventListView.Location = new System.Drawing.Point(18, 461);
            this.EventListView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EventListView.Name = "EventListView";
            this.EventListView.Size = new System.Drawing.Size(461, 232);
            this.EventListView.TabIndex = 1;
            this.EventListView.UseCompatibleStateImageBehavior = false;
            this.EventListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "";
            this.columnHeader1.Width = 300;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 436);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Event Log";
            // 
            // MenuStrip
            // 
            this.MenuStrip.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.MenuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem,
            this.infoToolStripMenuItem});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(501, 33);
            this.MenuStrip.TabIndex = 3;
            this.MenuStrip.Text = "menuStrip1";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FPSAdjustToolStripMenuItem,
            this.autoTransposeToolStripMenuItem,
            this.DetailedLoggingToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(92, 29);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // FPSAdjustToolStripMenuItem
            // 
            this.FPSAdjustToolStripMenuItem.Name = "FPSAdjustToolStripMenuItem";
            this.FPSAdjustToolStripMenuItem.Size = new System.Drawing.Size(250, 34);
            this.FPSAdjustToolStripMenuItem.Text = "FPS Adjust";
            this.FPSAdjustToolStripMenuItem.Click += new System.EventHandler(this.FPSAdjustToolStripMenuItem_Click);
            // 
            // autoTransposeToolStripMenuItem
            // 
            this.autoTransposeToolStripMenuItem.Name = "autoTransposeToolStripMenuItem";
            this.autoTransposeToolStripMenuItem.Size = new System.Drawing.Size(250, 34);
            this.autoTransposeToolStripMenuItem.Text = "Auto Transpose";
            this.autoTransposeToolStripMenuItem.Click += new System.EventHandler(this.AutoTransposeToolStripMenuItem_Click);
            // 
            // DetailedLoggingToolStripMenuItem
            // 
            this.DetailedLoggingToolStripMenuItem.Name = "DetailedLoggingToolStripMenuItem";
            this.DetailedLoggingToolStripMenuItem.Size = new System.Drawing.Size(250, 34);
            this.DetailedLoggingToolStripMenuItem.Text = "Detailed Logging";
            this.DetailedLoggingToolStripMenuItem.Click += new System.EventHandler(this.DetailedLoggingToolStripMenuItem_Click);
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.creditsToolStripMenuItem});
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(60, 29);
            this.infoToolStripMenuItem.Text = "Info";
            // 
            // creditsToolStripMenuItem
            // 
            this.creditsToolStripMenuItem.Name = "creditsToolStripMenuItem";
            this.creditsToolStripMenuItem.Size = new System.Drawing.Size(169, 34);
            this.creditsToolStripMenuItem.Text = "Credits";
            this.creditsToolStripMenuItem.Click += new System.EventHandler(this.CreditsToolStripMenuItem_Click);
            // 
            // checkboxDrums
            // 
            this.checkboxDrums.AutoSize = true;
            this.checkboxDrums.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.checkboxDrums.Location = new System.Drawing.Point(361, 435);
            this.checkboxDrums.Name = "checkboxDrums";
            this.checkboxDrums.Size = new System.Drawing.Size(118, 24);
            this.checkboxDrums.TabIndex = 7;
            this.checkboxDrums.Text = "Drum Mode";
            this.checkboxDrums.UseVisualStyleBackColor = true;
            this.checkboxDrums.CheckedChanged += new System.EventHandler(this.CheckboxDrums_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(335, 155);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "label7";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 707);
            this.Controls.Add(this.checkboxDrums);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EventListView);
            this.Controls.Add(this.TabControl);
            this.Controls.Add(this.MenuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MenuStrip;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Text = "Tower Unite MIDI .NET";
            this.TopMost = true;
            this.TabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OctaveTranspositionSlider)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MIDIPlaybackTransposeSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MIDIPlaybackSpeedSlider)).EndInit();
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TabControl TabControl;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.ListView EventListView;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.MenuStrip MenuStrip;
		private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem FPSAdjustToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem DetailedLoggingToolStripMenuItem;
		private System.Windows.Forms.Button InputDeviceScanButton;
		private System.Windows.Forms.ComboBox DeviceComboBox;
		private System.Windows.Forms.Button StopListeningButton;
		private System.Windows.Forms.Button StartListeningButton;
		private System.Windows.Forms.ToolTip ToolTipController;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button MIDIBrowseButton;
		private System.Windows.Forms.Button MIDIPlayButton;
		private System.Windows.Forms.TrackBar MIDIPlaybackSpeedSlider;
		private System.Windows.Forms.Button MIDIStopButton;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TrackBar MIDIPlaybackTransposeSlider;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TrackBar OctaveTranspositionSlider;
		public System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creditsToolStripMenuItem;
        private System.Windows.Forms.CheckBox checkboxDrums;
        private System.Windows.Forms.ToolStripMenuItem autoTransposeToolStripMenuItem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label7;
    }
}