using System;
namespace Cartagena
{
    public class Pirata
    {
        string _cor;
        public string cor { get { return _cor; } }
        public int local { get; set; }

        public Pirata(string cor)
        {
            _cor = cor;
            local = 0;
        }
        
        public Pirata(string cor, int local)
        {
            _cor = cor;
            this.local = local;
        }
    }
}
