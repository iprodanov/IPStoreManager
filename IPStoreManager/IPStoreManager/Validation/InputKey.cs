using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IPStoreManager.Validation
{
    public static class InputKey
    {
        public static bool ValidNumberKey(KeyEventArgs e)
        {
            if (IsDigit(e) || IsBackSpace(e) || IsDeleteKey(e) ||
                IsArrowKey(e) || IsHomeEndKey(e))
            {
                return true;
            }
            return false;
        }

        public static bool IsDecimalPoint(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Decimal)
            {
                return true;
            }
            else if (e.KeyCode == Keys.OemPeriod && InputLanguage.CurrentInputLanguage.Culture.ToString() == "en-US")
            {
                return true;
            }
            else if (e.KeyCode == Keys.Oemcomma && InputLanguage.CurrentInputLanguage.Culture.ToString() == "bg-BG")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static bool IsDigit(KeyEventArgs e)
        {
            if (IsNumberKey(e) || IsNumPadNumberKey(e))
            {
                if (IsShiftKey(e))
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            return false;
        }

        private static bool IsNumberKey(KeyEventArgs e)
        {
            if (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9)
            {
                return false;
            }
            return true;
        }

        private static bool IsNumPadNumberKey(KeyEventArgs e)
        {
            if (e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9)
            {
                return false;
            }
            return true;
        }

        private static bool IsShiftKey(KeyEventArgs e)
        {
            if (Control.ModifierKeys == Keys.Shift)
            {
                return true;
            }
            return false;
        }

        private static bool IsDeleteKey(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                return true;
            }
            return false;
        }

        private static bool IsArrowKey(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.Right ||
                e.KeyCode == Keys.Up || e.KeyCode == Keys.Down)
            {
                return true;
            }
            return false;
        }

        private static bool IsBackSpace(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                return true;
            }
            return false;
        }

        private static bool IsHomeEndKey(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Home || e.KeyCode == Keys.End)
            {
                return true;
            }
            return false;
        }
    }
}
