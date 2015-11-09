namespace Ideial
{
    public class Organizacao
    {
        private int id;
        private string nome;
        private string endereco;
        private int telemovel;

        public int Id { get; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public int Telemovel { get; set; }

        public Organizacao(int id, string nome, string endereco, int telemovel)
        {
            this.id = id;
            this.nome = nome;
            this.endereco = endereco;
            this.telemovel = telemovel;
        }
    }
}