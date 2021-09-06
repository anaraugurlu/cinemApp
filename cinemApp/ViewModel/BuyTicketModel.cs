using cinemApp.Command;
using cinemApp.Model;
using cinemApp.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace cinemApp.ViewModel
{
    class BuyTicketModel:Base
    {
      public  BuyTicketUc Buy { get; set; }
        public RelayCommand ButtonClick { get; set; }
        public RelayCommand buy { get; set; }
        public BuyTicketModel()
        {
            buy = new RelayCommand ((t) => {

                MessageBox.Show("The ticket was purchased successfully");
             
            
            });
            ButtonClick = new RelayCommand((b) => {
                Buy.buyy.Visibility = Visibility.Visible;
                Buy.buy.Visibility = Visibility.Visible;
                Ticket ticket = new Ticket();
                MessageBox.Show("Click buy");
            });
        }
    }
}
