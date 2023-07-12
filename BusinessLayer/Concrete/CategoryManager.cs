using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager
    {
        GenericRepository<Category> repository = new GenericRepository<Category>();
        public List<Category> TGetAll()
        {
            return repository.List();
        }
        public void TAddCategory(Category p)
        {
            if(p.CategoryName == "" || p.CategoryName.Length <= 3 || p.CategoryDescription == "" || p.CategoryName.Length > 51)
            {
                //hata mesajı
            }
            else
            {
                repository.Add(p);
            }
        }
    }
}
