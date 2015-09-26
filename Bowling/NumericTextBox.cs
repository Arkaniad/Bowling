using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bowling {
    //Derived from https://msdn.microsoft.com/en-us/library/ms229644(v=vs.90).aspx, needed a text box that would return a 0 value if empty
    class NumericTextBox : TextBox {

        // Restricts the entry of characters to digits only
        protected override void OnKeyPress(KeyPressEventArgs e) {
            base.OnKeyPress(e);

            NumberFormatInfo numberFormatInfo = System.Globalization.CultureInfo.CurrentCulture.NumberFormat;

            string keyInput = e.KeyChar.ToString();
            if (Char.IsDigit(e.KeyChar)) {
                // Digits OK
            } else if (e.KeyChar == '\b') {
                // Backspace OK
            } else if (e.KeyChar == 'x' || e.KeyChar == 'X' || e.KeyChar == '/' || e.KeyChar == '-') {
                // Bowling characters OK!
            } else {
                e.Handled = true;
            }
        }

        public int IntValue {
            get {
                if (this.Text == string.Empty || this.Text == "-") {
                    return 0;
                } else if (this.Text.ToLower() == "x") {
                    return 10;
                } else if (this.Text == "/") {
                    return -1; //Will have to calculate the spare score
                } else {
                    return Int32.Parse(this.Text);
                }
            }
        }
    }
}
