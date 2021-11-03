using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkersPanel.Interfaces
{
    public interface IMaintanable<T>
    {
        void Create(T obj);
        T Retrieve(string key);
        void Update(T obj, T obj2);
        void Delete(T obj);
    }
}
