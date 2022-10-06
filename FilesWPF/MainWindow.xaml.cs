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
using System.IO;
using System.Collections.ObjectModel;

namespace FilesWPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly FileWorker worker;
        public MainWindow()
        {
            InitializeComponent();
            //_showData = new ObservableCollection<ShowData>();
            worker = new FileWorker();
            worker.Filework();
            userLists.ItemsSource = worker.Filework();
            userLists.DisplayMemberPath = "ShortInformation";
            

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var show = userLists.SelectedItem;
            MessageBox.Show((show as User).FullInformation);
            // userLists.DisplayMemberPath = "FullInformation";
        }
    }
}
