using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellingCourseWebsite.BLL.Repository
{
    public interface ICrudRepository<Type, IdType>
    {
        public List<Type> GetAll();
        public Type GetById(IdType id);
        public List<Type> Search(string keyword);

        public int Add(Type type);
        public int Update(Type type);
        public int Delete(IdType id);
    }
}
