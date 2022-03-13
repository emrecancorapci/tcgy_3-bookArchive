﻿namespace tcgy_3_bookArchive.Forms
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.b_addBook = new System.Windows.Forms.Button();
            this.b_addAuthor = new System.Windows.Forms.Button();
            this.b_addPublisher = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridView1.Location = new System.Drawing.Point(24, 27);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.RowTemplate.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(448, 241);
            this.dataGridView1.TabIndex = 0;
            // 
            // b_addBook
            // 
            this.b_addBook.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.b_addBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_addBook.Location = new System.Drawing.Point(12, 274);
            this.b_addBook.Name = "b_addBook";
            this.b_addBook.Size = new System.Drawing.Size(140, 32);
            this.b_addBook.TabIndex = 1;
            this.b_addBook.Text = "Add Book";
            this.b_addBook.Click += new System.EventHandler(this.b_addBook_Click);
            // 
            // b_addAuthor
            // 
            this.b_addAuthor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.b_addAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_addAuthor.Location = new System.Drawing.Point(166, 274);
            this.b_addAuthor.Name = "b_addAuthor";
            this.b_addAuthor.Size = new System.Drawing.Size(140, 32);
            this.b_addAuthor.TabIndex = 1;
            this.b_addAuthor.Text = "Add Author";
            this.b_addAuthor.UseVisualStyleBackColor = false;
            this.b_addAuthor.Click += new System.EventHandler(this.b_addAuthor_Click);
            // 
            // b_addPublisher
            // 
            this.b_addPublisher.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.b_addPublisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_addPublisher.Location = new System.Drawing.Point(320, 274);
            this.b_addPublisher.Name = "b_addPublisher";
            this.b_addPublisher.Size = new System.Drawing.Size(140, 32);
            this.b_addPublisher.TabIndex = 1;
            this.b_addPublisher.Text = "Add Publisher";
            this.b_addPublisher.UseVisualStyleBackColor = false;
            this.b_addPublisher.Click += new System.EventHandler(this.b_addPublisher_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.b_addAuthor);
            this.panel1.Controls.Add(this.b_addPublisher);
            this.panel1.Controls.Add(this.b_addBook);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(472, 449);
            this.panel1.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 473);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "Book Archive";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button b_addBook;
        private System.Windows.Forms.Button b_addAuthor;
        private System.Windows.Forms.Button b_addPublisher;
        private System.Windows.Forms.Panel panel1;
    }
}

