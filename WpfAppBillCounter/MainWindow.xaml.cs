using MaterialDesignThemes.Wpf;
using System.Collections.ObjectModel;
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
using WpfAppBillCounter.Models;
using WpfAppBillCounter.Views;

namespace WpfAppBillCounter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Transaction> Transactions { get; set; }

        public MainWindow()
        {
            InitializeComponent();

            Transactions = new ObservableCollection<Transaction>
            {
                new Transaction
                {
                    TransactionId = 1,
                    FirstName = "John",
                    LastName = "Doe",
                    CountMode = "Automatic",
                    CountType = "Standard",
                    Currency = "USD",
                    TotalCount = 100,
                    Date = DateTime.Now
                },
                // Add more sample transactions as needed
            };

            DataContext = this;

            //AdjustColumnWidths();
        }




        /*private void AdjustColumnWidths()
        {
            foreach (GridViewColumn column in ((GridView)TransactionListView.View).Columns)
            {
                if (column.Header is string header)
                {
                    var headerText = new TextBlock { Text = header };
                    headerText.Measure(new Size(Double.PositiveInfinity, Double.PositiveInfinity));
                    double headerWidth = headerText.DesiredSize.Width + 20; // Add padding for better appearance
                    column.Width = headerWidth;
                }
            }
        }*/

        private void ToggleDrawer_Click(object sender, RoutedEventArgs e)
        {
           //if(DrawerHost.OpenMode is DrawerHostOpenMode.Standard )
                DrawerHost.OpenDrawerCommand.Execute(null, null);
           //DrawerHost.CloseDrawerCommand.Execute(null, null);
        }

        private void Menu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e.AddedItems.Count > 0)
            {
                var selectedItem = (ListBoxItem)e.AddedItems[0];
                string tag = (string)selectedItem.Tag;

               
            }
        }

        private void MenuOpen_Click(object sender, RoutedEventArgs e)
        {

        }

        private void GitHubButton_OnClick(object sender, RoutedEventArgs e)
        {

        }

        private void MenuToggleButton_OnClick(object sender, RoutedEventArgs e)
        {

        }

        private void GridBarraTitulo_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void ButtonFechar_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ListView_Selected(object sender, RoutedEventArgs e)
        {

        }
    }
}