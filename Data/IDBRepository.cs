using System.Linq;
using System.Threading.Tasks;
using MoviesOnDemand.Models;

namespace MoviesOnDemand.Data.Repository
{
    public interface IDBRepository
    {
        Task<bool> CreateUser(User user);

        Task<bool> CreateCategory(MovieCategory category);

        Task<bool> DeleteCategory(MovieCategory category);

        Task<bool> CreateMovie(Movie movie);

        IOrderedQueryable<User> GetUserByUserID(string userID);

        IOrderedQueryable<MovieCategory> GetAllCategories();

        IOrderedQueryable<Movie> GetAllMovies();

        IOrderedQueryable<Movie> GetAllMoviesForCategory(MovieCategory category);

        Task<bool> UpdateMovieDesc(Movie movie, string desc);
    }
}