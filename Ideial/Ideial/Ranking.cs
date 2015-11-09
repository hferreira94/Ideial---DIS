namespace Ideial
{
    public class Ranking
    {
        private int id;
        private int numP;
        private int numV;

        public int Id { get; }
        public int NumP { get; set; }
        public int NumV { get; set; }

        public Ranking(int id, int numP, int numV)
        {
            this.id = id;
            this.numP = numP;
            this.numV = numV;
        }
    }
}