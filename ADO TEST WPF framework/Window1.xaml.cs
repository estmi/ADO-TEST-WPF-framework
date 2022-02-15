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

namespace ADO_TEST_WPF_framework
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        classiccarDataSet ds;
        classiccarDataSetTableAdapters.employeesTableAdapter tableAdapter = new classiccarDataSetTableAdapters.employeesTableAdapter();
        public Window1(classiccarDataSet classiccarDataSet)
        {
            InitializeComponent();
            ds = classiccarDataSet;
        }
        protected override void OnActivated(EventArgs e)
        {
            tableAdapter.FillByOffice(ds.employees);
            dgv.ItemsSource = ds.employees;
            base.OnActivated(e);
        }
    }
}
