using Newtonsoft.Json.Linq;
using ShabatHost.DAL.Models;
using ShabatHost.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ShabatHost.Views
{
    internal partial class ShabatHostForm : Form
    {
        private CategoryRepository _categoryRepository;
        private DataTable Categories;
        public ShabatHostForm(CategoryRepository? categoryRepository)
        {
            InitializeComponent();
            _categoryRepository = categoryRepository;
            //LoadCategories(_categoryRepository.FindAll());
            LoadCategories(_categoryRepository.FindAllDT());
        }
        private void LoadCategories(DataTable categories)
        {
            // Clear existing items
            listBoxCategories.Items.Clear();

            if (categories.Columns.Count > 0)
            {

                // Add new items from DataTable, to listbox
                foreach (DataRow row in categories.Rows)
                {                  
                    listBoxCategories.Items.Add(row[0].ToString());
                }
            }
            else
            {
                // Handle the case where there are no rows
                MessageBox.Show("No Rows available in the DataTable.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void buttonInsert_Click(object sender, EventArgs e)
        {
            string category = textBoxInsert.Text.Trim();
            if (string.IsNullOrEmpty(category))
            {
                MessageBox.Show("נא להכניס קטגוריה להוספה");
                return;
            }

            bool sucess = _categoryRepository.Insert(new CategoryModel(category, null));
            if (!sucess)
            {
                MessageBox.Show("לא ניתן להוסיף קטגוריה");
            }

            LoadCategories(_categoryRepository.FindAllDT());
            textBoxInsert.Text = "";
        }

       
    }

}
