using System;
using System.Linq;
using System.Windows.Forms;
using tcgy_3_bookArchive.Data;
using tcgy_3_bookArchive.Entities;

namespace tcgy_3_bookArchive.Forms
{
    public partial class AuthorForm : Form
    {
        public AuthorForm()
        {
            InitializeComponent();
        }

        private readonly BookshopDbContext _context = new BookshopDbContext();

        private void bt_submit_Click(object sender, EventArgs e)
        {
            var name = tb_name.Text;
            var lastName = tb_lastName.Text;

            if (name == "" || lastName == "")
            {
                MessageBox.Show("Name or last name cannot be empty!", "Error!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var author = new Author()
            {
                Name = tb_name.Text,
                LastName = tb_lastName.Text,
                BirthDate = dtp_birthDate.Value.Date,
                Info = rtb_Info.Text
            };

            if (IsAuthorExistInDb(author)) return;

            _context.Authors.Add(author);
            _context.SaveChanges();
            Close();
        }

        private bool IsAuthorExistInDb(Author author)
        {
            foreach (var answer in
                     from a in _context.Authors.ToList()
                     where a.FullName == author.FullName
                     select MessageBox.Show(
                         $"An author by the same name who was\n" +
                         $"born in {a.BirthDate.Year} is in the database.\n\n" +
                         "Would you like to add another one?",
                         "Same author!",
                         MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                if (answer == DialogResult.Yes) break;
                else return true;
            }

            return false;
        }

        private void bt_cancel_Click(object sender, EventArgs e) => Close();
    }
}
