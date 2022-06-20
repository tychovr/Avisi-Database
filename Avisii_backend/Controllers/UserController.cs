using Avisi_backend.Models;
using Avisii_backend.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Avisi_backend.Controllers
{

    [Route("api/[controller]/[action]")]
    [ApiController]

    public class UserController : ControllerBase
    {
        private readonly IDbContextFactory<AvisiContext> _dbContext;

        public UserController(IDbContextFactory<AvisiContext> dbContext) 
        {
            _dbContext = dbContext;
        }


        /// <summary>
        /// Get all users
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<User> GetUsers() 
        {
            using (var context = _dbContext.CreateDbContext()) 
            {
                return context.Set<User>().ToList();
            } 
        }
    }


}
