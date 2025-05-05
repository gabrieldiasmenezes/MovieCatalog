using System.ComponentModel.DataAnnotations;

namespace MovieCatalog.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome do filme é obrigatório.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "O diretor é obrigatório.")]
        public string Director { get; set; }

        [Required(ErrorMessage = "O ano de lançamento é obrigatório.")]
        [Range(1888, 2100, ErrorMessage = "Ano inválido.")]
        public int ReleaseYear { get; set; }

        [Required(ErrorMessage = "O gênero é obrigatório.")]
        public Genre Genre { get; set; }

        [Required(ErrorMessage = "A descrição é obrigatória.")]
        public string Description { get; set; }

        public string? ImageUrl { get; set; } 

    }
}



