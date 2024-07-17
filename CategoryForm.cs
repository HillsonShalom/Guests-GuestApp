using Guests_GuestApp.DAL;
using Guests_GuestApp.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Guests_GuestApp
{
    public partial class CategoryForm : Form
    {
        public static string name;
        public static int nameID;
        internal static DBContext db;
        internal static string[] categories;
        private int _index;
        private int _categoryID;
        public CategoryForm(int categoryIndex)
        {
            InitializeComponent();
            _index = categoryIndex;
            label_category.Text = categories[categoryIndex];
            FillTable();
            FillList();

            SqlParameter[] pars = { new SqlParameter("@name", categories[categoryIndex]) };
            _categoryID = (int)db.ExecuteScalar("select ID from Categories where Name = @name", pars);
        }



        private void FillTable()
        {
            DataTable tbl;
            SqlParameter[] parameters = {new SqlParameter("@category", label_category.Text),
                                         new SqlParameter("@name", name)};
            tbl = db.ExecuteQuery(@"select g.Name, f.Name from Food f 
                                    join Guests g on f.Guest_ID = g.ID
                                    join Categories c on f.Category_ID = c.ID
                                    where c.Name = @category and g.name != @name", parameters);
            table.DataSource = tbl;
        }

        private void FillList()
        {
            SqlParameter[] parameters = {new SqlParameter("@category", label_category.Text),
                                         new SqlParameter("@name", name)};
            DataTable tbl = db.ExecuteQuery(@"select f.Name from Food f 
                                    join Guests g on f.Guest_ID = g.ID
                                    join Categories c on f.Category_ID = c.ID
                                    where c.Name = @category and g.name = @name", parameters);
            string[] my = tbl.AsEnumerable().Select(row => row.Field<string>("Name")).ToArray();
            foreach (string myItem in my)
            {
                list_myfood.Items.Add(myItem);
            }
        }

        private void button_previous_Click(object sender, EventArgs e)
        {
            if (_index == 0)
            {
                _index = categories.Length - 1;
            }
            else
            {
                _index--;
            }
            move(_index);
        }

        private void button_next_Click(object sender, EventArgs e)
        {
            if (_index == categories.Length - 1)
            {
                _index = 0;
            }
            else
            {
                _index++;
            }
            move(_index);
        }

        private void move(int index)
        {
            Thread move = new Thread(() =>
            {
                Application.Run(new CategoryForm(index));
            });
            move.Start();
            this.Close();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(text_food.Text))
            {
                MessageBox.Show("הכנס שם מאכל");
                return;
            }

            SqlParameter[] pars = { new SqlParameter("@name", text_food.Text),
                                    new SqlParameter("@gueID", nameID),
                                    new SqlParameter("@catID", _categoryID)};
            int answer = db.ExecuteNonQuery(@"insert into Food(name, Guest_ID, Category_ID) 
                                            values (@name, @gueID, @catID)", pars);
            if (answer < 1)
            {
                MessageBox.Show("לא הצליח");
                return;
            }
            FillList();
        }
    }
}
