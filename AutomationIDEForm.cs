using System;
using System.Windows.Forms;
using AutomationIDELibrary.Compiler;
using System.Threading;

namespace AutomationIDE
{
    public partial class AutomationIDEForm : Form
    {
        private bool _fireFox, _chrome;

        public AutomationIDEForm()
        {
            InitializeComponent();
            var console = new TextBoxWriter(ConsoleTB);
            Console.SetOut(console);
        }

        private void compileBTN_Click(object sender, EventArgs e)
        {
            new Thread(Compile) {IsBackground = true}.Start();
        }

        private async void Compile()
        {
            var compiler = new Compiler();
            await compiler.ReadTextBoxLinesAsync(compilerTB).ConfigureAwait(true);

            // The build options for the script/what driver the script is to be ran on
            if (_fireFox) compiler.BuildFireFox(websiteTB.Text);
            else if (_chrome) compiler.BuildChrome(websiteTB.Text);
            else MessageBox.Show(@"No Browser Type Chosen!", @"Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification, false);
        }

        private void ChromeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Sets the browser driver to Chrome
            selectedBrowser.Text = @"Browser: Chrome";

            _chrome = true;
            _fireFox = false;
        }

        private void FirefoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Sets the browser driver to FireFox
            selectedBrowser.Text = @"Browser: FireFox";

            _fireFox = true;
            _chrome = false;
        }

        private void HelpButton_Click(object sender, EventArgs e)
        {
            void HelpButtonThread()
            {
                Application.Run(new DocumentationPage());
            }
            new Thread(HelpButtonThread) {IsBackground = true}.Start();
        }

        private void CloseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}