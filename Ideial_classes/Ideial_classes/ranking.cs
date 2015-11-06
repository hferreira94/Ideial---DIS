using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//
namespace Ideial_classes
{
    class ranking
    {
        private int id;
        private int numP;
        private int numV;

        public int Id { get; }
        public int NumP { get; set; }
        public int NumV { get; set; }

        public ranking(int id, int numP, int numV)
        {
            this.id = id;
            this.numP = numP;
            this.numV = numV;
        }
    }
}
