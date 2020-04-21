namespace TricoreInstrHelper.WinUI
{
    partial class AssignAddressHelperForm
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
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.comboAddressRegister = new System.Windows.Forms.ComboBox();
            this.labelAddressRegister = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.TabIndex = 3;
            this.buttonGenerate.Click += new System.EventHandler(this.ButtonGenerate_Click);
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.textBoxAddress.Location = new System.Drawing.Point(207, 41);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(172, 31);
            this.textBoxAddress.TabIndex = 1;
            this.textBoxAddress.TextChanged += new System.EventHandler(this.TextBoxAddress_TextChanged);
            // 
            // comboAddressRegister
            // 
            this.comboAddressRegister.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboAddressRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboAddressRegister.FormattingEnabled = true;
            this.comboAddressRegister.Location = new System.Drawing.Point(207, 113);
            this.comboAddressRegister.Name = "comboAddressRegister";
            this.comboAddressRegister.Size = new System.Drawing.Size(172, 33);
            this.comboAddressRegister.TabIndex = 2;
            this.comboAddressRegister.SelectedIndexChanged += new System.EventHandler(this.ComboAddressRegister_SelectedIndexChanged);
            // 
            // labelAddressRegister
            // 
            this.labelAddressRegister.AutoSize = true;
            this.labelAddressRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddressRegister.Location = new System.Drawing.Point(12, 116);
            this.labelAddressRegister.Name = "labelAddressRegister";
            this.labelAddressRegister.Size = new System.Drawing.Size(193, 25);
            this.labelAddressRegister.TabIndex = 21;
            this.labelAddressRegister.Text = "Address Register";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddress.Location = new System.Drawing.Point(12, 47);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(98, 25);
            this.labelAddress.TabIndex = 20;
            this.labelAddress.Text = "Address";
            // 
            // AssignAddressHelperForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 451);
            this.Controls.Add(this.textBoxAddress);
            this.Controls.Add(this.comboAddressRegister);
            this.Controls.Add(this.labelAddressRegister);
            this.Controls.Add(this.labelAddress);
            this.Name = "AssignAddressHelperForm";
            this.Text = "Assign Address Helper";
            this.Load += new System.EventHandler(this.AssignAddressHelperForm_Load);
            this.Controls.SetChildIndex(this.buttonGenerate, 0);
            this.Controls.SetChildIndex(this.labelAddress, 0);
            this.Controls.SetChildIndex(this.labelAddressRegister, 0);
            this.Controls.SetChildIndex(this.comboAddressRegister, 0);
            this.Controls.SetChildIndex(this.textBoxAddress, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.ComboBox comboAddressRegister;
        private System.Windows.Forms.Label labelAddressRegister;
        private System.Windows.Forms.Label labelAddress;
    }
}