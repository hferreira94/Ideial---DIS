using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ideial_classes
{
    class utilizador
    {
        private int id;
        private string nome;
        private string genero;
        private int idade;
        private string cargo;
        private int rating;
        private List<ideia> feed;

        public int Id { get; }
        public string Nome { get; set; }
        public string Genero { get; set; }
        public int Idade { get; set; }
        public string Cargo { get; set; }
        public int Rating { get; set; }
        public List<ideia> Feed { get; set; }

        public utilizador(int id, string nome, string genero, int idade, string cargo, int rating, List<ideia> feed)
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
