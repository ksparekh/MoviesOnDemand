using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MoviesOnDemand.Models;
using MoviesOnDemand.RepositoryServiceLocator;

namespace MoviesOnDemand
{
    [Route("Users")]
    public class UsersController : Controller
    {
        private readonly IRepoService _userService;

        public UsersController(IRepoService repoService) => this._userService = repoService;

        [HttpPost("Register")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]        
        public async Task<IActionResult> RegisterUser(User user)
        {
            if (user != null && !string.IsNullOrEmpty(user.Name) && !string.IsNullOrEmpty(user.UserID) && !string.IsNullOrEmpty(user.Password))
            {
                var result = await _userService.CreateUser(user);

                if (result)
                    return Ok(result);
                else
                    return BadRequest("User Registration Failed.");
            }
            else
            {
                return BadRequest("Invalid User Registration Request.");
            }
        }
    }
}