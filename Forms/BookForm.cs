using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using tcgy_3_bookArchive.Data;
using tcgy_3_bookArchive.Models;

namespace tcgy_3_bookArchive.Forms
{
    public partial class BookForm : Form
    {
        private readonly Book _editBook;
        private Book currentBook;

        public BookForm(Book book)
        {
            InitializeComponent();

            _editBook = book;
        }

        private readonly BookshopDbContext _context = new BookshopDbContext();

        private void BookForm_Load(object sender, EventArgs e)
        {
            GetAuthors();
            GetPublishers();
            GetLanguages();

            if (_editBook == null) return;

            FillFields();
        }

        private void FillFields()
        {
            tb_name.Text = _editBook.Name;
            tb_pages.Text = _editBook.Pages.ToString();
            tb_isbn.Text = _editBook.ISBN.ToString();
            tb_condition.Text = _editBook.Condition;
            tb_edition.Text = _editBook.Edition;
            dtp_publishDate.Value = _editBook.PublishDate;


            if (_editBook.LanguageID != null)
                cb_language.SelectedIndex = (int)_editBook.LanguageID;
        }

        private void b_submit_Click(object sender, EventArgs e)
        {
            AddBook();
            var result = _context.SaveChanges();
            ShowResult(result);
            Close();
        }

        private void b_cancel_Click(object sender, EventArgs e) => Close();

        private void b_addAuthor_Click(object sender, EventArgs e)
        {
            UpdateBookValues();
            if (currentBook == null) return;


            HashSet<int> hsAuthorIDs;

            if (_editBook != null)
            {
                hsAuthorIDs = 
                    (from author in currentBook.Authors
                    where author.AuthorID == currentBook.ID
                    select author.AuthorID).ToHashSet();
            }
            else
            {
                hsAuthorIDs = new HashSet<int> { cb_author.SelectedIndex };
            }


            Form form = new AddBookAuthorForm(hsAuthorIDs, ref currentBook);
            form.FormClosing += new FormClosingEventHandler(this.AuthorFormClosing);
            form.Show();
        }

        private void b_addPublisher_Click(object sender, EventArgs e)
        {
            Form form = new AddNewPublisherForm();
            form.FormClosing += new FormClosingEventHandler(this.PublisherFormClosing);
            form.Show();
        }

        private void AuthorFormClosing(object sender, FormClosingEventArgs e)
        {
            cb_author.DataSource = _context.Authors.ToList();
            cb_author.ValueMember = "ID";
            cb_author.DisplayMember = "FullName";
        }

        private void PublisherFormClosing(object sender, FormClosingEventArgs e)
        {
            cb_publisher.DataSource = _context.Authors.ToList();
            cb_publisher.ValueMember = "ID";
            cb_publisher.DisplayMember = "FullName";
        }

        private void GetLanguages()
        {
            cb_language.DataSource = _context.Languages.ToList();
            cb_language.ValueMember = "ID";
            cb_language.DisplayMember = "Name";
        }

        private void GetPublishers()
        {
            cb_publisher.DataSource = _context.Publishers.ToList();
            cb_publisher.ValueMember = "ID";
            cb_publisher.DisplayMember = "Name";
        }

        private void GetAuthors()
        {
            cb_author.DataSource = _context.Authors.ToList();
            cb_author.ValueMember = "ID";
            cb_author.DisplayMember = "FullName";
        }

        private static void ShowResult(int result)
        {
            var (msg1, msg2) = result > 0 ? ("Success!", "added") : ("Failed!", "cannot added");
            MessageBox.Show($"Book {msg2} to database.", $"{msg1}");
        }

        private void AddBook()
        {
            if (currentBook != null) return;
            _context.Books.Add(currentBook);
        }

        private void UpdateBookValues()
        {
            var name = tb_name.Text;
            var pages = TextBoxToInt(tb_pages.Text);
            var isbn = TextBoxToInt(tb_isbn.Text);
            
            if (CheckValues(pages, isbn, name)) return;

            currentBook = new Book()
            {
                Name = name,
                Pages = (int)pages,
                ISBN = (long)isbn,
                Condition = tb_condition.Text,
                Edition = tb_edition.Text,
                LanguageID = cb_language.SelectedIndex
            };
        }

        private static bool CheckValues(int? pages, int? isbn, string name)
        {
            if (pages == null)
            {
                MessageBox.Show("Enter pages as number!", "Format error!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }

            if (isbn == null)
            {
                MessageBox.Show("Enter isbn as number!", "Format error!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }

            if (name == "")
            {
                MessageBox.Show("Name field cannot be empty!", "Error!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }

            return false;
        }

        private static int? TextBoxToInt(string str)
        {
            if (int.TryParse(str, out var result)) return result;
            else
            {
                if (str == "") return 0;
                else return null;
            }
        }


    }
}
