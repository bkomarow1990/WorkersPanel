using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using WorkersPanel.ViewModels;

namespace WorkersPanel.Windows
{
    /// <summary>
    /// Interaction logic for EditRegisterWindow.xaml
    /// </summary>
    public partial class EditRegisterWindow : Window
    {
        private bool isEdit = false;
        MainViewModel mainViewModel = null;
        string imagePath = null;
        public EditRegisterWindow(MainViewModel mainViewModel, bool isEdit)
        {
            InitializeComponent();
            this.isEdit = isEdit;
            this.mainViewModel = mainViewModel;
            if (isEdit)
            {
                try
                {
                    nameTxtBox.Text = mainViewModel.SelectedWorker.Name;
                    surnameTxtBox.Text = mainViewModel.SelectedWorker.Surname;
                    ageTxtBox.Text = mainViewModel.SelectedWorker.Age.ToString();
                    isActiveCheckBox.IsChecked = mainViewModel.SelectedWorker.IsActive;
                    imagePath = mainViewModel.SelectedWorker.ImagePath;
                    pictureImg.Source = BitmapFrame.Create(new Uri(imagePath, UriKind.Relative));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void cancelBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void okBtn_Click(object sender, RoutedEventArgs e)
        {
            if (imagePath == null)
            {
                MessageBox.Show("Please, select an image");
                return;
            }
            if (isActiveCheckBox.IsChecked == null)
            {
                MessageBox.Show("Please, select IsActive property");
                return;
            }
            byte age = 1;
            try
            {
                age = Byte.Parse(ageTxtBox.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (isEdit)
            {
                mainViewModel.WorkerContext.Update(mainViewModel.SelectedWorker, new Worker { Name = nameTxtBox.Text, Surname = surnameTxtBox.Text, Age = age, ImagePath = imagePath, IsActive = isActiveCheckBox.IsChecked.HasValue ? isActiveCheckBox.IsChecked.Value : false });
                return;
            }
            mainViewModel.WorkerContext.Create(new Worker { Name = nameTxtBox.Text, Surname = surnameTxtBox.Text, Age = age, ImagePath = imagePath, IsActive = isActiveCheckBox.IsChecked.HasValue ? isActiveCheckBox.IsChecked.Value : false });
        }

        private void choosePictureBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                OpenFileDialog OpenFile = new OpenFileDialog();
                OpenFile.Multiselect = true;
                OpenFile.Title = "Select Picture(s)";
                OpenFile.Filter = "ALL supported Graphics| *.jpeg; *.jpg;*.png;";
                if (OpenFile.ShowDialog() == true)
                {
                    foreach (String file in OpenFile.FileNames)
                    {
                        imagePath = file;
                        pictureImg.Source = BitmapFrame.Create(new Uri(imagePath, UriKind.Relative));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
