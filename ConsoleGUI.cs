using System;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace WinUtilHelper
{
    public class ConsoleGUI : TextWriter
    {
        TextBox _output = null;

        public ConsoleGUI(TextBox output)
        {
            _output = output;
        }

        public override void Write(char value)
        {
            base.Write(value);
            _output.AppendText(value.ToString()); // When character data is written, append it to the text box.
        }

        internal static void SetOut(TextWriter writer)
        {
            throw new NotImplementedException();
        }

        public override Encoding Encoding
        {
            get { return System.Text.Encoding.UTF8; }
        }
    }
}