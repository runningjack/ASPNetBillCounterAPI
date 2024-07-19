using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using WpfAppBillCounter.Models;
using WpfAppBillCounter.Views;
using MenuItem = WpfAppBillCounter.Models.MenuItem;

namespace WpfAppBillCounter.ViewModels
{
    public class MainWindowViewModel
    {
        public ICommand OpenAddCustomerCommand { get; }

        public ObservableCollection<MenuItem> MenuItems { get; }

        private MenuItem _selectedMenuItem;
        public MenuItem SelectedMenuItem
        {
            get => _selectedMenuItem;
            set
            {
                if (_selectedMenuItem != value)
                {
                    _selectedMenuItem = value;
                    OnPropertyChanged(nameof(SelectedMenuItem));
                    if (_selectedMenuItem != null)
                    {
                        _selectedMenuItem.Command?.Execute(null);
                    }
                }
            }
        }

        public MainWindowViewModel()
        {
            OpenAddCustomerCommand = new RelayCommand(OpenAddCustomer);
            MenuItems = new ObservableCollection<MenuItem>
        {
            new MenuItem { Icon = "MonitorDashboard", Text = "Dashboard" },
            new MenuItem { Icon = "Money100", Text = "Transaction" },
            new MenuItem { Icon = "CustomerService", Text = "Customer", Command = OpenAddCustomerCommand },
            new MenuItem { Icon = "UserAccessControl", Text = "Roles" },
            new MenuItem { Icon = "Settings", Text = "Settings" }
        };
        }

        private void OpenAddCustomer()
        {
            var customerView = new AddNewCustomerView
            {
                DataContext = new AddNewCustomerViewModel()
            };
            customerView.ShowDialog();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
