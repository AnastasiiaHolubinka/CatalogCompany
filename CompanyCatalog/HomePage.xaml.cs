using System.Windows;
using System.Windows.Controls;


namespace CompanyCatalog
{
    /// <summary>
    /// Interaction logic for HomePage.xaml
    /// </summary>
    public partial class HomePage : Page
    {
        private Frame Frame;
        CompanyViewModel CompanyVM;
        public HomePage()
        {
            InitializeComponent();
        }

        public HomePage(Frame frame1, CompanyViewModel companyVM)
        {
            InitializeComponent();
            this.Frame = frame1;
            this.CompanyVM = companyVM;
        }

        private void SearchBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(new SearchPage(this.Frame, this.CompanyVM));
        }

        private void addBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(new AddPage(this.Frame, this.CompanyVM));

        }
    }
}
