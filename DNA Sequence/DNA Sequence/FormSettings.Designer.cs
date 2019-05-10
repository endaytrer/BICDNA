namespace DNA_Sequence
{
    partial class FormSettings
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonS = new System.Windows.Forms.RadioButton();
            this.radioButtonT = new System.Windows.Forms.RadioButton();
            this.checkBoxBar = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxBar);
            this.groupBox1.Controls.Add(this.radioButtonT);
            this.groupBox1.Controls.Add(this.radioButtonS);
            this.groupBox1.Location = new System.Drawing.Point(15, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(357, 123);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Protein Sequence";
            // 
            // radioButtonS
            // 
            this.radioButtonS.AutoSize = true;
            this.radioButtonS.Location = new System.Drawing.Point(24, 24);
            this.radioButtonS.Name = "radioButtonS";
            this.radioButtonS.Size = new System.Drawing.Size(115, 22);
            this.radioButtonS.TabIndex = 0;
            this.radioButtonS.Text = "Single-Letter";
            this.radioButtonS.UseVisualStyleBackColor = true;
            // 
            // radioButtonT
            // 
            this.radioButtonT.AutoSize = true;
            this.radioButtonT.Checked = true;
            this.radioButtonT.Location = new System.Drawing.Point(24, 51);
            this.radioButtonT.Name = "radioButtonT";
            this.radioButtonT.Size = new System.Drawing.Size(119, 22);
            this.radioButtonT.TabIndex = 1;
            this.radioButtonT.TabStop = true;
            this.radioButtonT.Text = "Three-Letters";
            this.radioButtonT.UseVisualStyleBackColor = true;
            // 
            // checkBoxBar
            // 
            this.checkBoxBar.AutoSize = true;
            this.checkBoxBar.Checked = true;
            this.checkBoxBar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxBar.Location = new System.Drawing.Point(24, 78);
            this.checkBoxBar.Name = "checkBoxBar";
            this.checkBoxBar.Size = new System.Drawing.Size(52, 22);
            this.checkBoxBar.TabIndex = 2;
            this.checkBoxBar.Text = "Bar";
            this.checkBoxBar.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(250, 143);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 54);
            this.button1.TabIndex = 1;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(122, 143);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(122, 54);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 211);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormSettings";
            this.Text = "FormSettings";
            this.Load += new System.EventHandler(this.FormSettings_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBoxBar;
        private System.Windows.Forms.RadioButton radioButtonT;
        private System.Windows.Forms.RadioButton radioButtonS;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonCancel;
    }
}