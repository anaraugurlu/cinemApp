using cinemApp.Command;
using cinemApp.Model;
using cinemApp.Repostory;
using cinemApp.View;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace cinemApp.ViewModel
{
    class RemoveMovieUcModel:Base
    {


        public RelayCommand SearchButtonClick { get; set; }
        public RelayCommand RemoveMovieButtonClick { get; set; }
        public FakeRepostory MoviesRepository { get; set; }
        public ObservableCollection<Movie> Movies { get; set; }
        public RemoveMovieUC RemoveMovie { get; set; }
       
        HttpClient http = new HttpClient();

        public RemoveMovieUcModel()
        {
            HttpResponseMessage response = new HttpResponseMessage();

            RemoveMovieButtonClick = new RelayCommand((r) => {

                foreach (var item in Movies)
                {


                    if (RemoveMovie.messtxtb.Text == item.Name)
                    {
                        Movies.Remove(item);
                        MessageBox.Show($"movie {item.Name } was deleted");
               
                       
                        return;
                    }
                }
                foreach (var item in MoviesRepository .GetMovies ())
                {


                    if (RemoveMovie.messtxtb.Text == item.Name)
                    {
                        Movies.Remove(item);
                        MessageBox.Show($"movie {item.Name } was deleted");
                        return;
                    }
                }
            });
            MoviesRepository = new FakeRepostory();
            Movies = new ObservableCollection<Movie>(MoviesRepository.GetMovies());

                        Movie movie = new Movie();

            SearchButtonClick = new RelayCommand((sh) => {
                MessageBox.Show("if nothing has changed, you have written the name of a movie that is not in the cinema");
                foreach (var item in Movies)
                {
                  

                    if (RemoveMovie.messtxtb.Text == item.Name)
                    {


                        movie.Name = RemoveMovie.messtxtb.Text;

                        Helper.Help(movie, response, http);

                        RemoveMovie.rem.Visibility = Visibility.Visible;
                        
                    }



                }
                        Movies[12] = movie;
            
            
            
            });







        }
        //public RelayCommand AddMovieButtonClick { get; set; }
        //public int Count { get; set; }
        //public RelayCommand SearchButtonClick { get; set; }
    }
}
