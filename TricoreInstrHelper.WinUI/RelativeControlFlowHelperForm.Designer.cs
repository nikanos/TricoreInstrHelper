namespace TricoreInstrHelper.WinUI
{
    partial class RelativeControlFlowHelperForm
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
            this.textBoxAddressEnd = new System.Windows.Forms.TextBox();
            this.textBoxAddressStart = new System.Windows.Forms.TextBox();
            this.comboInstruction = new System.Windows.Forms.ComboBox();
            this.labelVersion = new System.Windows.Forms.Label();
            this.labelEdition = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.TabIndex = 4;
            this.buttonGenerate.Click += new System.EventHandler(this.ButtonGenerate_Click);
            // 
            // textBoxAddressEnd
            // 
            this.textBoxAddressEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.textBoxAddressEnd.Location = new System.Drawing.Point(196, 75);
            this.textBoxAddressEnd.Name = "textBoxAddressEnd";
            this.textBoxAddressEnd.Size = new System.Drawing.Size(172, 31);
            this.textBoxAddressEnd.TabIndex = 2;
            this.textBoxAddressEnd.TextChanged += new System.EventHandler(this.TextBoxAddressEnd_TextChanged);
            // 
            // textBoxAddressStart
            // 
            this.textBoxAddressStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.textBoxAddressStart.Location = new System.Drawing.Point(196, 13);
            this.textBoxAddressStart.Name = "textBoxAddressStart";
            this.textBoxAddressStart.Size = new System.Drawing.Size(172, 31);
            this.textBoxAddressStart.TabIndex = 1;
            this.textBoxAddressStart.TextChanged += new System.EventHandler(this.TextBoxAddressStart_TextChanged);
            // 
            // comboInstruction
            // 
            this.comboInstruction.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboInstruction.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboInstruction.FormattingEnabled = true;
            this.comboInstruction.Location = new System.Drawing.Point(196, 130);
            this.comboInstruction.Name = "comboInstruction";
            this.comboInstruction.Size = new System.Drawing.Size(172, 33);
            this.comboInstruction.TabIndex = 3;
            this.comboInstruction.SelectedIndexChanged += new System.EventHandler(this.ComboInstruction_SelectedIndexChanged);
            // 
            // labelVersion
            // 
            this.labelVersion.AutoSize = true;
            this.labelVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVersion.Location = new System.Drawing.Point(12, 133);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(181, 25);
            this.labelVersion.TabIndex = 22;
            this.labelVersion.Text = "Instruction Type";
            // 
            // labelEdition
            // 
            this.labelEdition.AutoSize = true;
            this.labelEdition.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEdition.Location = new System.Drawing.Point(12, 78);
            this.labelEdition.Name = "labelEdition";
            this.labelEdition.Size = new System.Drawing.Size(146, 25);
            this.labelEdition.TabIndex = 21;
            this.labelEdition.Text = "Address End";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 25);
            this.label2.TabIndex = 20;
            this.label2.Text = "Address Start";
            // 
            // RelativeControlFlowHelperForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxAddressEnd);
            this.Controls.Add(this.textBoxAddressStart);
            this.Controls.Add(this.comboInstruction);
            this.Controls.Add(this.labelVersion);
            this.Controls.Add(this.labelEdition);
            this.Controls.Add(this.label2);
            this.Name = "RelativeControlFlowHelperForm";
            this.Text = "Relative Control Flow Helper";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Controls.SetChildIndex(this.buttonGenerate, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.labelEdition, 0);
            this.Controls.SetChildIndex(this.labelVersion, 0);
            this.Controls.SetChildIndex(this.comboInstruction, 0);
            this.Controls.SetChildIndex(this.textBoxAddressStart, 0);
            this.Controls.SetChildIndex(this.textBoxAddressEnd, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxAddressEnd;
        private System.Windows.Forms.TextBox textBoxAddressStart;
        private System.Windows.Forms.ComboBox comboInstruction;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.Label labelEdition;
        private System.Windows.Forms.Label label2;
    }
}