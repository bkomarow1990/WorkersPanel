using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkersPanel.Interfaces;

namespace WorkersPanel.ViewModels
{
    public class WorkerContext : IMaintanable<Worker>
    {
        public ObservableCollection<Worker> WorkerList { get; set; } = new ObservableCollection<Worker>
        { new Worker{ ImagePath=$"{Directory.GetCurrentDirectory()}/Resources/img_504781.png", Name="Amy", Surname="Carter",Age=23,IsActive=false},
          new Worker{ ImagePath=$"{Directory.GetCurrentDirectory()}/Resources/img_504768.png", Name="Craig", Surname="Joy", Age=24,IsActive=false},
          new Worker{ ImagePath=$"{Directory.GetCurrentDirectory()}/Resources/img_504781.png", Name="Mary", Surname="Crawford",Age=30, IsActive=false},
          new Worker{ ImagePath=$"{Directory.GetCurrentDirectory()}/Resources/img_504768.png", Name="Jamie", Surname="Cole",Age=29, IsActive=false}
        };
        public void Create(Worker obj)
        {
            if (obj == null)
            {
                throw new ApplicationException("Object is null");
            }
            WorkerList.Add(obj);
        }

        public void Delete(Worker obj)
        {
            WorkerList.Remove(obj);
        }

        public Worker Retrieve(string key)
        {
            return WorkerList.Where((el) => el.Name == key).First();
        }

        public void Update(Worker obj, Worker obj2)
        {
            obj.Name = obj2.Name;
            obj.Surname = obj2.Surname;
            obj.Age = obj2.Age;
            obj.IsActive = obj2.IsActive;
            obj.ImagePath = obj2.ImagePath;
        }
        public void Clear()
        {
            WorkerList.Clear();
        }
    }
}
