namespace tcgy_3_bookArchive
{
    partial class BookForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_publisher = new System.Windows.Forms.ComboBox();
            this.tb_pages = new System.Windows.Forms.TextBox();
            this.pagesText = new System.Windows.Forms.Label();
            this.dtp_publishDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.l_summary = new System.Windows.Forms.Label();
            this.rtb_summary = new System.Windows.Forms.RichTextBox();
            this.tb_edition = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_condition = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.l_language = new System.Windows.Forms.Label();
            this.cb_language = new System.Windows.Forms.ComboBox();
            this.b_submit = new System.Windows.Forms.Button();
            this.b_addAuthor = new System.Windows.Forms.Button();
            this.b_cancel = new System.Windows.Forms.Button();
            this.b_addPublisher = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_author = new System.Windows.Forms.ComboBox();
            this.tb_isbn = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(94, 15);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(191, 20);
            this.tb_name.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name* :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Author* :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Publisher :";
            // 
            // cb_publisher
            // 
            this.cb_publisher.FormattingEnabled = true;
            this.cb_publisher.Location = new System.Drawing.Point(94, 68);
            this.cb_publisher.Name = "cb_publisher";
            this.cb_publisher.Size = new System.Drawing.Size(191, 21);
            this.cb_publisher.TabIndex = 2;
            // 
            // tb_pages
            // 
            this.tb_pages.Location = new System.Drawing.Point(370, 16);
            this.tb_pages.Name = "tb_pages";
            this.tb_pages.Size = new System.Drawing.Size(27, 20);
            this.tb_pages.TabIndex = 0;
            // 
            // pagesText
            // 
            this.pagesText.AutoSize = true;
            this.pagesText.Location = new System.Drawing.Point(302, 18);
            this.pagesText.Name = "pagesText";
            this.pagesText.Size = new System.Drawing.Size(43, 13);
            this.pagesText.TabIndex = 1;
            this.pagesText.Text = "Pages :";
            // 
            // dtp_publishDate
            // 
            this.dtp_publishDate.CustomFormat = "dd-MM-yyyy";
            this.dtp_publishDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_publishDate.Location = new System.Drawing.Point(485, 15);
            this.dtp_publishDate.Name = "dtp_publishDate";
            this.dtp_publishDate.Size = new System.Drawing.Size(75, 20);
            this.dtp_publishDate.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(403, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Publish Date : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(303, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "ISBN :";
            // 
            // l_summary
            // 
            this.l_summary.AutoSize = true;
            this.l_summary.Location = new System.Drawing.Point(12, 125);
            this.l_summary.Name = "l_summary";
            this.l_summary.Size = new System.Drawing.Size(56, 13);
            this.l_summary.TabIndex = 1;
            this.l_summary.Text = "Summary :";
            // 
            // rtb_summary
            // 
            this.rtb_summary.Location = new System.Drawing.Point(94, 125);
            this.rtb_summary.Name = "rtb_summary";
            this.rtb_summary.Size = new System.Drawing.Size(467, 100);
            this.rtb_summary.TabIndex = 4;
            this.rtb_summary.Text = "";
            // 
            // tb_edition
            // 
            this.tb_edition.Location = new System.Drawing.Point(370, 69);
            this.tb_edition.Name = "tb_edition";
            this.tb_edition.Size = new System.Drawing.Size(191, 20);
            this.tb_edition.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(303, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Edition";
            // 
            // tb_condition
            // 
            this.tb_condition.Location = new System.Drawing.Point(370, 96);
            this.tb_condition.Name = "tb_condition";
            this.tb_condition.Size = new System.Drawing.Size(191, 20);
            this.tb_condition.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(303, 99);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Condition* :";
            // 
            // l_language
            // 
            this.l_language.AutoSize = true;
            this.l_language.Location = new System.Drawing.Point(12, 99);
            this.l_language.Name = "l_language";
            this.l_language.Size = new System.Drawing.Size(61, 13);
            this.l_language.TabIndex = 1;
            this.l_language.Text = "Language :";
            // 
            // cb_language
            // 
            this.cb_language.FormattingEnabled = true;
            this.cb_language.Location = new System.Drawing.Point(94, 96);
            this.cb_language.Name = "cb_language";
            this.cb_language.Size = new System.Drawing.Size(191, 21);
            this.cb_language.TabIndex = 2;
            // 
            // b_submit
            // 
            this.b_submit.Location = new System.Drawing.Point(485, 234);
            this.b_submit.Name = "b_submit";
            this.b_submit.Size = new System.Drawing.Size(75, 23);
            this.b_submit.TabIndex = 5;
            this.b_submit.Text = "Submit";
            this.b_submit.UseVisualStyleBackColor = true;
            this.b_submit.Click += new System.EventHandler(this.b_submit_Click);
            // 
            // b_addAuthor
            // 
            this.b_addAuthor.Location = new System.Drawing.Point(12, 234);
            this.b_addAuthor.Name = "b_addAuthor";
            this.b_addAuthor.Size = new System.Drawing.Size(75, 23);
            this.b_addAuthor.TabIndex = 5;
            this.b_addAuthor.Text = "Add Author";
            this.b_addAuthor.UseVisualStyleBackColor = true;
            // 
            // b_cancel
            // 
            this.b_cancel.Location = new System.Drawing.Point(404, 234);
            this.b_cancel.Name = "b_cancel";
            this.b_cancel.Size = new System.Drawing.Size(75, 23);
            this.b_cancel.TabIndex = 5;
            this.b_cancel.Text = "Cancel";
            this.b_cancel.UseVisualStyleBackColor = true;
            // 
            // b_addPublisher
            // 
            this.b_addPublisher.Location = new System.Drawing.Point(93, 234);
            this.b_addPublisher.Name = "b_addPublisher";
            this.b_addPublisher.Size = new System.Drawing.Size(93, 23);
            this.b_addPublisher.TabIndex = 5;
            this.b_addPublisher.Text = "Add Publisher";
            this.b_addPublisher.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(336, 239);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "* is required";
            // 
            // cb_author
            // 
            this.cb_author.FormattingEnabled = true;
            this.cb_author.Location = new System.Drawing.Point(94, 41);
            this.cb_author.Name = "cb_author";
            this.cb_author.Size = new System.Drawing.Size(191, 21);
            this.cb_author.TabIndex = 2;
            // 
            // tb_isbn
            // 
            this.tb_isbn.Location = new System.Drawing.Point(370, 43);
            this.tb_isbn.Name = "tb_isbn";
            this.tb_isbn.Size = new System.Drawing.Size(191, 20);
            this.tb_isbn.TabIndex = 0;
            // 
            // BookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 269);
            this.Controls.Add(this.b_addPublisher);
            this.Controls.Add(this.b_addAuthor);
            this.Controls.Add(this.b_cancel);
            this.Controls.Add(this.b_submit);
            this.Controls.Add(this.rtb_summary);
            this.Controls.Add(this.dtp_publishDate);
            this.Controls.Add(this.cb_language);
            this.Controls.Add(this.l_language);
            this.Controls.Add(this.cb_publisher);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb_author);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pagesText);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.l_summary);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_pages);
            this.Controls.Add(this.tb_condition);
            this.Controls.Add(this.tb_edition);
            this.Controls.Add(this.tb_isbn);
            this.Controls.Add(this.tb_name);
            this.Name = "BookForm";
            this.Text = "BookForm";
            this.Load += new System.EventHandler(this.BookForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_publisher;
        private System.Windows.Forms.TextBox tb_pages;
        private System.Windows.Forms.Label pagesText;
        private System.Windows.Forms.DateTimePicker dtp_publishDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label l_summary;
        private System.Windows.Forms.RichTextBox rtb_summary;
        private System.Windows.Forms.TextBox tb_edition;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_condition;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label l_language;
        private System.Windows.Forms.ComboBox cb_language;
        private System.Windows.Forms.Button b_submit;
        private System.Windows.Forms.Button b_addAuthor;
        private System.Windows.Forms.Button b_cancel;
        private System.Windows.Forms.Button b_addPublisher;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cb_author;
        private System.Windows.Forms.TextBox tb_isbn;
    }
}