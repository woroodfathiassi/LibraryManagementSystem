using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System
{
    internal interface IRepository<T>
    {
        void AddItem(T item);
        void RemoveItem(T item);
        List<T> RetrieveAll();
        T FindItem(Predicate<T> match);
    }
}
