using BuscarFilmes.Common.Models;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace BuscarFilmes.Common.Repository
{
    public interface IMovieRepository
    {
        Task<ObservableCollection<Movie>> GetMovies(MovieCall movieCall);
    }
}
