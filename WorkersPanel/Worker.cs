using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WorkersPanel
{
    public class Worker : INotifyPropertyChanged
    {
        string name;
        string surname;
        byte age;
        bool isActive;
        string imagePath;

        public string Name { get=> name ; set { name = value; NotifyPropertyChanged(); } }
        public string Surname { get => surname; set { surname = value; NotifyPropertyChanged(); } }
        public byte Age { get => age; set { age = value; NotifyPropertyChanged(); } }
        public bool IsActive { get => isActive; set { isActive = value; NotifyPropertyChanged(); } }
        public string ImagePath { get => imagePath; set { imagePath = value; NotifyPropertyChanged(); } }
        public Worker()
        {

        }
        private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
