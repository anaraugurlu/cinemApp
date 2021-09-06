using cinemApp.Command;
using cinemApp.Model;
using cinemApp.Repostory;
using cinemApp.View;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace cinemApp.ViewModel
{
    class SignAdminModel:Base 
    {
        public RelayCommand SelectedItemChangedCommand { get; set; }

        public FakeRepostory UserRepository { get; set; }
        public FakeRepostory AdminRepository { get; set; }
        public RelayCommand SignInButtonClick { get; set; }
        public RelayCommand SignUpButtonClick { get; set; }
        public SignAdmin sign { get; set; }
        public MainWindow MainWindow { get; set; }
        public ObservableCollection<User> Users { get; set; }
        public ObservableCollection<Admin> Admins { get; set; } 
        private User user;
        private Admin admin;

        public User User
        {
            get { return user; }
            set { user = value; OnPropertyChanged(); }
        }
        public Admin Admin
        {
            get { return admin; }
            set { admin = value; OnPropertyChanged(); }
        }

        public SignAdminModel()
        {
            UserRepository = new FakeRepostory();
            AdminRepository = new FakeRepostory();
            Users = new ObservableCollection<User>(UserRepository.GetAllUsers());
            Admins = new ObservableCollection<Admin>(AdminRepository.GetAllAdmins());
            SelectedItemChangedCommand = new RelayCommand((SelectedItem) =>
            {



                var item2 = SelectedItem as User;

                User = item2;
                var item = SelectedItem as Admin;

                Admin = item;

            });
            SignUpButtonClick = new RelayCommand((su) =>
            {
                Admin admin = new Admin()
                {
                    Age = int.Parse(sign.age.Text),
                    UserName = sign.name2.Text,

                    Password = sign.passw2.Text,
                    Email = sign.email.Text,
                };
                Admins.Add(admin);
                AdminRepository.GetAllAdmins().Add(admin);
                MessageBox.Show("new admin was added");
            });
               
            



            
            SignInButtonClick = new RelayCommand((si) =>
            {
              
                foreach (var item in Admins)
                {
                    if (sign.name.Text == item.UserName && sign.passw.Text == item.Password||sign.name .Text ==sign.name2 .Text &&sign.passw .Text ==sign.passw2 .Text )
                    {
                       

                        sign.singin.Visibility = Visibility.Collapsed;
                        sign.signu .Visibility = Visibility.Collapsed;
                        sign.admin.Visibility = Visibility.Visible;
                        return;
                     
                    }
                    else
                    {
                        MessageBox.Show("this user not aviable please try again");
                        return;
                    }



                }
            });

        }
    }
}
