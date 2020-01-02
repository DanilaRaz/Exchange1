using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Exchange.Model.Data;

namespace Exchange.Model.Repository
{
    public class Repository<T>: IRepository<T> where T:Base
    {
        public List<T> Values { get; set; }

        public Repository()
        {
            Values = new List<T>();
        }

        public void Add(T model)
        {
            model.Id = Values.Count;
            Values.Add(model);
        }

        public T Get(int id)
        {
            return Values.FirstOrDefault(value => value.Id.Equals(id));
        }

        public List<T> GetAll()
        {
            return Values;
        }

        public void Delete(int id)
        {
            Values.Remove(Get(id));
        }

        public void Update(T model)
        {
            var find = Values.FirstOrDefault(value => value.Id.Equals(model.Id));
            find = model;
        }

        public List<T> FindBy(Func<T, bool> condition)
        {
            return new List<T>(Values.Where(condition));
        }
    }
}