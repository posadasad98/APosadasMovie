using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Formatters;
using Newtonsoft.Json.Linq;

namespace PL.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult GetAll()
        {
            Models.Movie movie = new Models.Movie();
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://api.themoviedb.org/3/");
                var responseTask = client.GetAsync("https://api.themoviedb.org/3/movie/popular?api_key=cb3633d8da41a6869845529e2e3e1183");
                responseTask.Wait();
                var respuesta = responseTask.Result;
                if (respuesta.IsSuccessStatusCode)
                {
                    var readTask = respuesta.Content.ReadAsStringAsync();
                    readTask.Wait();
                    movie.Movies = new List<object>();
                    dynamic JsonObject = JObject.Parse(readTask.Result);

                    foreach (var registro in JsonObject.results)
                    {
                        Models.Movie movieobj = new Models.Movie();

                        movieobj.Id = registro.id;
                        movieobj.Nombre = registro.original_title;
                        movieobj.Poster = "https://image.tmdb.org/t/p/w1280/" + registro.poster_path;
                        movieobj.Descripcion = registro.overview;
                        movie.Movies.Add(movieobj);
                    }
                }
                else
                {
                    return View(movie);
                }
            }
            return View(movie);
        }

        public IActionResult Add(int IdPelicula)
        {
            Models.Movie movie = new Models.Movie();
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://api.themoviedb.org/3/");

                var responseTask = client.PostAsJsonAsync("account/20961218/favorite?api_key=cb3633d8da41a6869845529e2e3e1183&session_id=5976f0a0d1e800c81d850aa46c3885b45e8904e3", new
                {
                    media_type = "movie",
                    media_id = IdPelicula,
                    favorite = true
                });
                responseTask.Wait();
                var respuesta = responseTask.Result;
                if (respuesta.IsSuccessStatusCode)
                {

                    ViewBag.mensaje = "Se agrego";
                    return PartialView("Modal");
                }
                else
                {
                    ViewBag.mensaje = "no se agrego";
                    return PartialView("Modal");
                }
            }
        }

        public IActionResult GetFavorites()
        {
            Models.Movie movie = new Models.Movie();
            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://api.themoviedb.org/3/");
                var responseTask = client.GetAsync("account/20961194/favorite/movies?language=en-US&page=1&session_id=5976f0a0d1e800c81d850aa46c3885b45e8904e3&api_key=cb3633d8da41a6869845529e2e3e1183");
                responseTask.Wait();
                var respuesta = responseTask.Result;
                if (respuesta.IsSuccessStatusCode)
                {
                    var readTask = respuesta.Content.ReadAsStringAsync();
                    readTask.Wait();
                    movie.Movies = new List<object>();
                    dynamic JsonObject = JObject.Parse(readTask.Result);

                    foreach (var registro in JsonObject.results)
                    {
                        Models.Movie movieobj = new Models.Movie();

                        movieobj.Id = registro.id;
                        movieobj.Nombre = registro.original_title;
                        movieobj.Poster = "https://image.tmdb.org/t/p/w1280/" + registro.poster_path;
                        movieobj.Descripcion = registro.overview;
                        movie.Movies.Add(movieobj);
                    }
                }
                else
                {
                    return View(movie);
                }
            }
            return View(movie);
        }
    }

}

