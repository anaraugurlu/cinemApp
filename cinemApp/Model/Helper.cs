using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
namespace cinemApp.Model
{
    class Helper
{
        static public void Help(Movie mov, HttpResponseMessage response, HttpClient http)
{
            var movie = mov.Name ;
            response =
                                  http.GetAsync($@"http://www.omdbapi.com/?apikey=ddee1dae&s={movie}&plot=full").Result;
            var str = response.Content.ReadAsStringAsync().Result;
            mov.Data = JsonConvert.DeserializeObject(str);
            response =
                                      http.GetAsync($@"http://www.omdbapi.com/?apikey=ddee1dae&t={mov.Data.Search[0].Title}&plot=full").Result;
            str = response.Content.ReadAsStringAsync().Result;
            mov.SingleData = JsonConvert.DeserializeObject(str);
            mov.ImagePath = mov.SingleData.Poster;
            mov.Description = mov.SingleData.Genre;
}
}
}