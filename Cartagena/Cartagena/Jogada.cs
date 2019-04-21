namespace Cartagena
{
    public class Jogada
    {
        string _carta { get; set; }
        Tabuleiro _tabuleiro { get; set; }
        Pirata _pirata { get; set; }
        private int _indexPirata;
        
        public string carta { get { return _carta; } }
        public Tabuleiro tabuleiro { get { return _tabuleiro; } }
        public Pirata pirata { get { return _pirata; } }
        public int indexPirata { get { return _indexPirata; } }
        public int pontuacao { get; set; }

        public Jogada(Tabuleiro tabuleiro, Pirata pirata, string carta, int l)
        {
            _tabuleiro = new Tabuleiro(tabuleiro);
            _pirata = pirata.copiar();
            _carta = carta;
            _indexPirata = l;
        }

        public Jogada(Tabuleiro tabuleiro, Pirata pirata, int l)
        {
            _tabuleiro = tabuleiro;
            _pirata = pirata;
            _carta = null;
            _indexPirata = l;
        }
        
        public void simularJogada()
        {
            if (carta == null)
            {
                int localAntigo = pirata.local, localNovo;

                for (int i = localAntigo - 1; i > 0; i--)
                {
                    if (tabuleiro.Posicoes[i].numeroPiratas() > 0 &&
                        tabuleiro.Posicoes[i].numeroPiratas() < 3)
                    {
                        localNovo = i;
                        tabuleiro.Posicoes[localAntigo].piratas.Remove(pirata);
                        pirata.local = localNovo;
                        tabuleiro.Posicoes[localNovo].piratas.Add(pirata);
                        break;
                    }
                }
                
            }
            else
            {
                int localNovo, localAntigo = pirata.local;

                // Acha o novo local do pirata
                for (localNovo = localAntigo; localNovo < tabuleiro.Posicoes.Length - 1; localNovo++)
                {
                    if (carta == tabuleiro.Posicoes[localNovo].tipo &&
                        tabuleiro.Posicoes[localNovo].piratas.Count == 0) break;
                }

                // Remove o pirata do lugar antigo e coloca no novo.
                tabuleiro.Posicoes[localAntigo].piratas.Remove(pirata);
                pirata.local = localNovo;
                tabuleiro.Posicoes[localNovo].piratas.Add(pirata);
            }
        }
        
    }
}