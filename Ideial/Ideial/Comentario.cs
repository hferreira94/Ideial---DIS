using System;

namespace Ideial
{
    public class Comentario
    {
        private int id;
        private string texto;
        private DateTime dataCriacao;

        public int Id { get; }
        public string Texto { get; set; }
        public DateTime DataCriacao { get; set; }

        public Comentario(int id, string texto, DateTime dataCriacao)
        {
            this.id = id;
            this.texto = texto;
            this.dataCriacao = dataCriacao;
        }
    }
}