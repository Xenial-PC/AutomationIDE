using System.IO;
using System.Text;
using System.Windows.Forms;

namespace AutomationIDE
{
    public class TextBoxWriter : TextWriter
    {
        private readonly Control _myControl;
        public TextBoxWriter(Control control)
        {
            _myControl = control;
        }

        public override void Write(char value)
        {
            _myControl.Text += value;
        }

        public override void Write(string value)
        {
            _myControl.Text += value;
        }

        public override void WriteLine(char value)
        {
            _myControl.Text += value;
        }

        public override void WriteLine(string value)
        {
            _myControl.Text += value;
        }

        public override Encoding Encoding => Encoding.Unicode;
    }
}
