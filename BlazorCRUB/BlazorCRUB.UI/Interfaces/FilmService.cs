using BlazorCRUB.Data.Dapper.Repositories;
using BlazorCRUB.Model;
using BlazorCRUB.UI.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorCRUB.UI.Interfaces
{
    public class FilmService : IFilmService
    {
        private readonly SqlConfiguration _configuration;
        private IFilmRepository __filmRepository;

        public FilmService(SqlConfiguration configuration)
        {
            _configuration = configuration;
            __filmRepository = new FilmRepository(configuration.ConnectionString);
            
        }
        public Task<bool> DeleteFilm(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Film>> GetAllFilms()
        {
            return __filmRepository.GetAllFilms();
        }

        public Task<Film> GetDetails(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> SaveFilm(Film film)
        {
            if (film.Id == 0)
                return __filmRepository.InsertFilm(film);
            else
                return null;
        }
    }
}
