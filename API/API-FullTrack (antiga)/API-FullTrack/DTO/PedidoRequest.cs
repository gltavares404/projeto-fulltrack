using API_FullTrack.Model;
using System.ComponentModel.DataAnnotations;

namespace API_FullTrack.DTO
{
    public class PedidoRequest
    {
        public int Id { get; set; }

        [Required]
        public string Titulo { get; set; }
        [Required]
        public string Endereco { get; set; }
        [Required]
        public TimeOnly Horario { get; set; }
        [Required]
        public DateOnly Data { get; set; }

        public Pedido toModel()
            => new Pedido(Titulo, Endereco, Horario, Data);
    }
}
