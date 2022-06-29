using DataAccesLayer.Abstract;
using DataAccesLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Repositories
{
    public class CategoryRepository : ICategoryDal
    {

        Context C = new Context();
        public void AddCategory(Category category)
        {
            C.Add(category); 
            C.SaveChanges(); //executeNonQuery
        }

        public void DeleteCategory(Category category)
        {
            C.Remove(category);
            C.SaveChanges();
        }

        public Category GetByID(int id)
        {
            return C.Categories.Find(id);
        }

        public List<Category> ListAllCategory()
        {
            return C.Categories.ToList();
        }

        public void UpdateCategory(Category category)
        {
            C.Update(category);
            C.SaveChanges();
        }
    }
}
