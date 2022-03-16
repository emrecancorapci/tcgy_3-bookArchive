using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tcgy_3_bookArchive.Data;
using tcgy_3_bookArchive.Entities;
using Publisher = tcgy_3_bookArchive.Models.Publisher;

namespace tcgy_3_bookArchive.Forms
{
    public partial class AddNewPublisherForm : Form
    {
        public AddNewPublisherForm()
        {
            InitializeComponent();
        }

        private readonly BookshopDbContext _context = new BookshopDbContext();

        private void b_submit_Click(object sender, EventArgs e)
        {
            var name = tb_name.Text;
            if (name == "")
            {
                MessageBox.Show("Name field cannot be empty!", "Empty field!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var publisher = new Publisher()
            {
                Name = name,
                Info = rtb_info.Text
            };

            _context.Publishers.Add(publisher);
            _context.SaveChanges();
            Close();
        }

        private void b_cancel_Click(object sender, EventArgs e) => Close();
    }
}
