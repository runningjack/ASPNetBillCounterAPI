using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WpfAppBillCounter.Models;

namespace WpfAppBillCounter.ViewModels
{
    public class AddNewCustomerViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        private string _firstName;
        private string _lastName;
        private string _email;

        public string FirstName
        {
            get => _firstName;
            set
            {
                _firstName = value;
                OnPropertyChanged(nameof(FirstName));
            }
        }

        public string LastName
        {
            get => _lastName;
            set
            {
                _lastName = value;
                OnPropertyChanged(nameof(LastName));
            }
        }

        public string Email
        {
            get => _email;
            set
            {
                _email = value;
                OnPropertyChanged(nameof(Email));
            }
        }

        public ICommand AddCustomerCommand { get; }
        public ICommand CancelCommand { get; }

        public AddNewCustomerViewModel()
        {
            AddCustomerCommand = new RelayCommand(AddCustomer);
            CancelCommand = new RelayCommand(Cancel);
        }

        private void AddCustomer()
        {
            // Implement the logic to add a new customer.
            // For example, save the customer data to a database or a collection.
            Console.WriteLine($"Customer added: {FirstName} {LastName} ({Email})");
        }

        private void Cancel()
        {
            // Implement the logic to cancel the operation.
            // For example, clear the fields or close the window.
            Console.WriteLine("Operation canceled");
        }

        //public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
