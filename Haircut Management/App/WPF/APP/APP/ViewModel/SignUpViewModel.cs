using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using APP.Command;
using APP.View;

namespace APP.ViewModel
{
    class SingUpViewModel :BaseViewModel
    {


        // command button for login view changed signup view
        #region command for button  
        public ICommand LoginChanged { get; set; }
        public ICommand CloseWindow { get; set; }
        #endregion


        // constructor
        public SingUpViewModel() 
        {
            LoginChanged = new RelayCommand(LoginChangedExecute, LoginChangedCanExecute);
            CloseWindow = new RelayCommand(CloseExcute, CloseCanExecute);
        }

        

        // envent button 
        #region Login changed command
        private bool LoginChangedCanExecute(object arg)
        {
            return true;
        }

        private void LoginChangedExecute(object obj)
        {
           LoginView loginView = new LoginView();
           loginView.Show();
           //App.Current.MainWindow.Close();
        }
        #endregion

        // button  command close
        #region Login changed command
        private bool CloseCanExecute(object arg)
        {
           return true;
        }

        private void CloseExcute(object obj)
        {
            App.Current.MainWindow.Close();
        }
        #endregion


    }
}
