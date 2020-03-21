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
            this.components = new System.ComponentModel.Container();
            this.comboInstructionType = new System.Windows.Forms.ComboBox();
            this.labelVersion = new System.Windows.Forms.Label();
            this.labelEdition = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.labelResult = new System.Windows.Forms.Label();
            this.contextMenuStripResult = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.textBoxAddressStart = new System.Windows.Forms.TextBox();
            this.textBoxAddressEnd = new System.Windows.Forms.TextBox();
            this.contextMenuStripResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboInstructionType
            // 
            this.comboInstructionType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboInstructionType.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboInstructionType.FormattingEnabled = true;
            this.comboInstructionType.Location = new System.Drawing.Point(196, 129);
            this.comboInstructionType.Name = "comboInstructionType";
            this.comboInstructionType.Size = new System.Drawing.Size(172, 33);
            this.comboInstructionType.TabIndex = 15;
            this.comboInstructionType.SelectedIndexChanged += new System.EventHandler(this.ComboInstructionType_SelectedIndexChanged);
            // 
            // labelVersion
            // 
            this.labelVersion.AutoSize = true;
            this.labelVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVersion.Location = new System.Drawing.Point(12, 132);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(181, 25);
            this.labelVersion.TabIndex = 14;
            this.labelVersion.Text = "Instruction Type";
            // 
            // labelEdition
            // 
            this.labelEdition.AutoSize = true;
            this.labelEdition.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEdition.Location = new System.Drawing.Point(12, 77);
            this.labelEdition.Name = "labelEdition";
            this.labelEdition.Size = new System.Drawing.Size(146, 25);
            this.labelEdition.TabIndex = 12;
            this.labelEdition.Text = "Address End";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Address Start";
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGenerate.ForeColor = System.Drawing.Color.Navy;
            this.buttonGenerate.Location = new System.Drawing.Point(-1, 169);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(799, 85);
            this.buttonGenerate.TabIndex = 17;
            this.buttonGenerate.Text = "Generate Instruction";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            this.buttonGenerate.Click += new System.EventHandler(this.ButtonGenerate_Click);
            // 
            // labelResult
            // 
            this.labelResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelResult.ContextMenuStrip = this.contextMenuStripResult;
            this.labelResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResult.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelResult.Location = new System.Drawing.Point(-1, 257);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(799, 193);
            this.labelResult.TabIndex = 16;
            this.labelResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelResult.UseMnemonic = false;
            // 
            // contextMenuStripResult
            // 
            this.contextMenuStripResult.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemCopy});
            this.contextMenuStripResult.Name = "contextMenuStripResult";
            this.contextMenuStripResult.Size = new System.Drawing.Size(138, 40);
            this.contextMenuStripResult.Opening += new System.ComponentModel.CancelEventHandler(this.ContextMenuStripResult_Opening);
            // 
            // toolStripMenuItemCopy
            // 
            this.toolStripMenuItemCopy.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItemCopy.Name = "toolStripMenuItemCopy";
            this.toolStripMenuItemCopy.Size = new System.Drawing.Size(137, 36);
            this.toolStripMenuItemCopy.Text = "Copy";
            this.toolStripMenuItemCopy.Click += new System.EventHandler(this.ToolStripMenuItemCopy_Click);
            // 
            // textBoxAddressStart
            // 
            this.textBoxAddressStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.textBoxAddressStart.Location = new System.Drawing.Point(196, 12);
            this.textBoxAddressStart.Name = "textBoxAddressStart";
            this.textBoxAddressStart.Size = new System.Drawing.Size(172, 31);
            this.textBoxAddressStart.TabIndex = 18;
            this.textBoxAddressStart.TextChanged += new System.EventHandler(this.TextBoxAddressStart_TextChanged);
            // 
            // textBoxAddressEnd
            // 
            this.textBoxAddressEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            this.textBoxAddressEnd.Location = new System.Drawing.Point(196, 74);
            this.textBoxAddressEnd.Name = "textBoxAddressEnd";
            this.textBoxAddressEnd.Size = new System.Drawing.Size(172, 31);
            this.textBoxAddressEnd.TabIndex = 19;
            this.textBoxAddressEnd.TextChanged += new System.EventHandler(this.TextBoxAddressEnd_TextChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxAddressEnd);
            this.Controls.Add(this.textBoxAddressStart);
            this.Controls.Add(this.buttonGenerate);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.comboInstructionType);
            this.Controls.Add(this.labelVersion);
            this.Controls.Add(this.labelEdition);
            this.Controls.Add(this.label2);
            this.Name = "MainForm";
            this.Text = "Tricore Instruction Helper";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.contextMenuStripResult.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboInstructionType;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.Label labelEdition;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.TextBox textBoxAddressStart;
        private System.Windows.Forms.TextBox textBoxAddressEnd;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripResult;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemCopy;
    }
}

