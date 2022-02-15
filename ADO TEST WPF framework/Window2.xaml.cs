using ADO_TEST_WPF_framework.classiccarDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
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
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        classiccarDataSet ds;
        DataView dv;
        productlinesTableAdapter productlinesTableAdapter = new productlinesTableAdapter();
        productsTableAdapter productsTableAdapter = new productsTableAdapter();
        public Window2(classiccarDataSet dss)
        {
            ds = dss;
            dv = new DataView(ds.products);
            InitializeComponent();
        }
        protected override void OnActivated(EventArgs e)
        {
            productlinesTableAdapter.Fill(ds.productlines);
            cmb.ItemsSource = ds.productlines;
            cmb.SelectedValuePath = "productLine";
            cmb.DisplayMemberPath = "productLine";
            productsTableAdapter.Fill(ds.products);
            dgv.ItemsSource = dv;
           
            
            base.OnActivated(e);
        }
    }
}
