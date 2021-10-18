using System.Windows;
using System.Windows.Controls;


namespace CompanyCatalog
{
    /// <summary>
    /// Interaction logic for AddPage.xaml
    /// </summary>
    public partial class AddPage : Page
    {
        CompanyViewModel CompanyVM;
        Frame Frame;
        public AddPage()
        {
            InitializeComponent();
        }

        public AddPage(Frame frame1, CompanyViewModel companyVM)
        {
            InitializeComponent();
            this.Frame = frame1;
            this.CompanyVM = companyVM;
        }

        private void CompanyName_GotFocus(object sender, RoutedEventArgs e)
        {
            CompanyName_TBox.Text = "";
            CompanyName_TBox.FontStyle = FontStyles.Normal;
            CompanyName_TBox.FontWeight = FontWeights.Normal;
        }

        private void CompanyAddress_GotFocus(object sender, RoutedEventArgs e)
        {
            CompanyAddress_TBox.Text = "";
            CompanyAddress_TBox.FontStyle = FontStyles.Normal;
            CompanyAddress_TBox.FontWeight = FontWeights.Normal;
        }

        private void FoundationYear_GotFocus(object sender, RoutedEventArgs e)
        {
            FoundationYear_TBox.Text = "";
            FoundationYear_TBox.FontStyle = FontStyles.Normal;
            FoundationYear_TBox.FontWeight = FontWeights.Normal;
        }
        private void AnnualRevenue_GotFocus(object sender, RoutedEventArgs e)
        {
            AnnualRevenue_TBox.Text = "";
            AnnualRevenue_TBox.FontStyle = FontStyles.Normal;
            AnnualRevenue_TBox.FontWeight = FontWeights.Normal;
        }
        private void BusinessType_GotFocus(object sender, RoutedEventArgs e)
        {
            BusinessType_TBox.FontStyle = FontStyles.Normal;
            BusinessType_TBox.FontWeight = FontWeights.Normal;
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            Company company = new Company();
            company.CompanyName = CompanyName_TBox.Text;
            company.CompanyAddress = CompanyAddress_TBox.Text;
            company.FoundationYear = int.Parse(FoundationYear_TBox.Text);
            company.AnnualRevenue = int.Parse(AnnualRevenue_TBox.Text);
            company.BusinessType = BusinessType_TBox.Text;
            
            CompanyVM.AddRecordToRepo(company);
            MessageBox.Show("The record is add");
        }

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.NavigationService.GoBack();
        }

        private void BusinessType_TBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
