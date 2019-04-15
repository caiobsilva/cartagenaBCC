using System;

namespace Cartagena
{
    public class Jogador
    {

        int _id { get; set; }
        string _nome { get; set; }
        string _cor { get; set; }
        string _senha { get; set; }
        public Pirata[] piratas;

        public int id { get { return _id; } }
        public string nome { get { return _nome; } }
        public string cor { get { return _cor; } }
        public string senha { get { return _senha; } }

        public Jogador(int id, string nome, string cor, string senha)
        {
            _id = id;
            _cor = cor;
            _nome = nome;
            _senha = senha;
            piratas = new Pirata[] { 
                new Pirata(_cor),
                new Pirata(_cor),
                new Pirata(_cor),
                new Pirata(_cor),
                new Pirata(_cor),
                new Pirata(_cor),
            };
        }
    }
}
