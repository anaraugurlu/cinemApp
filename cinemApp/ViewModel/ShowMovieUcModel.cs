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

namespace cinemApp.ViewModel
{
     class ShowMovieUcModel:Base
    {
        public string name { get; set; }
        public string password { get; set; }
        public RelayCommand SelectedItemChangedCommand { get; set; }
        public FakeRepostory  MoviesRepostory { get; set; }
        public ObservableCollection<Movie> Movies { get; set; }
        private Movie  movie;
        public Movie Movie
        {
            get { return movie; }
            set { movie = value; OnPropertyChanged(); }
        }
        public ShowMovieUc  ShowMovie { get; set; }
       HttpClient http = new HttpClient();
        public ShowMovieUcModel()
        {
            MoviesRepostory = new FakeRepostory();
            Movies  = new ObservableCollection<Movie >(MoviesRepostory.GetMovies());
             HttpResponseMessage response = new HttpResponseMessage();
       
            Helper.Help(Movies[0], response ,http);
            Helper.Help(Movies[1], response ,http);
            Helper.Help(Movies[2], response ,http);
            Helper.Help(Movies[3], response, http);
            Helper.Help(Movies[4], response, http); 
           if (Movies [5].Name !=null)
            {
            Helper.Help(Movies[5], response, http);

            }
           else if (Movies[6].Name != null)
            {
                Helper.Help(Movies[6], response, http);

            }
           else if (Movies[7].Name != null)
            {
                Helper.Help(Movies[7], response, http);

            }
            else if (Movies[8].Name != null)
            {
                Helper.Help(Movies[8], response, http);

            }
            else if (Movies[9].Name != null)
            {
                Helper.Help(Movies[9], response, http);

            }
            else if (Movies[10].Name != null)
            {
                Helper.Help(Movies[10], response, http);

            }
            

          
            SelectedItemChangedCommand = new RelayCommand((SelectedItem) =>
            {
                var item = SelectedItem as Movie ;
                Movie  = item;
            });

        }

    }

    
}
