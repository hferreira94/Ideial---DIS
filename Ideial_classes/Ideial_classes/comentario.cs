using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ideial_classes
{
    class comentario
    {
        private int id;
        private string texto;
        private DateTime dataCriacao;

        public int Id { get; }
        public string Texto { get; set; }
        public DateTime DataCriacao { get; set; }

        public comentario(int id, string texto, DateTime dataCriacao)
        {
            this.id = id;
            this.texto = texto;
            this.dataCriacao = dataCriacao;
        }
    }
}
