namespace tcgy_3_bookArchive.Forms
{
    partial class AddNewAuthorForm
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
            this.tb_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_lastName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtp_birthDate = new System.Windows.Forms.DateTimePicker();
            this.rtb_Info = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.bt_submit = new System.Windows.Forms.Button();
            this.bt_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(104, 12);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(185, 20);
            this.tb_name.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name :";
            // 
            // tb_lastName
            // 
            this.tb_lastName.Location = new System.Drawing.Point(104, 38);
            this.tb_lastName.Name = "tb_lastName";
            this.tb_lastName.Size = new System.Drawing.Size(185, 20);
            this.tb_lastName.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Birth Date :";
            // 
            // dtp_birthDate
            // 
            this.dtp_birthDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_birthDate.Location = new System.Drawing.Point(104, 67);
            this.dtp_birthDate.Name = "dtp_birthDate";
            this.dtp_birthDate.Size = new System.Drawing.Size(185, 20);
            this.dtp_birthDate.TabIndex = 2;
            // 
            // rtb_Info
            // 
            this.rtb_Info.Location = new System.Drawing.Point(104, 107);
            this.rtb_Info.Name = "rtb_Info";
            this.rtb_Info.Size = new System.Drawing.Size(185, 122);
            this.rtb_Info.TabIndex = 3;
            this.rtb_Info.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Info :";
            // 
            // bt_submit
            // 
            this.bt_submit.BackColor = System.Drawing.Color.Honeydew;
            this.bt_submit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_submit.Location = new System.Drawing.Point(191, 245);
            this.bt_submit.Name = "bt_submit";
            this.bt_submit.Size = new System.Drawing.Size(75, 23);
            this.bt_submit.TabIndex = 4;
            this.bt_submit.Text = "Submit";
            this.bt_submit.UseVisualStyleBackColor = false;
            this.bt_submit.Click += new System.EventHandler(this.bt_submit_Click);
            // 
            // bt_cancel
            // 
            this.bt_cancel.BackColor = System.Drawing.Color.MistyRose;
            this.bt_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bt_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_cancel.Location = new System.Drawing.Point(25, 245);
            this.bt_cancel.Name = "bt_cancel";
            this.bt_cancel.Size = new System.Drawing.Size(75, 23);
            this.bt_cancel.TabIndex = 4;
            this.bt_cancel.Text = "Cancel";
            this.bt_cancel.UseVisualStyleBackColor = false;
            this.bt_cancel.Click += new System.EventHandler(this.bt_cancel_Click);
            // 
            // AuthorForm
            // 
            this.AcceptButton = this.bt_submit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bt_cancel;
            this.ClientSize = new System.Drawing.Size(301, 280);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.tb_lastName);
            this.Controls.Add(this.dtp_birthDate);
            this.Controls.Add(this.rtb_Info);
            this.Controls.Add(this.bt_cancel);
            this.Controls.Add(this.bt_submit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddAuthorForm";
            this.Text = "Add Author";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_lastName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtp_birthDate;
        private System.Windows.Forms.RichTextBox rtb_Info;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bt_submit;
        private System.Windows.Forms.Button bt_cancel;
    }
}