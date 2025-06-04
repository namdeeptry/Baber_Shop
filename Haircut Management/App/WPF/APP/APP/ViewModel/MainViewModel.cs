using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using APP.Command;

namespace APP.ViewModel
{
    class MainViewModel : BaseViewModel
    {
        // ViewModel current get views defferent
        private BaseViewModel? _currentView;
        public BaseViewModel? CurrentView
        {
            get => _currentView;
            set
            {
                _currentView = value;
                OnPropertyChanged(nameof(CurrentView));
            }
        }

        // Commands to switch views
        public ICommand ShowHomeViewModel { get; set; }
        public ICommand ShowInvoicesViewCommand { get; set; }
        public ICommand ShowCustomersViewCommand { get; set; }
        public ICommand ShowAppointmentsViewCommand { get; set; }
        public ICommand ShowStaffsViewCommand { get; set; }
        public ICommand ShowServicesViewCommand { get; set; }
        public ICommand ShowReportsViewCommand { get; set; }
        public ICommand ShowSettingsViewCommand { get; set; }
        public ICommand MinimizeWindowCommand { get; }
        public ICommand MaximizeRestoreWindowCommand { get; }
        public ICommand CloseWindowCommand { get; }

        // Constructor
        public MainViewModel()
        {
            // Initialize commands to switch views
            ShowInvoicesViewCommand = new RelayCommand(o => CurrentView = new InvoicesViewModel());
            ShowCustomersViewCommand = new RelayCommand(o => CurrentView = new CustomersViewModel());
            ShowAppointmentsViewCommand = new RelayCommand(o => CurrentView = new AppointmentsViewModel());
            ShowStaffsViewCommand = new RelayCommand(o => CurrentView = new StaffsViewModel());
            ShowServicesViewCommand = new RelayCommand(o => CurrentView = new ServicesViewModel());
            ShowReportsViewCommand = new RelayCommand(o => CurrentView = new ReportsViewModel());
            ShowSettingsViewCommand = new RelayCommand(o => CurrentView = new SettingsViewModel());
            ShowHomeViewModel = new RelayCommand(o => CurrentView = new HomeViewModel());

            // Initialize window control commands
            MinimizeWindowCommand = new RelayCommand(o =>
            {
                if (o is Window window)
                    window.WindowState = WindowState.Minimized;
            });

            MaximizeRestoreWindowCommand = new RelayCommand(o =>
            {
                if (o is Window window)
                {
                    window.WindowState = window.WindowState == WindowState.Maximized
                        ? WindowState.Normal
                        : WindowState.Maximized;
                }
            });

            CloseWindowCommand = new RelayCommand(o =>
            {
                if (o is Window window)
                    window.Close();
            });



            CurrentView = new HomeViewModel(); // Set default view

        }


    }
}

