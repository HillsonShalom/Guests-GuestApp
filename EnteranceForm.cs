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
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Guests_GuestApp
{
    public partial class EnteranceForm : Form
    {
        private DBContext db;
        public EnteranceForm()
        {
            InitializeComponent();
            db = new DBContext(ConfigService.GetConnectionString());
            InitializeList();
        }

        public void InitializeList()
        {
            DataTable table = new DataTable();
            table = db.ExecuteQuery("select name from Guests", null);
            string[] gues = table.AsEnumerable().Select(row => row.Field<string>("Name")).ToArray();
            foreach (string gue in gues)
            {
                list_guests.Items.Add($"{gue}");
            }

        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            

            string name = text_name.Text;
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("הכנס שם");
                return;
            }

            SqlParameter[] pars = { new SqlParameter("@name", name) };
            int answer = db.ExecuteNonQuery("insert into Guests(name) values (@name)", pars);
            if (answer < 1)
            {
                MessageBox.Show("כבר קיים");
            }

            list_guests.Items.Add(name);
            MoveOn(text_name.Text);
        }

        private void MoveOn(string name)
        {
            Thread move = new Thread(() =>
            {
                //NavigationService ns = new NavigationService(name);
                SqlParameter[] pars = { new SqlParameter("@name", name) };
                CategoryForm.nameID = (int)db.ExecuteScalar("select ID from Guests where Name = @name", pars);
                CategoryForm.name = name;
                CategoryForm.categories = GetCategories();
                CategoryForm.db = db;
                Application.Run(new CategoryForm(0));
            });
            move.Start();
            this.Close();
            //NavigationService ns = new NavigationService(name);
            //ns.ShowFirstCategory();
        }

        private void ListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (list_guests.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = list_guests.SelectedItems[0];
                HandleItemClick(selectedItem);
            }
        }

        private void HandleItemClick(ListViewItem item)
        {
            string txt = item.Text;
            //MessageBox.Show($"{item.Text}");
            MoveOn(txt);
        }

        public string[] GetCategories()
        {
            DataTable? table;
            table = db.ExecuteQuery("select name from Categories", null);
            return table.AsEnumerable().Select(row => row.Field<string>("Name")).ToArray();
        }
    }
}
