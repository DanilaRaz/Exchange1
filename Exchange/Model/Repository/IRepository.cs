using System;
using System.Collections.Generic;
using Exchange.Model.Data;

namespace Exchange.Model.Repository
{
    public interface IRepository<T> where T: Base
    {
        List<T> Values { get; set; }

        void Add(T model);
        T Get(int id);
        List<T> GetAll();
        void Delete(int id);
        void Update(T model);

        List<T> FindBy(Func<T, bool> condition);
    }
}