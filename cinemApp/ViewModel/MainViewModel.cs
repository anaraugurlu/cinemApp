using cinemApp.Command;
using cinemApp.Model;
using cinemApp.Repostory;
using cinemApp.View;
using System.Collections.ObjectModel;
using System.Windows;

namespace cinemApp.ViewModel
{
    class MainViewModel : Base
    {
      
       public MainWindow MainWindow { get; set; }

        public RelayCommand  AdminButtonClick { get; set; }
        public RelayCommand UserButtonClick { get; set; }
        public SignUc sign { get; set; } 
        public SignUcModel signuc { get; set; }
        public RelayCommand CloseAdminButtonClick { get; set; }
        public RelayCommand CloseWindowButtonClick { get; set; }
        public RelayCommand CloseUserButtonClick { get; set; }
        public MainViewModel()
        {
            CloseWindowButtonClick = new RelayCommand((clb) =>

              {
                  MainWindow.closewindow.Visibility = Visibility.Visible;
                  MainWindow.window.Close();
              });
            CloseUserButtonClick = new RelayCommand((clu) =>
             {
                 MainWindow.closeuser.Visibility = Visibility.Hidden ;
                 MainWindow.signucus.Visibility = Visibility.Hidden ;
                 MainWindow.user.Visibility = Visibility.Visible ;
                 MainWindow.admin.Visibility = Visibility.Visible ;
             });
            CloseAdminButtonClick = new RelayCommand((clu) =>
            {
                MainWindow.closeadmin.Visibility = Visibility.Hidden ;
                MainWindow.signucus.Visibility = Visibility.Hidden;
                MainWindow.user.Visibility = Visibility.Visible;
                MainWindow.admin.Visibility = Visibility.Visible;
            });
            UserButtonClick = new RelayCommand((ub) =>
             {
                 MainWindow.signucus.Visibility = Visibility.Visible;
                 MainWindow.user.Visibility = Visibility.Collapsed;
                 MainWindow.admin.Visibility = Visibility.Collapsed;
                 MainWindow.closeuser.Visibility = Visibility.Visible;
                 MainWindow.closewindow.Visibility = Visibility.Hidden ;


             });
            AdminButtonClick = new RelayCommand((ac) =>
             {                 MainWindow.signadmin.Visibility = Visibility.Visible;
                 MainWindow.user.Visibility = Visibility.Collapsed;
                 MainWindow.admin.Visibility = Visibility.Collapsed;
                 MainWindow.closewindow.Visibility = Visibility.Hidden ;

                 MainWindow.closeadmin.Visibility = Visibility.Visible;
             });
        }

    }
}
