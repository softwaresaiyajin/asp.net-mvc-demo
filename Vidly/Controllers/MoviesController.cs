
using Microsoft.AspNetCore.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {

        public ViewResult Random()
        {
            var movie = new Movie
            {
                Id = 1,
                Name = "Shrek"
            };
            return View(movie);
        }

    }
}
