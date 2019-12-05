using System.Linq;
using System.Threading.Tasks;
using MoviesOnDemand.Data.Repository;
using MoviesOnDemand.Models;

namespace MoviesOnDemand.RepositoryServiceLocator
{
    public class RepoService : IRepoService
    {
        private readonly IDBRepository _repo;

        public RepoService(IDBRepository repo)
        {
            _repo = repo;
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
            var success = await _repo.CreateUser(user);

            return success;
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

        public IOrderedQueryable<User> GetUserByUserID(string userID)
        {
            return _repo.GetUserByUserID(userID);
        }

        public Task<bool> UpdateMovieDesc(Movie movie, string desc)
        {
            throw new System.NotImplementedException();
        }
    }
}