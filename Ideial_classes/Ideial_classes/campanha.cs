using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ideial_classes
{
    class campanha
    {
        private int id;
        private string nome;
        private string texto;

        public int Id { get; }
        public string Nome { get; set; }
        public string Texto { get; set; }

        public campanha(int id, string nome, string texto)
        {
            this.id = id;
            this.nome = nome;
            this.texto = texto;
        }
    }
}
