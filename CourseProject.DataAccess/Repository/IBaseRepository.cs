using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject.DataAccess.Repository
{
    interface IBaseRepository<T> where T : class
    {
        List<T> GetAll();

        T GetByID(int id);

        void Create(T item);

        void Update(T item, Func<T, bool> findByIDPredecate);
    }
}