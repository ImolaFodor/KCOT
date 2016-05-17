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
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using KCOT.View;

namespace KCOT
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Entities _context = new Entities();
        
        public MainWindow()
        {
            InitializeComponent();
            
        }

        Window1 welcome_zap = new Window1();
        PocetnaOrg welcome_org = new PocetnaOrg();

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            if (textBoxEmail.Text.Length == 0)
            {
                errormessage.Text = "Unesite korisničko ime.";
                textBoxEmail.Focus();
            }
            else
            {
                
                    string korime = textBoxEmail.Text;
                    string password = passwordBox1.Password;
                    var zaposleni = _context.ZAPs.ToList();

                    foreach (var zaposlen in zaposleni)
                    {
                        int i = Convert.ToInt32(zaposlen.TIP_ZAP_IDTIPZAP);
                        if (zaposlen.KORISNICKO_IME == korime && zaposlen.LOZINKA == password && i == 1)
                        {

                            welcome_org.TextBlockName.Text = zaposlen.IME;//Sending value from one form to another form.
                            welcome_org.Show();
                            Close();
                        }
                        else if (zaposlen.KORISNICKO_IME == korime && zaposlen.LOZINKA == password && i == 2)
                        {
                            welcome_zap.TextBlockName.Text = zaposlen.IME;//Sending value from one form to another form.
                            welcome_zap.Show();
                            Close();
                        }
                        else
                        {
                            errormessage.Text = "Izvinite! Unesite validno korisnicko ime i lozinku";
                        }

                    }
                

            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
                KCOT.DataSet dataSet = ((KCOT.DataSet)(this.FindResource("dataSet")));
                // Load data into the table ZAP. You can modify this code as needed.
                KCOT.DataSetTableAdapters.ZAPTableAdapter dataSetZAPTableAdapter = new KCOT.DataSetTableAdapters.ZAPTableAdapter();
                dataSetZAPTableAdapter.Fill(dataSet.ZAP);
                System.Windows.Data.CollectionViewSource zAPViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("zAPViewSource")));
                zAPViewSource.View.MoveCurrentToFirst();
                // Load data into the table TIP_ZAP. You can modify this code as needed.
                KCOT.DataSetTableAdapters.TIP_ZAPTableAdapter dataSetTIP_ZAPTableAdapter = new KCOT.DataSetTableAdapters.TIP_ZAPTableAdapter();
                dataSetTIP_ZAPTableAdapter.Fill(dataSet.TIP_ZAP);
                System.Windows.Data.CollectionViewSource tIP_ZAPViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("tIP_ZAPViewSource")));
                tIP_ZAPViewSource.View.MoveCurrentToFirst();

                // Load is an extension method on IQueryable,  
                // defined in the System.Data.Entity namespace. 
                // This method enumerates the results of the query,  
                // similar to ToList but without creating a list. 
                // When used with Linq to Entities this method  
                // creates entity objects and adds them to the context. 
                _context.TIP_ZAP.Load();
                _context.ZAPs.Load();
                // After the data is loaded call the DbSet<T>.Local property  
                // to use the DbSet<T> as a binding source. 
                tIP_ZAPViewSource.Source = _context.TIP_ZAP.Local;
                zAPViewSource.Source = _context.ZAPs.Local;
            }

        
    }
}
