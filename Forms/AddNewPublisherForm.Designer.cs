namespace tcgy_3_bookArchive.Forms
{
    partial class AddNewPublisherForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.rtb_info = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.b_submit = new System.Windows.Forms.Button();
            this.b_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name :";
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(66, 21);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(275, 20);
            this.tb_name.TabIndex = 1;
            // 
            // rtb_info
            // 
            this.rtb_info.Location = new System.Drawing.Point(66, 50);
            this.rtb_info.Name = "rtb_info";
            this.rtb_info.Size = new System.Drawing.Size(275, 80);
            this.rtb_info.TabIndex = 2;
            this.rtb_info.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Info :";
            // 
            // b_submit
            // 
            this.b_submit.BackColor = System.Drawing.Color.Honeydew;
            this.b_submit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.b_submit.Location = new System.Drawing.Point(351, 21);
            this.b_submit.Name = "b_submit";
            this.b_submit.Size = new System.Drawing.Size(75, 23);
            this.b_submit.TabIndex = 3;
            this.b_submit.Text = "Submit";
            this.b_submit.UseVisualStyleBackColor = false;
            this.b_submit.Click += new System.EventHandler(this.b_submit_Click);
            // 
            // b_cancel
            // 
            this.b_cancel.BackColor = System.Drawing.Color.MistyRose;
            this.b_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.b_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.b_cancel.Location = new System.Drawing.Point(351, 50);
            this.b_cancel.Name = "b_cancel";
            this.b_cancel.Size = new System.Drawing.Size(75, 23);
            this.b_cancel.TabIndex = 4;
            this.b_cancel.Text = "Cancel";
            this.b_cancel.UseVisualStyleBackColor = false;
            this.b_cancel.Click += new System.EventHandler(this.b_cancel_Click);
            // 
            // PublisherForm
            // 
            this.AcceptButton = this.b_submit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.b_cancel;
            this.ClientSize = new System.Drawing.Size(438, 152);
            this.Controls.Add(this.b_cancel);
            this.Controls.Add(this.b_submit);
            this.Controls.Add(this.rtb_info);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddPublisherForm";
            this.Text = "Add Publisher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.RichTextBox rtb_info;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button b_submit;
        private System.Windows.Forms.Button b_cancel;
    }
}