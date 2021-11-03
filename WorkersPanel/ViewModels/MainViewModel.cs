using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkersPanel.ViewModels
{
    public class MainViewModel
    {
        public WorkerContext WorkerContext { get; set; } = new WorkerContext();
        public Worker SelectedWorker { get; set; }
    }
}
