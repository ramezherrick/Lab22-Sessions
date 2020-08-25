using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text.Json;
using System.Threading.Tasks;
using Lab21_MovieRegisteration.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Lab21_MovieRegisteration.Controllers
{
    public class MovieController : Controller
    {
        List<Movie> movieList = new List<Movie>();
        List<Movie> shoppingCart = new List<Movie>();
        //private readonly IHttpContextAccessor _accessor;

        //public MovieController(IHttpContextAccessor accessor)
        //{
        //    _accessor = accessor;
        //}

        public IActionResult Index()
        {
            return View(new Movie());
        }
        public IActionResult MovieResult(Movie movie)
        {
            if (ModelState.IsValid)
            {
                string movieListJSON = HttpContext.Session.GetString("MovieListSession") ?? "EmptySession";

                if (movieListJSON != "EmptySession")
                {
                    //using System.Text.Json;
                    //This turns the string of JSON into List of individual Book Objects
                    movieList = JsonSerializer.Deserialize<List<Movie>>(movieListJSON);
                }

                //Update the bookList by adding the movie from the form
                movieList.Add(movie);

                //Update/Save the new book into the session
                //Turns our List of objects (books) into a string that the session can keep
                movieListJSON = JsonSerializer.Serialize(movieList);

                //sets the session to the updated JSON
                HttpContext.Session.SetString("MovieListSession", movieListJSON);



                return View(movieList);
            }

            return View("Index", movie);
        }
        public IActionResult ShoppingCart(int ID)
        {

            //var mlist = GetMovieSession("MovieListSesssion", movieList);
            //var slist = GetMovieSession("ShoppingCartSession", shoppingCart);
            string shoppingCartJson = HttpContext.Session.GetString("ShoppingCartSession") ?? "EmptySession";

            if (shoppingCartJson != "EmptySession")
            {
                //using System.Text.Json;
                //This turns the string of JSON into List of individual Book Objects
                shoppingCart = JsonSerializer.Deserialize<List<Movie>>(shoppingCartJson);
            }

            string movieListJSON = HttpContext.Session.GetString("MovieListSession") ?? "EmptySession";

            if (movieListJSON != "EmptySession")
            {
                //using System.Text.Json;
                //This turns the string of JSON into List of individual Book Objects
                movieList = JsonSerializer.Deserialize<List<Movie>>(movieListJSON);
            }


            //Update the bookList by adding the movie from the for
            for (int i = 0; i < movieList.Count; i++)
            {
                if (ID == movieList[i].ID)
                {
                    shoppingCart.Add(movieList[i]);
                }
            }          

            //Update/Save the new book into the session
            //Turns our List of objects (books) into a string that the session can keep
            shoppingCartJson = JsonSerializer.Serialize(shoppingCart);

            //sets the session to the updated JSON
            HttpContext.Session.SetString("ShoppingCartSession", shoppingCartJson);

            return View(shoppingCart);
        }

        //public List<Movie> GetMovieSession(string sessionName, List<Movie> list)
        //{
        //    string jsonData = _accessor.HttpContext.Session.GetString(sessionName) ?? "EmptySession";

        //    if (jsonData != "EmptySession")
        //    {
        //        //using System.Text.Json;
        //        //This turns the string of JSON into List of individual Book Objects
        //        list = JsonSerializer.Deserialize<List<Movie>>(jsonData);
        //    }

        //    return list;
        //}
    }
}
