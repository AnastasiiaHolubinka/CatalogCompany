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
    /// Interaction logic for EditPage.xaml
    /// </summary>
    public partial class EditPage : Page
    {
        private Frame Frame;
        private CompanyViewModel CompanyVM;
        private Company Company;
        public EditPage()
        {
            InitializeComponent();
        }

        public EditPage(Frame frame, CompanyViewModel companyVM, Company company)
        {
            InitializeComponent();
            this.Frame = frame;
            this.CompanyVM = companyVM;
            this.Company = company;
            this.CompanyName_TBox.Text = company.CompanyName;
            this.CompanyAddress_TBox.Text = company.CompanyAddress;
            this.FoundationYear_TBox.Text = company.FoundationYear.ToString();
            this.AnnualRevenue_TBox.Text = company.AnnualRevenue.ToString();
            this.BusinessType_TBox.Text = company.BusinessType;
            this.UpdateBtn.IsEnabled = false;           
        }

        private void UpdateBtn_Click(object sender, RoutedEventArgs e)
        {
            Company tempCompany = new Company();
            tempCompany.Id = Company.Id;
            tempCompany.CompanyName = CompanyName_TBox.Text;
            tempCompany.CompanyAddress = CompanyAddress_TBox.Text;
            tempCompany.FoundationYear = int.Parse(FoundationYear_TBox.Text.ToString());
            tempCompany.AnnualRevenue = int.Parse(AnnualRevenue_TBox.Text.ToString());
            tempCompany.BusinessType = BusinessType_TBox.Text;
            CompanyVM.UpdateRecordInRepo(tempCompany);
            MessageBox.Show("The record is updated", "Update");
        }

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.NavigationService.GoBack();
        }

        private void LostFocus_TextBox(object sender, RoutedEventArgs e)
        {
            if (!(this.Company.CompanyName.Equals(this.CompanyName_TBox.Text)
                && this.Company.CompanyAddress.Equals(this.CompanyAddress_TBox.Text)
                && this.Company.FoundationYear.Equals(int.Parse(this.FoundationYear_TBox.Text))
                && this.Company.AnnualRevenue.Equals(int.Parse(this.AnnualRevenue_TBox.Text))
                && this.Company.BusinessType.Equals(this.BusinessType_TBox.Text)))
            {
                UpdateBtn.IsEnabled = true;
            }
        }
    }
}
