using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using MoviesOnDemand.Data.Context;
using MoviesOnDemand.Models;

namespace MoviesOnDemand.Data.Repository
{
    public class DBRepository : IDBRepository
    {
        private readonly IServiceScope _scope;
        private readonly MoviesOnDemandDbContext _dbContext;

        public DBRepository(IServiceProvider services)
        {
            _scope = services.CreateScope();
            _dbContext = _scope.ServiceProvider.GetRequiredService<MoviesOnDemandDbContext>();
        }

        public Task<bool> CreateCategory(MovieCategory category)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> CreateMovie(Movie movie)
        {
            throw new System.NotImplementedException();
        }

        public async Task<bool> CreateUser(User user)
        {
            var isUserAdded = false;

            _dbContext.User.Add(user);

            var totalUsersAdded = await _dbContext.SaveChangesAsync();
            isUserAdded = (totalUsersAdded == 1);

            return isUserAdded;
        }

        public IOrderedQueryable<User> GetUserByUserID(string userID)
        {
            return _dbContext.User.Where(user => user.UserID == userID).OrderBy(user => user.Name);
        }

        public Task<bool> DeleteCategory(MovieCategory category)
        {
            throw new System.NotImplementedException();
        }

        public IOrderedQueryable<MovieCategory> GetAllCategories()
        {
            throw new System.NotImplementedException();
        }

        public IOrderedQueryable<Movie> GetAllMovies()
        {
            throw new System.NotImplementedException();
        }

        public IOrderedQueryable<Movie> GetAllMoviesForCategory(MovieCategory category)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> UpdateMovieDesc(Movie movie, string desc)
        {
            throw new System.NotImplementedException();
        }
    }
}