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
using System.Windows.Navigation;
using System.Windows.Shapes;
using WorkersPanel.ViewModels;
using WorkersPanel.Windows;

namespace WorkersPanel
{
    public partial class MainWindow : Window
    {
        private MainViewModel mainViewModel = new MainViewModel();
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = mainViewModel;
        }

        private void cleanWorkersBtn_Click(object sender, RoutedEventArgs e)
        {
            mainViewModel.WorkerContext.Clear();
        }

        private void deleteWorkerBtn_Click(object sender, RoutedEventArgs e)
        {
            if (workersListBox.SelectedItem == null)
            {
                MessageBox.Show("Please select worker!");
                return;
            }
            mainViewModel.WorkerContext.Delete(workersListBox.SelectedItem as Worker);
        }

        private void addNewWorkerBtn_Click(object sender, RoutedEventArgs e)
        {
            if (mainViewModel.SelectedWorker == null)
            {
                MessageBox.Show("Please, select a worker");
                return;
            }
            EditRegisterWindow editRegisterWindow = new EditRegisterWindow(mainViewModel, false);
            editRegisterWindow.ShowDialog();
        }

        private void editWorkerBtn_Click(object sender, RoutedEventArgs e)
        {
            if (mainViewModel.SelectedWorker == null)
            {
                MessageBox.Show("Please, select a worker");
                return;
            }
            EditRegisterWindow editRegisterWindow = new EditRegisterWindow(mainViewModel, true);
            editRegisterWindow.ShowDialog();
        }
    }
}
