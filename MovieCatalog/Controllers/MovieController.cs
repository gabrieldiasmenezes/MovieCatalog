using Microsoft.AspNetCore.Mvc;
using MovieCatalog.Models;

namespace MovieCatalog.Controllers
{
    public class MovieController:Controller
    {
        private static List<Movie> _movies = new List<Movie>
        {
            new Movie
{
    Id = 1,
    Name = "Interestelar",
    Genre = Genre.FICÇÃO_CIENTÍFICA,
    ReleaseYear = 2014,
    Director = "Christopher Nolan",
    Description = "Um grupo de astronautas viaja por um buraco de minhoca em busca de um novo lar para a humanidade.",
    ImageUrl = "https://m.media-amazon.com/images/S/pv-target-images/4a38198dbdc5535e124d063718b6610e103f6965b7984b6377cceeb9e5fe8046.jpg"
},
new Movie
{
    Id = 2,
    Name = "O Poderoso Chefão",
    Genre = Genre.DRAMA,
    ReleaseYear = 1972,
    Director = "Francis Ford Coppola",
    Description = "A saga da família mafiosa Corleone, seu império e os conflitos de poder.",
    ImageUrl = "https://mid-noticias.curitiba.pr.gov.br/2022/00337449.jpg"
},
new Movie
{
    Id = 3,
    Name = "Cidade de Deus",
    Genre = Genre.AÇÃO,
    ReleaseYear = 2002,
    Director = "Fernando Meirelles",
    Description = "A história da criminalidade no Rio de Janeiro contada a partir da favela Cidade de Deus.",
    ImageUrl = "https://www1.folha.uol.com.br/folha/especial/2002/cidadededeus/images/promocao-premios-200x265.jpg"
},
new Movie
{
    Id = 4,
    Name = "O Auto da Compadecida",
    Genre = Genre.COMÉDIA,
    ReleaseYear = 2000,
    Director = "Guel Arraes",
    Description = "As aventuras de dois nordestinos espertalhões enfrentando problemas com fé e astúcia.",
    ImageUrl = "https://images.justwatch.com/poster/302483003/s718/o-auto-da-compadecida.jpg"
},
new Movie
{
    Id = 5,
    Name = "Se Eu Fosse Você",
    Genre = Genre.ROMANCE,
    ReleaseYear = 2006,
    Director = "Daniel Filho",
    Description = "Um casal troca de corpos e precisa lidar com os desafios do cotidiano no corpo um do outro.",
    ImageUrl = "https://m.media-amazon.com/images/S/pv-target-images/afcce1a3ff6583f869b65d59a1c3ecc5eba5e2852b8ea7d79944e8471385ad8c.jpg"
}

        };
        public IActionResult Index(string search)
        {
            // Filtra os filmes com base no parâmetro de pesquisa, se fornecido.
            var filteredMovies = _movies.AsQueryable();

            if (!string.IsNullOrEmpty(search))
            {
                filteredMovies = filteredMovies.Where(m =>
                    m.Name.Contains(search, StringComparison.OrdinalIgnoreCase) ||
                    m.Director.Contains(search, StringComparison.OrdinalIgnoreCase) ||
                    m.Genre.ToString().Contains(search, StringComparison.OrdinalIgnoreCase));
            }

            // Passa o termo de pesquisa para a view
            ViewData["Search"] = search;

            return View(filteredMovies.ToList());
        }


        public IActionResult Details(int id)
        {
            var movie = _movies.FirstOrDefault(m => m.Id == id);
            if (movie == null) return NotFound();
            return View(movie);
        }
        public IActionResult Add(){return View();}

        //Ação para salvar novo filme
        [HttpPost]
        public IActionResult Add(Movie movie)
        {
            if (ModelState.IsValid)
            {
                movie.Id = _movies.Max(m => m.Id) + 1;
                _movies.Add(movie);
                return RedirectToAction("Index");
            }
            return View(movie);
        }

        public IActionResult Edit(int id)
        {
            var movie = _movies.FirstOrDefault(m => m.Id == id);
            if (movie == null) return NotFound();
            return View(movie);
        }
        [HttpPost]
        public IActionResult Edit(Movie movie)
        {
            if (ModelState.IsValid)
            {
                var existingMovie = _movies.FirstOrDefault(m => m.Id == movie.Id);
                if (existingMovie != null)
                {
                    existingMovie.Name = movie.Name;
                    existingMovie.Description = movie.Description;
                    existingMovie.ReleaseYear = movie.ReleaseYear;
                    existingMovie.Director = movie.Director;
                    existingMovie.Genre = movie.Genre;
                }
                return RedirectToAction("Index");
            }
            return View(movie);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id)
        {
            var movie = _movies.FirstOrDefault(m => m.Id == id);
            if (movie == null) return NotFound();

            _movies.Remove(movie);
            return RedirectToAction("Index");
        }

        public IActionResult Privacy(){return View();}
    }
}
