using cinemApp.Command;
using cinemApp.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
namespace cinemApp.ViewModel
{
    class UserPartUcModel:Base
    {
        public UserPartUc UserUc{get;set;}
        public RelayCommand CloseShowButtonClick{get;set;}
        public RelayCommand CloseBuyButtonClick{get;set;}
        public RelayCommand ShowMoviesButtonClick{get;set;}
        public RelayCommand BuyTicketButtonClick{get;set;}
        public UserPartUcModel()
        {
            BuyTicketButtonClick = new RelayCommand((b) => {
                UserUc.buy.Visibility = Visibility.Visible;
                UserUc.s.Visibility = Visibility.Hidden;
                UserUc.b.Visibility = Visibility.Hidden;
                UserUc.image.Visibility = Visibility.Hidden;
                UserUc.label.Visibility = Visibility.Hidden;
                UserUc.closebuy.Visibility = Visibility.Visible;
            });
            CloseShowButtonClick = new RelayCommand((c) =>
              {
                  UserUc.show.Visibility = Visibility.Hidden;
                  UserUc.s.Visibility = Visibility.Visible;
                  UserUc.b.Visibility = Visibility.Visible;
                  UserUc.image.Visibility = Visibility.Visible ;
                  UserUc.label.Visibility = Visibility.Visible  ;
                  UserUc.closeshow.Visibility = Visibility.Hidden;
                  UserUc.closebuy.Visibility = Visibility.Visible;

              });
            CloseBuyButtonClick = new RelayCommand((c) =>
            {
                UserUc.buy.Visibility = Visibility.Hidden;
                UserUc.s.Visibility = Visibility.Visible;
                UserUc.b.Visibility = Visibility.Visible;
                UserUc.image.Visibility = Visibility.Visible;
                UserUc.label.Visibility = Visibility.Visible;
                UserUc.closebuy.Visibility = Visibility.Hidden;
            });
            ShowMoviesButtonClick = new RelayCommand((sh) => {
                UserUc.s.Visibility = Visibility.Hidden; 
                UserUc.b.Visibility = Visibility.Hidden;
                UserUc.show.Visibility = Visibility.Visible;
                UserUc.image.Visibility = Visibility.Hidden;
                UserUc.label.Visibility = Visibility.Hidden;
                UserUc.closeshow.Visibility = Visibility.Visible;
            });
        }
    }
}
