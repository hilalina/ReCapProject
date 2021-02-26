using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IBusinessRepository<T> where T : class
    {
        List<T> GetAll();
        List<T> GetById(int id);
        void Add(T business);
        void Update(T business);
        void Delete(T business);
    }
}
