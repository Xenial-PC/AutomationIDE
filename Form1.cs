using System;
using System.Windows.Forms;
using AutomationIDELibrary.Compiler;

namespace AutomationIDE
{
    public partial class AutomationIde : Form
    {
        private bool _fireFox, _chrome;

        public AutomationIde()
        {
            InitializeComponent();
        }

        private async void compileBTN_Click(object sender, EventArgs e)
        {
            await Compiler.ReadTextBoxLinesAsync(compilerTB).ConfigureAwait(true);
            if (_fireFox) Compiler.BuildFireFox(websiteTB.Text);
            else if (_chrome) Compiler.BuildChrome(websiteTB.Text);
            else MessageBox.Show(@"No Browser Type Chosen!", @"Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification, false);
        }

        private void chromeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selectedBrowser.Text = @"Browser: Chrome";
            _chrome = true;
            _fireFox = false;
        }

        private void firefoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selectedBrowser.Text = @"Browser: FireFox";
            _fireFox = true;
            _chrome = false;
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}