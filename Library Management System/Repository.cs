using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System
{
    internal class Repository<T> : IRepository<T>
    {
        private List<T> items = new List<T>();

        public void AddItem(T item)
        {
            items.Add(item);
        }

        public void RemoveItem(T item) => items.Remove(item);

        public List<T> RetrieveAll() => new List<T>(items);

        public T FindItem(Predicate<T> item) => items.Find(item); //
    }
}
