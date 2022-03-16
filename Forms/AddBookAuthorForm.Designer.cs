namespace tcgy_3_bookArchive.Forms
{
    partial class AddBookAuthorForm
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
            this.lb_bookAuthors = new System.Windows.Forms.ListBox();
            this.lb_authorList = new System.Windows.Forms.ListBox();
            this.b_remove = new System.Windows.Forms.Button();
            this.b_Add = new System.Windows.Forms.Button();
            this.tb_bookName = new System.Windows.Forms.TextBox();
            this.b_Submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_bookAuthors
            // 
            this.lb_bookAuthors.FormattingEnabled = true;
            this.lb_bookAuthors.Location = new System.Drawing.Point(12, 75);
            this.lb_bookAuthors.Name = "lb_bookAuthors";
            this.lb_bookAuthors.Size = new System.Drawing.Size(120, 147);
            this.lb_bookAuthors.TabIndex = 1;
            // 
            // lb_authorList
            // 
            this.lb_authorList.FormattingEnabled = true;
            this.lb_authorList.Location = new System.Drawing.Point(199, 75);
            this.lb_authorList.Name = "lb_authorList";
            this.lb_authorList.Size = new System.Drawing.Size(120, 147);
            this.lb_authorList.TabIndex = 2;
            // 
            // b_remove
            // 
            this.b_remove.Location = new System.Drawing.Point(150, 163);
            this.b_remove.Name = "b_remove";
            this.b_remove.Size = new System.Drawing.Size(31, 23);
            this.b_remove.TabIndex = 3;
            this.b_remove.Text = "->";
            this.b_remove.UseVisualStyleBackColor = true;
            this.b_remove.Click += new System.EventHandler(this.b_remove_Click);
            // 
            // b_Add
            // 
            this.b_Add.Location = new System.Drawing.Point(150, 115);
            this.b_Add.Name = "b_Add";
            this.b_Add.Size = new System.Drawing.Size(31, 23);
            this.b_Add.TabIndex = 4;
            this.b_Add.Text = "<-";
            this.b_Add.UseVisualStyleBackColor = true;
            this.b_Add.Click += new System.EventHandler(this.b_Add_Click);
            // 
            // tb_bookName
            // 
            this.tb_bookName.Location = new System.Drawing.Point(70, 24);
            this.tb_bookName.Name = "tb_bookName";
            this.tb_bookName.Size = new System.Drawing.Size(195, 20);
            this.tb_bookName.TabIndex = 5;
            // 
            // b_Submit
            // 
            this.b_Submit.Location = new System.Drawing.Point(240, 241);
            this.b_Submit.Name = "b_Submit";
            this.b_Submit.Size = new System.Drawing.Size(79, 23);
            this.b_Submit.TabIndex = 6;
            this.b_Submit.Text = "Submit";
            this.b_Submit.UseVisualStyleBackColor = true;
            // 
            // AddBookAuthorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 276);
            this.Controls.Add(this.b_Submit);
            this.Controls.Add(this.tb_bookName);
            this.Controls.Add(this.b_Add);
            this.Controls.Add(this.b_remove);
            this.Controls.Add(this.lb_authorList);
            this.Controls.Add(this.lb_bookAuthors);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddBookAuthorForm";
            this.Text = "AddBookAuthorForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lb_bookAuthors;
        private System.Windows.Forms.ListBox lb_authorList;
        private System.Windows.Forms.Button b_remove;
        private System.Windows.Forms.Button b_Add;
        private System.Windows.Forms.TextBox tb_bookName;
        private System.Windows.Forms.Button b_Submit;
    }
}