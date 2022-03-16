using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using tcgy_3_bookArchive.Data;
using tcgy_3_bookArchive.Models;

namespace tcgy_3_bookArchive.Forms
{
    public partial class AddBookAuthorForm : Form
    {
        private readonly BookshopDbContext _context = new BookshopDbContext();
        private readonly Book _book;
        private List<Author> authorList;


        public AddBookAuthorForm(HashSet<int> authorsID, ref Book book)
        {
            InitializeComponent();

            tb_bookName.Text = book.Name;
            _book = book;

            authorList = (from author in _book.Authors
                where author.AuthorID == _book.ID
                select author.Author).ToList();

            UpdateAuthorList();
            UpdateBookAuthors();
        }

        private void UpdateAuthorList()
        {
            var authors = _context.Authors.Select(
                a => new
                {
                    a.ID,
                    FullName = a.Name + " " + a.LastName
                }).ToList();

            lb_authorList.DataSource = authors;
            lb_authorList.DisplayMember = "FullName";
            lb_authorList.ValueMember = "ID";
        }
        private void UpdateBookAuthors()
        {
            var bookAuthors = authorList.Select(
                a => new
                {
                    a.ID,
                    FullName = a.Name + " " + a.LastName
                }).ToList();

            lb_bookAuthors.DataSource = bookAuthors;
            lb_bookAuthors.DisplayMember = "FullName";
            lb_bookAuthors.ValueMember = "ID";
        }

        private void b_Add_Click(object sender, System.EventArgs e)
        {
            lb_bookAuthors.Items.Add(lb_authorList.SelectedItems);
            UpdateBookAuthors();
        }

        private void b_remove_Click(object sender, System.EventArgs e)
        {
            lb_bookAuthors.Items.Remove(lb_bookAuthors.SelectedItems);
            UpdateBookAuthors();
        }
    }
}
