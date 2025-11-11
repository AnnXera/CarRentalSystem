using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalSystem.Code
{
    internal interface IModalFactory<T>
    {
        void Add(T entity);
        void Edit(T entity);
        List<T> ViewAll();
    }
}
