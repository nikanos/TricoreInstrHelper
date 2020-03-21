using System;
using System.ComponentModel;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using TricoreInstrHelperLib;
using System.Linq;

namespace TricoreInstrHelper.WinUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        #region Properties
        
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

        public ControlFlowInstructionType InstructionType
        {
            get
            {
                string selectedInstructionType = (string)comboInstructionType.SelectedItem;
                if (!IsValidInstructionType(selectedInstructionType))
                    throw new InvalidInputException("Instruction Type is invalid");
                return (ControlFlowInstructionType)Enum.Parse(typeof(ControlFlowInstructionType), selectedInstructionType);
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

        #endregion

        #region Handlers

        private void MainForm_Load(object sender, EventArgs e)
        {
            string[] instructionTypes = Enum.GetNames(typeof(ControlFlowInstructionType));
            this.comboInstructionType.Items.AddRange(instructionTypes);
            this.comboInstructionType.SelectedItem = ControlFlowInstructionType.Call32.ToString();
        }

        private void ButtonGenerate_Click(object sender, EventArgs e)
        {
            try
            {
                string instr = InstructionHelper.GetInstructionString(InstructionType, AddressStart, AddressEnd);
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

        private void ContextMenuStripResult_Opening(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(Result))
                e.Cancel = true;
        }

        private void ToolStripMenuItemCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(Result);
        }

        private void ComboInstructionType_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearResult();
        }

        private void TextBoxAddressStart_TextChanged(object sender, EventArgs e)
        {
            ClearResult();
        }

        private void TextBoxAddressEnd_TextChanged(object sender, EventArgs e)
        {
            ClearResult();
        }

        #endregion

        #region Helpers

        private bool IsValidAddress(string addressString)
        {
            return Regex.IsMatch(addressString, "^[0-9A-F]{1,8}$", RegexOptions.IgnoreCase);
        }

        private bool IsValidInstructionType(string instructionType)
        {
            if (string.IsNullOrEmpty(instructionType))
                return false;
            return Enum.GetNames(typeof(ControlFlowInstructionType)).Contains(instructionType);
        }

        private void ClearResult()
        {
            this.Result = string.Empty;
        }

        #endregion
    }
}
