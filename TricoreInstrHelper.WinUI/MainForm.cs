using System;
using System.Windows.Forms;

namespace TricoreInstrHelper.WinUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        #region Fields

        private RelativeControlFlowHelperForm _relativeControlFlowHelper;
        private AssignAddressHelperForm _assignAddressHelper;

        #endregion

        #region Properties

        private RelativeControlFlowHelperForm RelativeControlFlowHelperForm
        {
            get
            {
                if (ShouldInitialize(_relativeControlFlowHelper))
                    _relativeControlFlowHelper = new RelativeControlFlowHelperForm();
                return _relativeControlFlowHelper;
            }
        }

        private AssignAddressHelperForm AssignAddressHelperForm
        {
            get
            {
                if (ShouldInitialize(_assignAddressHelper))
                    _assignAddressHelper = new AssignAddressHelperForm();
                return _assignAddressHelper;
            }
        }

        #endregion

        #region Handlers
        
        private void ButtonShowRelativeControlFlowForm_Click(object sender, EventArgs e)
        {
            RelativeControlFlowHelperForm.Show();
            RelativeControlFlowHelperForm.BringToFront();
        }

        private void ButtonShowAssignAddressForm_Click(object sender, EventArgs e)
        {
            AssignAddressHelperForm.Show();
            AssignAddressHelperForm.BringToFront();
        }

        #endregion

        #region Helpers
        
        private bool ShouldInitialize(Form frm)
        {
            return frm == null || frm.IsDisposed;
        }

        #endregion
    }
}
