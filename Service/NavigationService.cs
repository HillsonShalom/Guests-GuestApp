using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Guests_GuestApp.DAL;

namespace Guests_GuestApp.Service
{
    internal class NavigationService
    {
        public static string Name;
        public static string[] categories;
        public static DBContext db;

        public NavigationService(string name)
        {
            Name = name; 
            CategoryForm.name = name;
            db = new DBContext(ConfigService.GetConnectionString());
            categories = GetCategories();
            CategoryForm.categories = categories;
            CategoryForm.db = db;
            
            //for (int i = 0; i < formsArray.Length; i++)
            //{
            //    formsArray[i] = new CategoryForm(categories[i]);
            //}
        }

        public void ShowFirstCategory()
        {
            CloseAllForms();
            //formsArray[0].Show();
        }

        public static void CloseAllForms()
        {
            List<Form> openForms = new List<Form>(Application.OpenForms.Cast<Form>());
            openForms.ForEach(f => f.Close());
        }


        public string[] GetCategories()
        {
            DataTable? table;
            table = db.ExecuteQuery("select name from Categories", null);
            return table.AsEnumerable().Select(row => row.Field<string>("Name")).ToArray();
        }
    }
}
