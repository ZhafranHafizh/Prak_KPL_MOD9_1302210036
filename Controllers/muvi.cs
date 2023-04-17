using Microsoft.AspNetCore.Mvc;
using System.Numerics;
using System;
using Microsoft.Extensions.Logging;
using System.IO;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace modul9_1302210036.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class muvi : ControllerBase
    {
        public static List<Movie> _listMovie = new List<Movie>
        {
            new Movie(){Title = "The Shawshank Redemption", Director = "Frank Darabont", Stars = 
                {"Tim Robbins, Morgan Freeman", "Bob Gunton", "William Sadler"}, 
                Description = "Over the course of several years, two convicts form a friendship, seeking consolation and, eventually, redemption through basic compassion."},
            new Movie(){Title = "The Godfather", Director = "Francis Ford Coppol", Stars = { "Marlon Brando", "Al Pacino", "James Caan", "Diane Keaton"}, Description = "The aging patriarch of an organized crime dynasty in postwar New York City transfers control of his clandestine empire to his reluctant youngest son."},
            new Movie(){Title = "The Dark Knight", Director = "Christopher Nolan", Stars = { "Christian Bale", "Heath Ledger", "Aaron Eckhart", "Michael Caine"}, Description = "When the menace known as the Joker wreaks havoc and chaos on the people of Gotham, Batman must accept one of the greatest psychological and physical tests of his ability to fight injustice."}
        };
        //GET api/movie
        [HttpGet]
        public IEnumerable<Movie> Get()
        {
            return _listMovie;
        }
        //GET API/movie/id
        [HttpGet("{id}")]
        public Movie Get(int id)
        {
            return _listMovie[id];
        }
        //POST/api/movie
        [HttpPost]
        public void Post([FromBody]Movie value)
        {
            _listMovie.Add(value);
        }
        //DELETE/api/movie/id
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _listMovie.RemoveAt(id);
        }
    }
}