using System.Windows;
using System.Windows.Controls;


namespace CompanyCatalog
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public CompanyViewModel CompanyVM { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            CompanyVM = new CompanyViewModel();
            Frame.Navigate(new HomePage(Frame, CompanyVM));
        }
    }
}
