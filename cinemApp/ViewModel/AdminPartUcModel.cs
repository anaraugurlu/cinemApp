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
using System.Windows.Media;

namespace cinemApp.ViewModel
{
    class AdminPartUcModel:Base
    {
        public AdminPartUc AdminUc { get; set; }
        public RemoveMovieUC RemoveMovieUC { get; set; }
        public FakeRepostory MoviesRepository { get; set; }
        public ObservableCollection<Movie> Movies { get; set; }
        public RelayCommand CloseAddButtonClick { get; set; }
        public RelayCommand CloseRemoveButtonClick { get; set; }
        public RelayCommand CloseButtonClick { get; set; }
        public RelayCommand AddMovieButtonClick { get; set; }
        public RelayCommand  RemoveMovieButtonClick { get; set; }
        public AdminPartUcModel()
        {
            
            MoviesRepository = new FakeRepostory();
            Movies = new ObservableCollection<Movie>(MoviesRepository.GetMovies());
            CloseAddButtonClick = new RelayCommand((cladd) =>
             {
                 AdminUc.add.Visibility = Visibility.Hidden;
                 AdminUc.s.Visibility = Visibility.Visible ;
                 AdminUc.b.Visibility = Visibility.Visible;

                 AdminUc.image.Visibility = Visibility.Visible;
                 AdminUc.label.Visibility = Visibility.Visible ;
                 AdminUc.closeadd.Visibility = Visibility.Hidden ;

             });
            CloseRemoveButtonClick = new RelayCommand((cladd) =>
            {
                AdminUc.remove.Visibility = Visibility.Hidden;
                AdminUc.s.Visibility = Visibility.Visible;
                AdminUc.b.Visibility = Visibility.Visible;

                AdminUc.image.Visibility = Visibility.Visible;
                AdminUc.label.Visibility = Visibility.Visible;
                AdminUc.closeremove.Visibility = Visibility.Hidden ;

            });
            AddMovieButtonClick = new RelayCommand((sh) =>
            {
                AdminUc.s.Visibility = Visibility.Hidden;
                AdminUc.b.Visibility = Visibility.Hidden;

                AdminUc.image.Visibility = Visibility.Hidden;
                AdminUc.label.Visibility = Visibility.Hidden;
                AdminUc.add.Visibility = Visibility.Visible;
                AdminUc.closeadd .Visibility = Visibility.Visible;
            });
            RemoveMovieButtonClick = new RelayCommand((rm) =>
          {
              MessageBox.Show("include name movie wich you want remove");

              AdminUc.remove.Visibility = Visibility.Visible;
              AdminUc.s.Visibility = Visibility.Hidden;

              AdminUc.image.Visibility = Visibility.Hidden;
              AdminUc.label.Visibility = Visibility.Hidden;
              AdminUc.b.Visibility = Visibility.Hidden;
              AdminUc.closeremove.Visibility = Visibility.Visible;



          });
        }
    }
}