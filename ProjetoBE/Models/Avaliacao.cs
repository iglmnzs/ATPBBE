namespace ProjetoBE.Models
{
    public class Avaliacao
    {
        public int IdAvaliacao { get; set; }
        public Jogo Jogo { get; set; }
        /*public Usuario Usuario { get; set; }*/
        public double Nota { get; set; }
        public string Comentario { get; set; }
    }
}
