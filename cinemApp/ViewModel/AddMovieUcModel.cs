using cinemApp.Command;
using cinemApp.Model;
using cinemApp.Repostory;
using cinemApp.View;
using Newtonsoft.Json;
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
    class AddMovieUcModel:Base
    {
     
        public FakeRepostory MoviesRepository { get; set; }
        public ObservableCollection<Movie> Movies { get; set; }
        public AddMovieUc AddMovie { get; set; }
        
        public RelayCommand AddMovieButtonClick { get; set; }
     
        public int Count { get; set; }
        public RelayCommand SearchButtonClick { get; set; }
      
   HttpClient http = new HttpClient();
        public AddMovieUcModel()
        {
            //Movies.Count 
            MoviesRepository = new FakeRepostory();
            Movies = new ObservableCollection<Movie>(MoviesRepository.GetMovies());
            HttpResponseMessage response = new HttpResponseMessage();
         
            AddMovieButtonClick = new RelayCommand((a) =>
             {
                 //if(Movies[5].Name == null)
                 //{
                 //AddMovie .show .name.Content  = AddMovie.messtxtb.Text.ToString();
                 //AddMovie.n2.Visibility = Visibility.Hidden;
                 //AddMovie.n.Visibility = Visibility.Hidden;
                 //AddMovie.show.Visibility = Visibility.Visible;
                 //  Movies[5].Name = AddMovie.messtxtb.Text.ToString();
                 //Movie movie = new Movie();

                 ////  MoviesRepository.GetMovies()[5].Name = AddMovie.messtxtb.Text.ToString();
                 //movie.Name =  AddMovie.messtxtb.Text.ToString();
                 ////Helper.Help(movie, response, http);
                 Movie movie = new Movie();
          
                 movie .Name = AddMovie.messtxtb.Text.ToString();
                 Helper.Help(movie, response, http);
             if(Movies[5].Name == null)
                 {
                 Movies[5] = movie;
                 MoviesRepository.GetMovies()[5]=movie ;

                 }


                 else if (Movies[6].Name == null)
                 {
                     Movies[6] = movie;
                     MoviesRepository.GetMovies()[6] = movie;

                 }
                 else if (Movies[7].Name == null)
                 {
                     Movies[7] = movie;
                     MoviesRepository.GetMovies()[7] = movie;

                 }
                 else if (Movies[8].Name == null)
                 {
                     Movies[8] = movie;
                     MoviesRepository.GetMovies()[8] = movie;

                 }
                 else if (Movies[9].Name == null)
                 {
                     Movies[9] = movie;
                     MoviesRepository.GetMovies()[9] = movie;

                 }
                 MessageBox.Show($"the movie {movie.Name } was added");
             });
            SearchButtonClick = new RelayCommand((s) =>
            {

                Movie movie = new Movie();
                //if(AddMovie .messtxtb .Text != null)
                //{
                movie.Name = AddMovie.messtxtb.Text;
                Helper.Help(movie, response, http);
               
                //Helper.Help(Movies[11], response, http);

                //}
                Movies[11] = movie;

                AddMovie.ad.Visibility = Visibility.Visible;


                //Movies[13].Name = AddMovie.messtxtb.Text;



            });
        } 
    }
}
