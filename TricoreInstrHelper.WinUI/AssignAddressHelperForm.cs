using System;
using System.Windows.Forms;
using TricoreInstrHelperLib;

namespace TricoreInstrHelper.WinUI
{
    public partial class AssignAddressHelperForm : InstructionHelperBaseForm
    {
        public AssignAddressHelperForm()
        {
            InitializeComponent();
        }

        #region Properties

        public UInt32 Address
        {
            get
            {
                if (!IsValidAddress(textBoxAddress.Text))
                    throw new InvalidInputException("Address is invalid");
                return Convert.ToUInt32(textBoxAddress.Text, 16);
            }
        }

        public AddressRegister AddressRegister
        {
            get
            {
                string selectedAddressRegister = (string)comboAddressRegister.SelectedItem;
                if (!IsValidEnumName<AddressRegister>(selectedAddressRegister))
                    throw new InvalidInputException("Address Register is invalid");
                return (AddressRegister)Enum.Parse(typeof(AddressRegister), selectedAddressRegister);
            }
        }

        #endregion

        #region Handlers

        private void AssignAddressHelperForm_Load(object sender, EventArgs e)
        {
            string[] addressRegisters = Enum.GetNames(typeof(AddressRegister));
            this.comboAddressRegister.Items.AddRange(addressRegisters);
        }

        private void ButtonGenerate_Click(object sender, EventArgs e)
        {
            GenerateResultHelper();
        }

        private void TextBoxAddress_TextChanged(object sender, EventArgs e)
        {
            GenerateResultHelper(showErrorMessage: false);
        }

        private void ComboAddressRegister_SelectedIndexChanged(object sender, EventArgs e)
        {
            GenerateResultHelper(showErrorMessage: false);
        }

        #endregion

        #region Helpers

        private void GenerateResultHelper(bool showErrorMessage = true)
        {
            try
            {
                string instr = InstructionHelper.GetAssignAddressInstructionString(AddressRegister, Address);
                Result = instr;
            }
            catch (InvalidInputException ex)
            {
                if (showErrorMessage)
                    MessageBox.Show(ex.Message, "Input error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Result = string.Empty;
            }
        }

        #endregion

    }
}
