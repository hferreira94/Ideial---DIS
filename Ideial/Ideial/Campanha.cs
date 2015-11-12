namespace Ideial
{
    public class Campanha
    { //henrique
        private int id;
        private string nome;
        private string texto;

        public int Id { get; }
        public string Nome { get; set; }
        public string Texto { get; set; }

        public Campanha(int id, string nome, string texto)
        {
            this.id = id;
            this.nome = nome;
            this.texto = texto;
        }
    }
}