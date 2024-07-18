using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShabatHost.DAL.Models;

namespace ShabatHost.DAL.Repositories
{
    internal class CategoryRepository : IRepository<CategoryModel>
    {
        private readonly DBContext _dbContext;

        public CategoryRepository(DBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<CategoryModel> FindAll()
        {
            var categories = new List<CategoryModel>();
            string query = "SELECT ID, Name FROM Categories";

            DataTable result = _dbContext.ExecuteQuery(query, null);
            foreach (DataRow row in result.Rows)
            {
                categories.Add(new CategoryModel(row));
            }

            return categories;
        }
        public DataTable FindAllDT()
        {
            string query = "SELECT Name FROM Categories";

            DataTable result = _dbContext.ExecuteQuery(query, null);
            return result;
        }

        public CategoryModel FindById(int categoryId)
        {
            string query = "SELECT ID, Name FROM Categories WHERE ID = @CategoryID";
            SqlParameter[] parameters = { new SqlParameter("@CategoryID", categoryId) };

            DataTable result = _dbContext.ExecuteQuery(query, parameters);
            if (result.Rows.Count == 0)
            {
                return null;
            }

            return new CategoryModel(result.Rows[0]);
        }

        public bool Insert(CategoryModel category)
        {
            string query = "INSERT INTO Categories (Name) VALUES (@CategoryName)";
            SqlParameter[] parameters = { new SqlParameter("@CategoryName", category.CategoryName) };

            int rowsAffected = _dbContext.ExecuteNonQuery(query, parameters);
            return rowsAffected > 0;
        }

        public bool Update(CategoryModel category)
        {
            string query = "UPDATE Categories SET Name = @CategoryName WHERE ID = @CategoryID";
            SqlParameter[] parameters = {
                new SqlParameter("@CategoryName", category.CategoryName),
                new SqlParameter("@CategoryID", category.CategoryID)
            };

            int rowsAffected = _dbContext.ExecuteNonQuery(query, parameters);
            return rowsAffected > 0;
        }

        public bool Delete(int categoryId)
        {
            string query = "DELETE FROM Categories WHERE ID = @CategoryID";
            SqlParameter[] parameters = { new SqlParameter("@CategoryID", categoryId) };

            int rowsAffected = _dbContext.ExecuteNonQuery(query, parameters);
            return rowsAffected > 0;
        }
        public CategoryModel ValueAt(int id)
        {
            throw new NotImplementedException();
        }
    }
}
