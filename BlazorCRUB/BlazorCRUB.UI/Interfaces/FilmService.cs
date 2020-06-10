using BlazorCRUB.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorCRUB.UI.Interfaces
{
    public class FilmService : IFilmService
    {
        public Task<bool> DeleteFilm(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Film>> GetAllFilms()
        {
            throw new NotImplementedException();
        }

        public Task<Film> GetDetails(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> SaveFilm(Film film)
        {
            throw new NotImplementedException();
        }
    }
}
