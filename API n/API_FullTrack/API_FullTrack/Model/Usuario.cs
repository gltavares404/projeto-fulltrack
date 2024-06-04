namespace API_FullTrack.Model
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Nome { get; set; }
        public int Meta { get; set; }
        public int Entregas { get; set; }
        //public int TotalAvaliacoes { get; set; }
        public int Multas { get; set; }

        public Usuario(string email, string senha, string nome, int meta, int entregas, int multas)
        {
            Email = email;
            Senha = senha;
            Nome = nome;
            Meta = meta;
            Entregas = entregas;
            Multas = multas;
            //TotalAvaliacoes = avaliacoes;
        }
    }
}
