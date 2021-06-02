namespace AutoTwitch
{
    partial class Form1
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
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.streamerSelection = new System.Windows.Forms.ListBox();
            this.controlPanel = new System.Windows.Forms.Panel();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbStreamer = new System.Windows.Forms.TextBox();
            this.updateTimer = new System.Windows.Forms.Timer(this.components);
            this.tabs = new System.Windows.Forms.TabControl();
            this.controlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(4, 437);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(138, 23);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(4, 466);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(138, 23);
            this.btnStop.TabIndex = 3;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // streamerSelection
            // 
            this.streamerSelection.FormattingEnabled = true;
            this.streamerSelection.Location = new System.Drawing.Point(4, 3);
            this.streamerSelection.Name = "streamerSelection";
            this.streamerSelection.Size = new System.Drawing.Size(138, 342);
            this.streamerSelection.TabIndex = 6;
            // 
            // controlPanel
            // 
            this.controlPanel.Controls.Add(this.numericUpDown1);
            this.controlPanel.Controls.Add(this.label1);
            this.controlPanel.Controls.Add(this.btnRemove);
            this.controlPanel.Controls.Add(this.btnAdd);
            this.controlPanel.Controls.Add(this.tbStreamer);
            this.controlPanel.Controls.Add(this.streamerSelection);
            this.controlPanel.Controls.Add(this.btnStart);
            this.controlPanel.Controls.Add(this.btnStop);
            this.controlPanel.Location = new System.Drawing.Point(12, 12);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(145, 532);
            this.controlPanel.TabIndex = 7;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown1.Location = new System.Drawing.Point(6, 508);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            3600000,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(136, 20);
            this.numericUpDown1.TabIndex = 11;
            this.numericUpDown1.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 492);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Update delay in ms:";
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(4, 408);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(138, 23);
            this.btnRemove.TabIndex = 9;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(4, 377);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(138, 23);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbStreamer
            // 
            this.tbStreamer.Location = new System.Drawing.Point(4, 351);
            this.tbStreamer.Name = "tbStreamer";
            this.tbStreamer.Size = new System.Drawing.Size(138, 20);
            this.tbStreamer.TabIndex = 7;
            this.tbStreamer.Text = "Enter Streamer name here";
            this.tbStreamer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbStreamer_KeyDown);
            // 
            // updateTimer
            // 
            this.updateTimer.Tick += new System.EventHandler(this.updateTimer_Tick);
            // 
            // tabs
            // 
            this.tabs.Location = new System.Drawing.Point(163, 15);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(1128, 529);
            this.tabs.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1303, 551);
            this.Controls.Add(this.tabs);
            this.Controls.Add(this.controlPanel);
            this.Name = "Form1";
            this.Text = "AutoTwitch";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.controlPanel.ResumeLayout(false);
            this.controlPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.ListBox streamerSelection;
        private System.Windows.Forms.Panel controlPanel;
        private System.Windows.Forms.TextBox tbStreamer;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Timer updateTimer;
        private System.Windows.Forms.TabControl tabs;
    }
}

