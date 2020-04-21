using System;
using System.ComponentModel;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace TricoreInstrHelper.WinUI
{
    public partial class InstructionHelperBaseForm : Form
    {
        public InstructionHelperBaseForm()
        {
            InitializeComponent();
        }

        #region Properties

        public string Result
        {
            get
            {
                return labelResult.Text;
            }
            set
            {
                labelResult.Text = value;
            }
        }

        #endregion

        #region Handlers

        private void ContextMenuStripResult_Opening(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(Result))
                e.Cancel = true;
        }

        private void ToolStripMenuItemCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(Result);
        }

        #endregion

        #region Helpers

        protected bool IsValidAddress(string addressString)
        {
            return Regex.IsMatch(addressString, "^[0-9A-F]{1,8}$", RegexOptions.IgnoreCase);
        }

        protected bool IsValidEnumName<EnumType>(string enumName) where EnumType : struct
        {
            if (!typeof(EnumType).IsEnum)
                throw new ArgumentException("Generic parameter EnumType is not an Enumeration");

            if (string.IsNullOrEmpty(enumName))
                return false;
            return Enum.GetNames(typeof(EnumType)).Contains(enumName);
        }

        protected void ClearResult()
        {
            this.Result = string.Empty;
        }

        #endregion
    }
}
