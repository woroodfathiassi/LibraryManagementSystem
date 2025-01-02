using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System
{
    internal interface IRepository<T>
    {
        public void AddItem(T item);
        public void RemoveItem(T item);

        public List<T> RetrieveAll();

        public T FindItem(Predicate<T> match);
    }
}
