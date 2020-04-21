namespace TricoreInstrHelper.WinUI
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonShowRelativeControlFlowForm = new System.Windows.Forms.Button();
            this.buttonShowAssignAddressForm = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonShowRelativeControlFlowForm
            // 
            this.buttonShowRelativeControlFlowForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonShowRelativeControlFlowForm.Image = global::TricoreInstrHelper.WinUI.Properties.Resources.call_Icon;
            this.buttonShowRelativeControlFlowForm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonShowRelativeControlFlowForm.Location = new System.Drawing.Point(13, 253);
            this.buttonShowRelativeControlFlowForm.Name = "buttonShowRelativeControlFlowForm";
            this.buttonShowRelativeControlFlowForm.Size = new System.Drawing.Size(384, 47);
            this.buttonShowRelativeControlFlowForm.TabIndex = 1;
            this.buttonShowRelativeControlFlowForm.Text = "Relative Control Flow Instruction Helper";
            this.buttonShowRelativeControlFlowForm.UseVisualStyleBackColor = true;
            this.buttonShowRelativeControlFlowForm.Click += new System.EventHandler(this.ButtonShowRelativeControlFlowForm_Click);
            // 
            // buttonShowAssignAddressForm
            // 
            this.buttonShowAssignAddressForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonShowAssignAddressForm.Image = global::TricoreInstrHelper.WinUI.Properties.Resources.memory_icon;
            this.buttonShowAssignAddressForm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonShowAssignAddressForm.Location = new System.Drawing.Point(13, 320);
            this.buttonShowAssignAddressForm.Name = "buttonShowAssignAddressForm";
            this.buttonShowAssignAddressForm.Size = new System.Drawing.Size(384, 47);
            this.buttonShowAssignAddressForm.TabIndex = 2;
            this.buttonShowAssignAddressForm.Text = "Assign Address Instruction Helper";
            this.buttonShowAssignAddressForm.UseVisualStyleBackColor = true;
            this.buttonShowAssignAddressForm.Click += new System.EventHandler(this.ButtonShowAssignAddressForm_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TricoreInstrHelper.WinUI.Properties.Resources.background;
            this.pictureBox1.Location = new System.Drawing.Point(100, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(216, 199);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 385);
            this.Controls.Add(this.buttonShowAssignAddressForm);
            this.Controls.Add(this.buttonShowRelativeControlFlowForm);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TriCore Instruction Helper";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonShowRelativeControlFlowForm;
        private System.Windows.Forms.Button buttonShowAssignAddressForm;
    }
}