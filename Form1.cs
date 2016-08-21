using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using Microsoft.Win32;
using System.Globalization;

namespace QuickStarter
{
    public partial class QuickStarter : Form
    {
        public QuickStarter()
        {
            InitializeComponent();

            if (Properties.Settings.Default.button1 != "Application")
            {
                // Get button 1 from settings
                Properties.Settings.Default.button1 = Properties.Settings.Default.button1;
                Properties.Settings.Default.Save();
                button1.Enabled = true;
            }

            if (Properties.Settings.Default.button2 != "Application")
            {
                // Get button 2 from settings
                Properties.Settings.Default.button2 = Properties.Settings.Default.button2;
                Properties.Settings.Default.Save();
                button2.Enabled = true;
            }

            if (Properties.Settings.Default.button3 != "Application")
            {
                // Get button 3 from settings
                Properties.Settings.Default.button3 = Properties.Settings.Default.button3;
                Properties.Settings.Default.Save();
                button3.Enabled = true;
            }

            if (Properties.Settings.Default.button4 != "Application")
            {
                // Get button 4 from settings
                Properties.Settings.Default.button4 = Properties.Settings.Default.button4;
                Properties.Settings.Default.Save();
                button4.Enabled = true;
            }

            if (Properties.Settings.Default.button5 != "Application")
            {
                // Get button 5 from settings
                Properties.Settings.Default.button5 = Properties.Settings.Default.button5;
                Properties.Settings.Default.Save();
                button5.Enabled = true;
            }

            if (Properties.Settings.Default.button1path != "")
            {
                // Load icon button 1
                ico = Icon.ExtractAssociatedIcon(Properties.Settings.Default.button1path);
                button1.Text = Path.GetFileNameWithoutExtension(Properties.Settings.Default.button1path);
                button1.Image = ico.ToBitmap();
            }

            if (Properties.Settings.Default.button2path != "")
            {
                // Load icon button 2
                ico = Icon.ExtractAssociatedIcon(Properties.Settings.Default.button2path);
                button2.Text = Path.GetFileNameWithoutExtension(Properties.Settings.Default.button2path);
                button2.Image = ico.ToBitmap();
            }

            if (Properties.Settings.Default.button3path != "")
            {
                // Load icon button 3
                ico = Icon.ExtractAssociatedIcon(Properties.Settings.Default.button3path);
                button3.Text = Path.GetFileNameWithoutExtension(Properties.Settings.Default.button3path);
                button3.Image = ico.ToBitmap();
            }

            if (Properties.Settings.Default.button4path != "")
            {
                // Load icon button 4
                ico = Icon.ExtractAssociatedIcon(Properties.Settings.Default.button4path);
                button4.Text = Path.GetFileNameWithoutExtension(Properties.Settings.Default.button4path);
                button4.Image = ico.ToBitmap();
            }

            if (Properties.Settings.Default.button5path != "")
            {
                // Load icon button 5
                ico = Icon.ExtractAssociatedIcon(Properties.Settings.Default.button5path);
                button5.Text = Path.GetFileNameWithoutExtension(Properties.Settings.Default.button5path);
                button5.Image = ico.ToBitmap();
            }

            // Check if registry key exists and set checkbox checked or unchecked if it not exists
            using (RegistryKey Key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run\"))
                if (Key != null)
                {
                    string val = (string)Key.GetValue("QuickStarter");
                    if (val == null)
                    {
                        checkBox1.Checked = false;
                    }
                    else
                    {
                        checkBox1.Checked = true;
                    }
                }
        }

        Icon ico = null;
        OpenFileDialog ofd = new OpenFileDialog();

        private void application1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ofd.Filter = "EXE|*.exe";
            ofd.Title = "Add application";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                // Set button 1
                ico = Icon.ExtractAssociatedIcon(ofd.FileName);
                button1.Text = Path.GetFileNameWithoutExtension(ofd.FileName);
                button1.Image = ico.ToBitmap();
                button1.Enabled = true;
                // Save into settings
                Properties.Settings.Default.button1 = Path.GetFileNameWithoutExtension(System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(ofd.FileName));
                Properties.Settings.Default.button1path = ofd.FileName;
                Properties.Settings.Default.Save();
            }
        }

