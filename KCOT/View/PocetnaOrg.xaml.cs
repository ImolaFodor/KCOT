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
using System.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using KCOT.View;

namespace KCOT.View
{
    /// <summary>
    /// Interaction logic for PocetnaOrg.xaml
    /// </summary>
    public partial class PocetnaOrg : Window
    {
        private Entities _context = new Entities();
        public PocetnaOrg()
        {
            InitializeComponent();
        }

        
        KCOT.DataSetTableAdapters.DOGADJAJTableAdapter dataSetDOGADJAJTableAdapter = null;
        KCOT.DataSet dataSet = null;

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            dataSet = ((KCOT.DataSet)(this.FindResource("dataSet")));
            
            // Load data into the table DOGADJAJ. You can modify this code as needed.
            dataSetDOGADJAJTableAdapter = new KCOT.DataSetTableAdapters.DOGADJAJTableAdapter();
            dataSetDOGADJAJTableAdapter.Fill(dataSet.DOGADJAJ);
            System.Windows.Data.CollectionViewSource dOGADJAJViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("dOGADJAJViewSource")));
            dOGADJAJViewSource.View.MoveCurrentToFirst();


        }

        private void Button_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            dataSetDOGADJAJTableAdapter.Update(this.dataSet.DOGADJAJ);
            MessageBox.Show("Update successful"); 
        }

       
    }
}
