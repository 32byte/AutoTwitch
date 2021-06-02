using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

using Gecko;

namespace AutoTwitch
{
    public partial class Form1 : Form
    {
        private List<GeckoWebBrowser> browsers = new List<GeckoWebBrowser>();

        public Form1()
        {
            InitializeComponent();

            Xpcom.Initialize("Firefox");
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (this.streamerSelection.Items.Count == 0)
            {
                MessageBox.Show("Input at least 1 Streamer");
                return;
            }

            this.btnAdd.Enabled = false;
            this.btnRemove.Enabled = false;

            foreach (string streamer in this.streamerSelection.Items)
            {
                this.tabs.TabPages.Add(streamer);
                this.browsers.Add(new GeckoWebBrowser { Dock = DockStyle.Fill });
                this.tabs.TabPages[this.tabs.TabPages.Count - 1].Controls.Add(this.browsers[this.tabs.TabPages.Count - 1]);
                this.browsers[this.tabs.TabPages.Count - 1].Navigate("https://www.twitch.tv/" + streamer.ToLower());
            }

            this.updateTimer.Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            this.btnAdd.Enabled = true;
            this.btnRemove.Enabled = true;
            this.updateTimer.Stop();
            this.tabs.TabPages.Clear();
            this.browsers.Clear();
            /*
            var browser = this.browsers[this.tabs.SelectedIndex];
            using (AutoJSContext ctx = new AutoJSContext(browser.Window))
            {
                ctx.EvaluateScript("(() => {Array.from(document.getElementsByTagName(\"a\")).forEach(e => {if (e.innerHTML.toString().toLowerCase().includes(\"watch\")) e.click(); });})();");
                //ctx.EvaluateScript("function f() => {alert(1); Array.from(document.getElementsByTagName(\"a\")).forEach(e => {if (e.innerHTML.toString().toLowerCase().includes(\"watch\")) e.click(); }); setTimeout(f, 10000);} setTimeout(f, 10000);");
            }
            */
        }

        private void updateTimer_Tick(object sender, EventArgs e)
        {
            foreach (var browser in this.browsers)
            {
                using (AutoJSContext ctx = new AutoJSContext(browser.Window))
                {
                    ctx.EvaluateScript("(() => {Array.from(document.getElementsByTagName(\"a\")).forEach(e => {if (e.innerHTML.toString().toLowerCase().includes(\"watch\")) e.click(); });})();");
                }
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            this.updateTimer.Interval = (int) this.numericUpDown1.Value;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (this.tbStreamer.Text.Contains(" "))
            {
                MessageBox.Show("Name can't contain spaces");
                return;
            }

            if (!this.streamerSelection.Items.Contains(this.tbStreamer.Text) &&
                    this.tbStreamer.Text != "")
                this.streamerSelection.Items.Add(this.tbStreamer.Text);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (this.streamerSelection.SelectedIndex != -1)
                this.streamerSelection.Items.RemoveAt(this.streamerSelection.SelectedIndex);
        }

        private void tbStreamer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter)
                return;

            if (this.tbStreamer.Text.Contains(" "))
            {
                MessageBox.Show("Name can't contain spaces");
                return;
            }

            if (!this.streamerSelection.Items.Contains(this.tbStreamer.Text) &&
                    this.tbStreamer.Text != "")
                this.streamerSelection.Items.Add(this.tbStreamer.Text);
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
