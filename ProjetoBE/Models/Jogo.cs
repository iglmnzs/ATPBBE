namespace ProjetoBE.Models
{
    public class Jogo
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public string Genero { get; set; }

        public string Desenvolvedor { get; set; }

        public string Descricao { get; set; }

        //Adicionado posteriormente
        public string ImagemUrl { get; set; }
    }
}
