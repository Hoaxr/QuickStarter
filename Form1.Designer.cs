namespace QuickStarter
{
    partial class QuickStarter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuickStarter));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.application1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.application2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.application3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.application4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.application5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetApplicationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 124);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(552, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.IsLink = true;
            this.toolStripStatusLabel1.LinkColor = System.Drawing.Color.Black;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(63, 17);
            this.toolStripStatusLabel1.Text = "BDekker.nl";
            this.toolStripStatusLabel1.VisitedLinkColor = System.Drawing.Color.Black;
            this.toolStripStatusLabel1.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(412, 129);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(140, 17);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "Run at Windows startup";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button2
            // 
            this.button2.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::QuickStarter.Properties.Settings.Default, "button2", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(119, 32);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 84);
            this.button2.TabIndex = 3;
            this.button2.Text = global::QuickStarter.Properties.Settings.Default.button2;
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::QuickStarter.Properties.Settings.Default, "button3", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(226, 32);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(101, 84);
            this.button3.TabIndex = 5;
            this.button3.Text = global::QuickStarter.Properties.Settings.Default.button3;
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::QuickStarter.Properties.Settings.Default, "button4", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.button4.Enabled = false;
            this.button4.Location = new System.Drawing.Point(333, 32);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(101, 84);
            this.button4.TabIndex = 6;
            this.button4.Text = global::QuickStarter.Properties.Settings.Default.button4;
            this.button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::QuickStarter.Properties.Settings.Default, "button5", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.button5.Enabled = false;
            this.button5.Location = new System.Drawing.Point(440, 32);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(101, 84);
            this.button5.TabIndex = 7;
            this.button5.Text = global::QuickStarter.Properties.Settings.Default.button5;
            this.button5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addApplicationToolStripMenuItem,
            this.resetApplicationsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(552, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addApplicationToolStripMenuItem
            // 
            this.addApplicationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.application1ToolStripMenuItem,
            this.application2ToolStripMenuItem,
            this.application3ToolStripMenuItem,
            this.application4ToolStripMenuItem,
            this.application5ToolStripMenuItem});
            this.addApplicationToolStripMenuItem.Name = "addApplicationToolStripMenuItem";
            this.addApplicationToolStripMenuItem.Size = new System.Drawing.Size(110, 20);
            this.addApplicationToolStripMenuItem.Text = "Add Applications";
            // 
            // application1ToolStripMenuItem
            // 
            this.application1ToolStripMenuItem.Name = "application1ToolStripMenuItem";
            this.application1ToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.application1ToolStripMenuItem.Text = "Application 1";
            this.application1ToolStripMenuItem.Click += new System.EventHandler(this.application1ToolStripMenuItem_Click);
            // 
            // application2ToolStripMenuItem
            // 
            this.application2ToolStripMenuItem.Name = "application2ToolStripMenuItem";
            this.application2ToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.application2ToolStripMenuItem.Text = "Application 2";
            this.application2ToolStripMenuItem.Click += new System.EventHandler(this.application2ToolStripMenuItem_Click);
            // 
            // application3ToolStripMenuItem
            // 
            this.application3ToolStripMenuItem.Name = "application3ToolStripMenuItem";
            this.application3ToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.application3ToolStripMenuItem.Text = "Application 3";
            this.application3ToolStripMenuItem.Click += new System.EventHandler(this.application3ToolStripMenuItem_Click);
            // 
            // application4ToolStripMenuItem
            // 
            this.application4ToolStripMenuItem.Name = "application4ToolStripMenuItem";
            this.application4ToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.application4ToolStripMenuItem.Text = "Application 4";
            this.application4ToolStripMenuItem.Click += new System.EventHandler(this.application4ToolStripMenuItem_Click);
            // 
            // application5ToolStripMenuItem
            // 
            this.application5ToolStripMenuItem.Name = "application5ToolStripMenuItem";
            this.application5ToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.application5ToolStripMenuItem.Text = "Application 5";
            this.application5ToolStripMenuItem.Click += new System.EventHandler(this.application5ToolStripMenuItem_Click);
            // 
            // resetApplicationsToolStripMenuItem
            // 
            this.resetApplicationsToolStripMenuItem.Name = "resetApplicationsToolStripMenuItem";
            this.resetApplicationsToolStripMenuItem.Size = new System.Drawing.Size(116, 20);
            this.resetApplicationsToolStripMenuItem.Text = "Reset Applications";
            this.resetApplicationsToolStripMenuItem.Click += new System.EventHandler(this.resetApplicationsToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::QuickStarter.Properties.Settings.Default, "button1", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(12, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 84);
            this.button1.TabIndex = 4;
            this.button1.Text = global::QuickStarter.Properties.Settings.Default.button1;
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // QuickStarter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 146);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "QuickStarter";
            this.Text = "QuickStarter";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetApplicationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem application1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem application2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem application3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem application4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem application5ToolStripMenuItem;
    }
}

