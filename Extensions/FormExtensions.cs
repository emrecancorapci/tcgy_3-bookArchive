using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;

namespace tcgy_3_bookArchive.Extensions
{
    public static class FormExtensions
    {
        private static void DataLoader<T>(this ComboBox cb, DbSet<T> db, string value, string display) where T : class
        {
            cb.DataSource = db.ToList();
            cb.ValueMember = value;
            cb.DisplayMember = display;
        }
    }
}