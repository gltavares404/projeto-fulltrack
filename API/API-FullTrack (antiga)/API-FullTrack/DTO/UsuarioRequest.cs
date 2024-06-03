using System.ComponentModel.DataAnnotations;
using API_FullTrack.Model;


namespace API_FullTrack.DTO
{
    public class UsuarioRequest
    {
        public int Id { get; set; }

        [Required]
        public string Email { get; set; }
        [Required]
        public string Senha { get; set; }
        [Required]
        public string Nome { get; set; }

        public int Meta { get; set; }
        public int Entregas { get; set; }
        public int TotalAvaliacoes { get; set; }
        public int Multas { get; set; }

        public Usuario toModel()
            => new Usuario(Email, Senha, Nome, Meta, Entregas, TotalAvaliacoes, Multas);
    }
}
