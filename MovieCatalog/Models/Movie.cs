using System.ComponentModel.DataAnnotations;

namespace MovieCatalog.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome do filme é obrigatório.")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "O nome deve ter entre 2 e 100 caracteres.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "O diretor é obrigatório.")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "O nome do diretor deve ter entre 2 e 100 caracteres.")]
        public string Director { get; set; }

        [Required(ErrorMessage = "O ano de lançamento é obrigatório.")]
        [Range(1888, 2100, ErrorMessage = "Informe um ano entre 1888 e 2100.")]
        public int ReleaseYear { get; set; }

        [Required(ErrorMessage = "O gênero é obrigatório.")]
        public Genre Genre { get; set; }

        [Required(ErrorMessage = "A descrição é obrigatória.")]
        [StringLength(1000, MinimumLength = 10, ErrorMessage = "A descrição deve ter entre 10 e 1000 caracteres.")]
        public string Description { get; set; }

        [Required(ErrorMessage = "A URL da imagem é obrigatória.")]
        [Url(ErrorMessage = "Informe uma URL válida para a imagem.")]
        public string ImageUrl { get; set; }
    }
}
