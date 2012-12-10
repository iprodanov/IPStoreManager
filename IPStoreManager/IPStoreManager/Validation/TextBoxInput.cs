using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IPStoreManager.Validation
{
    public class TextBoxInput
    {
        private static ErrorProvider tbErrorProvider;
        
        public static bool MissingText(TextBox tb)
        {
            SetErrorProviderProperties(tb);
            if (tb.Text == String.Empty)
            {
                tbErrorProvider.SetError(tb, "Text box must be filled!");
                return true;
            }
            else
            {
                tbErrorProvider.SetError(tb, null);
                return false;
            }
        }

        public static bool ContainsDecimalPointOnly(TextBox tb)
        {
            SetErrorProviderProperties(tb);
            if (tb.Text == "." || tb.Text == ",")
            {
                tbErrorProvider.SetError(tb, "Enter valid number!");
                return true;
            }
            else
            {
                tbErrorProvider.SetError(tb, null);
                return false;
            }
        }

        public static bool GreaterThanDecimalMaxValue(TextBox tb)
        {
            SetErrorProviderProperties(tb);
            try
            {
                if (Decimal.Parse(tb.Text, InputLanguage.CurrentInputLanguage.Culture) <= Decimal.MaxValue)
                {
                    tbErrorProvider.SetError(tb, null);
                    return false;
                }
            }
            catch (OverflowException)
            {
                tbErrorProvider.SetError(tb, "Value too large!");
            }
            return true;
        }

        public static bool ContainsDecimalPoint(TextBox tb)
        {
            if (tb.Text.Contains(".") || tb.Text.Contains(","))
            {
                return true;
            }
            return false;
        }

        public static bool SelectionContainsDecimalPoint(TextBox tb)
        {
            if (tb.SelectedText.Contains(".") || tb.SelectedText.Contains(","))
            {
                return true;
            }
            return false;
        }

        public static bool AllTextSelected(TextBox tb)
        {
            if (tb.SelectionLength == tb.Text.Length)
            {
                return true;
            }
            return false;
        }

        public static void InitializeErrorProvider()
        {
            tbErrorProvider = new ErrorProvider();
            tbErrorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
        }
        
        private static void SetErrorProviderProperties(TextBox tb)
        {   
            tbErrorProvider.SetIconAlignment(tb, ErrorIconAlignment.MiddleRight);
            tbErrorProvider.SetIconPadding(tb, 2);
        }
    }
}
