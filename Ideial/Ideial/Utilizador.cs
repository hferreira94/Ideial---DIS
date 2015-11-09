using System.Collections.Generic;

namespace Ideial
{
    public class Utilizador
    {
        private int id;
        private string nome;
        private string genero;
        private int idade;
        private string cargo;
        private int rating;
        private List<Ideia> feed;

        public int Id { get; }
        public string Nome { get; set; }
        public string Genero { get; set; }
        public int Idade { get; set; }
        public string Cargo { get; set; }
        public int Rating { get; set; }
        public List<Ideia> Feed { get; set; }

        public Utilizador(int id, string nome, string genero, int idade, string cargo, int rating, List<Ideia> feed)
        {
            this.id = id;
            this.nome = nome;
            this.genero = genero;
            this.idade = idade;
            this.cargo = cargo;
            this.rating = rating;
            this.feed = feed;
        }
    }
}