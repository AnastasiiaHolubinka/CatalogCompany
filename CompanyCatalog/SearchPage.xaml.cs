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

namespace CompanyCatalog
{
    /// <summary>
    /// Interaction logic for SearchPage.xaml
    /// </summary>
    public partial class SearchPage : Page
    {
        CompanyViewModel CompanyVM;
        Frame Frame;
        public SearchPage()
        {
            InitializeComponent();
        }

        public SearchPage(Frame frame, CompanyViewModel companyVM)
        {
            InitializeComponent();
            this.Frame = frame;
            this.CompanyVM = companyVM;

            this.Loaded += SearchPage_Loaded;
            EditBtn.IsEnabled = false;
            DelBtn.IsEnabled = false;
        }

        private void SearchPage_Loaded(object sender, RoutedEventArgs e)
        {
            searchBox.Focusable = true;
            Keyboard.Focus(searchBox);
        }

        private void Search_Click(object sender, RoutedEventArgs e)
        {
            if (searchBox.Text == "")
            {
                WarningSearchLabel.Visibility = Visibility.Visible;
                return;
            }

            WarningSearchLabel.Visibility = Visibility.Hidden;
            gridTable.DataContext = CompanyVM.searchRepo(searchBox.Text);
            gridTable.Columns[0].Visibility = Visibility.Hidden;        

            if (gridTable.SelectedCells.Count == 0)         
            {
                EditBtn.IsEnabled = false;
                DelBtn.IsEnabled = false;
            }
            else
            {
                EditBtn.IsEnabled = true;
                DelBtn.IsEnabled = true;
            }
        }

        private void SearchBox_GotFocus(object sender, RoutedEventArgs e)
        {
            searchBox.Text = "";
            searchBox.FontStretch = FontStretches.Normal;
            searchBox.FontStyle = FontStyles.Normal;
            searchBox.Foreground = Brushes.Black;
        }

        private void DelBtn_Click(object sender, RoutedEventArgs e)
        {
            Company company = (Company)gridTable.SelectedItem;
            CompanyVM.DeleteRecordFromRepo(company.Id);
            gridTable.DataContext = CompanyVM.searchRepo(searchBox.Text);    
            gridTable.Columns[0].Visibility = Visibility.Hidden;
        }


        private void EditBtn_Click(object sender, RoutedEventArgs e)
        {
            Company tempCompany = (Company)gridTable.SelectedItem;
            Frame.Navigate(new EditPage(Frame, CompanyVM, tempCompany));
        }

        private void gridTable_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (gridTable.SelectedCells.Count == 0)
            {
                EditBtn.IsEnabled = false;
                DelBtn.IsEnabled = false;
                return;
            }
            EditBtn.IsEnabled = true;
            DelBtn.IsEnabled = true;
        }

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(new HomePage(Frame, CompanyVM));
        }
    }
}
