using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ideial_classes
{
    class ideia
    {
        private int id;
        private string texto;
        private string tags;
        private int score;
        private DateTime dataCriacao;
        private DateTime dataPartilha;
        private string estado;

        public int Id { get; }
        public string Texto { get; set; }
        public string Tags { get; set; }
        public int Score { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime DataPartilha { get; set; }
        public string Estado { get; set; }

        public ideia(int id, string texto, string tags, int score, DateTime dataCriacao, DateTime dataPartilha, string estado)
        {
            this.id = id;
            this.texto = texto;
            this.tags = tags;
            this.score = score;
            this.dataCriacao = dataCriacao;
            this.dataPartilha = dataPartilha;
            this.estado = estado;
        }
    }
}
