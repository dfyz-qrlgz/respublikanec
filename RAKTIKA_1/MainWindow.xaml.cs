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
using RAKTIKA_1.libraryDataSetTableAdapters;

namespace RAKTIKA_1
{
    public partial class MainWindow : Window
    {
        authorsTableAdapter author = new authorsTableAdapter();
        public MainWindow()
        {
            InitializeComponent();
            datagrid.ItemsSource = author.GetData();
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            second window = new second();
            window.ShowDialog();
        }
    }
}
