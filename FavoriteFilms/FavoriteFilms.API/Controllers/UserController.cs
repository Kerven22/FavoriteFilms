using FavoriteFilims.API.Models.Responsies;
using FavoriteFilms.Storage;
using Microsoft.AspNetCore.Mvc;

namespace FavoriteFilims.API.Controllers
{
    public class UserController : Controller
    {
        private readonly FilimDbContext filimDbContext;

        public UserController(FilimDbContext filimDbContext)
        {
            this.filimDbContext = filimDbContext;
        }


        public IActionResult Index()
        {
            var responies = filimDbContext.Users.Select(f => new UserResponse
            {
                UserResponseId = f.UserId,
                Login = f.Login
            });
            return View(responies);
        }

        [HttpGet]
        public IActionResult GetUsers()
        {
            return View();
        }
        [HttpPut]
        public IActionResult CreateUser()
        {
            return View();
        }
    }
}
