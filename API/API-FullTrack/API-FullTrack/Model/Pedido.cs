namespace API_FullTrack.Model
{
    public class Pedido
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Endereco { get; set; }
        public TimeOnly Horario { get; set; }
        public DateOnly Data {  get; set; }

        public Pedido (string titulo, string endereco, TimeOnly horario, DateOnly data ) 
        {
            Titulo = titulo;
            Endereco = endereco;
            Horario = horario;
            Data = data;
            
        }
    }
}
