using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ideial_classes
{
    class conta
    {
        private int id;
        private string utilizador;
        private string email;
        private string password;

        public int Id { get; }
        public string Utilizador { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public conta(int id, string utilizador, string email, string password)
        {
            this.id = id;
            this.utilizador = utilizador;
            this.email = email;
            this.password = password;
        }

    }
}