        private void application2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ofd.Filter = "EXE|*.exe";
            ofd.Title = "Add application";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                // Set button 2
                ico = Icon.ExtractAssociatedIcon(ofd.FileName);
                button2.Text = Path.GetFileNameWithoutExtension(ofd.FileName);
                button2.Image = ico.ToBitmap();
                button2.Enabled = true;
                // Save into settings
                Properties.Settings.Default.button2 = Path.GetFileNameWithoutExtension(System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(ofd.FileName));
                Properties.Settings.Default.button2path = ofd.FileName;
                Properties.Settings.Default.Save();
            }
        }

        private void application3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ofd.Filter = "EXE|*.exe";
            ofd.Title = "Add application";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                // Set button 3
                ico = Icon.ExtractAssociatedIcon(ofd.FileName);
                button3.Text = Path.GetFileNameWithoutExtension(ofd.FileName);
                button3.Image = ico.ToBitmap();
                button3.Enabled = true;
                // Save into settings
                Properties.Settings.Default.button3 = Path.GetFileNameWithoutExtension(System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(ofd.FileName));
                Properties.Settings.Default.button3path = ofd.FileName;
                Properties.Settings.Default.Save();
            }
        }

        private void application4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ofd.Filter = "EXE|*.exe";
            ofd.Title = "Add application";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                // Set button 4
                ico = Icon.ExtractAssociatedIcon(ofd.FileName);
                button4.Text = Path.GetFileNameWithoutExtension(ofd.FileName);
                button4.Image = ico.ToBitmap();
                button4.Enabled = true;
                // Save into settings
                Properties.Settings.Default.button4 = Path.GetFileNameWithoutExtension(System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(ofd.FileName));
                Properties.Settings.Default.button4path = ofd.FileName;
                Properties.Settings.Default.Save();
            }
        }

        private void application5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ofd.Filter = "EXE|*.exe";
            ofd.Title = "Add application";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                // Set button 5
                ico = Icon.ExtractAssociatedIcon(ofd.FileName);
                button5.Text = Path.GetFileNameWithoutExtension(ofd.FileName);
                button5.Image = ico.ToBitmap();
                button5.Enabled = true;
                // Save into settings
                Properties.Settings.Default.button5 = Path.GetFileNameWithoutExtension(System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(ofd.FileName));
                Properties.Settings.Default.button5path = ofd.FileName;
                Properties.Settings.Default.Save();
            }
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            // Start application 1 on button click
            ProcessStartInfo start = new ProcessStartInfo();
            start.FileName = Properties.Settings.Default.button1path;
            Process.Start(start);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Start application 2 on button click
            ProcessStartInfo start = new ProcessStartInfo();
            start.FileName = Properties.Settings.Default.button2path;
            Process.Start(start);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Start application 3 on button click
            ProcessStartInfo start = new ProcessStartInfo();
            start.FileName = Properties.Settings.Default.button3path;
            Process.Start(start);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Start application 4 on button click
            ProcessStartInfo start = new ProcessStartInfo();
            start.FileName = Properties.Settings.Default.button4path;
            Process.Start(start);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Start application 5 on button click
            ProcessStartInfo start = new ProcessStartInfo();
            start.FileName = Properties.Settings.Default.button5path;
            Process.Start(start);
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {
            // Visit website
            System.Diagnostics.Process.Start("http://www.bdekker.nl");
        }

        private void resetApplicationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Reset all buttons and settings
            Properties.Settings.Default.button1 = "Application";
            Properties.Settings.Default.button1path = "";
            button1.Enabled = false;
            button1.Image = null;
            Properties.Settings.Default.button2 = "Application";
            Properties.Settings.Default.button2path = "";
            button2.Enabled = false;
            button2.Image = null;
            Properties.Settings.Default.button3 = "Application";
            Properties.Settings.Default.button3path = "";
            button3.Enabled = false;
            button3.Image = null;
            Properties.Settings.Default.button4 = "Application";
            Properties.Settings.Default.button4path = "";
            button4.Enabled = false;
            button4.Image = null;
            Properties.Settings.Default.button5 = "Application";
            Properties.Settings.Default.button5path = "";
            button5.Enabled = false;
            button5.Image = null;
            // Save settings
            Properties.Settings.Default.Save();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // if checkbox is checked set key in registry
            if (checkBox1 != null && checkBox1.Checked)
                using (RegistryKey key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true))
                {
                    key.SetValue("QuickStarter", "\"" + Application.ExecutablePath + "\"");
                }
            // if checkbox is unchecked delete key in registry
            else
                using (RegistryKey key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true))
                {
                    key.DeleteValue("QuickStarter", false);
                }
        }
    }
}