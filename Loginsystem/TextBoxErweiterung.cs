using System.Windows.Forms;
using System.Drawing;

namespace Loginsystem
{
    public static class TextBoxErweiterung
    {
        public static void AddPlaceholder(this TextBox textBox, string placeholderText)
        {
            // Hier wird ein Placeholder für TextBox-Steuerelemente erstellt
            textBox.Text = placeholderText;
            textBox.ForeColor = SystemColors.GrayText;

            textBox.Enter += (s, e) =>
            {
                // Falls ein TextBox angeklickt wird, verschwindet der Placeholder
                if (textBox.Text == placeholderText)
                {
                    textBox.Text = "";
                    textBox.ForeColor = SystemColors.ControlText;
                }
            };

            textBox.Leave += (s, e) =>
            {
                // Falls die Interaktion mit einer TextBox beendet wurde und der Inhalt leer ist, wird der Placeholder ausgegeben
                if (string.IsNullOrEmpty(textBox.Text))
                {
                    textBox.Text = placeholderText;
                    textBox.ForeColor = SystemColors.GrayText;
                }
            };
        }
    }
}
