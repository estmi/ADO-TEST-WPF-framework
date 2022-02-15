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

namespace ADO_TEST_WPF_framework
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            ADO_TEST_WPF_framework.classiccarDataSet classiccarDataSet = ((ADO_TEST_WPF_framework.classiccarDataSet)(this.FindResource("classiccarDataSet")));
            // Load data into the table orders. You can modify this code as needed.
            ADO_TEST_WPF_framework.classiccarDataSetTableAdapters.ordersTableAdapter classiccarDataSetordersTableAdapter = new ADO_TEST_WPF_framework.classiccarDataSetTableAdapters.ordersTableAdapter();
            classiccarDataSetordersTableAdapter.Fill(classiccarDataSet.orders);
            System.Windows.Data.CollectionViewSource ordersViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("ordersViewSource")));
            ordersViewSource.View.MoveCurrentToFirst();
            // Load data into the table orderdetails. You can modify this code as needed.
            ADO_TEST_WPF_framework.classiccarDataSetTableAdapters.orderdetailsTableAdapter classiccarDataSetorderdetailsTableAdapter = new ADO_TEST_WPF_framework.classiccarDataSetTableAdapters.orderdetailsTableAdapter();
            classiccarDataSetorderdetailsTableAdapter.Fill(classiccarDataSet.orderdetails);
            System.Windows.Data.CollectionViewSource ordersorderdetailsViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("ordersorderdetailsViewSource")));
            ordersorderdetailsViewSource.View.MoveCurrentToFirst();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window1 wnd = new Window1((classiccarDataSet)FindResource("classiccarDataSet"));
            wnd.Show();
        }
    }
}
