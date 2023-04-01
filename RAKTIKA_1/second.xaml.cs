using RAKTIKA_1.libraryDataSetTableAdapters;
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

namespace RAKTIKA_1
{
    public partial class second : Window
    {
        booksTableAdapter books = new booksTableAdapter();
        public second()
        {
            InitializeComponent();
            datagrid2.ItemsSource = books.GetData();
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
