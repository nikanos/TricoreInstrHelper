using System;
using System.Windows.Forms;
using TricoreInstrHelperLib;

namespace TricoreInstrHelper.WinUI
{
    public partial class RelativeControlFlowHelperForm : InstructionHelperBaseForm
    {
        public RelativeControlFlowHelperForm()
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

        public ControlFlowInstruction ControlFlowInstruction
        {
            get
            {
                string selectedInstruction = (string)comboInstruction.SelectedItem;
                if (!IsValidEnumName<ControlFlowInstruction>(selectedInstruction))
                    throw new InvalidInputException("Instruction Type is invalid");
                return (ControlFlowInstruction)Enum.Parse(typeof(ControlFlowInstruction), selectedInstruction);
            }
        }

        #endregion

        #region Handlers

        private void MainForm_Load(object sender, EventArgs e)
        {
            string[] instructions = Enum.GetNames(typeof(ControlFlowInstruction));
            this.comboInstruction.Items.AddRange(instructions);
            this.comboInstruction.SelectedItem = ControlFlowInstruction.Call32.ToString();
        }

        private void ButtonGenerate_Click(object sender, EventArgs e)
        {
            GenerateResultHelper();
        }

        private void ComboInstruction_SelectedIndexChanged(object sender, EventArgs e)
        {
            GenerateResultHelper(showErrorMessage: false);
        }

        private void TextBoxAddressStart_TextChanged(object sender, EventArgs e)
        {
            GenerateResultHelper(showErrorMessage: false);
        }

        private void TextBoxAddressEnd_TextChanged(object sender, EventArgs e)
        {
            GenerateResultHelper(showErrorMessage: false);
        }

        #endregion

        #region Helpers

        private void GenerateResultHelper(bool showErrorMessage = true)
        {
            try
            {
                string instr = InstructionHelper.GetRelativeControlFlowInstructionString(ControlFlowInstruction, AddressStart, AddressEnd);
                Result = instr;
            }
            catch (InvalidInputException ex)
            {
                if (showErrorMessage)
                    MessageBox.Show(ex.Message, "Input error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Result = string.Empty;
            }
            catch (InvalidOffsetException ex)
            {
                if (showErrorMessage)
                    MessageBox.Show(ex.Message, "Calculated address offset error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Result = string.Empty;
            }
        }

        #endregion
    }
}
