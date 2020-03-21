using System;
using System.ComponentModel;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using TricoreInstrHelperLib;

namespace TricoreInstrHelper.WinUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public UInt32 AddressStart
        {
            get
            {
                if (!IsValidAddress(textBoxAddressStart.Text))
                    throw new InvalidInputException("Address Start is invalid");
                return Convert.ToUInt32(textBoxAddressStart.Text, 16);
            }
        }

        public UInt32 AddressEnd
        {
            get
            {
                if (!IsValidAddress(textBoxAddressEnd.Text))
                    throw new InvalidInputException("Address End is invalid");
                return Convert.ToUInt32(textBoxAddressEnd.Text, 16);
            }
        }

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

        private void ButtonGenerate_Click(object sender, EventArgs e)
        {
            try
            {
                string instr = InstructionHelper.GetInstructionString(ControlFlowInstructionType.Call, AddressStart, AddressEnd);
                Result = instr;
            }
            catch (InvalidInputException ex)
            {
                MessageBox.Show(ex.Message, "Input error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Result = string.Empty;
            }
            catch (InvalidOffsetException ex)
            {
                MessageBox.Show(ex.Message, "Calculated address offset error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Result = string.Empty;
            }
        }

        private bool IsValidAddress(string addressString)
        {
            return Regex.IsMatch(addressString, "^[0-9A-F]{1,8}$", RegexOptions.IgnoreCase);
        }

        private void ContextMenuStripResult_Opening(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(Result))
                e.Cancel = true;
        }

        private void ToolStripMenuItemCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(Result);
        }
    }
}
