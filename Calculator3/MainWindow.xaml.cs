using System.Windows;

namespace Calculator3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// private int _startCost;

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            MainWindow mainWindow = new MainWindow();
            DataContext = mainWindow;
            InitializeComponent();

        }
        private string _startCost { get; set; } = "";
        double StartCost;

        private string _handlingCost { get; set; } = "";
        double HandlingCost;

        private string _price { get; set; } = "";
        double Price;

        string ErrorMessage = "";




        public void Button_Click(object sender, RoutedEventArgs e)
        {

            if (!(double.TryParse(_startCost, out StartCost) && StartCost <= 0))
            {
                ErrorMessage += "Zadané náklady musí být číslo, větší nebo rovno nule\n";
            }
            if (!(double.TryParse(_handlingCost, out HandlingCost) && StartCost <= 0))
            {
                ErrorMessage += "Zadané náklady na opravu musí být číslo, větší nebo rovno nule\n";
            }
            if (!(double.TryParse(_price, out Price) && StartCost <= 0))
            {
                ErrorMessage += "Zadaná hodnota požadovaného výdělku musí být číslo, větší nebo rovno nule\n";
            }
            if (ErrorMessage != "")
            {
                MessageBox.Show(ErrorMessage);
                ErrorMessage = "";
            }
            else MessageBox.Show($"Cena bez výdělku je: {StartCost + HandlingCost }\nCena s výdělkem je: {StartCost + HandlingCost + Price }");
        }
    }
}
